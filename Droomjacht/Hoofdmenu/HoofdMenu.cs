using Droomjacht.Reken;
using Droomjacht.abc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droomjacht.Hoofdmenu;
using Droomjacht.User;
using Droomjacht.Rekenen;
using Droomjacht.Event;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Droomjacht
{
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

        private void groeneKnop_Click(object sender, EventArgs e)
        {

        }

        private void geleKnop_Click(object sender, EventArgs e)
        {

        }

        private void oranjeKnop_Click(object sender, EventArgs e)
        {

        }

        private void rodeKnop_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
