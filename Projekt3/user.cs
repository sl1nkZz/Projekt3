using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3
{
    public class user
    {
        //Anlegen von Eigenschaften der Klasse "user"
        public int ID { get; private set; }
        public string Email { get; private set; }
        private string Passwort { get; set; }
        public string Name { get; private set; }
        public int RechteID { get; private set; }

        //Übergabe von Variablen in die davor angelegten Eigenschaften der Klasse "user" in user
        public user(int id, string email, string passwort, string name, int rechteID)
        {
            ID = id;
            Email = email;
            Passwort = passwort;
            Name = name;
            RechteID = rechteID;
        }
    }
}
