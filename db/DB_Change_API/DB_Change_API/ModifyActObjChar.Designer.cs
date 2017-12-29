namespace DB_Change_API
{
    partial class ModifyActObjChar
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
            this.tb_name_unit = new System.Windows.Forms.TextBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.rb_change = new System.Windows.Forms.RadioButton();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tb_name_ao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.tb_name_char = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_char_value = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name_unit
            // 
            this.tb_name_unit.Location = new System.Drawing.Point(270, 190);
            this.tb_name_unit.Name = "tb_name_unit";
            this.tb_name_unit.Size = new System.Drawing.Size(94, 20);
            this.tb_name_unit.TabIndex = 36;
            this.tb_name_unit.Click += new System.EventHandler(this.tb_name_unit_Click);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(42, 193);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(155, 13);
            this.label_unit.TabIndex = 35;
            this.label_unit.Text = "Введите единицы измерения";
            // 
            // rb_change
            // 
            this.rb_change.AutoSize = true;
            this.rb_change.Location = new System.Drawing.Point(257, 23);
            this.rb_change.Name = "rb_change";
            this.rb_change.Size = new System.Drawing.Size(76, 17);
            this.rb_change.TabIndex = 34;
            this.rb_change.TabStop = true;
            this.rb_change.Text = "Изменить";
            this.rb_change.UseVisualStyleBackColor = true;
            this.rb_change.CheckedChanged += new System.EventHandler(this.rb_change_CheckedChanged);
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(228, 236);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 26);
            this.but_cancel.TabIndex = 33;
            this.but_cancel.Text = "Отменить";
            this.but_cancel.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(85, 236);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(105, 26);
            this.but_ok.TabIndex = 32;
            this.but_ok.Text = "Применить";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tb_name_ao
            // 
            this.tb_name_ao.Location = new System.Drawing.Point(270, 62);
            this.tb_name_ao.Name = "tb_name_ao";
            this.tb_name_ao.Size = new System.Drawing.Size(94, 20);
            this.tb_name_ao.TabIndex = 31;
            this.tb_name_ao.Click += new System.EventHandler(this.tb_name_ao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Введите имя активного объекта";
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(170, 23);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(68, 17);
            this.rb_delete.TabIndex = 29;
            this.rb_delete.TabStop = true;
            this.rb_delete.Text = "Удалить";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_delete_CheckedChanged);
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(77, 23);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(75, 17);
            this.rb_add.TabIndex = 28;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Добавить";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // tb_name_char
            // 
            this.tb_name_char.Location = new System.Drawing.Point(270, 103);
            this.tb_name_char.Name = "tb_name_char";
            this.tb_name_char.Size = new System.Drawing.Size(94, 20);
            this.tb_name_char.TabIndex = 38;
            this.tb_name_char.Click += new System.EventHandler(this.tb_name_char_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Введите название характеристики";
            // 
            // tb_char_value
            // 
            this.tb_char_value.Location = new System.Drawing.Point(270, 146);
            this.tb_char_value.Name = "tb_char_value";
            this.tb_char_value.Size = new System.Drawing.Size(94, 20);
            this.tb_char_value.TabIndex = 40;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(42, 149);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(183, 13);
            this.label_value.TabIndex = 39;
            this.label_value.Text = "Введите значение характеристики";
            // 
            // ModifyActObjChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(411, 274);
            this.Controls.Add(this.tb_char_value);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.tb_name_char);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name_unit);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.rb_change);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_name_ao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_delete);
            this.Controls.Add(this.rb_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyActObjChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модификация таблицы ActObjChar";
            this.Load += new System.EventHandler(this.ModifyActObjChar_Load);
            this.Click += new System.EventHandler(this.ModifyActObjChar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name_unit;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.RadioButton rb_change;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TextBox tb_name_ao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.TextBox tb_name_char;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_char_value;
        private System.Windows.Forms.Label label_value;
    }
}