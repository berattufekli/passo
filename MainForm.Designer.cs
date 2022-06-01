namespace Passolig
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.CurrentTab = new System.Windows.Forms.Panel();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonMatches = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(225, 62);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1175, 738);
            this.childFormPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 62);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::Passolig.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(1343, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Passolig.Properties.Resources.ball_icon;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passolig";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Controls.Add(this.CurrentTab);
            this.panel3.Controls.Add(this.buttonTicket);
            this.panel3.Controls.Add(this.buttonAccount);
            this.panel3.Controls.Add(this.buttonMatches);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 738);
            this.panel3.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Image = global::Passolig.Properties.Resources.log_out;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 658);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(225, 80);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Çıkış";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // CurrentTab
            // 
            this.CurrentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.CurrentTab.Location = new System.Drawing.Point(217, 229);
            this.CurrentTab.Name = "CurrentTab";
            this.CurrentTab.Size = new System.Drawing.Size(8, 80);
            this.CurrentTab.TabIndex = 4;
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTicket.FlatAppearance.BorderSize = 0;
            this.buttonTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonTicket.ForeColor = System.Drawing.Color.White;
            this.buttonTicket.Image = global::Passolig.Properties.Resources.ticket32;
            this.buttonTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.Location = new System.Drawing.Point(0, 329);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonTicket.Size = new System.Drawing.Size(225, 80);
            this.buttonTicket.TabIndex = 2;
            this.buttonTicket.Text = "Biletlerim";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Image = global::Passolig.Properties.Resources.user32;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(0, 429);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAccount.Size = new System.Drawing.Size(225, 80);
            this.buttonAccount.TabIndex = 3;
            this.buttonAccount.Text = "Hesap";
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonMatches
            // 
            this.buttonMatches.BackColor = System.Drawing.Color.Transparent;
            this.buttonMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMatches.FlatAppearance.BorderSize = 0;
            this.buttonMatches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMatches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatches.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonMatches.ForeColor = System.Drawing.Color.White;
            this.buttonMatches.Image = global::Passolig.Properties.Resources.football32;
            this.buttonMatches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatches.Location = new System.Drawing.Point(0, 229);
            this.buttonMatches.Name = "buttonMatches";
            this.buttonMatches.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonMatches.Size = new System.Drawing.Size(225, 80);
            this.buttonMatches.TabIndex = 0;
            this.buttonMatches.Text = "Maçlar";
            this.buttonMatches.UseVisualStyleBackColor = true;
            this.buttonMatches.Click += new System.EventHandler(this.buttonMatches_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.childFormPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 800);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel CurrentTab;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonMatches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}