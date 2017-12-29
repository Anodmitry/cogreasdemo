using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;
using ChangeDB_Lib;
using System.Data.OleDb;
using System.Data.SqlClient;


//решена проблема (путём создания отдельных соединений) с незакрытыми датаридерами только в добавлении, удалении и переименовании ао 

namespace DB_Change_API
{
    public partial class MainForm : Form
    {
        public ChangeDB_Lib.Change_DB change_obj;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //private void but_connect_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        change_obj = new ChangeDB_Lib.Change_DB();
        //        change_obj.ConnectToDb(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\university\\KURSOVAYA\\testDLL.accdb;Persist Security Info=False;");
        //        cb_tables.DataSource = GetListTables();
        //        MessageBox.Show("Соединение с базой данных успешно установлено!", "Информация", MessageBoxButtons.OK);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void fillDataGridView (/*OleDbDataReader*/SqlDataReader resReader)
        {
            
            dgv_table.Columns.Clear();
            dgv_table.Rows.Clear();
            int fieldCount = resReader.FieldCount;//число столбцов в результате sql запроса
            DataTable schema = resReader.GetSchemaTable();//данные о запросе, в том числе названия столбцов
            //формируем заголовок таблицы
            for (int i = 0; i < fieldCount; i++)
            {
                //MessageBox.Show(schema.Rows[i][0].ToString());
                string tmps = schema.Rows[i][0].ToString();
                if (tmps != "upsize_ts") dgv_table.Columns.Add(schema.Rows[i][0].ToString(), schema.Rows[i][0].ToString());
            }
            //заполняем datagridview результатом
            while (resReader.Read())
            {
                int rowNum = dgv_table.Rows.Add();
                for (int i = 0; i < fieldCount; i++)
                {
                    string tmps = schema.Rows[i][0].ToString();
                    if (tmps != "upsize_ts") dgv_table.Rows[rowNum].Cells[schema.Rows[i][0].ToString()].Value = resReader[schema.Rows[i][0].ToString()].ToString();
                }
            }
            resReader.Close();
            //resReader = null;
            //MessageBox.Show((resReader == change_obj.temp_reader).ToString());//test
        }

