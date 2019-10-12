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
            Instellingen user = new Instellingen(users[0]);
            string userDataFile = ConfigurationManager.AppSettings[@"user_data_folder"] + gebruikersNaam + ".txt";
            StreamReader sr = new StreamReader(userDataFile);
            string data = sr.ReadLine(); 
            while (!(data == null)) 
            {
                string[] lines = data.Split(',');
                switch (lines[0])
                {
                    case "property":
                        user.property = Int32.Parse(lines[1]);
                        break;
                }
                data = sr.ReadLine();
            } 
            return user;
        }

        private void Knop0_Click(object sender, EventArgs e)
        {
            //https://www.techcoil.com/blog/how-to-save-and-load-objects-to-and-from-file-in-c/
            Instellingen userInstellingen = new Instellingen (users[0]);
            userInstellingen = LoadSettings(users[0]);
            Menu hoofdMenu = new Menu(userInstellingen);
            this.Hide();
            hoofdMenu.ShowDialog();
            this.Close();
        }

        private void Knop1_Click(object sender, EventArgs e)
        {
            Instellingen userInstellingen = new Instellingen(users[1]);
            userInstellingen = LoadSettings(users[1]);
            Menu hoofdMenu = new Menu(userInstellingen);
            this.Hide();
            hoofdMenu.ShowDialog();
            this.Close();
        }

        private void nieuweUserKnop_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
