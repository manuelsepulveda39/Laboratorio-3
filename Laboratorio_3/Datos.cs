﻿using System;
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
    public partial class Datos : Form
    {
        int contador = 0;
        AmigoSecreto amigoSecreto = new AmigoSecreto();
        

        public Datos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantJuga = amigoSecreto.getCantJuga();

            if (string.IsNullOrEmpty(nombree.Text) || string.IsNullOrEmpty(correoo.Text) || string.IsNullOrEmpty(endulzadaa.Text) || string.IsNullOrEmpty(regaloo.Text))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                String nombre = nombree.Text;
                String correo = correoo.Text;
                String endulzada = endulzadaa.Text;
                String regalo = regaloo.Text;

                amigoSecreto.asignacionJugador(nombre, correo, endulzada, regalo, contador);

                if (cantJuga - 1 > contador)
                {
                    contador++;
                    nombree.Clear();
                    correoo.Clear();
                    endulzadaa.Clear();
                    regaloo.Clear();
                }
                if (cantJuga - 2 == contador)
                {
                    button1.Text = "Ver";
                }
                if (cantJuga - 1 == contador)
                {
                    Informacion informacion = new Informacion();
                    informacion.Show();
                    this.Hide();
                }
            }
        }
    }
}
