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
    public partial class SetParameterProtectionForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Robot change_obj;

        public SetParameterProtectionForm()
        {
            InitializeComponent();
        }

        private void SetParameterProtectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_Robot();
                change_obj.dbconn = mainform.change_obj.dbconn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_set_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_def_act_name.Text == "" || tb_par_name.Text == "" || tb_coef_weak_attack.Text == "") throw new Exception("Все поля должны быть заполнены!");
                else
                {
                    change_obj.SetParameterProtection(tb_def_act_name.Text, tb_par_name.Text, tb_coef_weak_attack.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_def_act_name_MouseClick(object sender, MouseEventArgs e)
        {
            mainform.cb_tables.Text = "Defence_actions";
            mainform.ShowTable();
        }

        private void tb_par_name_MouseClick(object sender, MouseEventArgs e)
        {
            mainform.cb_tables.Text = "Robot_parameters";
            mainform.ShowTable();
        }
    }
}
