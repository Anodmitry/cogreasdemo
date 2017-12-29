namespace DB_Change_API
{
    partial class ModifyCharacteristics
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
            this.tb_new_name = new System.Windows.Forms.TextBox();
            this.label_new_name = new System.Windows.Forms.Label();
            this.rb_change = new System.Windows.Forms.RadioButton();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tb_new_name
            // 
            this.tb_new_name.Location = new System.Drawing.Point(249, 96);
            this.tb_new_name.Name = "tb_new_name";
            this.tb_new_name.Size = new System.Drawing.Size(94, 20);
            this.tb_new_name.TabIndex = 27;
            this.tb_new_name.Visible = false;
            // 
            // label_new_name
            // 
            this.label_new_name.AutoSize = true;
            this.label_new_name.Location = new System.Drawing.Point(21, 99);
            this.label_new_name.Name = "label_new_name";
            this.label_new_name.Size = new System.Drawing.Size(217, 13);
            this.label_new_name.TabIndex = 26;
            this.label_new_name.Text = "Введите новое название характеристики";
            this.label_new_name.Visible = false;
            // 
            // rb_change
            // 
            this.rb_change.AutoSize = true;
            this.rb_change.Location = new System.Drawing.Point(236, 22);
            this.rb_change.Name = "rb_change";
            this.rb_change.Size = new System.Drawing.Size(76, 17);
            this.rb_change.TabIndex = 25;
            this.rb_change.TabStop = true;
            this.rb_change.Text = "Изменить";
            this.rb_change.UseVisualStyleBackColor = true;
            this.rb_change.CheckedChanged += new System.EventHandler(this.rb_change_CheckedChanged);
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(205, 139);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 24;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(62, 139);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 23;
            this.but_ok.Text = "Применить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(249, 55);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(94, 20);
            this.tb_name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Введите название характеристики";
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(149, 22);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(68, 17);
            this.rb_delete.TabIndex = 20;
            this.rb_delete.TabStop = true;
            this.rb_delete.Text = "Удалить";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_delete_CheckedChanged);
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(56, 22);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(75, 17);
            this.rb_add.TabIndex = 19;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Добавить";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // ModifyActObjCharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 184);
            this.Controls.Add(this.tb_new_name);
            this.Controls.Add(this.label_new_name);
            this.Controls.Add(this.rb_change);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_delete);
            this.Controls.Add(this.rb_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyActObjCharacteristics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модификация характеристик активных объектов";
            this.Load += new System.EventHandler(this.ModifyActObjCharacteristics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_new_name;
        private System.Windows.Forms.Label label_new_name;
        private System.Windows.Forms.RadioButton rb_change;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_add;
    }
}