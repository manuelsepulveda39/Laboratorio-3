using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    //Creacion de clase AmigoSecreto
    public class AmigoSecreto
    {
        //Definicion de variables
        int cantJuga;
        DateTime fechaInicio;
        DateTime descubrimiento;
        int numEndulzadas;
        int frecuencia;
        int valorEndulzada;
        int valorRegalo; 

        //Creacion de vector
        private Jugador[] jugadores;

        //Metodo retornar cantidad de jugadores
        public int getCantJuga()
        {
            return cantJuga;
        }

        //
        public  void DatosAmigo(int cantJuga, DateTime fechaInicio, DateTime descubirmiento, int numEndulzadas, int frecuencia,
            int valorEndulzada, int valorRegalo)
        {
            this.cantJuga = cantJuga;
            this.fechaInicio = fechaInicio;
            this.descubrimiento = descubirmiento;
            this.numEndulzadas = numEndulzadas;
            this.frecuencia = frecuencia;
            this.valorEndulzada = valorEndulzada;
            this.valorRegalo = valorRegalo;
            
        }

        //Metodo asignar jugador a posicion del vector
        public void asignacionJugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal, int i)
        {
            Jugador[] jugadores = new Jugador[cantJuga];
            jugadores[i] = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
        }

        //Metodo asignar el amigo secreto a jugador
        public void asignarAmigo()
        {
            Random random = new Random();
            int[] numerosAleatorios = new int[cantJuga];

            int numeroMaximo = cantJuga;

            for (int i = 0; i < cantJuga; i++)
            {
                int numeroAleatorio;
                bool repetido;

                do
                {
                    numeroAleatorio = random.Next(1, numeroMaximo + 1);
                    repetido = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (numerosAleatorios[j] == numeroAleatorio)
                        {
                            repetido = true;
                            break;
                        }
                    }
                }
                while (repetido);

                numerosAleatorios[i] = numeroAleatorio;
            }

            for (int i = 0; i < cantJuga; i++)
            {
                int indiceAmigoSecreto = numerosAleatorios[i];
                Jugador jugadorActual = jugadores[i];
                jugadorActual.setAmigoSecreto(indiceAmigoSecreto);
            }

        }

    }
}
