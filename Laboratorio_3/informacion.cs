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
    public partial class Informacion : Form
    {
        public AmigoSecreto amigoSecreto = null;
        int contador = 0;
        int numJuga;

        public Informacion(AmigoSecreto amigoSecreto)
        {
            InitializeComponent();
            this.amigoSecreto = amigoSecreto;
            numJuga = amigoSecreto.getCantJuga();

            nombree.Text = amigoSecreto.nombreJugador(contador);
            correoo.Text = amigoSecreto.correoJugador(contador);
            amigoSecret.Text = amigoSecreto.amigoJugador(contador);
            endulzadaIdeal.Text = amigoSecreto.endulzadaAmigoJugador(contador);
            regaloIdeal.Text = amigoSecreto.regaloAmigoJugador(contador);
            contador++;
        }

        private void Informacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformacionJuego informacionJuego = new InformacionJuego(amigoSecreto);
            this.Hide();
            informacionJuego.Show();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (contador == numJuga - 1)
            {
                contador = 0;
            }
            nombree.Text = amigoSecreto.nombreJugador(contador);
            correoo.Text = amigoSecreto.correoJugador(contador);
            amigoSecret.Text = amigoSecreto.amigoJugador(contador);
            endulzadaIdeal.Text = amigoSecreto.endulzadaAmigoJugador(contador);
            regaloIdeal.Text = amigoSecreto.regaloAmigoJugador(contador);
            contador++;
        }
    }
}
