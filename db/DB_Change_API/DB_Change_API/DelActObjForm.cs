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
    public partial class DelActObjForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_ActObj change_obj;

        public DelActObjForm()
        {
            InitializeComponent();
        }

        private void DelActObjForm_Load(object sender, EventArgs e)
        {
            try
            {
                mainform = this.Owner as MainForm;
                change_obj = new ChangeDB_Lib.Change_ActObj();
                //change_obj.dbconn = mainform.change_obj.dbconn;//убрал, так как теперь создаётся всегда новое соединение при вызове конструктора
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void but_delAO_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "") throw new Exception("Все поля должны быть заполнены!");
                change_obj.DeleteActObj(tb_name.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelActObjForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("");
            try
            {
                if (change_obj != null) change_obj.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
