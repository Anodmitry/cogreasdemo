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
    public partial class DelRobotCharForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Robot change_obj;

        public DelRobotCharForm()
        {
            InitializeComponent();
        }

        private void but_delRobotChar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "") throw new Exception("Введите название характеристики!");
                else
                {
                    change_obj.DeleteParameter(tb_name.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelRobotCharForm_Load(object sender, EventArgs e)
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
    }
}
