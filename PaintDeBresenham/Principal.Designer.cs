namespace PaintDeBresenham
{
    partial class PaintDeBresenham
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.stsCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsCoordenadasDelPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnColorSeleccionado = new System.Windows.Forms.Button();
            this.btnBotonActivo = new System.Windows.Forms.Button();
            this.lblGrosor = new System.Windows.Forms.Label();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.cdgPaletaDeColores = new System.Windows.Forms.ColorDialog();
            this.ofdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.btnCuadradoCirculo = new System.Windows.Forms.Button();
            this.btnPentagonoCirculo = new System.Windows.Forms.Button();
            this.btnTrianguloCirculo = new System.Windows.Forms.Button();
            this.btnPaletaDeColores = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.btnPentagono = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnArco = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.paintArea = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            this.stsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsCoordenadas,
            this.stsSeparator,
            this.stsCoordenadasDelPanel});
            this.stsPrincipal.Location = new System.Drawing.Point(0, 534);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(784, 25);
            this.stsPrincipal.TabIndex = 1;
            this.stsPrincipal.Text = "statusStrip1";
            // 
            // stsCoordenadas
            // 
            this.stsCoordenadas.Name = "stsCoordenadas";
            this.stsCoordenadas.Size = new System.Drawing.Size(155, 20);
            this.stsCoordenadas.Text = "Pixeles en tiempo real";
            // 
            // stsSeparator
            // 
            this.stsSeparator.Name = "stsSeparator";
            this.stsSeparator.Size = new System.Drawing.Size(13, 20);
            this.stsSeparator.Text = "|";
            // 
            // stsCoordenadasDelPanel
            // 
            this.stsCoordenadasDelPanel.Name = "stsCoordenadasDelPanel";
            this.stsCoordenadasDelPanel.Size = new System.Drawing.Size(120, 20);
            this.stsCoordenadasDelPanel.Text = "Pixeles del panel";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPentagonoCirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnCuadradoCirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnTrianguloCirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnColorSeleccionado);
            this.splitContainer1.Panel1.Controls.Add(this.btnBotonActivo);
            this.splitContainer1.Panel1.Controls.Add(this.lblGrosor);
            this.splitContainer1.Panel1.Controls.Add(this.nudGrosor);
            this.splitContainer1.Panel1.Controls.Add(this.btnPaletaDeColores);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrar);
            this.splitContainer1.Panel1.Controls.Add(this.btnPoligono);
            this.splitContainer1.Panel1.Controls.Add(this.btnPentagono);
            this.splitContainer1.Panel1.Controls.Add(this.btnRectangulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnCuadrado);
            this.splitContainer1.Panel1.Controls.Add(this.btnTriangulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnArco);
            this.splitContainer1.Panel1.Controls.Add(this.btnCirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnLinea);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.paintArea);
            this.splitContainer1.Size = new System.Drawing.Size(778, 501);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnColorSeleccionado
            // 
            this.btnColorSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorSeleccionado.BackColor = System.Drawing.Color.Black;
            this.btnColorSeleccionado.Location = new System.Drawing.Point(138, 375);
            this.btnColorSeleccionado.Name = "btnColorSeleccionado";
            this.btnColorSeleccionado.Size = new System.Drawing.Size(58, 58);
            this.btnColorSeleccionado.TabIndex = 15;
            this.btnColorSeleccionado.UseVisualStyleBackColor = false;
            this.btnColorSeleccionado.Click += new System.EventHandler(this.btnColorSeleccionado_Click);
            // 
            // btnBotonActivo
            // 
            this.btnBotonActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBotonActivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBotonActivo.Location = new System.Drawing.Point(10, 375);
            this.btnBotonActivo.Margin = new System.Windows.Forms.Padding(0);
            this.btnBotonActivo.Name = "btnBotonActivo";
            this.btnBotonActivo.Size = new System.Drawing.Size(120, 120);
            this.btnBotonActivo.TabIndex = 14;
            this.btnBotonActivo.UseVisualStyleBackColor = true;
            // 
            // lblGrosor
            // 
            this.lblGrosor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrosor.AutoSize = true;
            this.lblGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosor.Location = new System.Drawing.Point(135, 448);
            this.lblGrosor.Name = "lblGrosor";
            this.lblGrosor.Size = new System.Drawing.Size(63, 17);
            this.lblGrosor.TabIndex = 11;
            this.lblGrosor.Text = "Grosor:";
            // 
            // nudGrosor
            // 
            this.nudGrosor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudGrosor.Location = new System.Drawing.Point(138, 468);
            this.nudGrosor.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(58, 22);
            this.nudGrosor.TabIndex = 13;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ofdAbrirArchivo
            // 
            this.ofdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // btnCuadradoCirculo
            // 
            this.btnCuadradoCirculo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.CuadradoCirculo;
            this.btnCuadradoCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadradoCirculo.Location = new System.Drawing.Point(74, 139);
            this.btnCuadradoCirculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuadradoCirculo.Name = "btnCuadradoCirculo";
            this.btnCuadradoCirculo.Size = new System.Drawing.Size(58, 58);
            this.btnCuadradoCirculo.TabIndex = 7;
            this.btnCuadradoCirculo.UseVisualStyleBackColor = true;
            this.btnCuadradoCirculo.Click += new System.EventHandler(this.btnCuadradoCirculo_Click);
            // 
            // btnPentagonoCirculo
            // 
            this.btnPentagonoCirculo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.PentagonoCirculo;
            this.btnPentagonoCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPentagonoCirculo.Location = new System.Drawing.Point(74, 203);
            this.btnPentagonoCirculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPentagonoCirculo.Name = "btnPentagonoCirculo";
            this.btnPentagonoCirculo.Size = new System.Drawing.Size(58, 58);
            this.btnPentagonoCirculo.TabIndex = 10;
            this.btnPentagonoCirculo.UseVisualStyleBackColor = true;
            this.btnPentagonoCirculo.Click += new System.EventHandler(this.btnPentagonoCirculo_Click);
            // 
            // btnTrianguloCirculo
            // 
            this.btnTrianguloCirculo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.TrianguloCirculo;
            this.btnTrianguloCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrianguloCirculo.Location = new System.Drawing.Point(74, 75);
            this.btnTrianguloCirculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrianguloCirculo.Name = "btnTrianguloCirculo";
            this.btnTrianguloCirculo.Size = new System.Drawing.Size(58, 58);
            this.btnTrianguloCirculo.TabIndex = 4;
            this.btnTrianguloCirculo.UseVisualStyleBackColor = true;
            this.btnTrianguloCirculo.Click += new System.EventHandler(this.btnTrianguloCirculo_Click);
            // 
            // btnPaletaDeColores
            // 
            this.btnPaletaDeColores.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Colores;
            this.btnPaletaDeColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaletaDeColores.Location = new System.Drawing.Point(10, 267);
            this.btnPaletaDeColores.Name = "btnPaletaDeColores";
            this.btnPaletaDeColores.Size = new System.Drawing.Size(58, 58);
            this.btnPaletaDeColores.TabIndex = 12;
            this.btnPaletaDeColores.UseVisualStyleBackColor = true;
            this.btnPaletaDeColores.Click += new System.EventHandler(this.btnPaletaDeColores_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Borrador;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(138, 203);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(58, 58);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPoligono
            // 
            this.btnPoligono.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Poligono;
            this.btnPoligono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoligono.Location = new System.Drawing.Point(138, 139);
            this.btnPoligono.Margin = new System.Windows.Forms.Padding(0);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(58, 58);
            this.btnPoligono.TabIndex = 8;
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // btnPentagono
            // 
            this.btnPentagono.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Pentagono;
            this.btnPentagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPentagono.Location = new System.Drawing.Point(10, 203);
            this.btnPentagono.Margin = new System.Windows.Forms.Padding(0);
            this.btnPentagono.Name = "btnPentagono";
            this.btnPentagono.Size = new System.Drawing.Size(58, 58);
            this.btnPentagono.TabIndex = 9;
            this.btnPentagono.UseVisualStyleBackColor = true;
            this.btnPentagono.Click += new System.EventHandler(this.btnPentagono_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Rectangulo;
            this.btnRectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangulo.Location = new System.Drawing.Point(138, 75);
            this.btnRectangulo.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(58, 58);
            this.btnRectangulo.TabIndex = 5;
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Cuadrado;
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadrado.Location = new System.Drawing.Point(10, 139);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(58, 58);
            this.btnCuadrado.TabIndex = 6;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Triangulo;
            this.btnTriangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangulo.Location = new System.Drawing.Point(10, 75);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(58, 58);
            this.btnTriangulo.TabIndex = 3;
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnArco
            // 
            this.btnArco.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Arco;
            this.btnArco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArco.Location = new System.Drawing.Point(138, 11);
            this.btnArco.Margin = new System.Windows.Forms.Padding(0);
            this.btnArco.Name = "btnArco";
            this.btnArco.Size = new System.Drawing.Size(58, 58);
            this.btnArco.TabIndex = 2;
            this.btnArco.UseVisualStyleBackColor = true;
            this.btnArco.Click += new System.EventHandler(this.btnArco_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Circulo;
            this.btnCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCirculo.Location = new System.Drawing.Point(74, 11);
            this.btnCirculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(58, 58);
            this.btnCirculo.TabIndex = 1;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.BackgroundImage = global::PaintDeBresenham.Properties.Resources.Linea;
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinea.Location = new System.Drawing.Point(10, 11);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(0);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(58, 58);
            this.btnLinea.TabIndex = 0;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // paintArea
            // 
            this.paintArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintArea.BackColor = System.Drawing.Color.White;
            this.paintArea.Location = new System.Drawing.Point(3, 3);
            this.paintArea.Name = "paintArea";
            this.paintArea.Size = new System.Drawing.Size(614, 495);
            this.paintArea.TabIndex = 0;
            this.paintArea.TabStop = false;
            this.paintArea.SizeChanged += new System.EventHandler(this.paintArea_SizeChanged);
            this.paintArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseClick);
            this.paintArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseDown);
            this.paintArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseMove);
            this.paintArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseUp);
            // 
            // PaintDeBresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PaintDeBresenham";
            this.Text = "Paint de Bresenham";
            this.Load += new System.EventHandler(this.PaintDeBresenham_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.stsPrincipal.ResumeLayout(false);
            this.stsPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel stsCoordenadas;
        private System.Windows.Forms.ToolStripStatusLabel stsSeparator;
        private System.Windows.Forms.ToolStripStatusLabel stsCoordenadasDelPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPaletaDeColores;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Button btnPentagono;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnArco;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.ColorDialog cdgPaletaDeColores;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivo;
        private System.Windows.Forms.SaveFileDialog sfdGuardarArchivo;
        private System.Windows.Forms.Button btnColorSeleccionado;
        private System.Windows.Forms.Button btnBotonActivo;
        private System.Windows.Forms.Label lblGrosor;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.PictureBox paintArea;
        private System.Windows.Forms.Button btnPentagonoCirculo;
        private System.Windows.Forms.Button btnCuadradoCirculo;
        private System.Windows.Forms.Button btnTrianguloCirculo;
    }
}

