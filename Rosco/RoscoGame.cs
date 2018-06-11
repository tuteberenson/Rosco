using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosco
{
    public partial class Rosco : Form
    {
        Dictionary<string,string> teams;
        private int timeCounterTeamOne = 1;
        private int timeCounterTeamTwo = 1;


        public Rosco(Dictionary<string, string> teams)
        {
            InitializeComponent();
            this.teams = teams;
            InitTeams();
        }

        private void InitTeams()
        {
            this.lblNameTeam1.Text = teams[Constants.TEAM_ONE_NAME_KEY];
            this.lblNameTeam2.Text = teams[Constants.TEAM_TWO_NAME_KEY];
            this.lblTimerTeam1.Text = teams[Constants.TEAM_ONE_TIME_KEY];
            this.lblTimerTeam2.Text = teams[Constants.TEAM_TWO_TIME_KEY];

            Int32.TryParse(teams[Constants.TEAM_ONE_TIME_KEY], out timeCounterTeamOne); 
            Int32.TryParse(teams[Constants.TEAM_TWO_TIME_KEY], out timeCounterTeamTwo);

            timerTeam1.Interval = 1000;
            timerTeam2.Interval = 1000;
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            ChangeColor((Button)sender);
        }

        private void ChangeColor(Button button)
        {
            switch (button.BackColor.Name)
            {
                case "Blue":
                    button.BackColor = Color.Yellow;
                    break;
                case "Yellow":
                    button.BackColor = Color.Lime;
                    break;
                case "Lime":
                    button.BackColor = Color.Red;
                    break;
                case "Red":
                    button.BackColor = Color.Blue;
                    break;
                default:
                    button.BackColor = Color.Blue;
                    break;
            }
        }

        private void timerTeam1_Tick(object sender, EventArgs e)
        {
            timeCounterTeamOne--;

            if (timeCounterTeamOne == 0)
                timerTeam1.Stop();

            this.lblTimerTeam1.Text = timeCounterTeamOne.ToString();
        }

        private void timerTeam2_Tick(object sender, EventArgs e)
        {
            timeCounterTeamTwo--;

            if (timeCounterTeamTwo == 0)
                timerTeam2.Stop();

            this.lblTimerTeam2.Text = timeCounterTeamTwo.ToString();
        }

        private void lblTimerTeam1_Click(object sender, EventArgs e)
        {

            if(timerTeam1.Enabled)
            {
                timerTeam1.Stop();
            }
            else
            {
                timerTeam1.Start();
            }

        }

        private void lblTimerTeam2_Click(object sender, EventArgs e)
        {
            if (timerTeam2.Enabled)
            {
                timerTeam2.Stop();
            }
            else
            {
                timerTeam2.Start();
            }
        }
    }
}
