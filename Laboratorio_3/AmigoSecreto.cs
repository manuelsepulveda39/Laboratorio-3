using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class AmigoSecreto
    {
        int cantJuga;
        DateTime fechaInicio;
        DateTime descubrimiento;
        int numEndulzadas;
        int frecuencia;
        int valorEndulzada;
        int valorRegalo;
        private Jugador[] jugadores;

        public int getCantJuga()
        {
            return cantJuga;
        }

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

            jugadores = new Jugador[cantJuga];
        }

        public void asignacionJugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal, int i)
        {
            jugadores[i] = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
        }

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
