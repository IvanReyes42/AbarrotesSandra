﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace AbarrotesSandra_IR
{
    public partial class FrmMenuPrincipal : Form
    {
       public static int op = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.LightSlateGray;
                }
            }
        }

        private void btnVentas_ButtonClick(object sender, EventArgs e)
        {
            if(op == 0)
            {
                op++;
                FrmPuntoDeVenta pv = new FrmPuntoDeVenta();
                pv.MdiParent = this;
                pv.Show();
            }
        }

        private void btnCompras_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmCompras co = new FrmCompras();
                co.MdiParent = this;
                co.Show();
            }
        }

        private void btnProveedores_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmProveedores p = new FrmProveedores();
                p.MdiParent = this;
                p.Show();
            }
        }

        private void btnInventario_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmInventario i = new FrmInventario();
                i.MdiParent = this;
                i.Show();
            }
        }

        private void BtnUsuarios_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmUsuarios u = new FrmUsuarios();
                u.MdiParent = this;
                u.Show();
            }
        }

        private void btnHorarios_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmHorarios h = new FrmHorarios();
                h.MdiParent = this;
                h.Show();
            }
        }

        private void bntReportes_ButtonClick(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op++;
                FrmReportes r = new FrmReportes();
                r.MdiParent = this;
                r.Show();
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion i = new FrmInicioSesion();
            i.Show();
            Close();
        }
    }
}
