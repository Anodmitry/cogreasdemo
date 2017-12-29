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
    public partial class SetAOTypeCanHaveCharForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_ActObj change_obj;

        public SetAOTypeCanHaveCharForm()
        {
            InitializeComponent();
        }

        private void SetAOTypeCanHaveCharForm_Load(object sender, EventArgs e)
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
                if (tb_name_char.Text == "" || tb_type.Text == "") throw new Exception("Все поля должны быть заполнены!");
                if (rb_let.Checked) change_obj.SetAOTypeCanHaveChar(tb_type.Text, tb_name_char.Text, true);
                if (rb_forbid.Checked) change_obj.SetAOTypeCanHaveChar(tb_type.Text, tb_name_char.Text, false);                
                mainform.cb_tables.Text = "AOTypeCanHaveChar";
                mainform.ShowTable();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_type_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "ActObjTypes";
            mainform.ShowTable();
        }

        private void tb_name_char_Click(object sender, EventArgs e)
        {
            mainform.cb_tables.Text = "Characteristics";
            mainform.ShowTable();
        }
    }
}
