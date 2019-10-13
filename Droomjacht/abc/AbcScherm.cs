using Droomjacht.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droomjacht.User;

namespace Droomjacht.abc
{
    public partial class AbcScherm : Droomjacht.Menu
    {
        public AbcScherm() : base()
        {
            InitializeComponent();
        }

        public AbcScherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
        }

        private Instellingen userInstellingen = new Instellingen("");

        private void letterSpelKnop_Click(object sender, EventArgs e)
        {
            AbcLetterScherm scherm = new AbcLetterScherm(userInstellingen);
            scherm.ShowDialog();
            this.Close();
        }
    }
}
