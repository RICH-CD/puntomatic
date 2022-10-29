using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puntomative
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUser.Text, txtPass.Text);
            if (usuario.validateCredentials())
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            btnIngreso.Focus();
        }
    }
}
