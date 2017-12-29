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
    public partial class ChangeRobotDefenceTypeForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Robot change_obj;

        public ChangeRobotDefenceTypeForm()
        {
            InitializeComponent();
        }

        private void ChangeRobotDefenceTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_Robot();
                change_obj.dbconn = mainform.change_obj.dbconn;
                MessageBox.Show("Оставьте поле пустым, чтобы не менять его значение в БД.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_changeDefType_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_old_name.Text == "") throw new Exception("Введите имя изменяемого действия защиты!");
                if (tb_new_name.Text == "" && tb_energySpending.Text == "") throw new Exception("Введите хотя бы одно новое значение!");
                else
                {
                    change_obj.ChangeDefenceAction(tb_old_name.Text, tb_new_name.Text, tb_energySpending.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
