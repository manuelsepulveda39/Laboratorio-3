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
    //Metodo para llevar a cabo form 4 (infojuego)
    public partial class InformacionJuego : Form
    {
        AmigoSecreto amigoSecreto = null;

        //Metodo al inicializar el form
        public InformacionJuego(AmigoSecreto amigoSecreto)
        {
            //Se igualan las instancias de la clase AmigoSecreto
            InitializeComponent();
            this.amigoSecreto = amigoSecreto;

            //Se muestran los datos del amigo secreto
            fechaInicioo.Text = amigoSecreto.getFechaInicio().ToString();
            fechaFinn.Text = amigoSecreto.getDescubrimiento().ToString();
            numeroEndulzadass.Text = amigoSecreto.getNumEndulzadas().ToString();
            frecuenciaEndulzadaa.Text = amigoSecreto.getFrecuencia().ToString();
            valorEndulzadaa.Text = amigoSecreto.getValorEndulzada().ToString();
            valorRegaloo.Text = amigoSecreto.getValorRegalo().ToString();
            proximaEndulzadaa.Text = amigoSecreto.proximaEndulzada();
        }


        //Metodo boton (regresar)
        private void button1_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(amigoSecreto);
            this.Hide();
            informacion.Show();
        }

        //Metodo para evitar errores de cerrado de pestañas
        private void informacionJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
