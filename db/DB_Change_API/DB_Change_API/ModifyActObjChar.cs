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
    public partial class ModifyActObjChar : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_ActObj change_obj;

        public ModifyActObjChar()
        {
            InitializeComponent();
        }

        private void ModifyActObjChar_Load(object sender, EventArgs e)
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

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            label_value.Visible = true;
            label_value.Text = "Введите значение характеристики";
            tb_char_value.Visible = true;
            label_unit.Visible = true;
            label_unit.Text = "Введите единицы измерения";
            tb_name_unit.Visible = true;
            this.Height = 313;
            but_ok.Top = 236;
            but_cancel.Top = 236;
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            label_value.Visible = false;
            tb_char_value.Visible = false;
            label_unit.Visible = false;
            tb_name_unit.Visible = false;
            this.Height = 237;
            but_ok.Top = 160;
            but_cancel.Top = 160;
        }

        private void rb_change_CheckedChanged(object sender, EventArgs e)
        {
            label_value.Visible = true;
            label_value.Text = "Введите новое значение характеристики";
            tb_char_value.Visible = true;
            label_unit.Visible = true;
            label_unit.Text = "Введите новые единицы измерения";
            tb_name_unit.Visible = true;
            this.Height = 313;
            but_ok.Top = 236;
            but_cancel.Top = 236;
        }

        private void tb_name_ao_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Active_objects";
            mainform.ShowTable();
        }

        private void tb_name_char_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Characteristics";
            mainform.ShowTable();
        }

        private void tb_name_unit_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Units";
            mainform.ShowTable();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name_ao.Text == "" || tb_name_char.Text == "") throw new Exception("Все поля должны быть заполнены!");
                if (rb_add.Checked)
                {
                    if (tb_name_unit.Text == "" || tb_char_value.Text == "") throw new Exception("Все поля должны быть заполнены!");
                    change_obj.AddActObjChar(tb_name_ao.Text, tb_name_char.Text, tb_char_value.Text, tb_name_unit.Text);
                }
                if (rb_delete.Checked) change_obj.DeleteActObjChar(tb_name_ao.Text, tb_name_char.Text);
                if (rb_change.Checked)
                {
                    if (tb_name_unit.Text == "" || tb_char_value.Text == "") throw new Exception("Все поля должны быть заполнены!");
                    change_obj.ChangeActObjChar(tb_name_ao.Text, tb_name_char.Text, tb_char_value.Text, tb_name_unit.Text);
                }
                mainform.cb_tables.Text = "ActObjChar";
                mainform.ShowTable();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyActObjChar_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "ActObjChar";
            mainform.ShowTable();
        }
    }
}
