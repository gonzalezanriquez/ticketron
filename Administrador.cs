﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP1_GrupoB.Login;

namespace TP1_GrupoB
{
    public partial class Administrador : Form
    {
        private Cine miCine;
        public Bienvenida_a_Usuarios transferencia;
        public Bienvenida_a_Funciones transferencia2;
        public Bienvenida_a_Peliculas transferencia3;
        public Bienvenida_a_Salas transferencia4;
        public cierreSesion transferencia5;


        public Administrador(Cine cine)
        {
            InitializeComponent();
            miCine = cine;

        }



        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.transferencia();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.transferencia3();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            this.transferencia4();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.transferencia2();

        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.transferencia5();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
        }

        public delegate void Bienvenida_a_Usuarios();
        public delegate void Bienvenida_a_Funciones();
        public delegate void Bienvenida_a_Peliculas();
        public delegate void Bienvenida_a_Salas();
        public delegate void cierreSesion();
        public delegate void volver();

    }







}
