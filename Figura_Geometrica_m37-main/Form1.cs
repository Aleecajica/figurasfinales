using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//BIBLIOTECA QUE PERMITE USAR EL BUFFER DE ESCRITURA Y LECTURA


namespace FiguraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            INFORMACION.Clear();
            IMAGEN.Image = (FiguraGeometrica.Properties.Resources.portada);
            DATOS.Clear();
            CUADRADO.Checked = false;
            TRIANGULO.Checked = false;
            RECTANGULO.Checked = false;
            ESFERA.Checked = false;
            CIRCULO.Checked = false;
            CUBO.Checked = false;
            PRISMA.Checked = false;
            POLIIRREC.Checked = false;
            POLIREG.Checked = false;
        }

        private void DUBUJAR_Click(object sender, EventArgs e)
        {
           
            if (CUADRADO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.cuadrado);
            }
            else if (TRIANGULO.Checked)
            {
               IMAGEN.Image = (FiguraGeometrica.Properties.Resources.triagulo);
            }
            else if (RECTANGULO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.retangulo);
            }
            else if (POLIREG.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.poligono_regular);
            }
            else if (POLIIRREC.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.poligono_irregular);
            }
            else if (CIRCULO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.circulo1);
            }
            else if (CUBO.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.cubo1);
            }
            else if (PRISMA.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.prisma1);
            }
            else if (ESFERA.Checked)
            {
                IMAGEN.Image = (FiguraGeometrica.Properties.Resources.esfera1);
            }
        }

        private void INFO_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cuadrado, " + "\n"+
                    "Sus datos son:" + "\n"+
                    "Longitud del lado: "
                    + DATOS.Text;
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIIRREC.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + DATOS.Text;
            } 
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS" + DATOS.Text, "Datos de alumno",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EXPORT_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                    @"C:\Users\aleja\Downloads\Figura_Geometrica_m37-main\textos\figura.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + DATOS.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CALC_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                float lado = Convert.ToSingle(DATOS.Text);
                Cuadrado cuadrado = new Cuadrado(lado);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + cuadrado.area() + "\n" + "Perimetro= " + cuadrado.perimetro() + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (TRIANGULO.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float bass = Convert.ToSingle(divicion[0]);
                float altura = Convert.ToSingle(divicion[1]);
                Triangulo triangulo = new Triangulo(bass, altura);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + triangulo.area() + "\n" + "Perimetro= " + triangulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (RECTANGULO.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float bass = Convert.ToSingle(divicion[0]);
                float altura = Convert.ToSingle(divicion[1]);
                Rectangulo rectangulo = new Rectangulo(bass, altura);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + rectangulo.area() + "\n" + "Perimetro= " + rectangulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (POLIREG.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float bass = Convert.ToSingle(divicion[0]);
                float apotema = Convert.ToSingle(divicion[1]);
                float nuLad = Convert.ToSingle(divicion[2]);
                PoligonoReg poligonoreg = new PoligonoReg(bass, apotema, nuLad);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + poligonoreg.area() + "\n" + "Perimetro= " + poligonoreg.perimetro() + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (POLIIRREC.Checked)
            {

                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CIRCULO.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float radio = Convert.ToSingle(divicion[0]);
                Circulo circulo = new Circulo(radio);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + circulo.area() + "\n" + "Perimetro= " + circulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CUBO.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float lado = Convert.ToSingle(divicion[0]);
                Cubo cubo = new Cubo(lado);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + cubo.area() +"\n" + "Perimetro= no definido" + "\n" + "Volumen= " + cubo.volumen() + "\n";
            }
            else if (PRISMA.Checked)
            {
                string cadena = DATOS.Text;
                string[] divicion = cadena.Split(',');
                float uno = Convert.ToSingle(divicion[0]);
                float dos = Convert.ToSingle(divicion[1]);
                float tre = Convert.ToSingle(divicion[2]);
                Prisma prisma = new Prisma(uno,dos,tre);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + prisma.area() + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + prisma.perimetro()
                  + "\n";
            }
            else if (ESFERA.Checked)
            {
                float rad = Convert.ToSingle(DATOS.Text);
                Esfera esfera = new Esfera(rad);
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + esfera.area()+ "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + esfera.volumen()
                   + "\n";
            }
        }
    }
    
}
