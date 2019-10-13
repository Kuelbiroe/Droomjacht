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
    public partial class Beginscherm : Droomjacht.Menu
    {
        public Beginscherm()
        {
            
            InitializeComponent();
        }

        public Beginscherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            TekstBallonVullen(user.gebruikersNaam);
            //juiste avatar laden nog inbouwen.
        }

        private Instellingen userInstellingen = new Instellingen("");

        private void TekstBallonVullen(string user)
        {
            tekstballon.Text = "Hoi " + user + "!" + Environment.NewLine + "Kom je leuk spelen?" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }
    }
}
