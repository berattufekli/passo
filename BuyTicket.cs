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
    public partial class BuyTicket : Form
    {
        public static PictureBox homeP;
        public static PictureBox awayP;
        public static Label mathInfoL;
        public static Label mathDateL;
        
        public BuyTicket()
        {
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login.mainform.openChildFrom(new MatchesChild());
        }

        //koltuk seç butonuna basıldığında koltuk seçme formunun açılması
        private void takeSeatBtn_Click(object sender, EventArgs e)
        {
            if(categoryCBox.Text == "") {
                Console.WriteLine("Seçim yapmadınız");
            }
            else
            {
                Login.mainform.openChildFrom(new ChooseSeat(categoryCBox.Text)); 
            }

        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            homeTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][1].ToString());
            teamsName.Text = DB.matchInfo.Rows[0][1].ToString() + " - " + DB.matchInfo.Rows[0][2].ToString();
            awayTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][2].ToString());
            matchDate.Text = DB.matchInfo.Rows[0][3].ToString() + "\n" + DB.matchInfo.Rows[0][4].ToString() + " " +
                                       DB.matchInfo.Rows[0][5].ToString();
        }
    }
}
