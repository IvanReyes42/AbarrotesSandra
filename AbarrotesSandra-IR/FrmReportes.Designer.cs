
namespace AbarrotesSandra_IR
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGastos = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInG = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinG = new System.Windows.Forms.DateTimePicker();
            this.btnImprimirGastos = new System.Windows.Forms.Button();
            this.chartGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblVentasTotales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInV = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinV = new System.Windows.Forms.DateTimePicker();
            this.btnImprimirVentas = new System.Windows.Forms.Button();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.btnImprimirInventario = new System.Windows.Forms.Button();
            this.chartInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).BeginInit();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.tabInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGastos);
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Controls.Add(this.tabInventario);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(12, 76);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 497);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabGastos
            // 
            this.tabGastos.Controls.Add(this.pictureBox4);
            this.tabGastos.Controls.Add(this.lblTotalGastos);
            this.tabGastos.Controls.Add(this.label6);
            this.tabGastos.Controls.Add(this.pictureBox5);
            this.tabGastos.Controls.Add(this.label3);
            this.tabGastos.Controls.Add(this.label1);
            this.tabGastos.Controls.Add(this.dtpFechaInG);
            this.tabGastos.Controls.Add(this.dtpFechaFinG);
            this.tabGastos.Controls.Add(this.btnImprimirGastos);
            this.tabGastos.Controls.Add(this.chartGastos);
            this.tabGastos.Location = new System.Drawing.Point(4, 29);
            this.tabGastos.Name = "tabGastos";
            this.tabGastos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGastos.Size = new System.Drawing.Size(956, 464);
            this.tabGastos.TabIndex = 0;
            this.tabGastos.Text = "Gastos";
            this.tabGastos.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Image = global::AbarrotesSandra_IR.Properties.Resources.bagofmoney_5108;
            this.pictureBox4.Location = new System.Drawing.Point(706, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 107;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalGastos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.ForeColor = System.Drawing.Color.Red;
            this.lblTotalGastos.Location = new System.Drawing.Point(772, 141);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(35, 37);
            this.lblTotalGastos.TabIndex = 106;
            this.lblTotalGastos.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(775, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "Gastos Totales:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(697, 103);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(251, 87);
            this.pictureBox5.TabIndex = 102;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Al";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Del";
            // 
            // dtpFechaInG
            // 
            this.dtpFechaInG.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInG.Location = new System.Drawing.Point(722, 36);
            this.dtpFechaInG.Name = "dtpFechaInG";
            this.dtpFechaInG.Size = new System.Drawing.Size(97, 26);
            this.dtpFechaInG.TabIndex = 37;
            this.dtpFechaInG.ValueChanged += new System.EventHandler(this.dtpFechaInG_ValueChanged);
            // 
            // dtpFechaFinG
            // 
            this.dtpFechaFinG.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinG.Location = new System.Drawing.Point(851, 36);
            this.dtpFechaFinG.Name = "dtpFechaFinG";
            this.dtpFechaFinG.Size = new System.Drawing.Size(97, 26);
            this.dtpFechaFinG.TabIndex = 36;
            this.dtpFechaFinG.ValueChanged += new System.EventHandler(this.dtpFechaFinG_ValueChanged);
            // 
            // btnImprimirGastos
            // 
            this.btnImprimirGastos.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirGastos.ForeColor = System.Drawing.Color.White;
            this.btnImprimirGastos.Location = new System.Drawing.Point(788, 399);
            this.btnImprimirGastos.Name = "btnImprimirGastos";
            this.btnImprimirGastos.Size = new System.Drawing.Size(126, 40);
            this.btnImprimirGastos.TabIndex = 20;
            this.btnImprimirGastos.Text = "Imprimir";
            this.btnImprimirGastos.UseVisualStyleBackColor = false;
            this.btnImprimirGastos.Click += new System.EventHandler(this.btnImprimirGastos_Click);
            // 
            // chartGastos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGastos.Legends.Add(legend1);
            this.chartGastos.Location = new System.Drawing.Point(23, 26);
            this.chartGastos.Name = "chartGastos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGastos.Series.Add(series1);
            this.chartGastos.Size = new System.Drawing.Size(659, 413);
            this.chartGastos.TabIndex = 0;
            this.chartGastos.Text = "chart1";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.pictureBox3);
            this.tabVentas.Controls.Add(this.lblVentasTotales);
            this.tabVentas.Controls.Add(this.label8);
            this.tabVentas.Controls.Add(this.pictureBox6);
            this.tabVentas.Controls.Add(this.label4);
            this.tabVentas.Controls.Add(this.label5);
            this.tabVentas.Controls.Add(this.dtpFechaInV);
            this.tabVentas.Controls.Add(this.dtpFechaFinV);
            this.tabVentas.Controls.Add(this.btnImprimirVentas);
            this.tabVentas.Controls.Add(this.chartVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 29);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(956, 464);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = global::AbarrotesSandra_IR.Properties.Resources.cash_register_icon_icons_com_64587;
            this.pictureBox3.Location = new System.Drawing.Point(706, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // lblVentasTotales
            // 
            this.lblVentasTotales.AutoSize = true;
            this.lblVentasTotales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblVentasTotales.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotales.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblVentasTotales.Location = new System.Drawing.Point(772, 141);
            this.lblVentasTotales.Name = "lblVentasTotales";
            this.lblVentasTotales.Size = new System.Drawing.Size(35, 37);
            this.lblVentasTotales.TabIndex = 110;
            this.lblVentasTotales.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(775, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 109;
            this.label8.Text = "Ventas Totales:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(697, 103);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(251, 87);
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Al";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Del";
            // 
            // dtpFechaInV
            // 
            this.dtpFechaInV.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInV.Location = new System.Drawing.Point(722, 36);
            this.dtpFechaInV.Name = "dtpFechaInV";
            this.dtpFechaInV.Size = new System.Drawing.Size(97, 26);
            this.dtpFechaInV.TabIndex = 41;
            this.dtpFechaInV.ValueChanged += new System.EventHandler(this.dtpFechaInV_ValueChanged);
            // 
            // dtpFechaFinV
            // 
            this.dtpFechaFinV.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinV.Location = new System.Drawing.Point(851, 36);
            this.dtpFechaFinV.Name = "dtpFechaFinV";
            this.dtpFechaFinV.Size = new System.Drawing.Size(97, 26);
            this.dtpFechaFinV.TabIndex = 40;
            this.dtpFechaFinV.ValueChanged += new System.EventHandler(this.dtpFechaFinV_ValueChanged);
            // 
            // btnImprimirVentas
            // 
            this.btnImprimirVentas.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirVentas.ForeColor = System.Drawing.Color.White;
            this.btnImprimirVentas.Location = new System.Drawing.Point(788, 399);
            this.btnImprimirVentas.Name = "btnImprimirVentas";
            this.btnImprimirVentas.Size = new System.Drawing.Size(126, 40);
            this.btnImprimirVentas.TabIndex = 22;
            this.btnImprimirVentas.Text = "Imprimir";
            this.btnImprimirVentas.UseVisualStyleBackColor = false;
            this.btnImprimirVentas.Click += new System.EventHandler(this.btnImprimirVentas_Click);
            // 
            // chartVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVentas.Legends.Add(legend2);
            this.chartVentas.Location = new System.Drawing.Point(23, 26);
            this.chartVentas.Name = "chartVentas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVentas.Series.Add(series2);
            this.chartVentas.Size = new System.Drawing.Size(659, 413);
            this.chartVentas.TabIndex = 21;
            this.chartVentas.Text = "chart1";
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.btnImprimirInventario);
            this.tabInventario.Controls.Add(this.chartInventario);
            this.tabInventario.Location = new System.Drawing.Point(4, 29);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(956, 464);
            this.tabInventario.TabIndex = 2;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // btnImprimirInventario
            // 
            this.btnImprimirInventario.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimirInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirInventario.ForeColor = System.Drawing.Color.White;
            this.btnImprimirInventario.Location = new System.Drawing.Point(788, 399);
            this.btnImprimirInventario.Name = "btnImprimirInventario";
            this.btnImprimirInventario.Size = new System.Drawing.Size(126, 40);
            this.btnImprimirInventario.TabIndex = 22;
            this.btnImprimirInventario.Text = "Imprimir";
            this.btnImprimirInventario.UseVisualStyleBackColor = false;
            this.btnImprimirInventario.Click += new System.EventHandler(this.btnImprimirInventario_Click);
            // 
            // chartInventario
            // 
            chartArea3.Name = "ChartArea1";
            this.chartInventario.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartInventario.Legends.Add(legend3);
            this.chartInventario.Location = new System.Drawing.Point(43, 26);
            this.chartInventario.Name = "chartInventario";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartInventario.Series.Add(series3);
            this.chartInventario.Size = new System.Drawing.Size(659, 413);
            this.chartInventario.TabIndex = 21;
            this.chartInventario.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1313, 68);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Location = new System.Drawing.Point(1007, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(48, 48);
            this.pbCerrar.TabIndex = 22;
            this.pbCerrar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AbarrotesSandra_IR.Properties.Resources.iconoregresar;
            this.pictureBox2.Location = new System.Drawing.Point(928, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(989, 585);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGastos.ResumeLayout(false);
            this.tabGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).EndInit();
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.tabInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGastos;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGastos;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.Button btnImprimirGastos;
        private System.Windows.Forms.Button btnImprimirVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Button btnImprimirInventario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInG;
        private System.Windows.Forms.DateTimePicker dtpFechaFinG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInV;
        private System.Windows.Forms.DateTimePicker dtpFechaFinV;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblVentasTotales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}