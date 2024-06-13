
namespace FiguraGeometrica
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CALC = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ESFERA = new System.Windows.Forms.RadioButton();
            this.PRISMA = new System.Windows.Forms.RadioButton();
            this.CUBO = new System.Windows.Forms.RadioButton();
            this.CIRCULO = new System.Windows.Forms.RadioButton();
            this.DATOS = new System.Windows.Forms.TextBox();
            this.POLIIRREC = new System.Windows.Forms.RadioButton();
            this.POLIREG = new System.Windows.Forms.RadioButton();
            this.RECTANGULO = new System.Windows.Forms.RadioButton();
            this.TRIANGULO = new System.Windows.Forms.RadioButton();
            this.CUADRADO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.EXPORT = new System.Windows.Forms.Button();
            this.DUBUJAR = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.INFORMACION = new System.Windows.Forms.RichTextBox();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CALC);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DATOS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EXPORT);
            this.groupBox1.Controls.Add(this.DUBUJAR);
            this.groupBox1.Controls.Add(this.INFO);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(832, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CALC
            // 
            this.CALC.Location = new System.Drawing.Point(521, 76);
            this.CALC.Margin = new System.Windows.Forms.Padding(4);
            this.CALC.Name = "CALC";
            this.CALC.Size = new System.Drawing.Size(100, 28);
            this.CALC.TabIndex = 16;
            this.CALC.Text = "CALCULAR";
            this.CALC.UseVisualStyleBackColor = true;
            this.CALC.Click += new System.EventHandler(this.CALC_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(401, 76);
            this.LIMPIAR.Margin = new System.Windows.Forms.Padding(4);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(100, 28);
            this.LIMPIAR.TabIndex = 15;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO ETC";
            // 
            // ESFERA
            // 
            this.ESFERA.AutoSize = true;
            this.ESFERA.ForeColor = System.Drawing.Color.Fuchsia;
            this.ESFERA.Location = new System.Drawing.Point(663, 301);
            this.ESFERA.Margin = new System.Windows.Forms.Padding(4);
            this.ESFERA.Name = "ESFERA";
            this.ESFERA.Size = new System.Drawing.Size(82, 20);
            this.ESFERA.TabIndex = 13;
            this.ESFERA.TabStop = true;
            this.ESFERA.Text = "ESFERA";
            this.ESFERA.UseVisualStyleBackColor = true;
            // 
            // PRISMA
            // 
            this.PRISMA.AutoSize = true;
            this.PRISMA.ForeColor = System.Drawing.Color.Fuchsia;
            this.PRISMA.Location = new System.Drawing.Point(663, 329);
            this.PRISMA.Margin = new System.Windows.Forms.Padding(4);
            this.PRISMA.Name = "PRISMA";
            this.PRISMA.Size = new System.Drawing.Size(79, 20);
            this.PRISMA.TabIndex = 12;
            this.PRISMA.TabStop = true;
            this.PRISMA.Text = "PRISMA";
            this.PRISMA.UseVisualStyleBackColor = true;
            // 
            // CUBO
            // 
            this.CUBO.AutoSize = true;
            this.CUBO.ForeColor = System.Drawing.Color.Fuchsia;
            this.CUBO.Location = new System.Drawing.Point(663, 413);
            this.CUBO.Margin = new System.Windows.Forms.Padding(4);
            this.CUBO.Name = "CUBO";
            this.CUBO.Size = new System.Drawing.Size(66, 20);
            this.CUBO.TabIndex = 12;
            this.CUBO.TabStop = true;
            this.CUBO.Text = "CUBO";
            this.CUBO.UseVisualStyleBackColor = true;
            // 
            // CIRCULO
            // 
            this.CIRCULO.AutoSize = true;
            this.CIRCULO.ForeColor = System.Drawing.Color.Fuchsia;
            this.CIRCULO.Location = new System.Drawing.Point(663, 459);
            this.CIRCULO.Margin = new System.Windows.Forms.Padding(4);
            this.CIRCULO.Name = "CIRCULO";
            this.CIRCULO.Size = new System.Drawing.Size(86, 20);
            this.CIRCULO.TabIndex = 11;
            this.CIRCULO.TabStop = true;
            this.CIRCULO.Text = "CÍRCULO";
            this.CIRCULO.UseVisualStyleBackColor = true;
            // 
            // DATOS
            // 
            this.DATOS.BackColor = System.Drawing.SystemColors.Highlight;
            this.DATOS.Location = new System.Drawing.Point(628, 146);
            this.DATOS.Margin = new System.Windows.Forms.Padding(4);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(97, 22);
            this.DATOS.TabIndex = 10;
            // 
            // POLIIRREC
            // 
            this.POLIIRREC.AutoSize = true;
            this.POLIIRREC.ForeColor = System.Drawing.Color.Fuchsia;
            this.POLIIRREC.Location = new System.Drawing.Point(663, 441);
            this.POLIIRREC.Margin = new System.Windows.Forms.Padding(4);
            this.POLIIRREC.Name = "POLIIRREC";
            this.POLIIRREC.Size = new System.Drawing.Size(178, 20);
            this.POLIIRREC.TabIndex = 9;
            this.POLIIRREC.TabStop = true;
            this.POLIIRREC.Text = "POLÍGONO IRREGULAR";
            this.POLIIRREC.UseVisualStyleBackColor = true;
            // 
            // POLIREG
            // 
            this.POLIREG.AutoSize = true;
            this.POLIREG.ForeColor = System.Drawing.Color.Fuchsia;
            this.POLIREG.Location = new System.Drawing.Point(663, 273);
            this.POLIREG.Margin = new System.Windows.Forms.Padding(4);
            this.POLIREG.Name = "POLIREG";
            this.POLIREG.Size = new System.Drawing.Size(165, 20);
            this.POLIREG.TabIndex = 8;
            this.POLIREG.TabStop = true;
            this.POLIREG.Text = "POLÍGONO REGULAR";
            this.POLIREG.UseVisualStyleBackColor = true;
            // 
            // RECTANGULO
            // 
            this.RECTANGULO.AutoSize = true;
            this.RECTANGULO.ForeColor = System.Drawing.Color.Fuchsia;
            this.RECTANGULO.Location = new System.Drawing.Point(663, 357);
            this.RECTANGULO.Margin = new System.Windows.Forms.Padding(4);
            this.RECTANGULO.Name = "RECTANGULO";
            this.RECTANGULO.Size = new System.Drawing.Size(121, 20);
            this.RECTANGULO.TabIndex = 7;
            this.RECTANGULO.TabStop = true;
            this.RECTANGULO.Text = "RECTÁNGULO";
            this.RECTANGULO.UseVisualStyleBackColor = true;
            // 
            // TRIANGULO
            // 
            this.TRIANGULO.AutoSize = true;
            this.TRIANGULO.ForeColor = System.Drawing.Color.Fuchsia;
            this.TRIANGULO.Location = new System.Drawing.Point(663, 245);
            this.TRIANGULO.Margin = new System.Windows.Forms.Padding(4);
            this.TRIANGULO.Name = "TRIANGULO";
            this.TRIANGULO.Size = new System.Drawing.Size(106, 20);
            this.TRIANGULO.TabIndex = 6;
            this.TRIANGULO.TabStop = true;
            this.TRIANGULO.Text = "TRIÁNGULO";
            this.TRIANGULO.UseVisualStyleBackColor = true;
            // 
            // CUADRADO
            // 
            this.CUADRADO.AutoSize = true;
            this.CUADRADO.ForeColor = System.Drawing.Color.Fuchsia;
            this.CUADRADO.Location = new System.Drawing.Point(663, 385);
            this.CUADRADO.Margin = new System.Windows.Forms.Padding(4);
            this.CUADRADO.Name = "CUADRADO";
            this.CUADRADO.Size = new System.Drawing.Size(105, 20);
            this.CUADRADO.TabIndex = 5;
            this.CUADRADO.TabStop = true;
            this.CUADRADO.Text = "CUADRADO";
            this.CUADRADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMÉTRICAS";
            // 
            // EXPORT
            // 
            this.EXPORT.Location = new System.Drawing.Point(293, 76);
            this.EXPORT.Margin = new System.Windows.Forms.Padding(4);
            this.EXPORT.Name = "EXPORT";
            this.EXPORT.Size = new System.Drawing.Size(100, 28);
            this.EXPORT.TabIndex = 3;
            this.EXPORT.Text = "EXPORTAR";
            this.EXPORT.UseVisualStyleBackColor = true;
            this.EXPORT.Click += new System.EventHandler(this.EXPORT_Click);
            // 
            // DUBUJAR
            // 
            this.DUBUJAR.Location = new System.Drawing.Point(175, 76);
            this.DUBUJAR.Margin = new System.Windows.Forms.Padding(4);
            this.DUBUJAR.Name = "DUBUJAR";
            this.DUBUJAR.Size = new System.Drawing.Size(100, 28);
            this.DUBUJAR.TabIndex = 2;
            this.DUBUJAR.Text = "DIBUJAR";
            this.DUBUJAR.UseVisualStyleBackColor = true;
            this.DUBUJAR.Click += new System.EventHandler(this.DUBUJAR_Click);
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(43, 76);
            this.INFO.Margin = new System.Windows.Forms.Padding(4);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(124, 28);
            this.INFO.TabIndex = 1;
            this.INFO.Text = "INFORMACIÓN";
            this.INFO.UseVisualStyleBackColor = true;
            this.INFO.Click += new System.EventHandler(this.INFO_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(632, 76);
            this.GUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(100, 28);
            this.GUARDAR.TabIndex = 0;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // INFORMACION
            // 
            this.INFORMACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.INFORMACION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFORMACION.Location = new System.Drawing.Point(355, 229);
            this.INFORMACION.Margin = new System.Windows.Forms.Padding(4);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.INFORMACION.Size = new System.Drawing.Size(283, 309);
            this.INFORMACION.TabIndex = 2;
            this.INFORMACION.Text = "";
            // 
            // IMAGEN
            // 
            this.IMAGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMAGEN.Image = global::FiguraGeometrica.Properties.Resources.portada;
            this.IMAGEN.Location = new System.Drawing.Point(17, 229);
            this.IMAGEN.Margin = new System.Windows.Forms.Padding(4);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(329, 310);
            this.IMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMAGEN.TabIndex = 1;
            this.IMAGEN.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 579);
            this.Controls.Add(this.INFORMACION);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CIRCULO);
            this.Controls.Add(this.CUBO);
            this.Controls.Add(this.PRISMA);
            this.Controls.Add(this.POLIIRREC);
            this.Controls.Add(this.ESFERA);
            this.Controls.Add(this.TRIANGULO);
            this.Controls.Add(this.POLIREG);
            this.Controls.Add(this.CUADRADO);
            this.Controls.Add(this.RECTANGULO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Figuras geometricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CALC;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ESFERA;
        private System.Windows.Forms.RadioButton PRISMA;
        private System.Windows.Forms.RadioButton CUBO;
        private System.Windows.Forms.RadioButton CIRCULO;
        private System.Windows.Forms.TextBox DATOS;
        private System.Windows.Forms.RadioButton POLIIRREC;
        private System.Windows.Forms.RadioButton POLIREG;
        private System.Windows.Forms.RadioButton RECTANGULO;
        private System.Windows.Forms.RadioButton TRIANGULO;
        private System.Windows.Forms.RadioButton CUADRADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EXPORT;
        private System.Windows.Forms.Button DUBUJAR;
        private System.Windows.Forms.Button INFO;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.RichTextBox INFORMACION;
    }
}

