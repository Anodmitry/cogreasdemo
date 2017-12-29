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
    public partial class RenameForm : Form
    {
        private string rename_type;
        MainForm mainform;
        ChangeDB_Lib.Change_Pheno change_pheno_obj;
        ChangeDB_Lib.Change_ActObj change_ao_obj;


        public RenameForm()
        {
            InitializeComponent();
        }
        public RenameForm(string rename_type)//параметр - "ao"/"pheno"/"interaction"
        {
            this.rename_type = rename_type;
            InitializeComponent();
            switch (rename_type)
            {
                case "pheno":
                    this.Text = "Переименование явления";
                    break;
                case "ao":
                    this.Text = "Переименование активного объекта";
                    break;
                case "action":
                    this.Text = "Переименование действия";
                    break;
            }
        }

        private void RenameForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                switch (this.rename_type)
                {
                    case "pheno":
                        change_pheno_obj = new ChangeDB_Lib.Change_Pheno();
                        //change_pheno_obj.dbconn = mainform.change_obj.dbconn;
                        break;
                    case "ao":
                        change_ao_obj = new ChangeDB_Lib.Change_ActObj();
                        //change_ao_obj.dbconn = mainform.change_obj.dbconn;
                        break;
                    case "interaction":

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_rename_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_old_name.Text == "" || tb_new_name.Text == "") MessageBox.Show("Оба имени должны быть указаны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    switch (this.rename_type)
                    {
                        case "pheno":
                            change_pheno_obj.RenamePheno(tb_old_name.Text, tb_new_name.Text);
                            break;
                        case "ao":
                            change_ao_obj.RenameActObj(tb_old_name.Text, tb_new_name.Text);
                            break;
                        case "action":
                            
                            break;
                    }                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (this.rename_type)
            {
                case "pheno":
                    try
                    {
                        if (change_pheno_obj != null) change_pheno_obj.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "ao":
                    try
                    {
                        if (change_ao_obj != null) change_ao_obj.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "interaction":

                    break;
            }

            
        }
    }
}
