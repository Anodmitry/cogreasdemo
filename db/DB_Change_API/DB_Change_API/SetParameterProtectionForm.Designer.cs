namespace DB_Change_API
{
    partial class SetParameterProtectionForm
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
            this.tb_def_act_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_par_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_coef_weak_attack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_def_act_name
            // 
            this.tb_def_act_name.Location = new System.Drawing.Point(256, 58);
            this.tb_def_act_name.Name = "tb_def_act_name";
            this.tb_def_act_name.Size = new System.Drawing.Size(123, 20);
            this.tb_def_act_name.TabIndex = 39;
            this.tb_def_act_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_def_act_name_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Введите название действия защиты";
            // 
            // tb_par_name
            // 
            this.tb_par_name.Location = new System.Drawing.Point(256, 14);
            this.tb_par_name.Name = "tb_par_name";
            this.tb_par_name.Size = new System.Drawing.Size(123, 20);
            this.tb_par_name.TabIndex = 41;
            this.tb_par_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_par_name_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Введите параметр для защиты";
            // 
            // tb_coef_weak_attack
            // 
            this.tb_coef_weak_attack.Location = new System.Drawing.Point(256, 103);
            this.tb_coef_weak_attack.Name = "tb_coef_weak_attack";
            this.tb_coef_weak_attack.Size = new System.Drawing.Size(70, 20);
            this.tb_coef_weak_attack.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Введите коэффициент ослабления атаки";
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(221, 155);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 45;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_set
            // 
            this.but_set.Location = new System.Drawing.Point(78, 155);
            this.but_set.Name = "but_set";
            this.but_set.Size = new System.Drawing.Size(105, 26);
            this.but_set.TabIndex = 44;
            this.but_set.Text = "Изменить";
            this.but_set.UseVisualStyleBackColor = true;
            this.but_set.Click += new System.EventHandler(this.but_set_Click);
            // 
            // SetParameterProtectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(406, 198);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_set);
            this.Controls.Add(this.tb_coef_weak_attack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_par_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_def_act_name);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetParameterProtectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Установление защиты для параметра";
            this.Load += new System.EventHandler(this.SetParameterProtectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_def_act_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_par_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_coef_weak_attack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_set;
    }
}