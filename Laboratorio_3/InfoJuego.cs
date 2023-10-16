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
    public partial class InformacionJuego : Form
    {
        AmigoSecreto amigoSecreto = null;
        DateTime fechaInicio;
        DateTime fechaDescubrimiento;
        int numEndulzada;
        int frecuencia;
        int valorEndulzada;
        int valorRegalo;

        public InformacionJuego(AmigoSecreto amigoSecreto)
        {
            InitializeComponent();
            this.amigoSecreto = amigoSecreto;

            DateTime fechaInicio = amigoSecreto.getFechaInicio();
            DateTime fechaDescubrimiento = amigoSecreto.getDescubrimiento();
            int numEndulzada = amigoSecreto.getNumEndulzadas();
            int frecuencia = amigoSecreto.getFrecuencia();
            int valorEndulzada = amigoSecreto.getValorEndulzada();
            int valorRegalo = amigoSecreto.getValorRegalo();
            String proxima = amigoSecreto.proximaEndulzada();

            fechaInicioo.Text = fechaInicio.ToString();
            fechaFinn.Text = fechaDescubrimiento.ToString();
            numeroEndulzadass.Text = numEndulzada.ToString();
            frecuenciaEndulzadaa.Text = frecuencia.ToString();
            valorEndulzadaa.Text = valorEndulzada.ToString();
            valorRegaloo.Text = valorRegalo.ToString();
            proximaEndulzadaa.Text = proxima;
        }

        private void informacionJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(amigoSecreto);
            this.Hide();
            informacion.Show();
        }
    }
}
