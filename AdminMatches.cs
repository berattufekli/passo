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
    public partial class AdminMatches : Form
    {
        DB db = new DB();
        DataTable teams = new DataTable();

        string ev;
        string deplasman;
        string stat;
        string date;
        string hour;
        public AdminMatches()
        {
            InitializeComponent();
        }

        private void AdminMatches_Load(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            date_lbl.Text = stat + "\n" + date + " - " + hour;
            getir();
        }

        private void getir()
        {
            db.griddoldur(dataGridView1);
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 165;
            dataGridView1.Columns[2].Width = 165;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;

            teams = db.getTeamsInfo();
            homeTeamCB.Items.Clear();
            awayTeamCB.Items.Clear();   
            for(int i = 0; i < teams.Rows.Count; i++)
            {
                homeTeamCB.Items.Add(teams.Rows[i][1].ToString());
                awayTeamCB.Items.Add(teams.Rows[i][1].ToString());
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teamsName.Text = CellsGetir(1) + " - " + CellsGetir(2);
                stadium.Text = CellsGetir(3);

                dateTimePicker.Value = DateTime.Parse(CellsGetir(4));
                status.Text = CellsGetir(6);
                saat.Text = CellsGetir(5);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private string CellsGetir(int cellIndex)
        {
            return dataGridView1.CurrentRow.Cells[cellIndex].Value.ToString();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Text != "" && saat.Text != "" && status.Text != "")
            {
                string sql = "update MatchesTBL set date='" + dateTimePicker.Value.ToString("dd.MM.yyyy") + "', hour='" + saat.Text + "', " +
                "status='" + status.Text + "' where matchID='" + CellsGetir(0) + "'";
                db.getQuery(sql);
                getir();
            }
            else
            {
                infoLabelTP2.Text = "Eksik bilgi var. Lütfen eksikleri doldurunuz.";
            }
            
        }


        private void homeTeamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = homeTeamCB.SelectedIndex;
            stat = teams.Rows[index][2].ToString();
            ev = homeTeamCB.SelectedItem.ToString();
            homeTeam.Image = DB.getImageFromResources(ev);
            teams_lbl.Text = ev + " - " + deplasman;
            date_lbl.Text = stat + "\n" + date + " - " + hour;
        }

        private void SifirlaBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void awayTeamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            deplasman = awayTeamCB.SelectedItem.ToString();
            awayTeam.Image = DB.getImageFromResources(deplasman);
            teams_lbl.Text = ev + " - " + deplasman;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("dd.MM.yyy");
            date_lbl.Text = stat + "\n" + date + " - " + hour;
        }

        private void saatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            hour = saatCB.Text.ToString();
            date_lbl.Text = stat + "\n" + date + " - " + hour;
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if(homeTeamCB.Text != "" && awayTeamCB.Text != "" && saatCB.Text != "" && dateTimePicker1.Text != "")
            {
                string sql = "insert into MatchesTBL(homeTeam, awayTeam, stadium, date, hour, status) " +
                   "values('" + ev + "', '" + deplasman + "', '" + stat + "', '" + date + "', '" + hour + "', 'Aktif')";
                db.getQuery(sql);
                getir();
                clear();
                infoLabelTP2.Text = "Müsabaka başarılı şekilde eklendi.";
            }
            else
            {
                infoLabelTP2.Text = "Eksik bilgi var. Lütfen eksikleri doldurunuz.";
            }
            
        }

        public void clear()
        {
            homeTeam.Image = null;
            awayTeam.Image = null;
            teams_lbl.Text = "";
            homeTeamCB.Text = "";
            awayTeamCB.Text = "";
            saatCB.Text = "";
            dateTimePicker1.Text = "";
            date_lbl.Text = "";
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            string sql = "delete from matchesTBL where matchID='" + CellsGetir(0) + "'";
            db.getQuery(sql);
            getir();
        }
    }
}
