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
    public partial class ModifyActionsForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Interaction change_obj;

        public ModifyActionsForm()
        {
            InitializeComponent();
        }

        private void ModifyActionsForm_Load(object sender, EventArgs e)
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

        private void rb_rename_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = true;
            tb_new_name.Visible = true;
            this.Height = 232;
            but_ok.Top = 155;
            but_cancel.Top = 155;
        }

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = false;
            tb_new_name.Visible = false;
            this.Height = 195;
            but_ok.Top = 115;
            but_cancel.Top = 115;
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = false;
            tb_new_name.Visible = false;
            this.Height = 195;
            but_ok.Top = 115;
            but_cancel.Top = 115;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name_action.Text == "") throw new Exception("Введите название действия!");
                else
                {
                    if (rb_add.Checked) change_obj.AddAction(tb_name_action.Text);
                    if (rb_delete.Checked) change_obj.DeleteAction(tb_name_action.Text);
                    if (rb_rename.Checked && tb_new_name.Text == "") throw new Exception("Введите новое название действия!");
                    if (rb_rename.Checked) change_obj.RenameAction(tb_name_action.Text, tb_new_name.Text);
                    mainform.cb_tables.Text = "Actions";
                    mainform.ShowTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
