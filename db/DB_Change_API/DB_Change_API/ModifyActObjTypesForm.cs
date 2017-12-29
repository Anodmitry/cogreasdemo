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
    public partial class ModifyActObjTypesForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_ActObj change_obj;

        public ModifyActObjTypesForm()
        {
            InitializeComponent();
        }

        private void ModifyActObjTypesForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_ActObj();
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
                if (tb_name.Text == "") throw new Exception("Все поля должны быть заполнены!");
                if (rb_add.Checked) change_obj.AddAOType(tb_name.Text);
                if (rb_delete.Checked) change_obj.DeleteAOType(tb_name.Text);
                if (rb_change.Checked)
                {
                    if (tb_new_name.Text == "") throw new Exception("Все поля должны быть заполнены!");
                    change_obj.ChangeAOType(tb_name.Text, tb_new_name.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = false;
            tb_new_name.Visible = false;
        }

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = false;
            tb_new_name.Visible = false;
        }

        private void rb_change_CheckedChanged(object sender, EventArgs e)
        {
            label_new_name.Visible = true;
            tb_new_name.Visible = true;
        }
    }
}
