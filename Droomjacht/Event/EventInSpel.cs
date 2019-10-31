using Droomjacht.User;
using System;
using Droomjacht.abc;

namespace Droomjacht.Event
{
    /// <summary>
    /// plays an event when the user has earned enough points
    /// </summary>
    public partial class EventInSpel : Menu
    {
        public EventInSpel(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            VulTekstBallon();
        }

        /// <summary>
        /// fills the text balloon of the avatar
        /// </summary>
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

        /// <summary>
        /// goes to the new game/level when clicking on the text balloon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
