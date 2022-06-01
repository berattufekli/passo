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
    public partial class AdminAccount : Form
    {
        DB db = new DB();

        DataTable userInfo = new DataTable();

        public AdminAccount()
        {
            InitializeComponent();
        }

        private void dataGridAdminler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            adminID.Text = CellsGetir(0);
            usernameTP1.Text = CellsGetir(1).Replace("admin@", "");
            sifreTP1.Text = CellsGetir(2);
        }

        private string CellsGetir(int cellIndex)
        {
            return dataGridAdminler.CurrentRow.Cells[cellIndex].Value.ToString();
        }

        private string UsersCellsGetir(int cellIndex)
        {
            return dataGridUsers.CurrentRow.Cells[cellIndex].Value.ToString();
        }

        private void getir(DataGridView data, string sql)
        { 
            db.griddoldur(data, sql);
            data.Columns[0].Width = 100;
            data.Columns[1].Width = 200;
            data.Columns[2].Width = 200;
            try
            {
                data.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            string sql = "select * from adminTBL";
            getir(dataGridAdminler, sql);

            sql = "select * from usersTBL";
            getir(dataGridUsers, sql);
        }

        private void guncelleBtnTP1_Click(object sender, EventArgs e)
        {
            if(usernameTP1.Text != null && sifreTP1.Text != null)
            { 
                if(sifreTP1.TextLength >= 6)
                {
                    try
                    {
                        string sql = "update adminTBL set username='admin@" + usernameTP1.Text + "', password='" + DB.MD5Password(sifreTP1.Text) + "' where adminID='" + adminID.Text + "'";
                        db.getQuery(sql);
                        MessageBox.Show("Admin bilgileri başarılı şekilde güncellenmiştir. Lütfen şifrenizi unutmayınız");
                        getir(dataGridAdminler, "select * from adminTBL");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kullanıcı adı daha önceden alınmış. Lütfen tekrar deneyiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni şifreniz 6 karakterden az olamaz.");
                    sifreTP1.Clear();
                    sifreTP1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre boş olamaz.");
                usernameTP1.Focus();
            }
            
        }

        private void silBtnTP4_Click(object sender, EventArgs e)
        {
            if(adminID.Text != null)
            {
                try
                {
                    string sql = "delete from adminTBL where adminID='" + adminID.Text + "'";
                    db.getQuery(sql);
                    MessageBox.Show("Admin silme işlemi başarılı");
                    getir(dataGridAdminler, "select * from adminTBL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
               
            }
            
        }

        private void sifirlaBtnTP2_Click(object sender, EventArgs e)
        {
            usernameTP2.Clear();
            sifreTP2.Clear();
            sifre2TP2.Clear();
            infoLabel2.Text = "";
        }

        private void ekleBtnTP2_Click(object sender, EventArgs e)
        {
            if(usernameTP2.Text != "" && sifreTP2.Text != "" && sifre2TP2.Text != "")
            {
               
                if(sifre2TP2.Text == sifreTP2.Text)
                {
                    if (sifreTP2.TextLength >= 6)
                    {
                        try
                        {
                            string sql = "insert into adminTBL(username,password) values('admin@" + usernameTP2.Text + "', '" + DB.MD5Password(sifreTP2.Text) + "')";
                            db.getQuery(sql);
                            infoLabel2.Text = "Yeni kullanıcı başarıyla eklendi.";
                            usernameTP2.Clear();
                            sifreTP2.Clear();
                            sifre2TP2.Clear();
                            getir(dataGridAdminler, "select * from adminTBL");
                        }
                        catch
                        {
                            infoLabel2.Text = "Kullanıcı adı daha önceden alınmış. Lütfen tekrar deneyiniz";
                            usernameTP2.Clear();
                            usernameTP2.Focus();
                        }
                    }
                    else
                    {
                        infoLabel2.Text = "Şifre 6 karakterden az olamaz. Lütfen tekrar deneyiniz.";
                        sifreTP2.Clear();
                        sifre2TP2.Clear();
                        sifreTP2.Focus();
                    }
                }
                else
                {
                    infoLabel2.Text = "Şifreler birbiriyle eşleşmiyor. Lütfen tekrar deneyiniz.";
                    sifreTP2.Clear();
                    sifre2TP2.Clear();
                    sifreTP2.Focus();
                }
                
            }
            else
            {
                infoLabel2.Text = "Kullanıcı adı ya da şifre boş olamaz. Tekrar deneyiniz";
                if(usernameTP2.Text == "")
                {
                    usernameTP2.Focus();
                }
                else if(sifreTP2.Text == "")
                {
                    sifreTP2.Focus();
                }
                else if (sifre2TP2.Text == "")
                {
                    sifreTP2.Focus();
                }
            }
            
        }

        private void sifirlaTP3_Click(object sender, EventArgs e)
        {
            yeniSifre2TP3.Clear();
            yeniSifreTP3.Clear();
            infoLabel3.Text = "";
        }

        private void guncelleBtnTP3_Click(object sender, EventArgs e)
        {
            if(yeniSifreTP3.Text != "" && yeniSifre2TP3.Text != "")
            {
                if(yeniSifreTP3.Text == yeniSifre2TP3.Text)
                {
                    if(yeniSifreTP3.TextLength >= 6)
                    {

                        string sql = "update adminTBL set password='" + DB.MD5Password(yeniSifreTP3.Text) + "' where adminID='" + DB.userID + "'";
                        db.getQuery(sql);
                        infoLabel3.Text = "Şifreniz başarıyla güncellendi.";
                        yeniSifre2TP3.Clear();
                        yeniSifreTP3.Clear();
                    }
                    else
                    {
                        infoLabel3.Text = "Şifre 6 karakterden az olamaz. Lütfen tekrar deneyiniz";
                    }
                }
                else
                {
                    infoLabel3.Text = "Şifreler birbiriyle uyuşmuyor. Lütfen tekrar deneyiniz";
                }
            }
            else
            {
                infoLabel3.Text = "Şifre boş olamaz. Lütfen tekrar deneyiniz";
            }
        }

        private void dataGridUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            userIDTP4.Text = UsersCellsGetir(0);
            usernameTP4.Text = UsersCellsGetir(1);
            passwordTP4.Text = UsersCellsGetir(2);
            kullaniciBilgileriGetir(userIDTP4.Text);
        }

        private void kullaniciBilgileriGetir(string userID)
        {
            int tutar = 0;
            //Alınan bilet ve gelir hesaplama
            db.tableDoldur(userInfo, "select category from TakenSeatsTBL where userID='" + userID + "'");
            alınanBilet.Text = userInfo.Rows.Count.ToString();
            for(int i =0; i < userInfo.Rows.Count; i++)
            {
                if (userInfo.Rows[i][0].ToString() == "1")
                {
                    tutar += 300;
                }
                else if (userInfo.Rows[i][0].ToString() == "2")
                {
                    tutar += 200;
                }
                else if (userInfo.Rows[i][0].ToString() == "3")
                {
                    tutar += 100;
                }
                else if (userInfo.Rows[i][0].ToString() == "4")
                {
                    tutar += 75;
                }
                else if (userInfo.Rows[i][0].ToString() == "5")
                {
                    tutar += 50;
                }
                else if (userInfo.Rows[i][0].ToString() == "6")
                {
                    tutar += 30;
                }
            }
            toplamGelir.Text = tutar.ToString();

            userInfo.Rows.Clear();
            db.tableDoldur(userInfo, "select distinct(matchID) from TakenSeatsTBL where userID='" + userID + "'");
            gidilenMacTP4.Text = userInfo.Rows.Count.ToString();
        }
    }
}
