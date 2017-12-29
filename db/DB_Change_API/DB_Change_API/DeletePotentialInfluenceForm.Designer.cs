namespace DB_Change_API
{
    partial class DeletePotentialInfluenceForm
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
            this.tb_ch_param = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_var_name = new System.Windows.Forms.TextBox();
            this.label_new_name = new System.Windows.Forms.Label();
            this.tb_name_action = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ch_param
            // 
            this.tb_ch_param.Location = new System.Drawing.Point(237, 26);
            this.tb_ch_param.Name = "tb_ch_param";
            this.tb_ch_param.Size = new System.Drawing.Size(123, 20);
            this.tb_ch_param.TabIndex = 57;
            this.tb_ch_param.Click += new System.EventHandler(this.tb_ch_param_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Введите название параметра робота";
            // 
            // tb_var_name
            // 
            this.tb_var_name.Location = new System.Drawing.Point(237, 102);
            this.tb_var_name.Name = "tb_var_name";
            this.tb_var_name.Size = new System.Drawing.Size(123, 20);
            this.tb_var_name.TabIndex = 70;
            this.tb_var_name.Click += new System.EventHandler(this.tb_var_name_Click);
            // 
            // label_new_name
            // 
            this.label_new_name.AutoSize = true;
            this.label_new_name.Location = new System.Drawing.Point(23, 105);
            this.label_new_name.Name = "label_new_name";
            this.label_new_name.Size = new System.Drawing.Size(151, 13);
            this.label_new_name.TabIndex = 69;
            this.label_new_name.Text = "Введите название вариации";
            // 
            // tb_name_action
            // 
            this.tb_name_action.Location = new System.Drawing.Point(237, 64);
            this.tb_name_action.Name = "tb_name_action";
            this.tb_name_action.Size = new System.Drawing.Size(123, 20);
            this.tb_name_action.TabIndex = 68;
            this.tb_name_action.Click += new System.EventHandler(this.tb_name_action_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Введите название действия";
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(215, 146);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 72;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(72, 146);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 71;
            this.but_ok.Text = "Удалить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // DeletePotentialInfluenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(392, 187);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_var_name);
            this.Controls.Add(this.label_new_name);
            this.Controls.Add(this.tb_name_action);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ch_param);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeletePotentialInfluenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление потенциального воздействия";
            this.Load += new System.EventHandler(this.DeletePotentialInfluenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ch_param;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_var_name;
        private System.Windows.Forms.Label label_new_name;
        private System.Windows.Forms.TextBox tb_name_action;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
    }
}