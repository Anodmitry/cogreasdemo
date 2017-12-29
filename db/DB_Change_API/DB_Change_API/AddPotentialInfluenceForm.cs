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
    public partial class AddPotentialInfluenceForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Interaction change_obj;

        public AddPotentialInfluenceForm()
        {
            InitializeComponent();
        }

        private void AddPotencialInfluenceForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_Interaction();
                change_obj.dbconn = mainform.change_obj.dbconn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_ch_param.Text == "" || tb_radius.Text == "" ||
                    tb_max_part.Text == "" || tb_change_type.Text == "" ||
                    tb_name_action.Text == "" || tb_var_name.Text == "") throw new Exception("Все поля должны быть заполнены!");
                else
                {
                    change_obj.AddPotInf(tb_ch_param.Text, tb_radius.Text, tb_max_part.Text, chbox_depend_dist.Checked.ToString(),
                                         tb_change_type.Text, tb_name_action.Text, tb_var_name.Text);
                    mainform.cb_tables.Text = "Potential_influence";
                    mainform.ShowTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_ch_param_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Robot_parameters";
            mainform.ShowTable();
        }

        private void tb_change_type_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Change_types";
            mainform.ShowTable();
        }

        private void tb_name_action_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Actions";
            mainform.ShowTable();
        }

        private void tb_var_name_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Interaction_types";
            mainform.ShowTable();
        }
    }
}
