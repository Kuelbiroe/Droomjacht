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
using Droomjacht.abc;

namespace Droomjacht.Event
{
    public partial class EventInSpel : Menu
    {
        public EventInSpel(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            VulTekstBallon();
        }

        private void VulTekstBallon()
        {
            switch(userInstellingen.eventSpel)
            {
                case "rekenPlus":
                    tekstballon.Text = "Goed gedaan, " + userInstellingen.gebruikersNaam + "!" + Environment.NewLine
                        + "Je hebt een nieuw niveau gehaald met rekenen (+)." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    break;
                case "letter":
                    tekstballon.Text = "Goed gedaan, " + userInstellingen.gebruikersNaam + "!" + Environment.NewLine
                        + "Je hebt een nieuw niveau gehaald met letters." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    break;
                case "letterBegin":
                    tekstballon.Text = "Goed gedaan, " + userInstellingen.gebruikersNaam + "!" + Environment.NewLine
                        + "Je hebt een nieuw spel verdiend." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    break;
                default:
                    tekstballon.Text = "Goed gedaan, " + userInstellingen.gebruikersNaam + "!" + Environment.NewLine
                        + "Je hebt een nieuw spel verdiend." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    break;
            }            
        }

        private void tekstballon_Click(object sender, EventArgs e)
        {
            switch (userInstellingen.eventSpel)
            {
                case "rekenPlus":
                    Reken.Rekenen rekenscherm = new Reken.Rekenen(userInstellingen);
                    this.Hide();
                    rekenscherm.Closed += (s, args) => this.Close();
                    rekenscherm.Show();
                    break;
                case "letter":
                case "letterBegin":
                    AbcLetterScherm AbcLetterScherm = new AbcLetterScherm(userInstellingen);
                    this.Hide();
                    AbcLetterScherm.Closed += (s, args) => this.Close();
                    AbcLetterScherm.Show();
                    break;
                default:                    
                    break;
            }
        }

        private Instellingen userInstellingen = new Instellingen("");


    }
}