        //private void but_runquery_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Выполняем запрос
        //        OleDbDataReader resReader = change_obj.RunSqlCommand("SELECT * FROM Books");
        //        fillDataGridView(resReader);//заполняем результат
        //        resReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("");
            try
            {
                if(change_obj != null) change_obj.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowTable()
        {
            try
            {
                //SqlDataReader resReader = change_obj.RunSqlCommand("SELECT * FROM " + cb_tables.Text);
                change_obj.RunSqlCommand("SELECT * FROM " + cb_tables.Text);
                
                SqlDataReader resReader = change_obj.temp_reader;
                fillDataGridView(resReader);//заполняем результат
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cb_tables_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowTable();
        }

        private List<string> GetListTables()
        {
            DataTable dt = change_obj.dbconn.GetSchema("Tables", new string[] { null, null, null, "BASE TABLE" });
            List<string> res = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                string tmps = (string)item["TABLE_NAME"];
                if (tmps != "sysdiagrams" && tmps != "dtproperties") res.Add(tmps);//убираю из списка системные таблицы
            }
            return res;
        }

        private void but_opendb_Click(object sender, EventArgs e)
        {
            try
            {
                change_obj = new ChangeDB_Lib.Change_DB();
                //статическая строка соединения - без одновременных datareader, работает с доб., уд., переим. активных объектов
                Change_DB.connectionString = @"Data Source=127.0.0.1\sqlexpress01;user id = admin;password = adminadmin;Initial Catalog=" + tb_pathdb.Text + ";";
                //change_obj.ConnectToDb(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\university\\KURSOVAYA\\Environment_db_lastversion.accdb;Persist Security Info=False;");
                //change_obj.ConnectToDb(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_pathdb.Text + ";Persist Security Info=False;");

                //MultipleActiveResultSets=true; чтобы не ругался на незакрытый SqlDataReader
                change_obj.ConnectToDb(@"Data Source=127.0.0.1\sqlexpress01;user id = admin;password = adminadmin;Initial Catalog=" +
                                        tb_pathdb.Text +
                                        ";MultipleActiveResultSets=true;");//MultipleActiveResultSets=true;
                cb_tables.DataSource = GetListTables();
                MessageBox.Show("Соединение с базой данных успешно установлено!", "Информация", MessageBoxButtons.OK);
                ShowTable();
                //позволяем выполнять действия
                cb_tables.Enabled = true;
                cb_modifyRobot.Enabled = true;
                cb_modifyAO.Enabled = true;
                cb_modifyPheno.Enabled = true;
                cb_modifyInteraction.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ВРОДЕ РАБОТАЕТ
        private void cb_modifyRobot_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (cb_modifyRobot.Text)
                {
                    case "Добавить характеристику":
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        AddRobotCharForm addRobotCharfrm = new AddRobotCharForm();
                        addRobotCharfrm.Owner = this;
                        addRobotCharfrm.ShowDialog();
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        break;
                    case "Удалить характеристику":
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        DelRobotCharForm delRobotCharfrm = new DelRobotCharForm();
                        delRobotCharfrm.Owner = this;
                        delRobotCharfrm.ShowDialog();
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        break;
                    case "Изменить характеристику":
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        ChangeRobotCharForm chRobotCharfrm = new ChangeRobotCharForm();
                        chRobotCharfrm.Owner = this;
                        chRobotCharfrm.ShowDialog();
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        break;
                    case "Добавить действие защиты":
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        AddRobotDefenceTypeForm addRobotDeffrm = new AddRobotDefenceTypeForm();
                        addRobotDeffrm.Owner = this;
                        addRobotDeffrm.ShowDialog();
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        break;
                    case "Удалить действие защиты":
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        DelRobotDefenceTypeForm delRobotDeffrm = new DelRobotDefenceTypeForm();
                        delRobotDeffrm.Owner = this;
                        delRobotDeffrm.ShowDialog();
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        break;
                    case "Изменить действие защиты":
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        ChangeRobotDefenceTypeForm chRobotDeffrm = new ChangeRobotDefenceTypeForm();
                        chRobotDeffrm.Owner = this;
                        chRobotDeffrm.ShowDialog();
                        cb_tables.Text = "Defence_actions";
                        ShowTable();
                        break;
                    case "Установить защиту для параметра":
                        cb_tables.Text = "ParameterProtection";
                        ShowTable();
                        SetParameterProtectionForm setParameterProtectionfrm = new SetParameterProtectionForm();
                        setParameterProtectionfrm.Owner = this;
                        setParameterProtectionfrm.ShowDialog();
                        cb_tables.Text = "ParameterProtection";
                        ShowTable();
                        break;
                    default:
                        MessageBox.Show("Операция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb_modifyRobot.SelectedIndex = -1;//сброс выбора
        }
        //ВРОДЕ РАБОТАЕТ
        private void cb_modifyAO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (cb_modifyAO.Text)
                {
                    case "Добавить активный объект":
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        AddActObjForm addAOfrm = new AddActObjForm();
                        addAOfrm.Owner = this;
                        addAOfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    case "Удалить активный объект":
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        DelActObjForm delAOfrm = new DelActObjForm();
                        delAOfrm.Owner = this;
                        delAOfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    case "Переименовать активный объект":
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        RenameForm renfrm = new RenameForm("ao");
                        renfrm.Owner = this;
                        renfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    case "Работа с типами объектов":
                        cb_tables.Text = "ActObjTypes";
                        ShowTable();
                        ModifyActObjTypesForm typesfrm = new ModifyActObjTypesForm();
                        typesfrm.Owner = this;
                        typesfrm.ShowDialog();
                        cb_tables.Text = "ActObjTypes";
                        ShowTable();
                        break;
                    case "Работа с таблицей характеристик":
                        cb_tables.Text = "Characteristics";
                        ShowTable();
                        ModifyCharacteristics charsfrm = new ModifyCharacteristics();
                        charsfrm.Owner = this;
                        charsfrm.ShowDialog();
                        cb_tables.Text = "Characteristics";
                        ShowTable();
                        break;
                    case "Работа с таблицей ActObjChar":
                        cb_tables.Text = "ActObjChar";
                        ShowTable();
                        ModifyActObjChar aocfrm = new ModifyActObjChar();
                        aocfrm.Owner = this;
                        aocfrm.ShowDialog();
                        cb_tables.Text = "ActObjChar";
                        ShowTable();
                        break;
                    case "Работа с AOTypeCanHaveChar":
                        cb_tables.Text = "AOTypeCanHaveChar";
                        ShowTable();
                        SetAOTypeCanHaveCharForm setfrm = new SetAOTypeCanHaveCharForm();
                        setfrm.Owner = this;
                        setfrm.ShowDialog();
                        cb_tables.Text = "AOTypeCanHaveChar";
                        ShowTable();
                        break;
                    default:
                        MessageBox.Show("Операция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb_modifyAO.SelectedIndex = -1;//сброс выбора
        }
        //ВРОДЕ РАБОТАЕТ
        private void cb_modifyPheno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (cb_modifyPheno.Text)
                {
                    case "Добавить явление":
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        AddPhenoForm addfrm = new AddPhenoForm();
                        addfrm.Owner = this;
                        addfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    case "Удалить явление":
                        cb_tables.Text = "Active_objects";//чтобы из формы удаления видеть нужную таблицу для указания ID
                        ShowTable();
                        DeletePhenoForm delfrm = new DeletePhenoForm();
                        delfrm.Owner = this;
                        delfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    case "Изменить явление":
                        cb_tables.Text = "Active_objects";//чтобы из формы изменения видеть нужную таблицу для указания ID
                        ShowTable();
                        ChangePhenoForm chfrm = new ChangePhenoForm();
                        chfrm.Owner = this;
                        chfrm.ShowDialog();
                        cb_tables.Text = "ActObjChar";
                        ShowTable();
                        break;
                    case "Переименовать явление":
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        RenameForm renfrm = new RenameForm("pheno");
                        renfrm.Owner = this;
                        renfrm.ShowDialog();
                        cb_tables.Text = "Active_objects";
                        ShowTable();
                        break;
                    default:
                        MessageBox.Show("Операция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb_modifyPheno.SelectedIndex = -1;//сброс выбора
        }
        //ВРОДЕ РАБОТАЕТ
        private void cb_modifyInteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cb_modifyInteraction.Text)
                {
                    case "Модификация действий":
                        cb_tables.Text = "Actions";
                        ShowTable();
                        ModifyActionsForm actfrm = new ModifyActionsForm();
                        actfrm.Owner = this;
                        actfrm.ShowDialog();
                        cb_tables.Text = "Actions";
                        ShowTable();
                        break;
                    case "Модификация типов взаимодействий":
                        cb_tables.Text = "Interaction_types";
                        ShowTable();
                        ModifyInteractionTypes itfrm = new ModifyInteractionTypes();
                        itfrm.Owner = this;
                        itfrm.ShowDialog();
                        cb_tables.Text = "Interaction_types";
                        ShowTable();
                        break;
                    case "Добавить потенциальное воздействие":
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        AddPotentialInfluenceForm apifrm = new AddPotentialInfluenceForm();
                        apifrm.Owner = this;
                        apifrm.ShowDialog();
                        cb_tables.Text = "Potential_influence";
                        ShowTable();
                        break;
                    case "Удалить потенциальное воздействие":                        
                        cb_tables.Text = "Robot_parameters";
                        ShowTable();
                        DeletePotentialInfluenceForm dpifrm = new DeletePotentialInfluenceForm();
                        dpifrm.Owner = this;
                        dpifrm.ShowDialog();
                        cb_tables.Text = "Potential_influence";
                        ShowTable();
                        break;
                    default:
                        //MessageBox.Show("Операция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb_modifyInteraction.SelectedIndex = -1;//сброс выбора
        }
    }
}
