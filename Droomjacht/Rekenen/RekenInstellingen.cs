using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Droomjacht.User;

namespace Droomjacht.Reken
{
    public partial class RekenInstellingen : Droomjacht.Menu
    {
        public RekenInstellingen()
        {
            InitializeComponent();
        }

        public RekenInstellingen(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
        }

        private Instellingen userInstellingen;

        public void Ophogen(ref TextBox textbox)
        {
            int getal = Int32.Parse(textbox.Text)+1;
            textbox.Text = Convert.ToString(getal);
        }

        public void Verlagen(ref TextBox textbox)
        {
            int getal = Int32.Parse(textbox.Text) - 1;
            textbox.Text = Convert.ToString(getal);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartKnop_Click(object sender, EventArgs e)
        {
            int getal;
            if (int.TryParse(textBox1.Text, out getal) && int.TryParse(textBox3.Text, out getal) && int.TryParse(textBox5.Text, out getal))
            {
                string [] tekenArray = new string[] { "+", "-", ":", "x" };
                string [] somtypeArray = new string[] { "=", "<", ">", "≥", "≤" };
                string checkTeken = textBox2.Text;
                string checkSomtype = textBox4.Text;
                if (tekenArray.Any(checkTeken.Equals) && somtypeArray.Any(checkSomtype.Equals))
                {
                    Rekenen RekenScherm = new Rekenen(userInstellingen);
                    RekenScherm.getal1Class = Int32.Parse(textBox1.Text);
                    RekenScherm.getal2Class = Int32.Parse(textBox3.Text);
                    RekenScherm.somClass = Int32.Parse(textBox5.Text);
                    RekenScherm.tekenClass = textBox2.Text;
                    RekenScherm.typeSomClass = textBox4.Text;

                    RekenScherm.MaakEenSom();
                    RekenScherm.ShowMyImage();
                    this.Hide();
                    RekenScherm.ShowDialog();
                    this.Close();
                }
                else if (!tekenArray.Any(checkTeken.Equals))
                {
                    textBox2.Text = "+";
                }
                else
                {
                    textBox4.Text = "=";
                }
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out getal))
                {
                    textBox1.Text = "1";
                }
                if (!int.TryParse(textBox3.Text, out getal))
                {
                    textBox3.Text = "1";
                }
                if (!int.TryParse(textBox5.Text, out getal))
                {
                    textBox5.Text = "1";
                }

            }
        }

        private void OmhoogKnop1_Click(object sender, EventArgs e)
        {
            Ophogen(ref textBox1);            
        }
        private void OmhoogKnop2_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            { 
                case "+":
                    textBox2.Text = "-";
                    break;
                case "-":
                    textBox2.Text = "x";
                    break;
                case "x":
                    textBox2.Text = ":";
                    break;
                case ":":
                    textBox2.Text = "+";
                    break;
                default:
                    textBox2.Text = "+";
                    break;
            }
        }
        private void OmhoogKnop3_Click(object sender, EventArgs e)
        {
            Ophogen(ref textBox3);
        }
        private void OmhoogKnop4_Click(object sender, EventArgs e)
        {
            switch (textBox4.Text)
            {
                case "=":
                    textBox4.Text = ">";
                    break;
                case ">":
                    textBox4.Text = "≥";
                    break;
                case "≥":
                    textBox4.Text = "<";
                    break;
                case "<":
                    textBox4.Text = "≤";
                    break;
                default:
                    textBox4.Text = "=";
                    break;
            }
        }
        private void OmhoogKnop5_Click(object sender, EventArgs e)
        {
            Ophogen(ref textBox5);
        }
        private void OmlaagKnop1_Click(object sender, EventArgs e)
        {
            Verlagen(ref textBox1);
        }
        private void OmlaagKnop2_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "-":
                    textBox2.Text = "+";
                    break;
                case "x":
                    textBox2.Text = "-";
                    break;
                case ":":
                    textBox2.Text = "x";
                    break;
                case "+":
                    textBox2.Text = ":";
                    break;
                default:
                    textBox2.Text = "+";
                    break;
            }
        }
        private void OmlaagKnop3_Click(object sender, EventArgs e)
        {
            Verlagen(ref textBox3);
        }
        private void OmlaagKnop4_Click(object sender, EventArgs e)
        {
            switch (textBox4.Text)
            {
                case "=":
                    textBox4.Text = "≤";
                    break;
                case "≥":
                    textBox4.Text = ">";
                    break;
                case "<":
                    textBox4.Text = "≥";
                    break;
                case "≤":
                    textBox4.Text = "<";
                    break;
                default:
                    textBox4.Text = "=";
                    break;
            }
        }
        private void OmlaagKnop5_Click(object sender, EventArgs e)
        {
            Verlagen(ref textBox5);
        }

    }
}
