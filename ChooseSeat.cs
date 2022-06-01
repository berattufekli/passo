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
    public partial class ChooseSeat : Form
    {
        char category;
        int categoryPrice;
        int totalPrice = 0;
        private List<Button> selectedSeats = new List<Button>();
        private List<Button> allSeats = new List<Button>();
        DB db = new DB();
        
        public ChooseSeat(string selectedCategory)
        {
            InitializeComponent();

            //seçilen kategoriye göre koltuk ücretlerinin belirlenmesi
            this.category = selectedCategory[0];
            categoryLabel.Text = selectedCategory.Substring(0,11);
            if(category == '1')
            {
                categoryPrice = 300;
            }
            else if(category == '2')
            {
                categoryPrice = 200;
            }
            else if (category == '3')
            {
                categoryPrice = 100;
            }
            else if (category == '4')
            {
                categoryPrice = 75;
            }
            else if (categoryPrice == '5')
            {
                categoryPrice = 50;
            }
            else if (categoryPrice == '6')
            {
                categoryPrice = 30;
            }

        }

        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            //maç bilgilerini göstermek için
            homeTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][1].ToString());
            teamsName.Text = DB.matchInfo.Rows[0][1].ToString() + " - " + DB.matchInfo.Rows[0][2].ToString();
            awayTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][2].ToString());
            matchDate.Text = DB.matchInfo.Rows[0][3].ToString() + "\n" + DB.matchInfo.Rows[0][4].ToString() + " " +
                                       DB.matchInfo.Rows[0][5].ToString();

            //FlowLayoutPanel içerisindeki butonları kontrol edebilmek için dinamik olarak butonların liste halinde saklanması
            allSeats = this.Controls.OfType<Button>().Concat(this.seatsPanel.Controls.OfType<Button>()).ToList();
            db.getTakenSeats(DB.matchInfo.Rows[0][0].ToString(), category.ToString(), allSeats);

            foreach (Button btn in allSeats)
            {
                //liste haline getirilen butonlara click eventi verilmesi
                btn.Click += new EventHandler(button_click);
            }
        }

        //Dinamik olarak button seçme ya da seçmeme olayı
        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            selectOrRemoveSeats(button);
        }

        //koltuk seçme ya da seçim kaldırma
        private void selectOrRemoveSeats(Button btn)
        {

            if(btn.BackColor == Color.Black)
            {
                btn.BackgroundImage = Properties.Resources.selectedBTN;
                btn.BackColor = Color.Transparent;
                selectedSeats.Add(btn);
                totalPrice += categoryPrice;
            }
            else
            {
                btn.BackgroundImage= Properties.Resources.emptyBTN;
                btn.BackColor = Color.Black;
                selectedSeats.Remove(btn);
                totalPrice -= categoryPrice;
            }
            payButton.Text = totalPrice.ToString() + " ₺\nÖdeme\nYap"; 
            payButton.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket();
            Login.mainform.openChildFrom(buyTicket);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay(categoryLabel.Text ,category ,selectedSeats);
            Login.mainform.openChildFrom(pay);
        }
    }
}
