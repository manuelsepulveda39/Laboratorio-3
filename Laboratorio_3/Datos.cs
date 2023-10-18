using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio_3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_3
{
    //Metodos para llevar a cabo el form 2 (Datos)
    public partial class Datos : Form
    {
        //Se crea contador y variable de la clase Amigo Secreto
        int contador = 0;
        public AmigoSecreto amigoSecreto = null;

        //Se igualan las instancias de los formularios para trabajar con los mismos datos
        public Datos(AmigoSecreto amigoSecreto)
        {
            InitializeComponent();
            this.amigoSecreto = amigoSecreto;
        }

        //Metodo boton (ingresar datos del siguiente jugador)
        private void button1_Click(object sender, EventArgs e)
        {
            int cantJuga = amigoSecreto.getCantJuga();

            //Validacion del ingreso de datos 
            if (string.IsNullOrEmpty(nombree.Text) || string.IsNullOrEmpty(correoo.Text) || string.IsNullOrEmpty(endulzadaa.Text) || string.IsNullOrEmpty(regaloo.Text))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                // Se crean las variables para crear un jugador nuevo
                String nombre = nombree.Text;
                String correo = correoo.Text;
                String endulzada = endulzadaa.Text;
                String regalo = regaloo.Text;

                //Se valida que el correo ingresado sea valido
                int posicionArroba = correo.IndexOf("@");
                int posicionPunto = correo.IndexOf(".");
                if(posicionArroba == -1 || posicionPunto == -1)
                {
                    MessageBox.Show("Correo invalido");
                }
                else
                {
                    //Se crea un nuevo jugador
                    amigoSecreto.asignacionJugador(nombre, correo, endulzada, regalo, contador);

                    //Se hacen varias validaciones con el contador
                    if (cantJuga > contador)
                    {
                        contador++;
                        nombree.Clear();
                        correoo.Clear();
                        endulzadaa.Clear();
                        regaloo.Clear();

                    }
                    if (cantJuga - 1 == contador)
                    {
                        button1.Text = "Ver";
                    }
                    if (cantJuga == contador)
                    {
                        //Se llama el siguiente formulario y se oculta este
                        amigoSecreto.asignarAmigo();
                        Informacion informacion = new Informacion(amigoSecreto);
                        informacion.Show();
                        this.Hide();
                    }
                }
            }
        }

        //Metodo para evitar errores de cerrado de pestañas
        private void Datos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
