using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Droomjacht.User;

namespace Droomjacht.Reken
{
    public partial class Rekenen : Droomjacht.Menu
    {
        public int getal1Class;
        public int getal2Class;
        public int somClass;
        public string tekenClass;
        public string typeSomClass;
        private Bitmap MyImage;
        int xSize = 240;
        int ySize = 240;
        string fileLocation = @"C:\Users\Maarten\source\repos\Droomjacht\afbeeldingen\";

        public Rekenen(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            fileLocation = fileLocation + userInstellingen.gebruikersNaam + "\\";
        }

        private Instellingen userInstellingen;

        public void MaakEenSom()
        {
            Random rnd = new Random();
            int maakGetal1 = rnd.Next(0, getal1Class + 1);
            int maakGetal2 = rnd.Next(0, getal2Class + 1);
            //check nog inbouwen dat de som niet groter is dan som
            switch (tekenClass)
            {
                case ":":
                    maakGetal1 = rnd.Next(1, getal1Class + 1);
                    maakGetal2 = rnd.Next(1, getal2Class + 1);
                    while (!(maakGetal1 % maakGetal2 == 0) | maakGetal1 == 0 | maakGetal2 == 0 | maakGetal1 < maakGetal2)
                    {
                        maakGetal1 = rnd.Next(1, getal1Class + 1);
                        maakGetal2 = rnd.Next(1, getal2Class + 1);
                    }
                    break;
                case "-":
                    int getal = maakGetal1;
                    maakGetal1 = maakGetal2;
                    maakGetal2 = getal;
                    break;
            }

            textBox1.Text = Convert.ToString(maakGetal1);
            textBox2.Text = tekenClass;
            textBox3.Text = Convert.ToString(maakGetal2);
            textBox4.Text = typeSomClass;
        }

        public bool CheckDeSom(string input)
        {
            int getal;
            if (int.TryParse(input, out getal))
            {
                int som;
                switch (tekenClass)
                {
                    case "+":
                        som = Int32.Parse(textBox1.Text) + Int32.Parse(textBox3.Text);
                        break;
                    case "-":
                        som = Int32.Parse(textBox1.Text) - Int32.Parse(textBox3.Text);
                        break;
                    case "x":
                        som = Int32.Parse(textBox1.Text) * Int32.Parse(textBox3.Text);
                        break;
                    case ":":
                        som = Int32.Parse(textBox1.Text) / Int32.Parse(textBox3.Text);
                        break;
                    default:
                        som = 0;
                        break;
                }
                if (som == getal)
                {
                    textBox5.BackColor = System.Drawing.Color.LimeGreen;
                    MaakPictureZichtbaar();
                }
                else
                {
                    string antwoord = Convert.ToString(som);
                    textBox5.BackColor = System.Drawing.Color.Red;
                    textBox5.Text = antwoord;                 
                }
                return true;
            }
            else return false;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckDeSom(textBox5.Text))
                {
                    this.Refresh();
                    System.Threading.Thread.Sleep(1500);
                    textBox5.BackColor = System.Drawing.Color.Coral;
                    textBox5.Text = "";
                    MaakEenSom();
                    if ((pictureBoxMiddenboven.Visible == false))
                        {
                            ToonNieuwePicture();
                        }
                    this.Refresh();
                }
                else
                {
                    
                }
            }
        }
        private void ToonNieuwePicture()
        {
            ShowMyImage();
            pictureBoxRechtsonder.Visible = true;
            pictureBoxLinksonder.Visible = true;
            pictureBoxMiddenonder.Visible =true;
            pictureBoxLinksmidden.Visible =true;
            pictureBoxRechtsmidden.Visible = true;
            pictureBoxMidden.Visible = true;
            pictureBoxRechtsboven.Visible =true;
            pictureBoxLinksboven.Visible = true;
            pictureBoxMiddenboven.Visible = true; 
            
        }
        private void MaakPictureZichtbaar()
        {
            if(!(pictureBoxRechtsonder.Visible == false))
            {
                pictureBoxRechtsonder.Visible = false;
            }
            else if (!(pictureBoxLinksonder.Visible == false))
            {
                pictureBoxLinksonder.Visible = false;
            }
            else if (!(pictureBoxMiddenonder.Visible == false))
            {
                pictureBoxMiddenonder.Visible = false;
            }
            else if (!(pictureBoxLinksmidden.Visible == false))
            {
                pictureBoxLinksmidden.Visible = false;
            }
            else if (!(pictureBoxRechtsmidden.Visible == false))
            {
                pictureBoxRechtsmidden.Visible = false;
            }
            else if (!(pictureBoxMidden.Visible == false))
            {
                pictureBoxMidden.Visible = false;
            }
            else if (!(pictureBoxRechtsboven.Visible == false))
            {
                pictureBoxRechtsboven.Visible = false;
            }
            else if (!(pictureBoxLinksboven.Visible == false))
            {
                pictureBoxLinksboven.Visible = false;
            }
            else 
            {
                pictureBoxMiddenboven.Visible = false;
            }
        }

        public void ShowMyImage()
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            var files = Directory.GetFiles(fileLocation, "*.*", SearchOption.AllDirectories);

            List<string> imageFiles = new List<string>();
            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                    imageFiles.Add(filename);
            }

            int aantal = imageFiles.Count;

            Random rnd = new Random();
            int pictureGetal = rnd.Next(0, aantal-1);
            string fileToDisplay = imageFiles[pictureGetal];

            // Stretches the image to fit the pictureBox.
            pictureBoxVerstopt.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBoxVerstopt.ClientSize = new Size(xSize, ySize);
            pictureBoxVerstopt.Image = (Image)MyImage;
        }

    }
}
