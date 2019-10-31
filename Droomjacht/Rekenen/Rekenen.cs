using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Droomjacht.Event;
using Droomjacht.User;

namespace Droomjacht.Reken
{
    /// <summary>
    /// creates a sum based on addition that per good answer shows a part of a picture
    /// </summary>
    public partial class Rekenen : Droomjacht.Menu
    {
        //to do: clean up code after direction change
        public Rekenen(Instellingen user) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            fileLocation = fileLocation + userInstellingen.gebruikersNaam + "\\";
            switch (userInstellingen.reken1Niveau)
            {
                case 1:
                    getal1Class = 5;
                    break;
                case 2:
                    getal1Class = 10;
                    break;
                case 3:
                    getal1Class = 20;
                    break;
                case 4:
                    getal1Class = 50;
                    break;
                case 5:
                    getal1Class = 100;
                    break;
                case 6:
                    getal1Class = 500;
                    break;
                default:
                    getal1Class = 1000;
                    break;
            }
            getal2Class = getal1Class;
            tekenClass = "+";
            typeSomClass = "=";
            MaakEenSom();
            MaakPictureZichtbaar();
        }

        public Rekenen(Instellingen user, int maxGetal) : base(user)
        {
            InitializeComponent();
            userInstellingen = user;
            fileLocation = fileLocation + userInstellingen.gebruikersNaam + "\\";
            getal1Class = maxGetal;
            getal2Class = getal1Class;
            tekenClass = "+";
            typeSomClass = "=";
            MaakEenSom();
            MaakPictureZichtbaar();
        }
                
        public int getal1Class;
        public int getal2Class;
        public int somClass;
        public string tekenClass;
        public string typeSomClass;
        private Bitmap MyImage;
        int xSize = 240;
        int ySize = 240;
        string fileLocation = @"C:\Users\Maarten\source\repos\Droomjacht\afbeeldingen\";

        private Instellingen userInstellingen;

        //creates the numbers for a sum
        public void MaakEenSom()
        {
            Random rnd = new Random();
            int maakGetal1 = rnd.Next(0, getal1Class + 1);
            int maakGetal2 = rnd.Next(0, getal2Class + 1);            

            textBox1.Text = Convert.ToString(maakGetal1);
            textBox2.Text = tekenClass;
            textBox3.Text = Convert.ToString(maakGetal2);
            textBox4.Text = typeSomClass;
        }
        /// <summary>
        ///checks the answer, if the answer is correct, a new sum is created, points are given for the correct answer and stored in the datafile. 
        /// </summary>
        /// <param name="input">answer as a string</param>
        /// <returns></returns>
        public bool CheckDeSom(string input)
        {
            int getal;
            if (int.TryParse(input, out getal))
            {
                int som = Int32.Parse(textBox1.Text) + Int32.Parse(textBox3.Text);    
                
                if (som == getal)
                {
                    textBox5.BackColor = System.Drawing.Color.LimeGreen;
                    userInstellingen.reken1Punten++;
                    userInstellingen.sterPunten++;
                    userInstellingen.SaveInstellingen();
                    if (userInstellingen.rekenImage < 9)
                        userInstellingen.rekenImage++;
                    else
                    {
                        userInstellingen.rekenImage = 0;
                        MaakPictureZichtbaar();                                               
                    }
                }
                else
                {
                    string antwoord = Convert.ToString(som);
                    textBox5.BackColor = System.Drawing.Color.Red;
                    textBox5.Text = antwoord;
                    userInstellingen.reken1Punten--;
                    userInstellingen.SaveInstellingen();
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
                    if (!userInstellingen.SpeelEvent())
                    {
                        Rekenen child = new Rekenen(userInstellingen, getal1Class);
                        this.Hide();
                        child.Closed += (s, args) => this.Close();
                        child.ShowDialog();
                    }
                    else
                    {
                        EventInSpel eventScherm = new EventInSpel(userInstellingen);
                        this.Hide();
                        eventScherm.Closed += (s, args) => this.Close();
                        eventScherm.Show();
                    }
                }
                else
                {
                    
                }
            }
        }

        /// <summary>
        /// shows a new picture with all the hiding boxes in front of it and returns its location 
        /// </summary>
        /// <returns>location of picture</returns>
        private string ToonNieuwePicture()
        {
            pictureBoxRechtsonder.Visible = true;
            pictureBoxLinksonder.Visible = true;
            pictureBoxMiddenonder.Visible =true;
            pictureBoxLinksmidden.Visible =true;
            pictureBoxRechtsmidden.Visible = true;
            pictureBoxMidden.Visible = true;
            pictureBoxRechtsboven.Visible =true;
            pictureBoxLinksboven.Visible = true;
            pictureBoxMiddenboven.Visible = true;
            return ShowMyImage();
        }

        /// <summary>
        /// hides the hiding boxes in front of the picture by the parameter imageSpel from the object Instellingen.
        /// </summary>
        private void MaakPictureZichtbaar()
        {
            switch (userInstellingen.rekenImage)
            {
                case 0:
                    userInstellingen.imageSpel=ToonNieuwePicture();
                    break;
                case 1:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxRechtsonder.Invalidate();
                    break;
                case 2:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxLinksonder.Invalidate();
                    break;
                case 3:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxMiddenonder.Invalidate();
                    break;
                case 4:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxLinksmidden.Invalidate();
                    break;
                case 5:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxRechtsmidden.Visible = false;
                    pictureBoxRechtsmidden.Invalidate();
                    break;
                case 6:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxRechtsmidden.Visible = false;
                    pictureBoxMidden.Visible = false;
                    pictureBoxMidden.Invalidate();
                    break;
                case 7:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxRechtsmidden.Visible = false;
                    pictureBoxMidden.Visible = false;
                    pictureBoxRechtsboven.Visible = false;
                    pictureBoxRechtsboven.Invalidate();
                    break;
                case 8:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxRechtsmidden.Visible = false;
                    pictureBoxMidden.Visible = false;
                    pictureBoxRechtsboven.Visible = false;
                    pictureBoxLinksboven.Visible = false;
                    pictureBoxLinksboven.Invalidate();
                    break;
                case 9:
                    ShowMyImage(userInstellingen.imageSpel);
                    pictureBoxRechtsonder.Visible = false;
                    pictureBoxLinksonder.Visible = false;
                    pictureBoxMiddenonder.Visible = false;
                    pictureBoxLinksmidden.Visible = false;
                    pictureBoxRechtsmidden.Visible = false;
                    pictureBoxMidden.Visible = false;
                    pictureBoxRechtsboven.Visible = false;
                    pictureBoxLinksboven.Visible = false;
                    pictureBoxMiddenboven.Visible = false;
                    pictureBoxMiddenboven.Invalidate();
                    this.Refresh();
                    break;
            }
        }

        /// <summary>
        /// shows a new picture at random and returns its location
        /// </summary>
        /// <returns>filelocation</returns>
        public string ShowMyImage()
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
            return fileToDisplay;
        }

        /// <summary>
        /// shows the picture based on the input(its location)
        /// </summary>
        /// <param name="imageLocation">imagelocation</param>
        public void ShowMyImage(string imageLocation)
        {
            // Stretches the image to fit the pictureBox.
            pictureBoxVerstopt.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(imageLocation);
            pictureBoxVerstopt.ClientSize = new Size(xSize, ySize);
            pictureBoxVerstopt.Image = (Image)MyImage;
        }

    }
}
