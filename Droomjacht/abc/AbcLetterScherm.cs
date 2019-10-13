using Droomjacht.Properties;
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

namespace Droomjacht.abc
{
    public partial class AbcLetterScherm : Menu
    {
        public AbcLetterScherm() : base()
        {
            InitializeComponent();
        }

        public AbcLetterScherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
        }

        private Instellingen userInstellingen = new Instellingen("");

        public void VulLetterVraag()
        {

            Random juisteAntwoord = new Random();
            int knopKeuze = juisteAntwoord.Next(1, 4);
            string knopAntwoord1 = RandomString(1);
            string knopAntwoord2 = RandomString(1);
            string knopAntwoord3 = RandomString(1);
            string vraag = RandomString(1);
            //check of 1 of meerdere antwoorden overeenkomen
            while (knopAntwoord1 == vraag)
                knopAntwoord1 = RandomString(1);
            while (knopAntwoord2 == vraag || knopAntwoord2 == knopAntwoord1)
                knopAntwoord2 = RandomString(1);
            while (knopAntwoord3 == vraag || knopAntwoord3 == knopAntwoord1 || knopAntwoord3 == knopAntwoord2)
                knopAntwoord3 = RandomString(1);
            switch (knopKeuze)
            {
                case 1:
                    knopAntwoord1 = vraag;
                    break;
                case 2:
                    knopAntwoord2 = vraag;
                    break;
                default:
                    knopAntwoord3 = vraag;
                    break;
            }

            letterWolk.Text = vraag;
            VeranderKleurWolk();
            this.knopAntwoord1.Text = knopAntwoord1;
            this.knopAntwoord2.Text = knopAntwoord2;
            this.knopAntwoord3.Text = knopAntwoord3;
        }

        public bool ControleerAntwoord(string antwoord)
        {
            if (antwoord == letterWolk.Text)
                return true;
            else
                return false;
        }

        public void VeranderKleurWolk(bool antwoordJuist, string knop)
        {
            if (antwoordJuist)
            {
                switch (knop)
                {
                    case "knopAntwoord1":
                        knopAntwoord1.BackgroundImage = Resources.wolkGroen;
                        break;
                    case "knopAntwoord2":
                        knopAntwoord2.BackgroundImage = Resources.wolkGroen;
                        break;
                    default:
                        knopAntwoord3.BackgroundImage = Resources.wolkGroen;
                        break;
                }

            }
            else
            {
                switch (knop)
                {
                    case "knopAntwoord1":
                        knopAntwoord1.BackgroundImage = Resources.wolkRood;
                        break;
                    case "knopAntwoord2":
                        knopAntwoord2.BackgroundImage = Resources.wolkRood;
                        break;
                    default:
                        knopAntwoord3.BackgroundImage = Resources.wolkRood;
                        break;
                }
            }
        }
        public void VeranderKleurWolk()
        {
            knopAntwoord1.BackgroundImage = Resources.wolkGrijs;
            knopAntwoord2.BackgroundImage = Resources.wolkGrijs;
            knopAntwoord3.BackgroundImage = Resources.wolkGrijs;
        }

        private void knopAntwoord1_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord1.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord1");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord) VulLetterVraag();
        }

        private void knopAntwoord2_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord2.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord2");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord) VulLetterVraag();
        }

        private void knopAntwoord3_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord3.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord3");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord) VulLetterVraag();
        }

        private static string RandomString(int length)
        {
            var rand = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
