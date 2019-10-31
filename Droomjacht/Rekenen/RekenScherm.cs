using Droomjacht.User;
using System;

namespace Droomjacht.Rekenen
{
    /// <summary>
    /// menu where all the math games can be found
    /// </summary>
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

        /// <summary>
        /// show only the buttons that the user has earned
        /// </summary>
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
