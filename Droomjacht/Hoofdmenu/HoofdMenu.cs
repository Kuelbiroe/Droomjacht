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
        }

        private Instellingen userInstellingen;

        private void RekenKnop_Click(object sender, EventArgs e)
        {
            RekenInstellingen InstellingScherm = new RekenInstellingen(userInstellingen);
            this.Hide();
            InstellingScherm.ShowDialog();
            this.Close();
        }
        
        private void abcKnop_Click(object sender, EventArgs e)
        {
            AbcScherm AbcScherm = new AbcScherm(userInstellingen);
            this.Hide();
            AbcScherm.ShowDialog();
            this.Close();
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
