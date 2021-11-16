using Manejadores;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AbarrotesSandra_IR
{
    public partial class FrmReportes : Form
    {
        ManejadorReportes mr;

        public FrmReportes()
        {
            InitializeComponent();
            mr = new ManejadorReportes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void btnImprimirGastos_Click(object sender, EventArgs e)
        {
            chartGastos.Printing.PrintDocument.Print(); 
        }

        public void Actualizar()
        {
            try
            {
                GraficarGastos();
                GraficarVentas();
                GraficarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar gráficas!");
            }
        }

        public void GraficarGastos()
        {
            chartGastos.Titles.Clear();
            chartGastos.Series.Clear();
            chartGastos.ChartAreas.Clear();
            chartGastos.Palette = ChartColorPalette.Excel;

            ChartArea area = new ChartArea();
            //area.Area3DStyle.Enable3D = true;
            chartGastos.ChartAreas.Add(area);

            Title titulo = new Title("Gastos  del  " + dtpFechaInG.Text + "  al  " + dtpFechaFinG.Text);
            titulo.Font = new Font("Arial", 14, FontStyle.Bold);
            chartGastos.Titles.Add(titulo);

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Bar;
            serie.XValueMember = "Producto";
            serie.YValueMembers = "Gasto";
            serie.Font = new Font("Arial", 12, FontStyle.Regular);
            serie.Color = Color.Orange;
            serie.IsValueShownAsLabel = true;
            chartGastos.Series.Add(serie);

            chartGastos.DataSource = mr.ConsultarGastos(dtpFechaInG.Text, dtpFechaFinG.Text);
            lblTotalGastos.Text = "$ " + mr.ConsultarTotalGastos(dtpFechaInG.Text, dtpFechaFinG.Text);
        }

        public void GraficarVentas()
        {
            chartVentas.Titles.Clear();
            chartVentas.Series.Clear();
            chartVentas.ChartAreas.Clear();
            chartVentas.Palette = ChartColorPalette.Excel;

            ChartArea area = new ChartArea();
            //area.Area3DStyle.Enable3D = true;
            chartVentas.ChartAreas.Add(area);

            Title titulo = new Title("Ventas  del  " + dtpFechaInV.Text + "  al  " + dtpFechaFinV.Text);
            titulo.Font = new Font("Arial", 14, FontStyle.Bold);
            chartVentas.Titles.Add(titulo);

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Bar;
            serie.XValueMember = "Producto";
            serie.YValueMembers = "Total";
            serie.Font = new Font("Arial", 12, FontStyle.Regular);
            serie.Color = Color.Orange;
            serie.IsValueShownAsLabel = true;
            chartVentas.Series.Add(serie);

            chartVentas.DataSource = mr.ConsultarVentas(dtpFechaInV.Text, dtpFechaFinV.Text);
            lblVentasTotales.Text = "$ " + mr.ConsultarTotalVentas(dtpFechaInV.Text, dtpFechaFinV.Text);
        }

        public void GraficarInventario()
        {
            chartInventario.Titles.Clear();
            chartInventario.Series.Clear();
            chartInventario.ChartAreas.Clear();
            chartInventario.Palette = ChartColorPalette.Excel;

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chartInventario.ChartAreas.Add(area);

            Title titulo = new Title("Almacen");
            titulo.Font = new Font("Arial", 14, FontStyle.Bold);
            chartInventario.Titles.Add(titulo);

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.XValueMember = "Producto";
            serie.YValueMembers = "Cantidad Existente";
            serie.Font = new Font("Arial", 12, FontStyle.Regular);
            serie.LabelForeColor = Color.Black;
            serie.IsValueShownAsLabel = true;
            chartInventario.Series.Add(serie);

            chartInventario.DataSource = mr.ConsultarInventario();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtpFechaInG_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtpFechaFinG_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtpFechaInV_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtpFechaFinV_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnImprimirVentas_Click(object sender, EventArgs e)
        {
            chartVentas.Printing.PrintDocument.Print();
        }

        private void btnImprimirInventario_Click(object sender, EventArgs e)
        {
            chartInventario.Printing.PrintDocument.Print();
        }
    }
}
