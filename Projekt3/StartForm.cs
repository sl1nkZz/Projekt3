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
    public partial class StartForm : Form
    {
        user loggedUser;
        LoginForm loginform;
        public StartForm(user loggedUser, LoginForm loginform)
        {
            this.loggedUser = loggedUser;
            this.loginform = loginform;
            InitializeComponent();

            kundenDatenView.DataSource = querys.fetchCustomers();
        }
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginform.Close();
        }

        private void beendenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform.Close();
        }

        private void benutzerverwaltungBtn_Click(object sender, EventArgs e)
        {
            BenutzerverwaltungForm benutzerverwaltung = new BenutzerverwaltungForm(loggedUser, this);
            if (loggedUser.RechteID == 1)
            {
                benutzerverwaltung.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Sie haben nicht die benötigten Berechtigungen diesen Bereich zu nutzen.");
            }
        }

        private void neuerEintragBtn_Click(object sender, EventArgs e)
        {
            NeuerKundeForm neuerKunde = new NeuerKundeForm();
            neuerKunde.ShowDialog();
            kundenDatenView.DataSource = null;
            kundenDatenView.DataSource = querys.kundenRefresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbconnect connection = new dbconnect();

            DataRow row = (kundenDatenView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            string sql = "SELECT * FROM [Kunden2] WHERE ID = " + row["ID"];
            DataSet result = connection.dbread(sql);
            EintragBearbeitenForm eintragBearbeiten = new EintragBearbeitenForm(loggedUser, result, this);
            eintragBearbeiten.ShowDialog();
            kundenDatenView.DataSource = null;
            kundenDatenView.DataSource = querys.kundenRefresh();
        }
    }
}
