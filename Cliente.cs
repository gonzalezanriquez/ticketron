﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GrupoB
{


    public partial class Cliente : Form
    {
        Cine miCine;
        public ClienteToCompra t1;
        public ClienteToListCompras t2;
        public ClienteToInicio t3;
        public ClienteToPerfil t4;


        public Cliente(Cine cine)
        {
            miCine = cine;
            InitializeComponent();
            label1.Text = miCine.nombreLogueado();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
        /*IR A LISTADO DE COMPRAS*/
        private void btnBuyTickets_Click(object sender, EventArgs e)
        {
            this.t1();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.t3();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.t2();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.t4();
        }

        public delegate void ClienteToCompra();
        public delegate void ClienteToListCompras();
        public delegate void ClienteToInicio();
        public delegate void ClienteToPerfil();
    }
}
