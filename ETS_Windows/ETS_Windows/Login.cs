using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS_Windows
{
    public partial class Login : Form
    {
        public int attempt = 0;
        public Login()
        {
            InitializeComponent();
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //textBoxUsername.Clear();
            //textBoxPassword.Clear();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (username == "admin" && password == "123")
            {
                this.Visible = false;
                MessageBox.Show("Welcome to the system!");

                ETSMain mainETS = new ETSMain();
                mainETS.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                attempt++;                
            }
            if (attempt == 3)
            {
                MessageBox.Show("You reached the maximum 3 attempts!");
                Environment.Exit(0);
            }            
        }
    }
}
