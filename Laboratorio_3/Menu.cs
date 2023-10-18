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
    //Metodos para llevar a cabo form 1 (Menu)
    public partial class inicio : Form
    {
        //Se crea la instancia de la clase de AmigoSecreto
        public AmigoSecreto amigoSecreto = new AmigoSecreto();

        public inicio()
        {
            InitializeComponent();
        }

        //Metodo guardar y validar informacion del menu
        private void continuar_Click(object sender, EventArgs e)
        {
            //Recibe dato CANTIDAD DE JUGADORES
            String cantidadJugadores = cantJugadores.Text;
            int cantJuga;

            if (int.TryParse(cantidadJugadores, out cantJuga) && cantJuga>2)
            {
                //Recibe dato NUMERO DE ENDULZADAS
                String numeroEndulzadas = numEndulzadas.Text;
                int numEndul;

                if (int.TryParse(numeroEndulzadas, out numEndul) && numEndul>0)
                {
                    //Recibe dato FRECUENCIA DE ENDULZADAS
                    String frecuenciaEndulzadas = frecuenEndulza.Text;
                    int frecuencia;

                    if (int.TryParse(frecuenciaEndulzadas, out frecuencia) && frecuencia>0)
                    {
                        //Recibe dato VALOR ENDULZADA
                        String valorEndulzada = valorEndulza.Text;
                        int valorEndul;

                        if (int.TryParse(valorEndulzada, out valorEndul) && valorEndul > 0)
                        {
                            //Recibe dato VALOR REGALO
                            String valorRegalo = valorRega.Text;
                            int valorReg;

                            if(int.TryParse(valorRegalo, out valorReg) && valorReg > 0)
                            {
                                // Recibe dato de la fecha de inicio
                                DateTime fechaInicio = DateTime.Parse(textBoxFechaInicio.Text);

                                //Se calcula dia del descubrimiento
                                int diasDescubrimiento = frecuencia * numEndul;
                                DateTime descubrimiento = fechaInicio.AddDays(diasDescubrimiento);

                                //Se guardan todos los datos en la clase de AmigoSecreto
                                amigoSecreto.DatosAmigo(cantJuga, fechaInicio, descubrimiento, numEndul, frecuencia,
                                    valorEndul, valorReg);
                                Datos datos = new Datos(amigoSecreto);

                                //Se muestra el siguiente formulario y se oculta este
                                this.Hide();
                                datos.ShowDialog();
                            }

                            //Validaciones de datos
                            else
                            {
                                MessageBox.Show("El valor del regalo debe ser un numero mayor a 0");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor de la endulzada debe ser un numero mayor a 0");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La frecuencia de las endulzadas debe ser un numero mayor a 0");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad de endulzadas debe ser un numero entero mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("La cantidad de jugadores debe ser un numero entero mayor a 2");
            }
        }
    }
}
