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
    public partial class ChangePhenoForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Pheno change_obj;

        public ChangePhenoForm()
        {
            InitializeComponent();
            dt_new_time.ShowUpDown = true;
        }

        private void but_changePheno_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "") throw new Exception("Введите имя явления!");
                if (cb_char.Text == "") throw new Exception("Выберите характеристику!");
                if (tb_x.Visible && tb_x.Text == "" || tb_y.Visible && tb_y.Text == "" || tb_new_val.Visible && tb_new_val.Text == "") throw new Exception("Введите значение!");
                else
                {
                    if (cb_char.Text == "координаты центра") change_obj.ChangePheno(tb_name.Text, cb_char.Text, tb_x.Text + ";" + tb_y.Text);
                    if (cb_char.Text == "время начала действия явления" || cb_char.Text == "время окончания действия явления") change_obj.ChangePheno(tb_name.Text, cb_char.Text, dt_new_time.Value.TimeOfDay.ToString());
                    else change_obj.ChangePheno(tb_name.Text, cb_char.Text, tb_new_val.Text);
                }
                MessageBox.Show("Изменения успешно внесены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePhenoForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_Pheno();
                change_obj.dbconn = mainform.change_obj.dbconn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cb_char_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (cb_char.Text)
                {
                    case "координаты центра":
                        tb_new_val.Visible = false;
                        dt_new_time.Visible = false;
                        label_x.Visible = true;
                        label_y.Visible = true;
                        tb_x.Visible = true;
                        tb_y.Visible = true;
                        break;
                    case "радиус явления":
                        tb_x.Visible = false;
                        tb_y.Visible = false;
                        label_x.Visible = false;
                        label_y.Visible = false;
                        dt_new_time.Visible = false;
                        tb_new_val.Visible = true;
                        break;
                    case "интенсивность явления":
                        tb_x.Visible = false;
                        tb_y.Visible = false;
                        label_x.Visible = false;
                        label_y.Visible = false;
                        dt_new_time.Visible = false;
                        tb_new_val.Visible = true;
                        break;
                    case "время начала действия явления":
                        tb_x.Visible = false;
                        tb_y.Visible = false;
                        label_x.Visible = false;
                        label_y.Visible = false;
                        tb_new_val.Visible = false;
                        dt_new_time.Visible = true;
                        break;
                    case "время окончания действия явления":
                        tb_x.Visible = false;
                        tb_y.Visible = false;
                        label_x.Visible = false;
                        label_y.Visible = false;
                        tb_new_val.Visible = false;
                        dt_new_time.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}