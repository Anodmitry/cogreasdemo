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
    public partial class ModifyInteractionTypes : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Interaction change_obj;

        public ModifyInteractionTypes()
        {
            InitializeComponent();
        }

        private void ModifyInteractionTypes_Load(object sender, EventArgs e)
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

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Text = "Введите название вариации";
            label_new_var.Visible = false;
            tb_new_var.Visible = false;
            this.Height = 213;
            but_ok.Top = 135;
            but_cancel.Top = 135;
        }

        private void rb_rename_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Text = "Введите старую вариацию";
            label_new_var.Visible = true;
            tb_new_var.Visible = true;
            this.Height = 254;
            but_ok.Top = 178;
            but_cancel.Top = 178;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name_action.Text == "" || tb_var_name.Text == "") throw new Exception("Введите названия действия и вариации!");
                else
                {
                    if (rb_add.Checked) change_obj.AddInterType(tb_name_action.Text, tb_var_name.Text);
                    //if (rb_delete.Checked) change_obj.DeleteAction(tb_name_action.Text);
                    if (rb_rename.Checked && tb_new_var.Text == "") throw new Exception("Введите новое название вариации!");
                    if (rb_rename.Checked) change_obj.ChangeVariation(tb_name_action.Text, tb_var_name.Text, tb_new_var.Text);
                    mainform.cb_tables.Text = "Interaction_types";
                    mainform.ShowTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
