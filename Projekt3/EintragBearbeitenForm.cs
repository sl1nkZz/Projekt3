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
    public partial class EintragBearbeitenForm : Form
    {
        user loggedUser;
        DataSet result;
        StartForm startForm;
        public EintragBearbeitenForm(user loggedUser, DataSet result, StartForm startForm)
        {
            this.result = result;
            this.loggedUser = loggedUser;
            this.startForm = startForm;
            InitializeComponent();

            vornameTextBox.Text = (string)result.Tables[0].Rows[0].ItemArray[1];
            nameTextBox.Text = (string)result.Tables[0].Rows[0].ItemArray[2];
            strasseTextBox.Text = (string)result.Tables[0].Rows[0].ItemArray[3];
            hausnrTextBox.Text = Convert.ToString(result.Tables[0].Rows[0].ItemArray[4]);
            plzTextBox.Text = Convert.ToString(result.Tables[0].Rows[0].ItemArray[5]);
            telefonTextBox.Text = (string)result.Tables[0].Rows[0].ItemArray[6];
            ansprechpartnerTextBox.Text = (string)result.Tables[0].Rows[0].ItemArray[7];
        }

        private void kundeBearbeitenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string vorname = vornameTextBox.Text;
                string nachname = nameTextBox.Text;
                string straße = strasseTextBox.Text;
                int hausnummer = Convert.ToInt32(hausnrTextBox.Text);
                int plz = Convert.ToInt32(plzTextBox.Text);
                string telefon = telefonTextBox.Text;
                string ansprechpartner = ansprechpartnerTextBox.Text;
                int id = (int)result.Tables[0].Rows[0].ItemArray[0];
                DateTime currentTime = DateTime.Now;
                querys.updateKunde(vorname, nachname, straße, hausnummer, plz, telefon, ansprechpartner, currentTime, id);
                MessageBox.Show("Bearbeiten erfolgreich.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Bearbeiten.\n\n" + ex.ToString());
            }
        }

        private void kundenLoeschenBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie diesen Eintrag wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)result.Tables[0].Rows[0].ItemArray[0];
                querys.loescheKunden(id);
                MessageBox.Show("Eintrag gelöscht.");
                Close();
            }
            else
            {
                MessageBox.Show("Löschen abgebrochen.");
                Close();
            }
        }
    }
}
