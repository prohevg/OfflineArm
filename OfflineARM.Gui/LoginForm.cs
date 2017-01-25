using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineARM.Gui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtLogin.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "admin" || txtPassword.Text != "admin")
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
