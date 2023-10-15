using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    //Creacion de clase Jugador
    internal class Jugador
    {
        //Definicion de variables
        String nombre;
        String correo;
        String endulzada;
        String regalo;
        int amigoSecreto;

        //
        public Jugador(String nombre, String correo, String endulzada, String regalo)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.endulzada = endulzada;
            this.regalo = regalo;
        }

        //Metodos setters y getters
        public String getNombre()
        {
            return nombre;
        }

        public String getCorreo()
        {
            return correo;
        }

        public String getEndulzada()
        {
            return endulzada;
        }

        public String getRegalo()
        {
            return regalo;
        }

        public int getAMigoSecreto()
        {
            return amigoSecreto;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public void setEndulzada(String endulzada)
        {
            this.endulzada = endulzada;
        }

        public void setRegalo(String regalo)
        {
            this.regalo= regalo;
        }

        public void setAmigoSecreto(int amigoSecreto)
        {
            this.amigoSecreto = amigoSecreto;
        }

    }
}
