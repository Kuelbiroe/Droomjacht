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

namespace Droomjacht
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.achtergrond;
        }

        private void JannaKnop_Click(object sender, EventArgs e)
        {
            //https://www.techcoil.com/blog/how-to-save-and-load-objects-to-and-from-file-in-c/
            RekenInstellingen RubenMenu = new RekenInstellingen("Ruben");
            this.Hide();
            RubenMenu.ShowDialog();
            this.Close();
        }

        private void RubenKnop_Click(object sender, EventArgs e)
        {
            //https://www.techcoil.com/blog/how-to-save-and-load-objects-to-and-from-file-in-c/
            RekenInstellingen JannaMenu = new RekenInstellingen("Janna");
            this.Hide();
            JannaMenu.ShowDialog();
            this.Close();
        }

        private void nieuweUserKnop_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
