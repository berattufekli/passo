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
    public partial class Account : Form
    {
        DB db = new DB();
        public Account()
        {
            InitializeComponent();
            db.getCard(cardsComboBox);
        }

        private void kartEkleBtn_Click(object sender, EventArgs e)
        {
            if (kartP1.Text != null && kartP2.Text != null && kartP3.Text != null && kartisim.Text !=
                null && kartkayitadi.Text != null && cvv.Text != null && ay.Text != null && yil.Text != null)
            {
                string cardno = kartP1.Text + kartP2.Text + kartP3.Text + kartP4.Text;
                string date = ay.Text + "/" + yil.Text;
                string sql = "insert into creditCardTBL(userID, creditCardNo, creditCardCVV, creditCardDate, creditCardName, creditCardSaveName)" +
                    " values('" + DB.userID + "', '" + cardno + "', '" + cvv.Text + "' ,'" + date + "', '" + kartisim.Text + "', '" + kartkayitadi.Text + "')";
                db.getQuery(sql);
                infoLabelTP3.Text = "Kart başarıyla eklendi";
                cardsComboBox.Items.Clear();
                db.getCard(cardsComboBox);
            }
            else
            {
                infoLabelTP3.Text = "Lütfen kart bilgilerini kontrol ediniz.";
            }
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

        private void kartGuncelleBtn_Click(object sender, EventArgs e)
        {
            int index = cardsComboBox.SelectedIndex;
            if (kartP1.Text != null && kartP2.Text != null && kartP3.Text != null && kartisim.Text !=
                null && kartkayitadi.Text != null && cvv.Text != null && ay.Text != null && yil.Text != null)
            {
                string cardno = kartP1.Text + kartP2.Text + kartP3.Text + kartP4.Text;
                string date = ay.Text + "/" + yil.Text;
                string sql = "update creditCardTBL set creditCardNo ='" + cardno + "', creditCardCVV='" + cvv.Text + "' ,creditCardDate='" + date + "', " +
                    "creditCardName= '" + kartisim.Text + "', creditCardSaveName='" + kartkayitadi.Text + "' where creditCardID='" + DB.cards.Rows[index][0] + "'";
                db.getQuery(sql);
                infoLabelTP3.Text = "Kart başarıyla güncellendi";
                cardsComboBox.Items.Clear();
                db.getCard(cardsComboBox);
                kartisim.Clear();
                kartP1.Clear();
                kartP2.Clear();
                kartP3.Clear();
                kartP4.Clear();
                ay.Clear();
                yil.Clear();
                kartkayitadi.Clear();
                cvv.Clear();
                cardsComboBox.Text = "";
            }
            else
            {
                infoLabelTP3.Text = "Lütfen kart bilgilerini kontrol ediniz.";
            }
        }

        private void kartSilBtn_Click(object sender, EventArgs e)
        {
            int index = cardsComboBox.SelectedIndex;
            string sql = "delete from creditCardTBL where creditCardID='" + DB.cards.Rows[index][0].ToString() + "'";
            db.getQuery(sql);
            infoLabelTP3.Text = "Kart başarıyla silindi";
            cardsComboBox.Items.Clear();
            db.getCard(cardsComboBox);
        }

        private void guncelleTP1_Click(object sender, EventArgs e)
        {
            if(usernameTP1.Text != null)
            {
                try
                {
                    string sql = "update usersTBL set username='" + usernameTP1.Text + "' where userID='" + DB.userID + "'";
                    db.getQuery(sql);
                    infoLabelTP1.Text = "Kullanıcı adı başarıyla güncellendi";
                    usernameTP1.Clear();
                }
                catch
                {
                    infoLabelTP1.Text = "Kullanıcı adı daha önceden alınmış. Lütfen terkar deneyiniz";
                }
            }
            else
            {
                infoLabelTP2.Text = "Boşlukları doldurup tekrar deneyiniz lütfen.";
            }
        }

        private void guncelleTP2_Click(object sender, EventArgs e)
        {
            if (yeniSifre2TP2.TextLength >= 6 && yeniSifreTP2.TextLength >= 6)
            {
                if(yeniSifre2TP2.Text == yeniSifreTP2.Text)
                {
                    try
                    {
                        string sql = "update usersTBL set password='" + DB.MD5Password(yeniSifreTP2.Text) + "' where userID='" + DB.userID + "'";
                        db.getQuery(sql);
                        infoLabelTP2.Text = "Şifre başarıyla güncellendi.";
                        yeniSifreTP2.Clear();
                        yeniSifre2TP2.Clear();
                    }
                    catch
                    {
                        infoLabelTP2.Text = "Bir hata oluştu tekrar deneyiniz.";

                    }
                }
                else
                {
                    infoLabelTP2.Text = "Şifreler birbiriyle uyuşmuyor. Lütfen tekrar deneyiniz";
                }
            }
            else
            {
                infoLabelTP2.Text = "Şifreniz 6 karakterden az olamaz. Lütfen tekrar deneyiniz.";
            }
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
