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
    public partial class NeuerKundeForm : Form
    {
        public NeuerKundeForm()
        {
            InitializeComponent();
        }

        private void neuerKundeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                querys.neuerKunde((string)vornameTextBox.Text, nameTextBox.Text, strasseTextBox.Text, Convert.ToInt32(hausnrTextBox.Text), Convert.ToInt32(plzTextBox.Text), telefonTextBox.Text, ansprechpartnerTextBox.Text);
                MessageBox.Show("Anlegen erfolgreich.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Anlegen.\n\n" + ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }
    }
}
