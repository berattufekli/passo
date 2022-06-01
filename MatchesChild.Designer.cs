namespace Passolig
{
    partial class MatchesChild
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.matchesFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.fullPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.sortPicture = new System.Windows.Forms.PictureBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.usersTBLTableAdapter1 = new Passolig._192503028DataSetTableAdapters.usersTBLTableAdapter();
            this.bottomPanel.SuspendLayout();
            this.fullPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.sortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.matchesFlowLayout);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 80);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1175, 658);
            this.bottomPanel.TabIndex = 2;
            // 
            // matchesFlowLayout
            // 
            this.matchesFlowLayout.AutoScroll = true;
            this.matchesFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.matchesFlowLayout.Location = new System.Drawing.Point(55, 79);
            this.matchesFlowLayout.Name = "matchesFlowLayout";
            this.matchesFlowLayout.Size = new System.Drawing.Size(1064, 500);
            this.matchesFlowLayout.TabIndex = 0;
            this.matchesFlowLayout.WrapContents = false;
            // 
            // fullPanel
            // 
            this.fullPanel.Controls.Add(this.bottomPanel);
            this.fullPanel.Controls.Add(this.topPanel);
            this.fullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullPanel.Location = new System.Drawing.Point(0, 0);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(1175, 738);
            this.fullPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.sortPanel);
            this.topPanel.Controls.Add(this.searchBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1175, 80);
            this.topPanel.TabIndex = 0;
            // 
            // sortPanel
            // 
            this.sortPanel.Controls.Add(this.sortPicture);
            this.sortPanel.Controls.Add(this.sortLabel);
            this.sortPanel.Location = new System.Drawing.Point(950, 25);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(137, 31);
            this.sortPanel.TabIndex = 10;
            // 
            // sortPicture
            // 
            this.sortPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.sortPicture.Image = global::Passolig.Properties.Resources.down_arrow;
            this.sortPicture.Location = new System.Drawing.Point(111, 0);
            this.sortPicture.Name = "sortPicture";
            this.sortPicture.Size = new System.Drawing.Size(26, 31);
            this.sortPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sortPicture.TabIndex = 1;
            this.sortPicture.TabStop = false;
            // 
            // sortLabel
            // 
            this.sortLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.sortLabel.ForeColor = System.Drawing.Color.White;
            this.sortLabel.Location = new System.Drawing.Point(0, 0);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(105, 31);
            this.sortLabel.TabIndex = 0;
            this.sortLabel.Text = "Sırala: A-Z";
            this.sortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(382, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(410, 31);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // usersTBLTableAdapter1
            // 
            this.usersTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // MatchesChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1175, 738);
            this.Controls.Add(this.fullPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchesChild";
            this.Text = "MatchesChild";
            this.Load += new System.EventHandler(this.MatchesChild_Load);
            this.bottomPanel.ResumeLayout(false);
            this.fullPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sortPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sortPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.FlowLayoutPanel matchesFlowLayout;
        private System.Windows.Forms.Panel fullPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sortPanel;
        private System.Windows.Forms.PictureBox sortPicture;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.TextBox searchBox;
        private _192503028DataSetTableAdapters.usersTBLTableAdapter usersTBLTableAdapter1;
    }
}