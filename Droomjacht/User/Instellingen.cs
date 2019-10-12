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
        public int property;
        
    }
}
