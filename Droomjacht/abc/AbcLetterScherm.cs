using Droomjacht.Event;
using Droomjacht.Properties;
using Droomjacht.User;
using System;
using System.Data;
using System.Linq;

namespace Droomjacht.abc
{
    /// <summary>
    /// letter game where the user needs to select the same letter
    /// </summary>
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
            VulLetterVraag();
        }

        private Instellingen userInstellingen = new Instellingen("");

        /// <summary>
        /// fill in a new letter with answers based on the users level
        /// </summary>
        public void VulLetterVraag()
        {
            Random juisteAntwoord = new Random();
            int knopKeuze = juisteAntwoord.Next(1, 4);
            string knopAntwoord1 = RandomString(1, userInstellingen.abc1Niveau);
            string knopAntwoord2 = RandomString(1, userInstellingen.abc1Niveau);
            string knopAntwoord3 = RandomString(1, userInstellingen.abc1Niveau);
            string vraag = RandomString(1, userInstellingen.abc1Niveau);
            //check of 1 of meerdere antwoorden overeenkomen
            while (knopAntwoord1 == vraag)
                knopAntwoord1 = RandomString(1, userInstellingen.abc1Niveau);
            while (knopAntwoord2 == vraag || knopAntwoord2 == knopAntwoord1)
                knopAntwoord2 = RandomString(1, userInstellingen.abc1Niveau);
            while (knopAntwoord3 == vraag || knopAntwoord3 == knopAntwoord1 || knopAntwoord3 == knopAntwoord2)
                knopAntwoord3 = RandomString(1, userInstellingen.abc1Niveau);
            switch (knopKeuze)
            {
                case 1:
                    if (userInstellingen.abc1Niveau == 4)
                    {
                        knopAntwoord1 = vraag.ToLower();
                        vraag = vraag.ToUpper();
                    }
                    else { knopAntwoord1 = vraag; }
                    break;
                case 2:
                    if (userInstellingen.abc1Niveau == 4)
                    {
                        knopAntwoord2 = vraag.ToLower();
                        vraag = vraag.ToUpper();
                    }
                    else
                    { knopAntwoord2 = vraag; }
                    break;
                default:
                    if (userInstellingen.abc1Niveau == 4)
                    {
                        knopAntwoord3 = vraag.ToLower();
                        vraag = vraag.ToUpper();
                    }
                    else
                    { knopAntwoord3 = vraag; }
                    break;
            }
            letterWolk.Text = vraag;
            VeranderKleurWolk();
            this.knopAntwoord1.Text = knopAntwoord1;
            this.knopAntwoord2.Text = knopAntwoord2;
            this.knopAntwoord3.Text = knopAntwoord3;
        }

        /// <summary>
        /// check the answer, lower or increase the points and save it to the file. Returns a bool.
        /// </summary>
        /// <param name="antwoord">bool correct answer</param>
        /// <returns></returns>
        public bool ControleerAntwoord(string antwoord)
        {
            if (antwoord.ToLower() == letterWolk.Text.ToLower())
            {
                userInstellingen.abc1Punten++;
                userInstellingen.sterPunten++;
                userInstellingen.SaveInstellingen();
                return true;
            }
            else
            {
                if (userInstellingen.abc1Punten > 0)
                {
                    userInstellingen.abc1Punten--;
                    userInstellingen.SaveInstellingen();
                }                
                return false;
            }
        }

        /// <summary>
        /// change the color of the cloud based on the answer
        /// </summary>
        /// <param name="antwoordJuist">answer</param>
        /// <param name="knop">cloud button</param>
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

        //change the color of the clouds to grey when a new question is asked
        public void VeranderKleurWolk()
        {
            knopAntwoord1.BackgroundImage = Resources.wolkGrijs;
            knopAntwoord2.BackgroundImage = Resources.wolkGrijs;
            knopAntwoord3.BackgroundImage = Resources.wolkGrijs;
        }

        //to do: combine the 3 answering buttons in one method to avoid duplicate code
        private void knopAntwoord1_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord1.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord1");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord)
            {
                if (!userInstellingen.SpeelEvent())
                {
                    AbcLetterScherm child = new AbcLetterScherm(userInstellingen);
                    this.Hide();
                    child.Closed += (s, args) => this.Close();
                    child.ShowDialog();
                }
                else
                {
                    EventInSpel eventScherm = new EventInSpel(userInstellingen);
                    this.Hide();
                    eventScherm.Closed += (s, args) => this.Close();
                    eventScherm.Show();
                }
            }
        }
        //to do: combine the 3 answering buttons in one method to avoid duplicate code
        private void knopAntwoord2_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord2.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord2");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord)
            {
                if (!userInstellingen.SpeelEvent())
                {
                    AbcLetterScherm child = new AbcLetterScherm(userInstellingen);
                    this.Hide();
                    child.Closed += (s, args) => this.Close();
                    child.ShowDialog();
                }
                else
                {
                    EventInSpel eventScherm = new EventInSpel(userInstellingen);
                    this.Hide();
                    eventScherm.Closed += (s, args) => this.Close();
                    eventScherm.Show();
                }
            }
        }
        //to do: combine the 3 answering buttons in one method to avoid duplicate code
        private void knopAntwoord3_Click(object sender, EventArgs e)
        {
            bool antwoord = ControleerAntwoord(knopAntwoord3.Text);
            VeranderKleurWolk(antwoord, "knopAntwoord3");
            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            if (antwoord)
            {
                if (!userInstellingen.SpeelEvent())
                {
                    AbcLetterScherm child = new AbcLetterScherm(userInstellingen);
                    this.Hide();
                    child.Closed += (s, args) => this.Close();
                    child.ShowDialog();
                }
                else
                {
                    EventInSpel eventScherm = new EventInSpel(userInstellingen);
                    this.Hide();
                    eventScherm.Closed += (s, args) => this.Close();
                    eventScherm.Show();
                }
            }
        }

        /// <summary>
        /// creates a random string of a certain length and a certain level.
        /// </summary>
        /// <param name="length">length of string</param>
        /// <param name="niveau">gamelevel</param>
        /// <returns></returns>
        private static string RandomString(int length, int niveau)
        {
            //to do: bring hard coded characters to a config file
            var chars = "";
            switch (niveau)
            {
                case 1:
                    chars = "bikmoprsv";
                    break;
                case 2:
                    chars = "abdegijklmnoprstuvwz";
                    break;
                case 3:
                    chars = "abcdefghijklmnopqrstuvwxyz";
                    break;
                case 4:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                default:
                    chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
            }
            var rand = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
