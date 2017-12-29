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
    public partial class DeletePhenoForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Pheno change_obj;

        public DeletePhenoForm()
        {
            InitializeComponent();
        }        

        private void DeletePhenoForm_Load(object sender, EventArgs e)
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

        private void but_delPheno_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "") MessageBox.Show("Укажите имя явления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    change_obj.DeletePheno(tb_name.Text);
                    this.Close();
                }
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
    }
}
