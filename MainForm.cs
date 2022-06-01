using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passolig
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildFrom(new MatchesChild());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonMatches_Click(object sender, EventArgs e)
        {
            CurrentTab.Height = buttonMatches.Height;
            CurrentTab.Top = buttonMatches.Top;
            openChildFrom(new MatchesChild());
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            CurrentTab.Height = buttonTicket.Height;
            CurrentTab.Top = buttonTicket.Top;
            openChildFrom(new Tickets());
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            CurrentTab.Height = buttonAccount.Height;
            CurrentTab.Top = buttonAccount.Top;
            openChildFrom(new Account());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login.loginform.Show();
            Login.mainform.Hide();
        }

        public void openChildFrom(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
