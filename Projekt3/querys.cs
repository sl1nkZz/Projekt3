using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BC = BCrypt.Net.BCrypt;
using System.Windows.Forms;

namespace Projekt3
{
    class querys
    {
        //Methode zum Login
        public static user loginuser(string loginemail, string passwort)
        {
            string sql = "SELECT [ID], [Email], [Password], [Name], [RechteID] FROM [User] WHERE [Email] = @email";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@email", loginemail);
            DataSet result = new DataSet();
            result = connection.dbread(sql, parameters);
            if (result.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                int id = (int)result.Tables[0].Rows[0].ItemArray[0];
                string email = (string)result.Tables[0].Rows[0].ItemArray[1];
                string pw = (string)result.Tables[0].Rows[0].ItemArray[2];
                string name = (string)result.Tables[0].Rows[0].ItemArray[3];
                int rechteID = (int)result.Tables[0].Rows[0].ItemArray[4];
                if (BC.Verify(passwort, pw))
                {
                    user loggedUser = new user(id, email, pw, name, rechteID);
                    return loggedUser;
                }
                else
                {
                    return null;
                }
            }
        }
        public static DataTable fetchCustomers()
        {
            string sql = "SELECT * FROM Kunden2";
            dbconnect connection = new dbconnect();
            DataSet result = new DataSet();
            result = connection.dbread(sql);
            DataTable output = new DataTable();
            output = result.Tables[0];
            return output;
        }

        public static DataTable fetchUser()
        {
            string sql = "SELECT * FROM [User]";
            dbconnect connection = new dbconnect();
            DataSet result = new DataSet();
            result = connection.dbread(sql);
            DataTable output = new DataTable();
            output = result.Tables[0];
            return output;
        }

        public static bool neuerUser(string email, string passwort, string name, int rechteID)
        {
            string sql = "INSERT INTO [User] (Email, Password, Name, RechteID) VALUES (@email, @passwort, @name, @rechteID)";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@email", email);
            parameters.Add("@passwort", passwort);
            parameters.Add("@name", name);
            parameters.Add("@rechteID", rechteID);
            connection.dbwrite(sql, parameters);
            return true;
        }

        internal static DataTable usrrefresh()
        {
            dbconnect connection = new dbconnect();
            string dbrenew = "SELECT * FROM [User]";
            DataSet result = new DataSet();
            result = connection.dbread(dbrenew);
            DataTable dt = new DataTable();
            dt = result.Tables[0];
            return dt;
        }

        internal static DataTable kundenRefresh()
        {
            dbconnect connection = new dbconnect();
            string sql = "SELECT * FROM [Kunden2]";
            DataSet result = new DataSet();
            result = connection.dbread(sql);
            DataTable output = result.Tables[0];
            return output;
        }

        public static void loescheUser(string name, user loggedUser)
        {
            string sql = "DELETE FROM [User] WHERE [Name] = @name";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            if (loggedUser.Name == name)
            {
                MessageBox.Show("Sie können Ihr eigenes Konto nicht löschen.");
            }
            else if (MessageBox.Show("Möchten sie diesen Benutzer wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.dbwrite(sql, parameters);
                MessageBox.Show("Löschen des Benutzers erfolgreich.");
            }
            else
            {
                MessageBox.Show("Löschen des Benutzers abgebrochen.");
            }
        }

        public static bool neuerKunde(string vorname, string name, string straße, int hausnummer, int postleitzahl, string telefon, string ansprechpartner)
        {
            string sql = "INSERT INTO [Kunden2] (Vorname, Name, Straße, Hausnummer, Postleitzahl, Telefonnummer, Ansprechpartner) VALUES (@vorname, @name, @straße, @hausnummer, @postleitzahl, @telefon, @ansprechpartner)";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@vorname", vorname);
            parameters.Add("@name", name);
            parameters.Add("@straße", straße);
            parameters.Add("@hausnummer", hausnummer);
            parameters.Add("@postleitzahl", postleitzahl);
            parameters.Add("@telefon", telefon);
            parameters.Add("@ansprechpartner", ansprechpartner);
            connection.dbwrite(sql, parameters);
            return true;
        }

        public static bool updateKunde(string vorname, string nachname, string straße, int hausnummer, int plz, string telefon, string ansprechpartner,  DateTime currentTime, int id)
        {
            string sql = "UPDATE [Kunden2] SET Vorname = @vorname, Name = @nachname, Straße = @straße, Hausnummer = @hausnr, Postleitzahl = @plz, Telefonnummer = @telefon, Ansprechpartner = @ansprechpartner, last_edited = @last_edited WHERE ID = @id";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@vorname", vorname);
            parameters.Add("@nachname", nachname);
            parameters.Add("@straße", straße);
            parameters.Add("@hausnr", hausnummer);
            parameters.Add("@plz", plz);
            parameters.Add("@telefon", telefon);
            parameters.Add("@ansprechpartner", ansprechpartner);
            parameters.Add("@last_edited", currentTime);
            parameters.Add("@id", id);
            connection.dbwrite(sql, parameters);
            return true;
        }

        public static void loescheKunden(int id)
        {
            string sql = "DELETE FROM [Kunden2] WHERE ID = @id";
            dbconnect connection = new dbconnect();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            connection.dbwrite(sql, parameters);
        }
    }
}
