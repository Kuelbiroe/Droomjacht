using Droomjacht.abc;
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
using Droomjacht.Rekenen;

namespace Droomjacht.Rekenen
{
    public partial class RekenScherm : Menu
    {
        public RekenScherm() : base()
        {
            InitializeComponent();
        }

        public RekenScherm(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
        }

        private Instellingen userInstellingen = new Instellingen("");

        private void tekenWolk_Click(object sender, EventArgs e)
        {
            Reken.Rekenen rekenscherm = new Reken.Rekenen(userInstellingen);
            //input vanuit niveau regelen...
            rekenscherm.getal1Class = 5;
            rekenscherm.getal2Class = 5;
            rekenscherm.somClass = 10;
            rekenscherm.tekenClass = "+";
            rekenscherm.typeSomClass = "=";

            rekenscherm.MaakEenSom();
            rekenscherm.ShowMyImage();
            rekenscherm.ShowDialog();
            this.Close();
        }
    }
}
