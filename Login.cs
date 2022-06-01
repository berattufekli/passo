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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public static MainForm mainform { get; set; }
        public static Login loginform { get; set; }

        public static AdminPanel adminpanel { get; set; }

        DB db = new DB();

        public Login()
        {
            InitializeComponent();
        }

        //close event when closeBtn is pressed
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //form move event 
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //switching from loginPanel to newUserPanel
        private void createText_Click(object sender, EventArgs e)
        {
            usernameTBox.Clear();
            passwordTBox.Clear();
            fullDockPanel.Controls.Remove(mainPanel);
            fullDockPanel.Controls.Add(newUserPanel);
            newUserPanel.Dock = DockStyle.Bottom;
        }

        //switching from newUserPanel to loginPanel
        private void backBtn_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBackLabel_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            fullDockPanel.Controls.Remove(newUserPanel);
            fullDockPanel.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Bottom;
            newUserTBox.Clear();
            newUserPassTBox.Clear();
            newUserPass2TBox.Clear();
            newUserEmailTBox.Clear();
        }

        

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (newUserTBox.Text != "" && newUserPassTBox.Text != "" && newUserEmailTBox.Text != "" && newUserPassTBox.TextLength >= 6)
            {
                if (newUserPassTBox.Text == newUserPass2TBox.Text && newUserEmailTBox.TextLength > 9 && (newUserEmailTBox.Text.Contains("gmail.com") ||
                    newUserEmailTBox.Text.Contains("icloud.com") || newUserEmailTBox.Text.Contains("hotmail.com")))
                {
                    Console.WriteLine("eklenmeye çalışıyor");
                    if (db.createNewUser(newUserTBox.Text, newUserPassTBox.Text, newUserEmailTBox.Text))
                    {
                        MessageBox.Show("Yeni kullanıcı başarıyla oluşturuldu.");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı daha önceden alınmış. Lütfen tekrar deneyiniz.");
                    }
                }
                else if (newUserPassTBox.Text != newUserPass2TBox.Text)
                {
                    MessageBox.Show("Şifreler eşleşmiyorç. Lütfen tekrar deneyiniz.");
                }
                else if (newUserEmailTBox.TextLength <= 9)
                {
                    MessageBox.Show("E-mail 10 karakterden az olamaz. Lütfen tekrar deneyiniz.");
                    newUserEmailTBox.Clear();
                    newUserEmailTBox.Focus();
                }
                else if (!newUserEmailTBox.Text.Contains("gmail.com")
                    && !newUserEmailTBox.Text.Contains("icloud.com") && !newUserEmailTBox.Text.Contains("hotmail.com"))
                {
                    MessageBox.Show("Lütfen gmail, icloud veya hotmail uzantılı bir gmail adresi giriniz.");
                    newUserEmailTBox.Clear();
                    newUserEmailTBox.Focus();
                }

            }

            else if (newUserTBox.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş olamaz. Lütfen tekrar deneyiniz.");
                newUserTBox.Focus();
            }
            else if (newUserPassTBox.Text == "")
            {
                MessageBox.Show("Şifre boş olamaz. Lütfen tekrar deneyiniz.");
                newUserPassTBox.Focus();
            }
            else if (newUserPass2TBox.Text == "")
            {
                MessageBox.Show("Şifre (Tekrar) boş olamaz. Lütfen tekrar deneyiniz.");
                newUserPass2TBox.Focus();
            }
            else if (newUserEmailTBox.Text == "")
            {
                MessageBox.Show("E-mail boş olamaz. Lütfen tekrar deneyiniz.");
                newUserEmailTBox.Focus();
            }
            else if (newUserPassTBox.TextLength < 6)
            {
                MessageBox.Show("Şifre 6 karakterden az olamaz. Lütfen tekrar deneyiniz");
                newUserPassTBox.Clear();
                newUserPass2TBox.Clear();
                newUserPassTBox.Focus();
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTBox.Text != "" && passwordTBox.Text != "")
            {
                if (usernameTBox.Text.Contains("admin@")) 
                {
                    if (db.adminLogin(usernameTBox.Text, passwordTBox.Text))
                    {
                        usernameTBox.Clear();
                        passwordTBox.Clear();

                        this.Hide();
                        loginform = this;
                        AdminPanel panel = new AdminPanel();
                        panel.Closed += (s, args) => this.Close();
                        panel.Show();
                        adminpanel = panel;

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış. Lütfen yöneticiye başvurarak şifrenizi sıfırlayın.");
                    }
                }
                else
                {
                    if (db.login(usernameTBox.Text, passwordTBox.Text))
                    {
                        usernameTBox.Clear();
                        passwordTBox.Clear();

                        this.Hide();
                        loginform = this;
                        MainForm mainForm = new MainForm();
                        mainForm.Closed += (s, args) => this.Close();
                        mainForm.Show();
                        mainform = mainForm;

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış. Tekrar deneyiniz ya da şifrenizi sıfırlayınız.");
                    }
                }
            }
            else if (usernameTBox.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş olamaz. Lütfen tekrar deneyiniz.");
            }
            else if (passwordTBox.Text == "")
            {
                MessageBox.Show("Şifre boş olamaz. Lütfen tekrar deneyiniz.");
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata oluştu. Lütfen tekrar deneyiniz.");
            }

        }

        private void sifreSifirla_Click(object sender, EventArgs e)
        {
            usernameTBox.Clear();
            passwordTBox.Clear();
            fullDockPanel.Controls.Remove(mainPanel);
            fullDockPanel.Controls.Add(resetPasswordPanel);
            resetPasswordPanel.Dock = DockStyle.Bottom;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            fullDockPanel.Controls.Remove(resetPasswordPanel);
            fullDockPanel.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Bottom;
            usernameRP.Clear();
            emailRP.Clear();    
            passwordRP.Clear();
            password2RP.Clear();
        }

        private void goBackRP_Click(object sender, EventArgs e)
        {
            fullDockPanel.Controls.Remove(resetPasswordPanel);
            fullDockPanel.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Bottom;
            usernameRP.Clear();
            emailRP.Clear();
            passwordRP.Clear();
            password2RP.Clear();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if(usernameRP.Text != "" && emailRP.Text != "" && passwordRP.Text != "" && password2RP.Text != "")
            {
                if(passwordRP.Text == password2RP.Text)
                {
                    if(passwordRP.TextLength >= 6)
                    {
                        if(emailRP.Text.Contains("gmail.com") || emailRP.Text.Contains("icloud.com") || emailRP.Text.Contains("hotmail.com"))
                        {
                            try
                            {
                                MessageBox.Show("Şifre sıfırlama işlemi başarılı. Artık giriş yapabilirsiniz");
                                string sql = "update usersTBL set password='" + DB.MD5Password(passwordRP.Text) + "'" +
                                " where username='" + usernameRP.Text + "' and email='" + emailRP.Text + "'";
                                db.getQuery(sql);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Kullanıcı adı ve email'in eşleştiği bir kullanıcı bulunamadı. Lütfen tekrar deneyiniz");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen gmail, icloud veya hotmail uzantılı bir gmail adresi giriniz.");
                            emailRP.Clear();
                            emailRP.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz 6 karakterden az olamaz. Lütfen tekrar deneyiniz");
                        passwordRP.Clear();
                        password2RP.Clear();
                        passwordRP.Focus(); 
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyiniz.");
                    passwordRP.Clear();
                    password2RP.Clear();
                    passwordRP.Focus();
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi bulunmaktadır. Lütfen tekrar deneyiniz");
            }
        }
    }
}
