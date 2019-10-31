using Droomjacht.abc;
using System;
using System.Windows.Forms;
using Droomjacht.Hoofdmenu;
using Droomjacht.User;
using Droomjacht.Rekenen;
using Droomjacht.Event;

namespace Droomjacht
{
    /// <summary>
    /// this is the main form used throughout the application where the menu items are located
    /// </summary>
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(Instellingen user)
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            this.BackgroundImage = Properties.Resources.achtergrond;
            userInstellingen = user;
            ster.Text = userInstellingen.sterPunten.ToString();
        }

        private Instellingen userInstellingen;

        private void RekenKnop_Click(object sender, EventArgs e)
        {
            if (!userInstellingen.SpeelEvent())
            {
                RekenScherm rekenScherm = new RekenScherm(userInstellingen);
                this.Hide();
                rekenScherm.Closed += (s, args) => this.Close();
                rekenScherm.Show();
            }
            else
            {
                EventInSpel eventScherm = new EventInSpel(userInstellingen);
                this.Hide();
                eventScherm.Closed += (s, args) => this.Close();
                eventScherm.Show();
            }
        }

        private void abcKnop_Click(object sender, EventArgs e)
        {
            if (!userInstellingen.SpeelEvent())
            {
                AbcScherm AbcScherm = new AbcScherm(userInstellingen);
                this.Hide();
                AbcScherm.Closed += (s, args) => this.Close();
                AbcScherm.Show();
            }
            else
            {
                EventInSpel eventScherm = new EventInSpel(userInstellingen);
                this.Hide();
                eventScherm.Closed += (s, args) => this.Close();
                eventScherm.Show();
            }
        }

        //to be build
        private void groeneKnop_Click(object sender, EventArgs e)
        {

        }

        //to be build
        private void geleKnop_Click(object sender, EventArgs e)
        {

        }

        //to be build
        private void oranjeKnop_Click(object sender, EventArgs e)
        {

        }

        //to be build
        private void rodeKnop_Click(object sender, EventArgs e)
        {

        }
    }
}
