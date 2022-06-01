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
    public partial class Pay : Form
    {
        DB db = new DB();
        char category;
        List<Button> selectedSeats = new List<Button>();

        public Pay(String categorylbl,char category,List<Button> selectedSeats)
        {
            InitializeComponent();
            categoryLabel.Text = categorylbl;
            this.category = category;
            this.selectedSeats = selectedSeats;

        }
        private void Pay_Load(object sender, EventArgs e)
        {
            //maç bilgilerini göstermek için
            homeTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][1].ToString());
            teamsName.Text = DB.matchInfo.Rows[0][1].ToString() + " - " + DB.matchInfo.Rows[0][2].ToString();
            awayTeam.Image = DB.getImageFromResources(DB.matchInfo.Rows[0][2].ToString());
            matchDate.Text = DB.matchInfo.Rows[0][3].ToString() + "\n" + DB.matchInfo.Rows[0][4].ToString() + " " +
                                       DB.matchInfo.Rows[0][5].ToString();

            db.getCard(cardsComboBox);
        }

        private void cardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cardsComboBox.SelectedIndex;
            string no = DB.cards.Rows[index][2].ToString();
            string isim = DB.cards.Rows[index][5].ToString();
            string kartcvv = DB.cards.Rows[index][3].ToString();
            string tarih = DB.cards.Rows[index][4].ToString();
            string kayitadi = DB.cards.Rows[index][6].ToString();

            kartisim.Text = isim;
            cvv.Text = kartcvv;
            kartP1.Text = no.Substring(0, 4);
            kartP2.Text = no.Substring(3, 4);
            kartP3.Text = no.Substring(7, 4);
            kartP4.Text = no.Substring(11, 4);

            ay.Text = tarih.Substring(0, 2);
            yil.Text = tarih.Substring(3, 4);

            kartkayitadi.Text = kayitadi;
            
        }

        private void odemeyiYapBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (kartkayitadi.Text != "")
                {
                    string kartno = kartP1.Text + kartP2.Text + kartP3.Text + kartP4.Text;
                    string date = ay.Text + "/" + yil.Text;

                    string query = "insert into creditCardTBL(userID, creditCardNo, creditCardCVV, creditCardDate, creditCardName, creditCardSaveName)" +
                        "values('" + DB.userID + "', '" + kartno + "', '" + cvv.Text + "', '" + date + "', '" + kartisim.Text + "', '" + kartkayitadi.Text + "')";
                    db.getQuery(query);
                   
                }
                else
                {
                    MessageBox.Show("Kart kayıt adı boş olamaz. Lütfen tekrar deneyiniz");
                }

            }

            if (kartP1.TextLength ==4 && kartP2.TextLength == 4 && kartP3.TextLength == 4 && kartP4.TextLength == 4 && cvv.TextLength == 3 &&
                ay.TextLength == 2 && yil.TextLength == 4 && kartisim.Text != "")
            {
                DateTime time = DateTime.Now;
                for (int i = 0; i < selectedSeats.Count(); i++)
                {
                    string sql = "insert into takenSeatsTBL(matchID, category, seat, userID, date)" +
                    " values('" + DB.matchInfo.Rows[0][0] + "','" + category + "', '" + selectedSeats[i].Name + "', '" + DB.userID + "', '" + time.ToString() + "')";
                    Console.WriteLine(sql);
                    db.getQuery(sql);

                    
                }
                if (checkBox1.Checked)
                {
                    MessageBox.Show("Biletler başarılı şekilde alındı ve kart kaydedildi.");
                    cardsComboBox.Items.Clear();
                    db.getCard(cardsComboBox);
                }
                else
                {
                    MessageBox.Show("Biletler başarılı şekilde alındı.");
                }
            }
            else
            {
                if (kartP1.TextLength < 4 || kartP2.TextLength < 4 || kartP3.TextLength < 4 || kartP4.TextLength < 4)
                {
                    MessageBox.Show("Kart numarası bilgileri eksik girildi. Lütfen tekrar deneyiniz");
                }
                else if (cvv.TextLength<3)
                {
                    MessageBox.Show("CVV kodu eksik girildi. Lütfen tekrar deneyiniz");
                }
                else if(ay.TextLength < 2)
                {
                    MessageBox.Show("Ay eksik girildi. Lütfen tekrar deneyiniz");
                }
                else if (yil.TextLength <4) 
                {
                    MessageBox.Show("Yıl eksik girildi. Lütfen tekrar deneyiniz");
                }

            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChooseSeat seat = new ChooseSeat(categoryLabel.Text);
            Login.mainform.openChildFrom(seat);
        }

        private void kartP1_TextChanged(object sender, EventArgs e)
        {
            sonraki(kartP1, kartP2, 4);
        }

        private void kartP2_TextChanged(object sender, EventArgs e)
        {
            sonraki(kartP2, kartP3, 4);
        }

        private void kartP3_TextChanged(object sender, EventArgs e)
        {
            sonraki(kartP3, kartP4, 4);
        }

        private void kartP4_TextChanged(object sender, EventArgs e)
        {
            sonraki(kartP4, cvv, 4);
        }

        private void cvv_TextChanged(object sender, EventArgs e)
        {
            sonraki(cvv, ay, 3);
        }

        private void ay_TextChanged(object sender, EventArgs e)
        {
            sonraki(ay, yil, 2);
        }

        private void yil_TextChanged(object sender, EventArgs e)
        {
            sonraki(yil, kartkayitadi, 4);
        }

        private void sonraki(TextBox t1, TextBox t2, int i)
        {
            if (t1.TextLength == i)
            {
                t2.Focus();
            }
        }
    }
}
