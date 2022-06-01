namespace Passolig
{
    partial class BuyTicket
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
            this.fullPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.takeSeatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryCBox = new System.Windows.Forms.ComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matchDate = new System.Windows.Forms.Label();
            this.teamsName = new System.Windows.Forms.Label();
            this.awayTeam = new System.Windows.Forms.PictureBox();
            this.homeTeam = new System.Windows.Forms.PictureBox();
            this.fullPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // fullPanel
            // 
            this.fullPanel.Controls.Add(this.panel3);
            this.fullPanel.Controls.Add(this.panel2);
            this.fullPanel.Controls.Add(this.topPanel);
            this.fullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullPanel.Location = new System.Drawing.Point(0, 0);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(1175, 738);
            this.fullPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 498);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(172, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ücretleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 126);
            this.label4.TabIndex = 0;
            this.label4.Text = "1. Kategori - 300₺\r\n2. Kategori - 200₺\r\n3. Kategori - 100₺\r\n4. Kategori - 75₺\r\n5." +
    " Kategori - 50₺\r\n6. Kategori - 30₺";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.takeSeatBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.categoryCBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(588, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 498);
            this.panel2.TabIndex = 1;
            // 
            // takeSeatBtn
            // 
            this.takeSeatBtn.BackColor = System.Drawing.Color.Transparent;
            this.takeSeatBtn.BackgroundImage = global::Passolig.Properties.Resources.btn;
            this.takeSeatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeSeatBtn.FlatAppearance.BorderSize = 0;
            this.takeSeatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.takeSeatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.takeSeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeSeatBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.takeSeatBtn.ForeColor = System.Drawing.Color.Transparent;
            this.takeSeatBtn.Location = new System.Drawing.Point(193, 279);
            this.takeSeatBtn.Name = "takeSeatBtn";
            this.takeSeatBtn.Size = new System.Drawing.Size(200, 40);
            this.takeSeatBtn.TabIndex = 5;
            this.takeSeatBtn.Text = "Koltuk Seç";
            this.takeSeatBtn.UseVisualStyleBackColor = false;
            this.takeSeatBtn.Click += new System.EventHandler(this.takeSeatBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(204, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lütfen kategori seçiniz";
            // 
            // categoryCBox
            // 
            this.categoryCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.categoryCBox.FormattingEnabled = true;
            this.categoryCBox.Items.AddRange(new object[] {
            "1. Kategori - 300₺",
            "2. Kategori - 200₺",
            "3. Kategori - 100₺",
            "4. Kategori - 75₺",
            "5. Kategori - 50₺",
            "6. Kategori - 30₺"});
            this.categoryCBox.Location = new System.Drawing.Point(206, 225);
            this.categoryCBox.Name = "categoryCBox";
            this.categoryCBox.Size = new System.Drawing.Size(175, 27);
            this.categoryCBox.TabIndex = 3;
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
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1175, 738);
            this.Controls.Add(this.fullPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.fullPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.awayTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fullPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button takeSeatBtn;
        public System.Windows.Forms.PictureBox awayTeam;
        public System.Windows.Forms.PictureBox homeTeam;
        public System.Windows.Forms.Label teamsName;
        public System.Windows.Forms.Label matchDate;
        private System.Windows.Forms.PictureBox backButton;
        public System.Windows.Forms.ComboBox categoryCBox;
    }
}