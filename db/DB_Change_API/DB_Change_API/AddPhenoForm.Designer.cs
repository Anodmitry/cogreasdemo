namespace DB_Change_API
{
    partial class AddPhenoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_radius = new System.Windows.Forms.TextBox();
            this.but_addPheno = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_intensity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название явления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите радиус действия явления";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(210, 17);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 20);
            this.tb_name.TabIndex = 2;
            // 
            // tb_radius
            // 
            this.tb_radius.Location = new System.Drawing.Point(210, 100);
            this.tb_radius.Name = "tb_radius";
            this.tb_radius.Size = new System.Drawing.Size(59, 20);
            this.tb_radius.TabIndex = 3;
            // 
            // but_addPheno
            // 
            this.but_addPheno.Location = new System.Drawing.Point(57, 289);
            this.but_addPheno.Name = "but_addPheno";
            this.but_addPheno.Size = new System.Drawing.Size(105, 26);
            this.but_addPheno.TabIndex = 4;
            this.but_addPheno.Text = "Добавить";
            this.but_addPheno.UseVisualStyleBackColor = true;
            this.but_addPheno.Click += new System.EventHandler(this.but_addPheno_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(200, 289);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 5;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(226, 58);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(43, 20);
            this.tb_x.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите координаты центра";
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(303, 58);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(43, 20);
            this.tb_y.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // tb_intensity
            // 
            this.tb_intensity.Location = new System.Drawing.Point(210, 147);
            this.tb_intensity.Name = "tb_intensity";
            this.tb_intensity.Size = new System.Drawing.Size(59, 20);
            this.tb_intensity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите интенсивность явления";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Явление действует с";
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(146, 192);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 20);
            this.dt_from.TabIndex = 18;
            this.dt_from.Value = new System.DateTime(2017, 5, 8, 11, 56, 6, 0);
            // 
            // dt_to
            // 
            this.dt_to.Location = new System.Drawing.Point(146, 233);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(200, 20);
            this.dt_to.TabIndex = 21;
            this.dt_to.Value = new System.DateTime(2017, 5, 8, 11, 56, 22, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Явление действует по";
            // 
            // AddPhenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 327);
            this.Controls.Add(this.dt_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_from);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_intensity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_addPheno);
            this.Controls.Add(this.tb_radius);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddPhenoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление явления";
            this.Load += new System.EventHandler(this.AddPhenoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_radius;
        private System.Windows.Forms.Button but_addPheno;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_intensity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label7;
    }
}