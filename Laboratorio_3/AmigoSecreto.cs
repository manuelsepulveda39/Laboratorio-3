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
        int numeroAleatorio;

        //Creacion de vector
        public Jugador[] jugadores;

        //Metodo retornar cantidad de jugadores
        public int getCantJuga()
        {
            return cantJuga;
        }

        //Metodo para definir datos del juego
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

        //Metodo para retornar datos de los jugadores
        public String nombreJugador(int i)
        {
            return jugadores[i].getNombre();
        }
        public String correoJugador(int i)
        {
            return jugadores[i].getCorreo();
        }
        public String amigoJugador(int i)
        {
            return jugadores[jugadores[i].getAmigoSecreto()].getNombre();
        }
        public String endulzadaAmigoJugador(int i)
        {
            return jugadores[jugadores[i].getAmigoSecreto()].getEndulzada();
        }
        public String regaloAmigoJugador(int i)
        {
            return jugadores[jugadores[i].getAmigoSecreto()].getRegalo();
        }

        //Metodo asignar jugador a posicion del vector
        public void asignacionJugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal, int i)
        {
            jugadores[i] = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
        }

        //Metodo asignar el amigo secreto a jugador
        public void asignarAmigo()
        {

            Random random = new Random();
            Boolean repetir = true;
            while (repetir)
            {
                numeroAleatorio = random.Next(0, cantJuga - 1);
                if (numeroAleatorio != 0)
                {
                    repetir = false;
                }
            }

            //Se guardan el valor del amigo secreto de cada jugador
            for (int i = 0; i < cantJuga; i++)
            {
                if (numeroAleatorio == cantJuga)
                {
                    numeroAleatorio = 0;
                }
                jugadores[i].setAmigoSecreto(numeroAleatorio);
                numeroAleatorio++;
            }

        }
        //Metodos para retornar datos del juego
        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }
        public DateTime getDescubrimiento()
        {
            return descubrimiento;
        }
        public int getNumEndulzadas()
        {
            return numEndulzadas;
        }
        public int getFrecuencia()
        {
            return frecuencia;
        }
        public int getValorEndulzada()
        {
            return valorEndulzada;
        }
        public int getValorRegalo()
        {
            return valorRegalo;
        }

        //Metodo que retorna cuando es la proxima endulzada
        public String proximaEndulzada()
        {
            if (fechaInicio > DateTime.Now)
            {
                return (fechaInicio).ToString();
            }
            else
            {
                for (int i = 1; i < numEndulzadas; i++)
                {
                    if (fechaInicio.AddDays(frecuencia*i) > DateTime.Now)
                    {
                        return (fechaInicio.AddDays(frecuencia * i).ToString());
                    }
                }
            }
            return "Ya se acabo el juego";
        }
    }
}
