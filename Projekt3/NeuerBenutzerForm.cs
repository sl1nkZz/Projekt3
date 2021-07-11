using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class NeuerBenutzerForm : Form
    {
        user loggedUser;
        BenutzerverwaltungForm benutzerverwaltung;
        public NeuerBenutzerForm(user loggedUser, BenutzerverwaltungForm benutzerverwaltung)
        {
            this.loggedUser = loggedUser;
            this.benutzerverwaltung = benutzerverwaltung;
            InitializeComponent();
        }

        bool IsValidEmail(string email) 
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(emailTextBox.Text))
            {
                string hashedPasswort = BCrypt.Net.BCrypt.HashPassword(passwortTextBox.Text);
                int rechteID;

                if (adminRadio.Checked)
                {
                    rechteID = 1;
                }
                else
                {
                    rechteID = 0;
                }
                try
                {
                    if (querys.neuerUser((string)emailTextBox.Text, hashedPasswort, (string)nameTextBox.Text, rechteID))
                    {
                        MessageBox.Show("Benutzer erfolgreich angelegt.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Benutzer anlegen fehlgeschlagen.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Die eingegebene E-Mail-Adresse hat das falsche Format.\nBitte korrigieren Sie die Eingabe und versuchen es erneuet.");
            }
        }
    }
}
