namespace DB_Change_API
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.cb_tables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pathdb = new System.Windows.Forms.TextBox();
            this.but_opendb = new System.Windows.Forms.Button();
            this.cb_modifyPheno = new System.Windows.Forms.ComboBox();
            this.cb_modifyAO = new System.Windows.Forms.ComboBox();
            this.cb_modifyRobot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_modifyInteraction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_table.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(11, 53);
            this.dgv_table.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.Size = new System.Drawing.Size(907, 383);
            this.dgv_table.TabIndex = 2;
            // 
            // cb_tables
            // 
            this.cb_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tables.Enabled = false;
            this.cb_tables.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_tables.FormattingEnabled = true;
            this.cb_tables.Location = new System.Drawing.Point(1093, 12);
            this.cb_tables.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cb_tables.Name = "cb_tables";
            this.cb_tables.Size = new System.Drawing.Size(164, 21);
            this.cb_tables.TabIndex = 3;
            this.cb_tables.SelectionChangeCommitted += new System.EventHandler(this.cb_tables_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(936, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отобразить таблицу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя базы данных";
            // 
            // tb_pathdb
            // 
            this.tb_pathdb.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pathdb.Location = new System.Drawing.Point(158, 12);
            this.tb_pathdb.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tb_pathdb.Name = "tb_pathdb";
            this.tb_pathdb.Size = new System.Drawing.Size(463, 21);
            this.tb_pathdb.TabIndex = 6;
            this.tb_pathdb.Text = "envdb";
            // 
            // but_opendb
            // 
            this.but_opendb.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_opendb.Location = new System.Drawing.Point(654, 8);
            this.but_opendb.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.but_opendb.Name = "but_opendb";
            this.but_opendb.Size = new System.Drawing.Size(173, 27);
            this.but_opendb.TabIndex = 7;
            this.but_opendb.Text = "Открыть базу данных";
            this.but_opendb.UseVisualStyleBackColor = true;
            this.but_opendb.Click += new System.EventHandler(this.but_opendb_Click);
            // 
            // cb_modifyPheno
            // 
            this.cb_modifyPheno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modifyPheno.Enabled = false;
            this.cb_modifyPheno.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_modifyPheno.FormattingEnabled = true;
            this.cb_modifyPheno.Items.AddRange(new object[] {
            "Добавить явление",
            "Удалить явление",
            "Изменить явление",
            "Переименовать явление"});
            this.cb_modifyPheno.Location = new System.Drawing.Point(955, 280);
            this.cb_modifyPheno.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cb_modifyPheno.Name = "cb_modifyPheno";
            this.cb_modifyPheno.Size = new System.Drawing.Size(301, 21);
            this.cb_modifyPheno.TabIndex = 14;
            this.cb_modifyPheno.SelectionChangeCommitted += new System.EventHandler(this.cb_modifyPheno_SelectionChangeCommitted);
            // 
            // cb_modifyAO
            // 
            this.cb_modifyAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modifyAO.Enabled = false;
            this.cb_modifyAO.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_modifyAO.FormattingEnabled = true;
            this.cb_modifyAO.Items.AddRange(new object[] {
            "Добавить активный объект",
            "Удалить активный объект",
            "Переименовать активный объект",
            "Работа с типами объектов",
            "Работа с таблицей характеристик",
            "Работа с таблицей ActObjChar",
            "Работа с AOTypeCanHaveChar"});
            this.cb_modifyAO.Location = new System.Drawing.Point(955, 200);
            this.cb_modifyAO.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cb_modifyAO.Name = "cb_modifyAO";
            this.cb_modifyAO.Size = new System.Drawing.Size(301, 21);
            this.cb_modifyAO.TabIndex = 15;
            this.cb_modifyAO.SelectionChangeCommitted += new System.EventHandler(this.cb_modifyAO_SelectionChangeCommitted);
            // 
            // cb_modifyRobot
            // 
            this.cb_modifyRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modifyRobot.Enabled = false;
            this.cb_modifyRobot.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_modifyRobot.FormattingEnabled = true;
            this.cb_modifyRobot.Items.AddRange(new object[] {
            "Добавить характеристику",
            "Удалить характеристику",
            "Изменить характеристику",
            "Добавить действие защиты",
            "Удалить действие защиты",
            "Изменить действие защиты",
            "Установить защиту для параметра"});
            this.cb_modifyRobot.Location = new System.Drawing.Point(955, 121);
            this.cb_modifyRobot.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cb_modifyRobot.Name = "cb_modifyRobot";
            this.cb_modifyRobot.Size = new System.Drawing.Size(301, 21);
            this.cb_modifyRobot.TabIndex = 16;
            this.cb_modifyRobot.SelectionChangeCommitted += new System.EventHandler(this.cb_modifyRobot_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(936, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Модифицировать робота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(936, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Модифицировать явления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(936, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Модифицировать активные объекты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(936, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Модифицировать взаимодействия";
            // 
            // cb_modifyInteraction
            // 
            this.cb_modifyInteraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modifyInteraction.Enabled = false;
            this.cb_modifyInteraction.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_modifyInteraction.FormattingEnabled = true;
            this.cb_modifyInteraction.Items.AddRange(new object[] {
            "Модификация действий",
            "Модификация типов взаимодействий",
            "Добавить потенциальное воздействие",
            "Удалить потенциальное воздействие"});
            this.cb_modifyInteraction.Location = new System.Drawing.Point(955, 360);
            this.cb_modifyInteraction.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cb_modifyInteraction.Name = "cb_modifyInteraction";
            this.cb_modifyInteraction.Size = new System.Drawing.Size(301, 21);
            this.cb_modifyInteraction.TabIndex = 21;
            this.cb_modifyInteraction.SelectedIndexChanged += new System.EventHandler(this.cb_modifyInteraction_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_modifyInteraction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_modifyRobot);
            this.Controls.Add(this.cb_modifyAO);
            this.Controls.Add(this.cb_modifyPheno);
            this.Controls.Add(this.but_opendb);
            this.Controls.Add(this.tb_pathdb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tables);
            this.Controls.Add(this.dgv_table);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модификация базы данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pathdb;
        private System.Windows.Forms.Button but_opendb;
        private System.Windows.Forms.ComboBox cb_modifyPheno;
        private System.Windows.Forms.ComboBox cb_modifyAO;
        private System.Windows.Forms.ComboBox cb_modifyRobot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cb_tables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_modifyInteraction;
    }
}

