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
using System.Configuration;
using System.IO;
using Droomjacht.User;
using Droomjacht.Beginscherm;

namespace Droomjacht
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
            LoadUsers();
            this.BackgroundImage = Properties.Resources.achtergrond;
        }

        List<string> users = new List<string>();

        private void LoadUsers()
        {
            string userDataFileLocation = ConfigurationManager.AppSettings[@"user_data"];
            StreamReader sr = new StreamReader(userDataFileLocation);
            string userName = sr.ReadLine();
            
            while (!(userName==null))
            {
                users.Add(userName);
                userName = sr.ReadLine();
            }
            int index=0;
            string buttonName = "";
            foreach (string user in users)
            {
                index = users.IndexOf(user);
                buttonName = "Knop" + index;
                this.Controls[buttonName].Text = user;         
            }
            if (users.Count < 6)
            {
                buttonName = "Knop" + users.Count;
                this.Controls[buttonName].Text = "+";
            }
            for (int i=users.Count+1; i<6; i++)
            {
                buttonName = "Knop" + i;
                this.Controls[buttonName].Visible=false;
            }
        }

        private Instellingen LoadSettings(string gebruikersNaam)
        {
            int teller = 0;
            string gebruiker = users[teller];
            while (!(gebruikersNaam == users[teller]))
            { teller++;              
            }
            Instellingen user = new Instellingen(users[teller]);
            string userDataFile = ConfigurationManager.AppSettings[@"user_data_folder"] + gebruikersNaam + ".txt";
            StreamReader sr = new StreamReader(userDataFile);
            string data = sr.ReadLine(); 
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

        private void Knop0_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop0.Text);
        }

        private void Knop1_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop1.Text);
        }

        private void Knop2_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop2.Text);
        }

        private void Knop3_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop3.Text);
        }

        private void Knop4_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop4.Text);
        }

        private void Knop5_Click(object sender, EventArgs e)
        {
            OpenNieuwScherm(Knop5.Text);
        }

        private void OpenNieuwScherm (string user)
        {
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
    }
}
