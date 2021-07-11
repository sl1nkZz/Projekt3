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
    public partial class BenutzerverwaltungForm : Form
    {
        user loggedUser;
        StartForm startForm;
        public BenutzerverwaltungForm(user loggedUser, StartForm startForm)
        {
            this.loggedUser = loggedUser;
            this.startForm = startForm;
            InitializeComponent();

            DataTable result = querys.fetchUser();
            foreach (DataRow rows in result.Rows)
            {
                userList.Items.Add(rows["name"].ToString());
            }
        }

        private void BenutzerverwaltungForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            startForm.Show();
        }

        private void zurueckBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            NeuerBenutzerForm neuerBenutzer = new NeuerBenutzerForm(loggedUser, this);
            neuerBenutzer.ShowDialog();
            DataTable dt = new DataTable();
            dt = querys.usrrefresh();
            userList.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                userList.Items.Add(dr["name"]).ToString();
            }
        }

        private void userDeleteBtn_Click(object sender, EventArgs e)
        {
            string name = userList.SelectedItem.ToString();
            querys.loescheUser(name, loggedUser);
            DataTable dt = new DataTable();
            dt = querys.usrrefresh();
            userList.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                userList.Items.Add(dr["name"]).ToString();
            }
        }
    }
}
