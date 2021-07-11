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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user loggedUser;
            loggedUser = querys.loginuser(emailBox.Text, passwortBox.Text);     //Methodenaufruf (Login)

            if (loggedUser != null)     //Wenn loggedUser nicht leer: Login erfolgreich
            {
                StartForm startForm = new StartForm(loggedUser, this);
                startForm.Show();
                this.Visible = false;
            }
            else    //Wenn loggedUser leer: Login fehlgeschlagen
            {
                MessageBox.Show("Login fehlgeschlagen.");
            }
        }
    }
}
