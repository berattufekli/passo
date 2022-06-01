namespace Passolig
{
    partial class Pay
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matchDate = new System.Windows.Forms.Label();
            this.teamsName = new System.Windows.Forms.Label();
            this.awayTeam = new System.Windows.Forms.PictureBox();
            this.homeTeam = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sifirlaBtn = new System.Windows.Forms.Button();
            this.odemeyiYapBtn = new System.Windows.Forms.Button();
            this.kartkayitadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cardsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kartisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kartP4 = new System.Windows.Forms.TextBox();
            this.kartP3 = new System.Windows.Forms.TextBox();
            this.kartP2 = new System.Windows.Forms.TextBox();
            this.kartP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.fullPanel = new System.Windows.Forms.Panel();
            this.tableAdapterManager1 = new Passolig._192503028DataSetTableAdapters.TableAdapterManager();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeam)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.fullPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1175, 240);
            this.topPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::Passolig.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(20, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 32);
            this.backButton.TabIndex = 1;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Passolig.Properties.Resources.ticketBG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.matchDate);
            this.panel1.Controls.Add(this.teamsName);
            this.panel1.Controls.Add(this.awayTeam);
            this.panel1.Controls.Add(this.homeTeam);
            this.panel1.Location = new System.Drawing.Point(237, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 200);
            this.panel1.TabIndex = 0;
            // 
            // matchDate
            // 
            this.matchDate.BackColor = System.Drawing.Color.Transparent;
            this.matchDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matchDate.Location = new System.Drawing.Point(128, 109);
            this.matchDate.Margin = new System.Windows.Forms.Padding(0);
            this.matchDate.Name = "matchDate";
            this.matchDate.Size = new System.Drawing.Size(444, 55);
            this.matchDate.TabIndex = 3;
            this.matchDate.Text = "Vodafone Park\r\n02.04.2022 19:00\r\n";
            this.matchDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamsName
            // 
            this.teamsName.BackColor = System.Drawing.Color.Transparent;
            this.teamsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teamsName.Location = new System.Drawing.Point(128, 36);
            this.teamsName.Margin = new System.Windows.Forms.Padding(0);
            this.teamsName.Name = "teamsName";
            this.teamsName.Size = new System.Drawing.Size(441, 73);
            this.teamsName.TabIndex = 2;
            this.teamsName.Text = "Beşiktaş - Trabzonspor";
            this.teamsName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // awayTeam
            // 
            this.awayTeam.BackColor = System.Drawing.Color.White;
            this.awayTeam.Location = new System.Drawing.Point(572, 36);
            this.awayTeam.Margin = new System.Windows.Forms.Padding(0);
            this.awayTeam.Name = "awayTeam";
            this.awayTeam.Size = new System.Drawing.Size(128, 128);
            this.awayTeam.TabIndex = 1;
            this.awayTeam.TabStop = false;
            // 
            // homeTeam
            // 
            this.homeTeam.BackColor = System.Drawing.Color.White;
            this.homeTeam.Location = new System.Drawing.Point(0, 36);
            this.homeTeam.Margin = new System.Windows.Forms.Padding(0);
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.Size = new System.Drawing.Size(128, 128);
            this.homeTeam.TabIndex = 0;
            this.homeTeam.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 498);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sifirlaBtn);
            this.panel3.Controls.Add(this.odemeyiYapBtn);
            this.panel3.Controls.Add(this.kartkayitadi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.cardsComboBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.kartisim);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.yil);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ay);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cvv);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.kartP4);
            this.panel3.Controls.Add(this.kartP3);
            this.panel3.Controls.Add(this.kartP2);
            this.panel3.Controls.Add(this.kartP1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.categoryLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 498);
            this.panel3.TabIndex = 6;
            // 
            // sifirlaBtn
            // 
            this.sifirlaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.sifirlaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirlaBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.sifirlaBtn.ForeColor = System.Drawing.Color.White;
            this.sifirlaBtn.Location = new System.Drawing.Point(351, 360);
            this.sifirlaBtn.Name = "sifirlaBtn";
            this.sifirlaBtn.Size = new System.Drawing.Size(175, 63);
            this.sifirlaBtn.TabIndex = 160;
            this.sifirlaBtn.Text = "Sıfırla";
            this.sifirlaBtn.UseVisualStyleBackColor = false;
            // 
            // odemeyiYapBtn
            // 
            this.odemeyiYapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(171)))));
            this.odemeyiYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeyiYapBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.odemeyiYapBtn.ForeColor = System.Drawing.Color.White;
            this.odemeyiYapBtn.Location = new System.Drawing.Point(653, 360);
            this.odemeyiYapBtn.Name = "odemeyiYapBtn";
            this.odemeyiYapBtn.Size = new System.Drawing.Size(175, 63);
            this.odemeyiYapBtn.TabIndex = 155;
            this.odemeyiYapBtn.Text = "Ödemeyi Yap";
            this.odemeyiYapBtn.UseVisualStyleBackColor = false;
            this.odemeyiYapBtn.Click += new System.EventHandler(this.odemeyiYapBtn_Click);
            // 
            // kartkayitadi
            // 
            this.kartkayitadi.BackColor = System.Drawing.Color.Black;
            this.kartkayitadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartkayitadi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartkayitadi.ForeColor = System.Drawing.Color.White;
            this.kartkayitadi.Location = new System.Drawing.Point(549, 303);
            this.kartkayitadi.Name = "kartkayitadi";
            this.kartkayitadi.Size = new System.Drawing.Size(278, 29);
            this.kartkayitadi.TabIndex = 150;
            this.kartkayitadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(347, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kart Kayıt Adı:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(351, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(472, 26);
            this.checkBox1.TabIndex = 145;
            this.checkBox1.Text = "Kartı sonraki işlemler için kaydetmek istiyor musunuz?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cardsComboBox
            // 
            this.cardsComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.cardsComboBox.FormattingEnabled = true;
            this.cardsComboBox.Location = new System.Drawing.Point(549, 76);
            this.cardsComboBox.Name = "cardsComboBox";
            this.cardsComboBox.Size = new System.Drawing.Size(277, 30);
            this.cardsComboBox.TabIndex = 100;
            this.cardsComboBox.SelectedIndexChanged += new System.EventHandler(this.cardsComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(347, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Kayıtlı Kartlarım:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kartisim
            // 
            this.kartisim.BackColor = System.Drawing.Color.Black;
            this.kartisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartisim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartisim.ForeColor = System.Drawing.Color.White;
            this.kartisim.Location = new System.Drawing.Point(549, 123);
            this.kartisim.Name = "kartisim";
            this.kartisim.Size = new System.Drawing.Size(278, 29);
            this.kartisim.TabIndex = 105;
            this.kartisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kart Sahibinin Adı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yil
            // 
            this.yil.BackColor = System.Drawing.Color.Black;
            this.yil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yil.ForeColor = System.Drawing.Color.White;
            this.yil.Location = new System.Drawing.Point(759, 215);
            this.yil.Name = "yil";
            this.yil.Size = new System.Drawing.Size(68, 29);
            this.yil.TabIndex = 140;
            this.yil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yil.TextChanged += new System.EventHandler(this.yil_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(725, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ay
            // 
            this.ay.BackColor = System.Drawing.Color.Black;
            this.ay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ay.ForeColor = System.Drawing.Color.White;
            this.ay.Location = new System.Drawing.Point(692, 215);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(30, 29);
            this.ay.TabIndex = 135;
            this.ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ay.TextChanged += new System.EventHandler(this.ay_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(628, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tarih:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cvv
            // 
            this.cvv.BackColor = System.Drawing.Color.Black;
            this.cvv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvv.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cvv.ForeColor = System.Drawing.Color.White;
            this.cvv.Location = new System.Drawing.Point(550, 214);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(50, 29);
            this.cvv.TabIndex = 130;
            this.cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cvv.TextChanged += new System.EventHandler(this.cvv_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "CVV:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kartP4
            // 
            this.kartP4.BackColor = System.Drawing.Color.Black;
            this.kartP4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartP4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartP4.ForeColor = System.Drawing.Color.White;
            this.kartP4.Location = new System.Drawing.Point(763, 168);
            this.kartP4.Name = "kartP4";
            this.kartP4.Size = new System.Drawing.Size(65, 29);
            this.kartP4.TabIndex = 125;
            this.kartP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kartP4.TextChanged += new System.EventHandler(this.kartP4_TextChanged);
            // 
            // kartP3
            // 
            this.kartP3.BackColor = System.Drawing.Color.Black;
            this.kartP3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartP3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartP3.ForeColor = System.Drawing.Color.White;
            this.kartP3.Location = new System.Drawing.Point(692, 168);
            this.kartP3.Name = "kartP3";
            this.kartP3.Size = new System.Drawing.Size(65, 29);
            this.kartP3.TabIndex = 120;
            this.kartP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kartP3.TextChanged += new System.EventHandler(this.kartP3_TextChanged);
            // 
            // kartP2
            // 
            this.kartP2.BackColor = System.Drawing.Color.Black;
            this.kartP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartP2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartP2.ForeColor = System.Drawing.Color.White;
            this.kartP2.Location = new System.Drawing.Point(621, 168);
            this.kartP2.Name = "kartP2";
            this.kartP2.Size = new System.Drawing.Size(65, 29);
            this.kartP2.TabIndex = 115;
            this.kartP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kartP2.TextChanged += new System.EventHandler(this.kartP2_TextChanged);
            // 
            // kartP1
            // 
            this.kartP1.BackColor = System.Drawing.Color.Black;
            this.kartP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartP1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartP1.ForeColor = System.Drawing.Color.White;
            this.kartP1.Location = new System.Drawing.Point(550, 168);
            this.kartP1.Name = "kartP1";
            this.kartP1.Size = new System.Drawing.Size(65, 29);
            this.kartP1.TabIndex = 110;
            this.kartP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kartP1.TextChanged += new System.EventHandler(this.kartP1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kart Numarası:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(0, 2);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(1175, 23);
            this.categoryLabel.TabIndex = 20;
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullPanel
            // 
            this.fullPanel.Controls.Add(this.panel2);
            this.fullPanel.Controls.Add(this.topPanel);
            this.fullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullPanel.Location = new System.Drawing.Point(0, 0);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(1175, 738);
            this.fullPanel.TabIndex = 2;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Passolig._192503028DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTBLTableAdapter = null;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1175, 738);
            this.Controls.Add(this.fullPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.awayTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.fullPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox awayTeam;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label matchDate;
        public System.Windows.Forms.Label teamsName;
        public System.Windows.Forms.PictureBox homeTeam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel fullPanel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kartP1;
        private System.Windows.Forms.TextBox kartP4;
        private System.Windows.Forms.TextBox kartP3;
        private System.Windows.Forms.TextBox kartP2;
        private System.Windows.Forms.TextBox cvv;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ay;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yil;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kartkayitadi;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cardsComboBox;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kartisim;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button odemeyiYapBtn;
        private System.Windows.Forms.Button sifirlaBtn;
        private _192503028DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}