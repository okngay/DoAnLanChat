using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void btConnect_Click(object sender, EventArgs e)
        {

            Client f1 = new Client();
            f1.UserName = textUserName.Text;
            f1.Show();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
