using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;
using System.Data;

namespace Passolig
{
    internal class DB
    {
        string connectionString = @"Data Source=WINDOWS\SQLEXPRESS;Initial Catalog=192503028;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        
        public static DataTable matches = new DataTable();
        DataTable takenSeats = new DataTable();
        //diğer formlardan erişmesi kolay olsun diye static tanımlı
        public static DataTable matchInfo = new DataTable();
        public static DataTable cards = new DataTable();
        public static DataTable tickets = new DataTable();
        
        public static string currentUser;
        public static string userID;


        //bağlantı kontrolü
        public void CheckConnection()
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                MessageBox.Show("Connection Open!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //md5 şifre oluşturma 
        public static string MD5Password(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(password);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (byte chrctr in array)
            {
                sb.Append(chrctr.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        //kullanıcılar tablosuna yeni kullanıcı ekleme
        public bool createNewUser(string username, string password, string email)
        {
            string query = "insert into usersTBL (username, password, email) values ('" + username + "', '" + MD5Password(password) + "', '" + email + "')";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //Login eventi
        public bool login(string username, string password)
        {
            string query = "select * from usersTBL where username=@user and password=@pass";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@user", username);
            cmd.Parameters.Add("@pass", MD5Password(password));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userID = dr[0].ToString();
                Console.WriteLine(userID);
                currentUser = username;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool adminLogin(string username, string password)
        {
            string query = "select * from adminTBL where username=@user and password=@pass";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@user", username);
            cmd.Parameters.Add("@pass", MD5Password(password));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userID = dr[0].ToString();
                Console.WriteLine(userID);
                currentUser = username;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void getMatches(FlowLayoutPanel flow, string query)
        {
            matchInfo.Clear();
            matches.Clear();
            flow.Controls.Clear();

            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(matches);

            if(matches.Rows.Count > 0)
            {
                //rows count çift ise
                if(matches.Rows.Count % 2 == 0)
                {
                    for(int i = 0; i < matches.Rows.Count/2; i++)
                    {
                        //her sırada 2 maç olmasını istediğim için böyle yaptım
                        Panel outsidePanel = new Panel();
                        outsidePanel.Size = new Size(1040, 250);
                        outsidePanel.Margin = new Padding(0);
                        outsidePanel.Padding = new Padding(0);


                        //sol taraftaki butonu oluşturma
                        outsidePanel.Controls.Add(dynamicButton(new Point(12, 22), matches.Rows[2 * i][0].ToString(), matches.Rows[2 * i][1].ToString(), matches.Rows[2 * i][2].ToString(),
                                                  matches.Rows[2 * i][3].ToString(), matches.Rows[2 * i][4].ToString(), matches.Rows[2 * i][5].ToString()));


                        //sağ taraftaki butonu oluşturma
                        outsidePanel.Controls.Add(dynamicButton(new Point(530, 22), matches.Rows[(2 * i) + 1][0].ToString(), matches.Rows[(2 * i) + 1][1].ToString(), matches.Rows[(2 * i) + 1][2].ToString(),
                                                  matches.Rows[(2 * i) + 1][3].ToString(), matches.Rows[(2 * i) + 1][4].ToString(), matches.Rows[(2 * i) + 1][5].ToString()));

                        //oluşturduğumuz outsidePaneli formdaki flowpanele ekleme
                        flow.Controls.Add(outsidePanel);
                    }
                }
                
                //rows count tek ise
                else if(matches.Rows.Count % 2 == 1)
                {
                    for(int i = 0; i <= matches.Rows.Count / 2; i++)
                    {
                        Panel outsidePanel = new Panel();
                        outsidePanel.Size = new Size(1040, 250);
                        outsidePanel.Margin = new Padding(0);
                        outsidePanel.Padding = new Padding(0);


                        //sol taraftaki butonu oluşturma
                        outsidePanel.Controls.Add(dynamicButton(new Point(12, 22), matches.Rows[i * 2][0].ToString(), matches.Rows[i * 2][1].ToString(), matches.Rows[i * 2][2].ToString(),
                                                  matches.Rows[i * 2][3].ToString(), matches.Rows[i * 2][4].ToString(), matches.Rows[i * 2][5].ToString()));

                        //sağ taraftaki butonu oluşturma 
                        //tek sayıda row olduğu için oluşturduğumuz son panelin sağdaki elemanı eksik olması gerekli
                        //bunun için datatable'ın son elemanı olana kadar bu işlemi yaptırdım
                        if ((2 * i)+1 != matches.Rows.Count)
                        {
                            try {
                                outsidePanel.Controls.Add(dynamicButton(new Point(530, 22), matches.Rows[(2 * i) + 1][0].ToString(), matches.Rows[(2 * i) + 1][1].ToString(), matches.Rows[(2 * i) + 1][2].ToString(),
                                                      matches.Rows[(2 * i) + 1][3].ToString(), matches.Rows[(2 * i) + 1][4].ToString(), matches.Rows[(2 * i) + 1][5].ToString()));
                            }
                            catch
                            {
                                Console.WriteLine("hata");
                            }  
                        }
                        //oluşturduğumuz outsidePaneli formdaki flowpanele ekleme
                        flow.Controls.Add(outsidePanel);
                    }
                }
            }
        }

        
        //veritabanındaki her row için dinamik button oluşturma
        //buttonlara 2 takım logosunu ekleyemediğimiz için bu şekilde panel oluşturup paneli button gibi gösterdim
        private Panel dynamicButton(Point btnLocation,string matchID, string homeTeam, string awayTeam,string stadium, string date , string hour)
        {
            //button paneli oluşturma
            Panel button = new Panel();
            button.Tag = matchID;
            button.Name = homeTeam;
            button.Size = new Size(500, 200);
            button.Margin = new Padding(0);
            button.Padding = new Padding(0);
            button.BackgroundImage = Properties.Resources.button;
            button.Location = btnLocation;
            button.Cursor = Cursors.Hand;
            //dinamik olarak picture ve label ekleme
            button.Controls.Add(dynamicImage(new Point(0, 36), matchID ,homeTeam));
            button.Controls.Add(dynamicLabel(new Point(131, 36), new Size(238, 73), matchID, homeTeam + " - " + awayTeam));
            button.Controls.Add(dynamicLabel(new Point(131, 109), new Size(238, 73), matchID, stadium + "\n" + date + " " + hour));
            button.Controls.Add(dynamicImage(new Point(372, 36), matchID, awayTeam));
            button.Click += new EventHandler(button_click);
            return button;
            
        }

        //veritabanından gelen kayıtlara göre dinamik PictureBox oluşturma
        private PictureBox dynamicImage(Point imageLocation, string matchID, string teamName)
        {
            PictureBox picture = new PictureBox();
            picture.Tag = matchID;
            picture.Size = new Size(128, 128);
            picture.Location = imageLocation;
            picture.Image = getImageFromResources(teamName);
            picture.Margin = new Padding(0);
            picture.Padding = new Padding(0);
            picture.Cursor = Cursors.Hand;
            picture.BackColor = Color.Transparent;
            picture.Click += new EventHandler(button_click);
            return picture;

        }

        //veritabanından gelen kayıtlara göre dinamik label oluşturma
        private Label dynamicLabel(Point labelLocation, Size labelSize,string matchID, string labelText)
        {
            Label label = new Label();
            label.Tag = matchID;
            label.AutoSize = false;
            label.BackColor = Color.White;
            label.Margin = new Padding(0);
            label.Padding = new Padding(0);
            label.Location = labelLocation;
            label.Size = labelSize;
            label.Text = labelText;
            label.Font = new Font("Microsoft YaHei UI", 12.25f, FontStyle.Bold);
            label.TextAlign = ContentAlignment.TopCenter;
            label.Click += new EventHandler(button_click);
            return label;
        }

        //resources kısmından takım ismine göre logoları getirme olayı
        public static Bitmap getImageFromResources(string imageName)
        {
            string teamImage = imageName.ToLower().Replace(" ", "-") + "-logo";
            Object obj = Properties.Resources.ResourceManager.GetObject(teamImage);
            Bitmap image = (Bitmap)obj;
            return image;
        }

        //Dinamik button tıklama eventi
        private void button_click(object sender, System.EventArgs e)
        {
            matches.Clear();
            matchInfo.Clear();
            BuyTicket buyTicket = new BuyTicket();

            
            if(sender is Panel)
            {
                //Maç id'sine göre tıklanan maç bilgilerini getirme
                Panel panel = sender as Panel;
                string query = "select * from matchesTBL where matchID=" + panel.Tag.ToString() + "";
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, con);
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(matchInfo);
            }
            else if(sender is Label)
            {
                //Maç id'sine göre tıklanan maç bilgilerini getirme
                Label label = sender as Label;
                string query = "select * from matchesTBL where matchID=" + label.Tag.ToString() + "";
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, con);
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(matchInfo);
            }
            else if(sender is PictureBox)
            {
                //Maç id'sine göre tıklanan maç bilgilerini getirme
                PictureBox pictureBox = sender as PictureBox;
                string query = "select * from matchesTBL where matchID=" + pictureBox.Tag.ToString() + "";
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, con);
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(matchInfo);

            }
            
            /*
            buyTicket.homeTeam.Image = getImageFromResources(matchInfo.Rows[0][1].ToString());
            buyTicket.teamsName.Text = matchInfo.Rows[0][1].ToString() + " - " + matchInfo.Rows[0][2].ToString();
            buyTicket.awayTeam.Image = getImageFromResources(matchInfo.Rows[0][2].ToString());
            buyTicket.matchDate.Text = matchInfo.Rows[0][3].ToString() + "\n" + matchInfo.Rows[0][4].ToString() + " " +
                                       matchInfo.Rows[0][5].ToString();
            */

            Login.mainform.openChildFrom(buyTicket);
            
        }

        //Daha önceden alınmış biletleri veritabanından çekme ve koltuk image'ını değiştirme
        public void getTakenSeats(string matchID, string category, List<Button> seats)
        {
            takenSeats.Clear();
            string sql = "select seat from TakenSeatsTBL where matchID='" + matchID + "' and category='" + category + "'";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(takenSeats);

            if (takenSeats.Rows.Count > 0)
            {
                for (int j = 0; j < takenSeats.Rows.Count; j++)
                {
                    for (int i = 0; i < seats.Count; i++)
                    {
                        if (takenSeats.Rows[j][0].ToString() == seats[i].Name)
                        {
                            seats[i].Image = Properties.Resources.takenBTN;
                            seats[i].Enabled = false;
                        }
                    }
                }
            }
            con.Close();
        }

        public void getCard(ComboBox box)
        {
            cards.Clear();
            string sql = "select * from creditCardTBL where userID='" + userID + "'";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(cards);
            if (cards.Rows.Count > 0)
            {
                for(int i=0; i<cards.Rows.Count; i++)
                {
                    box.Items.Add(cards.Rows[i][6].ToString());
                }
            }
        }

        public void getQuery(string sql)
        {
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void getTickets(FlowLayoutPanel flow)
        {
            tickets.Clear();
            string sql = "select * from matchesTBL as t1 inner join TakenSeatsTBL as t2 on t1.matchID=t2.matchID where userID='"+userID+"'";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(tickets);

            if (tickets.Rows.Count > 0)
            {
                for(int j=0; j<tickets.Rows.Count; j++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(983, 203);
                    panel.Margin = new Padding(0, 0, 0, 0);
                    panel.BackgroundImage = Properties.Resources.tickets;
                    panel.BackColor = Color.Transparent;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    panel.Controls.Add(dynamicLabel(new Point(0, 37), new Size(302, 128), ContentAlignment.MiddleCenter , tickets.Rows[j][9].ToString() + ". Kategori - " + tickets.Rows[j][10].ToString() + "\n" + tickets.Rows[j][6].ToString()));
                    panel.Controls.Add(dynamicImage(new Point(316, 37), tickets.Rows[j][1].ToString()));
                    panel.Controls.Add(dynamicImage(new Point(846, 37), tickets.Rows[j][2].ToString()));
                    panel.Controls.Add(dynamicLabel(new Point(444, 37), new Size(402, 73), ContentAlignment.TopCenter, tickets.Rows[j][1].ToString() + " - " + tickets.Rows[j][2].ToString()));
                    panel.Controls.Add(dynamicLabel(new Point(444, 110), new Size(402, 55), ContentAlignment.MiddleCenter, tickets.Rows[j][3].ToString() + "\n" + tickets.Rows[j][4].ToString() + " - " + tickets.Rows[j][5].ToString()));

                    flow.Controls.Add(panel);
                }
                
            }
        }

        public void griddoldur(DataGridView grid)
        { 
            matches.Rows.Clear();
            grid.Controls.Clear();
            string sql = "select * from matchesTBL";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(matches);
            grid.DataSource = matches;
            con.Close();
        }

        public void griddoldur(DataGridView grid, string sql)
        {
            matches.Rows.Clear();
            grid.Controls.Clear();
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }

        public void griddoldur(DataGridView grid, DataTable table,  string sql)
        {
            table.Rows.Clear();
            grid.Controls.Clear();
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(table);
            grid.DataSource = table;
            con.Close();
        }

        public void tableDoldur(DataTable table, string sql)
        {
            table.Rows.Clear();
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();
        }

        public DataTable getTeamsInfo()
        {
            
            string sql = "select * from TeamsTBL";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sql, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            DataTable teams = new DataTable();
            da.Fill(teams);
            con.Close();
            return teams;
        }

        private Label dynamicLabel(Point labelLocation, Size labelSize, ContentAlignment align, string labelText)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.BackColor = Color.White;
            label.Margin = new Padding(0);
            label.Padding = new Padding(0);
            label.Location = labelLocation;
            label.Size = labelSize;
            label.Text = labelText;
            label.Font = new Font("Microsoft YaHei UI", 14.25f, FontStyle.Bold);
            label.TextAlign = align;
            return label;
        }

        private PictureBox dynamicImage(Point imageLocation, string teamName)
        {
            PictureBox picture = new PictureBox();
            picture.Size = new Size(128, 128);
            picture.Location = imageLocation;
            picture.Image = getImageFromResources(teamName);
            picture.Margin = new Padding(0);
            picture.Padding = new Padding(0);
            picture.Cursor = Cursors.Hand;
            picture.BackColor = Color.Transparent;
            return picture;

        }


        


    }
}
