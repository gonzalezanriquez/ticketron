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
    public partial class Compra : Form
    {
        Cine miCine;
        CompraToCliente t1;
        public Compra(Cine miCine)
        {
            InitializeComponent();
            this.miCine = miCine;
        }

        public delegate void CompraToCliente();
    }
}
