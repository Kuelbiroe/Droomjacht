using Droomjacht.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droomjacht.User;

namespace Droomjacht.abc
{
    /// <summary>
    /// starting page for all letter related games
    /// </summary>
    public partial class AbcScherm : Droomjacht.Menu
    {
        public AbcScherm() : base()
        {
            InitializeComponent();
        }

        public AbcScherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            ToonKnoppen();
        }

        private Instellingen userInstellingen = new Instellingen("");

        private void letterSpelKnop_Click(object sender, EventArgs e)
        {
            AbcLetterScherm scherm = new AbcLetterScherm(userInstellingen);
            this.Hide();
            scherm.Closed += (s, args) => this.Close();
            scherm.Show();
        }

        /// <summary>
        /// method to show the buttons of the games that the user has access to
        /// </summary>
        public void ToonKnoppen()
        {
            if (userInstellingen.abc1Niveau>0)
            {
                letterSpelKnop.Visible = true;
            }
            else
            {
                letterSpelKnop.Visible = false;
            }
        }
    }
}
