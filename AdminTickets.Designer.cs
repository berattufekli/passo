namespace Passolig
{
    partial class AdminTickets
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gelir = new System.Windows.Forms.Label();
            this.seyirci = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bitis_date = new System.Windows.Forms.DateTimePicker();
            this.awayCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifirla = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.baslangic_date = new System.Windows.Forms.DateTimePicker();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 738);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(87, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.gelir);
            this.tabPage1.Controls.Add(this.seyirci);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bitis_date);
            this.tabPage1.Controls.Add(this.awayCB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.homeCB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.sifirla);
            this.tabPage1.Controls.Add(this.status);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.saat);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.baslangic_date);
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Biletleri Görüntüle";
            // 
            // gelir
            // 
            this.gelir.BackColor = System.Drawing.Color.Transparent;
            this.gelir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelir.ForeColor = System.Drawing.Color.White;
            this.gelir.Location = new System.Drawing.Point(344, 569);
            this.gelir.Margin = new System.Windows.Forms.Padding(0);
            this.gelir.Name = "gelir";
            this.gelir.Size = new System.Drawing.Size(300, 30);
            this.gelir.TabIndex = 55;
            this.gelir.Text = "Toplam Gelir: 50000";
            this.gelir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seyirci
            // 
            this.seyirci.BackColor = System.Drawing.Color.Transparent;
            this.seyirci.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seyirci.ForeColor = System.Drawing.Color.White;
            this.seyirci.Location = new System.Drawing.Point(44, 569);
            this.seyirci.Margin = new System.Windows.Forms.Padding(0);
            this.seyirci.Name = "seyirci";
            this.seyirci.Size = new System.Drawing.Size(300, 30);
            this.seyirci.TabIndex = 54;
            this.seyirci.Text = "Alınan Bilet Sayısı: 999";
            this.seyirci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Bitiş Tarihi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitis_date
            // 
            this.bitis_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitis_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitis_date.Location = new System.Drawing.Point(323, 138);
            this.bitis_date.Name = "bitis_date";
            this.bitis_date.Size = new System.Drawing.Size(175, 28);
            this.bitis_date.TabIndex = 52;
            this.bitis_date.ValueChanged += new System.EventHandler(this.bitis_date_ValueChanged);
            // 
            // awayCB
            // 
            this.awayCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.awayCB.FormattingEnabled = true;
            this.awayCB.Items.AddRange(new object[] {
            ""});
            this.awayCB.Location = new System.Drawing.Point(323, 66);
            this.awayCB.Name = "awayCB";
            this.awayCB.Size = new System.Drawing.Size(175, 30);
            this.awayCB.TabIndex = 51;
            this.awayCB.SelectedIndexChanged += new System.EventHandler(this.awayCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Deplasman";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeCB
            // 
            this.homeCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeCB.FormattingEnabled = true;
            this.homeCB.Location = new System.Drawing.Point(44, 68);
            this.homeCB.Name = "homeCB";
            this.homeCB.Size = new System.Drawing.Size(175, 30);
            this.homeCB.TabIndex = 49;
            this.homeCB.SelectedIndexChanged += new System.EventHandler(this.homeCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ev Sahibi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifirla
            // 
            this.sifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirla.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla.ForeColor = System.Drawing.Color.White;
            this.sifirla.Location = new System.Drawing.Point(827, 126);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(121, 40);
            this.sifirla.TabIndex = 47;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.UseVisualStyleBackColor = false;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Aktif",
            "Geçmiş"});
            this.status.Location = new System.Drawing.Point(827, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(120, 30);
            this.status.TabIndex = 45;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(827, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Durum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saat
            // 
            this.saat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.FormattingEnabled = true;
            this.saat.Items.AddRange(new object[] {
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.saat.Location = new System.Drawing.Point(602, 65);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(121, 30);
            this.saat.TabIndex = 43;
            this.saat.SelectedIndexChanged += new System.EventHandler(this.saat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(602, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Saat";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 41;
            this.label7.Text = "Başlangıç Tarihi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baslangic_date
            // 
            this.baslangic_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangic_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangic_date.Location = new System.Drawing.Point(48, 138);
            this.baslangic_date.Name = "baslangic_date";
            this.baslangic_date.Size = new System.Drawing.Size(164, 28);
            this.baslangic_date.TabIndex = 40;
            this.baslangic_date.ValueChanged += new System.EventHandler(this.baslangic_date_ValueChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(48, 193);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(900, 350);
            this.dataGrid.TabIndex = 0;
            // 
            // AdminTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1175, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminTickets";
            this.Text = "AdminTickets";
            this.Load += new System.EventHandler(this.AdminTickets_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label gelir;
        public System.Windows.Forms.Label seyirci;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker bitis_date;
        private System.Windows.Forms.ComboBox awayCB;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox homeCB;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.ComboBox status;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox saat;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker baslangic_date;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}