using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puntomative.Formularios.Usuarios
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
            lbl_IdUsuario.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
