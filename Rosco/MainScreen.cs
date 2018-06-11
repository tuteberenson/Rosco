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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {  
            Rosco game = new Rosco(GetImputValues());
            game.Show();
            this.Hide();
        }

        private Dictionary<string, string> GetImputValues()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(Constants.TEAM_ONE_NAME_KEY, this.team1Name.Text);
            dic.Add(Constants.TEAM_ONE_TIME_KEY, this.team1Time.Text);
            dic.Add(Constants.TEAM_TWO_NAME_KEY, this.team2Name.Text);
            dic.Add(Constants.TEAM_TWO_TIME_KEY, this.team2Time.Text);

            return dic;
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
