namespace DB_Change_API
{
    partial class SetAOTypeCanHaveCharForm
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
            this.rb_forbid = new System.Windows.Forms.RadioButton();
            this.rb_let = new System.Windows.Forms.RadioButton();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tb_name_char = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_forbid
            // 
            this.rb_forbid.AutoSize = true;
            this.rb_forbid.Location = new System.Drawing.Point(217, 130);
            this.rb_forbid.Name = "rb_forbid";
            this.rb_forbid.Size = new System.Drawing.Size(78, 17);
            this.rb_forbid.TabIndex = 31;
            this.rb_forbid.TabStop = true;
            this.rb_forbid.Text = "Запретить";
            this.rb_forbid.UseVisualStyleBackColor = true;
            // 
            // rb_let
            // 
            this.rb_let.AutoSize = true;
            this.rb_let.Location = new System.Drawing.Point(96, 130);
            this.rb_let.Name = "rb_let";
            this.rb_let.Size = new System.Drawing.Size(81, 17);
            this.rb_let.TabIndex = 30;
            this.rb_let.TabStop = true;
            this.rb_let.Text = "Разрешить";
            this.rb_let.UseVisualStyleBackColor = true;
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(207, 188);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 35;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(64, 188);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 34;
            this.but_ok.Text = "Применить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tb_name_char
            // 
            this.tb_name_char.Location = new System.Drawing.Point(237, 74);
            this.tb_name_char.Name = "tb_name_char";
            this.tb_name_char.Size = new System.Drawing.Size(104, 20);
            this.tb_name_char.TabIndex = 40;
            this.tb_name_char.Click += new System.EventHandler(this.tb_name_char_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Введите название характеристики";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(237, 30);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(104, 20);
            this.tb_type.TabIndex = 42;
            this.tb_type.Click += new System.EventHandler(this.tb_type_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Введите название типа";
            // 
            // SetAOTypeCanHaveCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 231);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name_char);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.rb_forbid);
            this.Controls.Add(this.rb_let);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetAOTypeCanHaveCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Разрешение/запрет типу иметь характеристику";
            this.Load += new System.EventHandler(this.SetAOTypeCanHaveCharForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_forbid;
        private System.Windows.Forms.RadioButton rb_let;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TextBox tb_name_char;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label2;
    }
}