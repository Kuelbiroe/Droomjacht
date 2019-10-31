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

namespace Droomjacht
{
    public partial class NieuweGebruiker : Form
    {
        public NieuweGebruiker()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.achtergrond;
        }

        private void nameBox_Clicked(object sender, EventArgs e)
        {
            nameBox.Text = "";
        }
        private void nameBox_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                Instellingen userInstellingen = new Instellingen(nameBox.Text);
                //to do  userInstellingen.NieuweGebruikerAanmaken(nameBox.Text);
                Beginscherm.Beginscherm beginScherm = new Beginscherm.Beginscherm(userInstellingen);
                this.Hide();
                beginScherm.Closed += (s, args) => this.Close();
                beginScherm.Show();
            }
            else
            {

            }
        }
    }
}
