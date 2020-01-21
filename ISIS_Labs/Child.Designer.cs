namespace ISIS_Labs
{
    partial class Child
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textLoad = new System.Windows.Forms.Button();
            this.textSave = new System.Windows.Forms.Button();
            this.statsCount = new System.Windows.Forms.Button();
            this.wordCount = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveXML = new System.Windows.Forms.Button();
            this.iniSave = new System.Windows.Forms.Button();
            this.iniLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statsClear = new System.Windows.Forms.Button();
            this.openTextFromDB = new System.Windows.Forms.Button();
            this.saveIniToDB = new System.Windows.Forms.Button();
            this.loadIniToDB = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.wordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(619, 551);
            this.textBox1.TabIndex = 0;
            // 
            // textLoad
            // 
            this.textLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLoad.Location = new System.Drawing.Point(12, 695);
            this.textLoad.Name = "textLoad";
            this.textLoad.Size = new System.Drawing.Size(297, 49);
            this.textLoad.TabIndex = 1;
            this.textLoad.Text = "Загрузка текста";
            this.textLoad.UseVisualStyleBackColor = true;
            this.textLoad.Click += new System.EventHandler(this.textLoad_Click);
            // 
            // textSave
            // 
            this.textSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSave.Location = new System.Drawing.Point(315, 695);
            this.textSave.Name = "textSave";
            this.textSave.Size = new System.Drawing.Size(316, 49);
            this.textSave.TabIndex = 2;
            this.textSave.Text = "Сохранение текста";
            this.textSave.UseVisualStyleBackColor = true;
            this.textSave.Click += new System.EventHandler(this.textSave_Click);
            // 
            // statsCount
            // 
            this.statsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsCount.Location = new System.Drawing.Point(918, 695);
            this.statsCount.Name = "statsCount";
            this.statsCount.Size = new System.Drawing.Size(258, 49);
            this.statsCount.TabIndex = 3;
            this.statsCount.Text = "Подсчет статистики";
            this.statsCount.UseVisualStyleBackColor = true;
            this.statsCount.Click += new System.EventHandler(this.statsCount_Click);
            // 
            // wordCount
            // 
            this.wordCount.Location = new System.Drawing.Point(637, 40);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(539, 56);
            this.wordCount.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(646, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 22);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 413);
            this.dataGridView1.TabIndex = 6;
            // 
            // saveXML
            // 
            this.saveXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveXML.Location = new System.Drawing.Point(646, 640);
            this.saveXML.Name = "saveXML";
            this.saveXML.Size = new System.Drawing.Size(530, 49);
            this.saveXML.TabIndex = 7;
            this.saveXML.Text = "Сохранить таблицу в XML";
            this.saveXML.UseVisualStyleBackColor = true;
            this.saveXML.Click += new System.EventHandler(this.saveXML_Click);
            // 
            // iniSave
            // 
            this.iniSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iniSave.Location = new System.Drawing.Point(646, 585);
            this.iniSave.Name = "iniSave";
            this.iniSave.Size = new System.Drawing.Size(266, 49);
            this.iniSave.TabIndex = 8;
            this.iniSave.Text = "Сохранить в ini";
            this.iniSave.UseVisualStyleBackColor = true;
            this.iniSave.Click += new System.EventHandler(this.iniSave_Click);
            // 
            // iniLoad
            // 
            this.iniLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iniLoad.Location = new System.Drawing.Point(918, 585);
            this.iniLoad.Name = "iniLoad";
            this.iniLoad.Size = new System.Drawing.Size(258, 49);
            this.iniLoad.TabIndex = 9;
            this.iniLoad.Text = "Загрузить в ini";
            this.iniLoad.UseVisualStyleBackColor = true;
            this.iniLoad.Click += new System.EventHandler(this.iniLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(838, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длина слова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(786, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Полученная статистика";
            // 
            // statsClear
            // 
            this.statsClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsClear.Location = new System.Drawing.Point(646, 695);
            this.statsClear.Name = "statsClear";
            this.statsClear.Size = new System.Drawing.Size(266, 49);
            this.statsClear.TabIndex = 12;
            this.statsClear.Text = "Очистка статистики";
            this.statsClear.UseVisualStyleBackColor = true;
            this.statsClear.Click += new System.EventHandler(this.statsClear_Click);
            // 
            // openTextFromDB
            // 
            this.openTextFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openTextFromDB.Location = new System.Drawing.Point(334, 28);
            this.openTextFromDB.Name = "openTextFromDB";
            this.openTextFromDB.Size = new System.Drawing.Size(297, 49);
            this.openTextFromDB.TabIndex = 13;
            this.openTextFromDB.Text = "Открыть текст из БД";
            this.openTextFromDB.UseVisualStyleBackColor = true;
            this.openTextFromDB.Click += new System.EventHandler(this.openTextFromDB_Click);
            // 
            // saveIniToDB
            // 
            this.saveIniToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveIniToDB.Location = new System.Drawing.Point(12, 83);
            this.saveIniToDB.Name = "saveIniToDB";
            this.saveIniToDB.Size = new System.Drawing.Size(297, 49);
            this.saveIniToDB.TabIndex = 14;
            this.saveIniToDB.Text = "Сохранить ini в БД";
            this.saveIniToDB.UseVisualStyleBackColor = true;
            this.saveIniToDB.Click += new System.EventHandler(this.saveIniToDB_Click);
            // 
            // loadIniToDB
            // 
            this.loadIniToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadIniToDB.Location = new System.Drawing.Point(334, 83);
            this.loadIniToDB.Name = "loadIniToDB";
            this.loadIniToDB.Size = new System.Drawing.Size(297, 49);
            this.loadIniToDB.TabIndex = 15;
            this.loadIniToDB.Text = "Загрузить ini в БД";
            this.loadIniToDB.UseVisualStyleBackColor = true;
            this.loadIniToDB.Click += new System.EventHandler(this.loadIniToDB_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(12, 28);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(297, 22);
            this.domainUpDown1.TabIndex = 16;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 756);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.loadIniToDB);
            this.Controls.Add(this.saveIniToDB);
            this.Controls.Add(this.openTextFromDB);
            this.Controls.Add(this.statsClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniLoad);
            this.Controls.Add(this.iniSave);
            this.Controls.Add(this.saveXML);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.statsCount);
            this.Controls.Add(this.textSave);
            this.Controls.Add(this.textLoad);
            this.Controls.Add(this.textBox1);
            this.Name = "Child";
            this.Text = "Child";
            ((System.ComponentModel.ISupportInitialize)(this.wordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button textLoad;
        private System.Windows.Forms.Button textSave;
        private System.Windows.Forms.Button statsCount;
        private System.Windows.Forms.TrackBar wordCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveXML;
        private System.Windows.Forms.Button iniSave;
        private System.Windows.Forms.Button iniLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button statsClear;
        private System.Windows.Forms.Button openTextFromDB;
        private System.Windows.Forms.Button saveIniToDB;
        private System.Windows.Forms.Button loadIniToDB;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}

