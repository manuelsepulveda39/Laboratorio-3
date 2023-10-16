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
    public partial class inicio : Form
    {
        public AmigoSecreto amigoSecreto = new AmigoSecreto();

        public inicio()
        {
            InitializeComponent();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            String cantidadJugadores = cantJugadores.Text;
            int cantJuga;
            if (int.TryParse(cantidadJugadores, out cantJuga) && cantJuga>2)
            {
                String numeroEndulzadas = numEndulzadas.Text;
                int numEndul;
                if (int.TryParse(numeroEndulzadas, out numEndul) && numEndul>0)
                {

                    String frecuenciaEndulzadas = frecuenEndulza.Text;
                    int frecuencia;
                    if (int.TryParse(frecuenciaEndulzadas, out frecuencia) && frecuencia>0)
                    {
                        String valorEndulzada = valorEndulza.Text;
                        int valorEndul;
                        if (int.TryParse(valorEndulzada, out valorEndul) && valorEndul > 0)
                        {
                            String valorRegalo = valorRega.Text;
                            int valorReg;
                            if(int.TryParse(valorRegalo, out valorReg) && valorReg > 0)
                            {
                                DateTime fechaInicio = DateTime.Parse(textBoxFechaInicio.Text);
                                DateTime fecha = DateTime.Parse(textBoxFecha.Text);

                                int diasDescubrimiento = frecuencia * numEndul;
                                DateTime descubrimiento = fechaInicio;
                                descubrimiento.AddDays(diasDescubrimiento);

                                
                                amigoSecreto.DatosAmigo(cantJuga, fechaInicio, descubrimiento, numEndul, frecuencia,
                                    valorEndul, valorReg);
                                Datos datos = new Datos(amigoSecreto);
                                this.Hide();
                                datos.ShowDialog();
                            }
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
