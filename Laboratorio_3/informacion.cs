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
    //Metodo para llevar a cabo form 3 (informacion)
    public partial class Informacion : Form
    {
        public AmigoSecreto amigoSecreto = null;
        int contador = 0;
        int numJuga;

        //Metodo al inicializar el formulario
        public Informacion(AmigoSecreto amigoSecreto)
        {
            //Se igualan las instancias de amigoSecreto
            InitializeComponent();
            this.amigoSecreto = amigoSecreto;
            numJuga = amigoSecreto.getCantJuga();

            //Los diferentes Label toman el valor de los datos de los jugadores
            nombree.Text = amigoSecreto.nombreJugador(contador);
            correoo.Text = amigoSecreto.correoJugador(contador);
            amigoSecret.Text = amigoSecreto.amigoJugador(contador);
            endulzadaIdeal.Text = amigoSecreto.endulzadaAmigoJugador(contador);
            regaloIdeal.Text = amigoSecreto.regaloAmigoJugador(contador);
            contador++;
        }

        //Metodo boton (informacion de juego)
        private void button1_Click(object sender, EventArgs e)
        {
            //Se llama el siguiente formulario 
            InformacionJuego informacionJuego = new InformacionJuego(amigoSecreto);
            this.Hide();
            informacionJuego.Show();
        }

        //Metodo boton (siguiente jugador)
        private void siguiente_Click(object sender, EventArgs e)
        {
            //Se crea este condicional para que se repita la informacion
            if (contador == numJuga)
            {
                contador = 0;
            }

            //Se muestra la informacion del siguiente jugador
            nombree.Text = amigoSecreto.nombreJugador(contador);
            correoo.Text = amigoSecreto.correoJugador(contador);
            amigoSecret.Text = amigoSecreto.amigoJugador(contador);
            endulzadaIdeal.Text = amigoSecreto.endulzadaAmigoJugador(contador);
            regaloIdeal.Text = amigoSecreto.regaloAmigoJugador(contador);
            contador++;
        }

        //Metodo para evitar errores de cerrado de pestañas
        private void Informacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
