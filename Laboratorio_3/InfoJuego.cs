using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class informacionJuego : Form
    {
        public informacionJuego()
        {
            InitializeComponent();
        }

        private void informacionJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
