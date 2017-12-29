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
    public partial class AddRobotCharForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Robot change_obj;

        public AddRobotCharForm()
        {
            InitializeComponent();
        }

        private void but_addChar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_chName.Text == "" || tb_chValue.Text == "") throw new Exception("Заполните оба поля!");
                else
                {
                    change_obj.AddParameter(tb_chName.Text, tb_chValue.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void AddRobotCharForm_Load(object sender, EventArgs e)
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
