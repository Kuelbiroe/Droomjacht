using Droomjacht.abc;
using Droomjacht.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droomjacht.Rekenen;

namespace Droomjacht.Rekenen
{
    public partial class RekenScherm : Menu
    {
        public RekenScherm() : base()
        {
            InitializeComponent();
        }

        public RekenScherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            ToonKnoppen();
        }

        private Instellingen userInstellingen = new Instellingen("");

        private void tekenWolk_Click(object sender, EventArgs e)
        {
            Reken.Rekenen rekenscherm = new Reken.Rekenen(userInstellingen);
            this.Hide();
            rekenscherm.Closed += (s, args) => this.Close();
            rekenscherm.Show();
        }
        public void ToonKnoppen()
        {
            if (userInstellingen.reken1Niveau > 0)
            {
                tekenWolk.Visible = true;
            }
            else
            {
                tekenWolk.Visible = false;
            }
        }
    }
}
