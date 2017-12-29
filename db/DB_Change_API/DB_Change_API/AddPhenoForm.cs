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
    public partial class AddPhenoForm : Form
    {
        MainForm mainform;
        ChangeDB_Lib.Change_Pheno change_obj;

        public AddPhenoForm()
        {
            InitializeComponent();
            dt_from.Format = DateTimePickerFormat.Time;
            dt_from.ShowUpDown = true;
            dt_to.Format = DateTimePickerFormat.Time;
            dt_to.ShowUpDown = true;
        }

        private void AddPhenoForm_Load(object sender, EventArgs e)
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

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_addPheno_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "" || tb_x.Text == "" ||
                    tb_y.Text == "" || tb_radius.Text == "" ||
                    tb_intensity.Text == "") MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //change_obj.AddPheno("явл_1","0","-7","23","12","13:00","22:00");
                    change_obj.AddPheno(tb_name.Text, tb_x.Text, tb_y.Text, tb_radius.Text, tb_intensity.Text,
                                        dt_from.Value.TimeOfDay.ToString(), dt_to.Value.TimeOfDay.ToString());
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
