using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droomjacht.User
{
    public class Instellingen
    {
        public Instellingen(string gebruiker)
        {
            gebruikersNaam=gebruiker;
        }
        public string gebruikersNaam;
        public int sterPunten;
        public int abc1Niveau;
        public int abc1Punten;
        public int reken1Niveau;
        public int reken1Punten;
        public int rekenImage=0;
        public string imageSpel;
        public string eventSpel;
        public string eventTekst;
        public void SaveInstellingen()
        {
            string userName = gebruikersNaam;
            string userDataFile = ConfigurationManager.AppSettings[@"user_data_folder"] + userName + ".txt";
            string[] lines = { @"sterPunten," + sterPunten, "abc1Niveau," + abc1Niveau, "abc1Punten," + abc1Punten, "reken1Niveau," + reken1Niveau,
            "reken1Punten," + reken1Punten };
            System.IO.File.WriteAllLines(userDataFile, lines);
        }
        public bool SpeelEvent()
        {
            if(reken1Punten>25 & reken1Niveau==1)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (reken1Punten > 50 & reken1Niveau == 2)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (reken1Punten > 75 & reken1Niveau == 3)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (reken1Punten > 100 & reken1Niveau == 4)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (reken1Punten > 125 & reken1Niveau == 5)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (reken1Punten > 150 & reken1Niveau == 6)
            {
                reken1Niveau++;
                eventSpel = "rekenPlus";
                return true;
            }
            if (abc1Punten>25 & abc1Niveau == 1)
            {
                abc1Niveau++;
                eventSpel = "letter";
                return true;
            }
            if (abc1Punten > 50 & abc1Niveau == 2)
            {
                abc1Niveau++;
                eventSpel = "letter";
                return true;
            }
            if (abc1Punten > 75 & abc1Niveau == 3)
            {
                abc1Niveau++;
                eventSpel = "letter";
                return true;
            }
            if (abc1Punten > 100 & abc1Niveau == 4)
            {
                abc1Niveau++;
                eventSpel = "letter";
                return true;
            }
            if (sterPunten > 50 & abc1Niveau == 0)
            {
                abc1Niveau++;
                eventSpel = "letterBegin";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
