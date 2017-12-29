using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Change_API
{
    public partial class AddActObjForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_ActObj change_obj;

        public AddActObjForm()
        {
            InitializeComponent();
        }

        private void AddActObjForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("");
            try
            {
                if (change_obj != null) change_obj.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddActObjForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_ActObj();
                //change_obj.dbconn = mainform.change_obj.dbconn;//убрал, так как теперь создаётся всегда новое соединение при вызове конструктора
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_addAO_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "" || tb_type.Text == "") throw new Exception("Все поля должны быть заполнены!");
                change_obj.AddActObj(tb_name.Text, tb_type.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void tb_name_MouseClick(object sender, MouseEventArgs e)
        {
            mainform.cb_tables.Text = "Active_objects";
            mainform.ShowTable();
        }

        private void tb_type_MouseClick(object sender, MouseEventArgs e)
        {
            mainform.cb_tables.Text = "ActObjTypes";
            mainform.ShowTable();
        }
    }
}
