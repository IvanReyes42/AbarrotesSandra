using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbarrotesSandra_IR
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias fc = new FrmCategorias();
            fc.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes fr = new FrmReportes();
            fr.ShowDialog();
        }
    }
}
