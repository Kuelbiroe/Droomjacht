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

namespace Droomjacht.Beginscherm
{
    /// <summary>
    /// starting page for the user where an avatar is welcoming him/her and he/she can choose the category to play. 
    /// </summary>
    public partial class Beginscherm : Droomjacht.Menu
    {
        public Beginscherm()
        {
            InitializeComponent();
        }

        public Beginscherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            TekstBallonVullen(user.gebruikersNaam);
            //to do different avatars per users: show the correct one based on the settings/instellingen.
        }

        /// <summary>
        /// fills the avatars message to the user
        /// </summary>
        private void TekstBallonVullen(string user)
        {
            tekstballon.Text =  "Hoi " + user + "!" + Environment.NewLine + 
                                "Kom je leuk spelen?" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }
    }
}
