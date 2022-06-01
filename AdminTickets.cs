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
    public partial class AdminTickets : Form
    {
        DataTable teams = new DataTable();
        DataTable tickets = new DataTable();
        DB db = new DB();
        List<String> queryList = new List<String>();
        string ev;
        string deplasman;
        string date;
        string hour;
        string durum;
        string sql = "select * from matchesTBL as t1 inner join TakenSeatsTBL as t2 on t1.matchId=t2.matchID ";
        public AdminTickets()
        {
            InitializeComponent();
        }

        private void getir()
        {
            //Alınan biletleri getir
            db.griddoldur(dataGrid, tickets, sql);
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[4].Visible = false;

            //Combobox için takımları getir
            teams = db.getTeamsInfo();

            homeCB.Items.Clear();
            awayCB.Items.Clear();   
            for (int i = 0; i < teams.Rows.Count; i++)
            {
                homeCB.Items.Add(teams.Rows[i][1].ToString());
                awayCB.Items.Add(teams.Rows[i][1].ToString());
            }

            //Kaç seyirci gelmiş ve ne kadar gelir oluşmuş hesapla
            gelirHesapla();
        }

        private void AdminTickets_Load(object sender, EventArgs e)
        {
            getir();

            queryList.Add(ev);
            queryList.Add(deplasman);
            queryList.Add(hour);
            queryList.Add(durum);
            queryList.Add(date);

        }

        private void sorguOlustur()
        {
            sql = "select * from matchesTBL as t1 inner join TakenSeatsTBL as t2 on t1.matchId=t2.matchID ";
            for (int i=0; i<queryList.Count; i++)
            {

                if (i == 0 && !sql.Contains("where"))
                {
                    sql += "where ";
                }

                if(queryList[i] != null)
                {
                    sql += queryList[i] + " and ";

                }
            }


            if(sql.Substring(sql.Length-4, 4).Contains("and"))
            {
                sql = sql.Substring(0, sql.Length-4);
                
            }
            Console.WriteLine(sql);

            getir();
        }

        private void homeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            ev = "homeTeam='" + homeCB.Text + "'";
            queryList[0] = ev;
            sorguOlustur();
            */
        }

        private void awayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            deplasman = "awayTeam='" + awayCB.Text + "'";
            queryList[1] = deplasman;
            sorguOlustur();
        }

        private void saat_SelectedIndexChanged(object sender, EventArgs e)
        {
            hour = "hour='" + saat.Text + "'";
            queryList[2] = hour;
            sorguOlustur();
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            durum = "status='" + status.Text + "'";
            queryList[3] = durum;
            sorguOlustur();
        }

        private void baslangic_date_ValueChanged(object sender, EventArgs e)
        {
            
            date = "t1.date between '" + baslangic_date.Value.ToString("dd.MM.yyyy") + "' and '" + bitis_date.Value.ToString("dd.MM.yyyy") + "'";
            queryList[4] = date;
            sorguOlustur();
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            queryList[0] = "";
            queryList[1] = "";
            queryList[2] = "";
            queryList[3] = "";
            queryList[4] = "";

           
            

            baslangic_date.Value = DateTime.Now;
            bitis_date.Value = DateTime.Now;

            sql = "select * from matchesTBL as t1 inner join TakenSeatsTBL as t2 on t2.matchId=t1.matchID ";
            db.griddoldur(dataGrid, teams, sql);
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[4].Visible = false;

            sorguOlustur();
            gelirHesapla();
        }

        private void gelirHesapla()
        {
            
            int tutar = 0;
            
            for(int i=0; i < tickets.Rows.Count-1; i++)
            {
                if(tickets.Rows[i][9].ToString() == "1")
                {
                    tutar += 300;
                }
                else if (tickets.Rows[i][9].ToString() == "2")
                {
                    tutar += 200;
                }
                else if (tickets.Rows[i][9].ToString() == "3")
                {
                    tutar += 100;
                }
                else if (tickets.Rows[i][9].ToString() == "4")
                {
                    tutar += 75;
                }
                else if (tickets.Rows[i][9].ToString() == "5")
                {
                    tutar += 50;
                }
                else if (tickets.Rows[i][9].ToString() == "6")
                {
                    tutar += 30;
                }
            }
            
            seyirci.Text = "Seyirci Sayısı: " + tickets.Rows.Count;
            gelir.Text = "Toplam Gelir: " + tutar.ToString();
            
        }

        private void bitis_date_ValueChanged(object sender, EventArgs e)
        {
            date = "t1.date between '" + baslangic_date.Value.ToString("dd.MM.yyyy") + "' and '" + bitis_date.Value.ToString("dd.MM.yyyy") + "'";
            queryList[4] = date;
            sorguOlustur();
        }
    }
}
