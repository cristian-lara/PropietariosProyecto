﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietarios
{
    public partial class EliminarFactura : Form
    {
        public EliminarFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facturacion fact = new Facturacion();
            fact.Show();
            this.Hide();
        }

        private void EliminarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }
    }
}
