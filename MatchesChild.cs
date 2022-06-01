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
    public partial class MatchesChild : Form
    {
        DB db = new DB();
        public MatchesChild()
        {
            InitializeComponent();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("slkfsafas");
        }

        private void MatchesChild_Load(object sender, EventArgs e)
        {
            db.getMatches(matchesFlowLayout, "select * from matchesTBL");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text != "")
            {
                string sql = "select * from matchesTBL where homeTeam like '" + searchBox.Text + "%' or awayTeam like '" + searchBox.Text + "%'";
                db.getMatches(matchesFlowLayout, sql);
            }
            else
            {
                db.getMatches(matchesFlowLayout, "select * from matchesTBL");
            }
        }
    }
}
