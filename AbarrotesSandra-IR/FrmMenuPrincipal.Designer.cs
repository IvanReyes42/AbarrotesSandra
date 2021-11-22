
namespace AbarrotesSandra_IR
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb1 = new System.Windows.Forms.ToolStripButton();
            this.tsb2 = new System.Windows.Forms.ToolStripButton();
            this.tsbVentas = new System.Windows.Forms.ToolStripButton();
            this.tsbCompras = new System.Windows.Forms.ToolStripButton();
            this.tsbProveedores = new System.Windows.Forms.ToolStripButton();
            this.tsbInventario = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbHorarios = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menu Principal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1572, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.DimGray;
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Image = global::AbarrotesSandra_IR.Properties.Resources.iconoregresar;
            this.pbSalir.Location = new System.Drawing.Point(1310, 4);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(48, 48);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 24;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb1,
            this.tsb2,
            this.tsbVentas,
            this.tsbCompras,
            this.tsbProveedores,
            this.tsbInventario,
            this.tsbUsuarios,
            this.tsbHorarios,
            this.tsbReportes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(69, 706);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb1
            // 
            this.tsb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb1.Image = ((System.Drawing.Image)(resources.GetObject("tsb1.Image")));
            this.tsb1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb1.Name = "tsb1";
            this.tsb1.Size = new System.Drawing.Size(66, 20);
            this.tsb1.Text = "toolStripButton1";
            // 
            // tsb2
            // 
            this.tsb2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb2.Image = ((System.Drawing.Image)(resources.GetObject("tsb2.Image")));
            this.tsb2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb2.Name = "tsb2";
            this.tsb2.Size = new System.Drawing.Size(66, 20);
            this.tsb2.Text = "toolStripButton1";
            // 
            // tsbVentas
            // 
            this.tsbVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVentas.Image = ((System.Drawing.Image)(resources.GetObject("tsbVentas.Image")));
            this.tsbVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVentas.Name = "tsbVentas";
            this.tsbVentas.Size = new System.Drawing.Size(66, 68);
            this.tsbVentas.Text = "Ventas";
            this.tsbVentas.Click += new System.EventHandler(this.tsbVentas_Click);
            // 
            // tsbCompras
            // 
            this.tsbCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCompras.Image = ((System.Drawing.Image)(resources.GetObject("tsbCompras.Image")));
            this.tsbCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCompras.Name = "tsbCompras";
            this.tsbCompras.Size = new System.Drawing.Size(66, 68);
            this.tsbCompras.Text = "Compras";
            this.tsbCompras.Click += new System.EventHandler(this.tsbCompras_Click);
            // 
            // tsbProveedores
            // 
            this.tsbProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProveedores.Image = ((System.Drawing.Image)(resources.GetObject("tsbProveedores.Image")));
            this.tsbProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProveedores.Name = "tsbProveedores";
            this.tsbProveedores.Size = new System.Drawing.Size(66, 68);
            this.tsbProveedores.Text = "Proveedores";
            this.tsbProveedores.Click += new System.EventHandler(this.tsbProveedores_Click);
            // 
            // tsbInventario
            // 
            this.tsbInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInventario.Image = ((System.Drawing.Image)(resources.GetObject("tsbInventario.Image")));
            this.tsbInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventario.Name = "tsbInventario";
            this.tsbInventario.Size = new System.Drawing.Size(66, 68);
            this.tsbInventario.Text = "Inventario";
            this.tsbInventario.Click += new System.EventHandler(this.tsbInventario_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(66, 68);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbHorarios
            // 
            this.tsbHorarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHorarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbHorarios.Image")));
            this.tsbHorarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHorarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHorarios.Name = "tsbHorarios";
            this.tsbHorarios.Size = new System.Drawing.Size(66, 68);
            this.tsbHorarios.Text = "Horarios";
            this.tsbHorarios.Click += new System.EventHandler(this.tsbHorarios_Click);
            // 
            // tsbReportes
            // 
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReportes.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportes.Image")));
            this.tsbReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(66, 68);
            this.tsbReportes.Text = "Reportes";
            this.tsbReportes.Click += new System.EventHandler(this.tsbReportes_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 706);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb1;
        private System.Windows.Forms.ToolStripButton tsb2;
        private System.Windows.Forms.ToolStripButton tsbVentas;
        private System.Windows.Forms.ToolStripButton tsbCompras;
        private System.Windows.Forms.ToolStripButton tsbProveedores;
        private System.Windows.Forms.ToolStripButton tsbInventario;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbHorarios;
        private System.Windows.Forms.ToolStripButton tsbReportes;
    }
}