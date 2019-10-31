using Droomjacht.User;
using System;
using System.Windows.Forms;

namespace Droomjacht
{
    /// <summary>
    /// new user can be defined here
    /// </summary>
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
                //to do: save the user to a txt file and add the user to the total list of users (txt file)
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
