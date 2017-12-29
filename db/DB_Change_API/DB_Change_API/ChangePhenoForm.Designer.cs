namespace DB_Change_API
{
    partial class ChangePhenoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_changePheno = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_char = new System.Windows.Forms.ComboBox();
            this.dt_new_time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_new_val = new System.Windows.Forms.TextBox();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(263, 166);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 11;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_changePheno
            // 
            this.but_changePheno.Location = new System.Drawing.Point(120, 166);
            this.but_changePheno.Name = "but_changePheno";
            this.but_changePheno.Size = new System.Drawing.Size(105, 26);
            this.but_changePheno.TabIndex = 10;
            this.but_changePheno.Text = "Изменить";
            this.but_changePheno.UseVisualStyleBackColor = true;
            this.but_changePheno.Click += new System.EventHandler(this.but_changePheno_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(229, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(225, 20);
            this.tb_name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите название характеристики";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите название явления";
            // 
            // cb_char
            // 
            this.cb_char.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_char.FormattingEnabled = true;
            this.cb_char.Items.AddRange(new object[] {
            "координаты центра",
            "радиус явления",
            "интенсивность явления",
            "время начала действия явления",
            "время окончания действия явления"});
            this.cb_char.Location = new System.Drawing.Point(229, 62);
            this.cb_char.Name = "cb_char";
            this.cb_char.Size = new System.Drawing.Size(225, 21);
            this.cb_char.TabIndex = 12;
            this.cb_char.SelectionChangeCommitted += new System.EventHandler(this.cb_char_SelectionChangeCommitted);
            // 
            // dt_new_time
            // 
            this.dt_new_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_new_time.Location = new System.Drawing.Point(229, 106);
            this.dt_new_time.Name = "dt_new_time";
            this.dt_new_time.Size = new System.Drawing.Size(84, 20);
            this.dt_new_time.TabIndex = 13;
            this.dt_new_time.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Укажите новое значение";
            // 
            // tb_new_val
            // 
            this.tb_new_val.Location = new System.Drawing.Point(299, 106);
            this.tb_new_val.Name = "tb_new_val";
            this.tb_new_val.Size = new System.Drawing.Size(155, 20);
            this.tb_new_val.TabIndex = 15;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(349, 109);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(14, 13);
            this.label_y.TabIndex = 19;
            this.label_y.Text = "Y";
            this.label_y.Visible = false;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(272, 109);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(14, 13);
            this.label_x.TabIndex = 18;
            this.label_x.Text = "X";
            this.label_x.Visible = false;
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(366, 106);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(43, 20);
            this.tb_y.TabIndex = 17;
            this.tb_y.Visible = false;
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(289, 106);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(43, 20);
            this.tb_x.TabIndex = 16;
            this.tb_x.Visible = false;
            // 
            // ChangePhenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 204);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.tb_new_val);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_new_time);
            this.Controls.Add(this.cb_char);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_changePheno);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChangePhenoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение явления";
            this.Load += new System.EventHandler(this.ChangePhenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_changePheno;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_char;
        private System.Windows.Forms.DateTimePicker dt_new_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_new_val;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.TextBox tb_x;
    }
}