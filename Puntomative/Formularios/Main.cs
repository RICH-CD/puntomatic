using Puntomative.Formularios.Usuarios;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuario form_Usuario = new Form_Usuario();
            form_Usuario.Show();

        }
    }
}
