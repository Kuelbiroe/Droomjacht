using Droomjacht.Reken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Droomjacht
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.achtergrond;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void RekenKnop_Click(object sender, EventArgs e)
        {
            RekenInstellingen InstellingScherm = new RekenInstellingen("");
            this.Hide();
            InstellingScherm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abcKnop_Click(object sender, EventArgs e)
        {

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
