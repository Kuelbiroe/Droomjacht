using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Droomjacht.User;

namespace Droomjacht
{
    ///<summary>
    ///First screen showing all users and the option to create a new user.
    ///</summary>
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
            LoadUsers();
            this.BackgroundImage = Properties.Resources.achtergrond;
        }

        private List<string> users = new List<string>();

        private void Knop0_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop0.Text);
        private void Knop1_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop1.Text);
        private void Knop2_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop2.Text);
        private void Knop3_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop3.Text);
        private void Knop4_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop4.Text);
        private void Knop5_Click(object sender, EventArgs e) => OpenNieuwScherm(Knop5.Text);

        /// <summary>
        /// Opens a new form with the users previous results or opens a new form to create a new account.
        /// </summary>
        private void OpenNieuwScherm(string user)
        {
            //checks if it's an existing user
            if (!(user == "+"))
            {
                Instellingen userInstellingen = new Instellingen(user);
                userInstellingen = LoadSettings(user);
                Beginscherm.Beginscherm beginScherm = new Beginscherm.Beginscherm(userInstellingen);
                this.Hide();
                beginScherm.Closed += (s, args) => this.Close();
                beginScherm.Show();
            }
            else
            {
                var nieuweGebruikerScherm = new NieuweGebruiker();
                this.Hide();
                nieuweGebruikerScherm.Closed += (s, args) => this.Close();
                nieuweGebruikerScherm.Show();
            }
        }               

        /// <summary>
        /// gets all users from the userDataFile, displays a button per user and an extra button for new users.
        /// </summary>
        private void LoadUsers()
        {
            int index = 0;
            string buttonName = "";
            //to do: check if the file is already made, if not: create the file
            string userDataFileLocation = ConfigurationManager.AppSettings[@"user_data"];
            StreamReader sr = new StreamReader(userDataFileLocation);

            //reads all lines of the file and adds each user to the users list.
            string userName = sr.ReadLine();
            while (!(userName==null))
            {
                users.Add(userName);
                userName = sr.ReadLine();
            }
            
            //generates a button for each user
            foreach (string user in users)
            {
                index = users.IndexOf(user);
                buttonName = "Knop" + index;
                this.Controls[buttonName].Text = user;         
            }

            //adds a button for a new user if there is enough room (current amount of users is below 6).
            if (users.Count < 6)
            {
                buttonName = "Knop" + users.Count;
                this.Controls[buttonName].Text = "+";
            }

            //makes the buttons that aren't used invisible
            for (int i=users.Count+1; i<6; i++)
            {
                buttonName = "Knop" + i;
                this.Controls[buttonName].Visible=false;
            }
        }

        /// <summary>
        /// gets all the data from the user out the datafile and returns the data as an instellingen object.
        /// </summary>
        private Instellingen LoadSettings(string gebruikersNaam)
        {
            Instellingen user = new Instellingen(gebruikersNaam);
            //to do: check if the file is indeed present, if not create it.
            string userDataFile = ConfigurationManager.AppSettings[@"user_data_folder"] + gebruikersNaam + ".txt";
            StreamReader sr = new StreamReader(userDataFile);
            string data = sr.ReadLine();

            //read all lines and adds the data of the lines to the Instellingen object (user).
            while (!(data == null)) 
            {
                string[] lines = data.Split(',');
                switch (lines[0])
                {
                    case "sterPunten":
                        user.sterPunten = Int32.Parse(lines[1]);
                        break;
                    case "abc1Niveau":
                        user.abc1Niveau = Int32.Parse(lines[1]);
                        break;
                    case "abc1Punten":
                        user.abc1Punten = Int32.Parse(lines[1]);
                        break;
                    case "reken1Niveau":
                        user.reken1Niveau = Int32.Parse(lines[1]);
                        break;
                    case "reken1Punten":
                        user.reken1Punten = Int32.Parse(lines[1]);
                        break;
                }
                data = sr.ReadLine();
            } 
            return user;
        }               
    }
}
