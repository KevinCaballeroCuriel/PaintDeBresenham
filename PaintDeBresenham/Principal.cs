using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDeBresenham
{
    public partial class PaintDeBresenham : Form
    {
        Bitmap canvas;
        Graphics objDibujador;
        bool pointSet = false, isRunning = false;
        float primerX, segundoX, dx, distancia;
        float primerY, segundoY, dy;
        int contadorPoligono = 0;
        Figuras figuraActiva;
        List<PointF> puntos = new List<PointF>();

        enum Figuras
        {
            Linea,
            Circulo,
            Arco,
            Triangulo,
            TrianguloCirculo,
            Cuadrado,
            CuadradoCirculo,
            Rectangulo,
            Pentagono,
            PentagonoCirculo,
            Poligono,
            FinPoligono
        }

        public PaintDeBresenham()
        {
            InitializeComponent();
            canvas = new Bitmap(paintArea.Width, paintArea.Height);
            objDibujador = Graphics.FromImage(canvas);
            objDibujador.Clear(Color.White);
            figuraActiva = Figuras.Linea;
            btnLinea.Select();
            btnBotonActivo.BackgroundImage = btnLinea.BackgroundImage;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem_Click(sender, e);
            objDibujador.Clear(paintArea.BackColor = Color.White);
            btnColorSeleccionado.BackColor = Color.Black;
            paintArea.Refresh();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAbrirArchivo.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png; ";
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                canvas = new Bitmap(ofdAbrirArchivo.FileName);
                paintArea.Image = (Image)canvas;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardarArchivo.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png ";
            if (sfdGuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(sfdGuardarArchivo.FileName);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaintDeBresenham_Load(object sender, EventArgs e)
        {
            isRunning = true;
        }

        private void paintArea_SizeChanged(object sender, EventArgs e)
        {
            stsCoordenadasDelPanel.Text = paintArea.Width + ", " + paintArea.Height + "px";
            if (isRunning)
            {
                Bitmap canvasResize = new Bitmap(paintArea.Width, paintArea.Height);
                if (canvas.Width > canvasResize.Width)
                {
                    canvasResize = new Bitmap(canvasResize.Width, canvasResize.Height);
                }
                if (canvas.Height > canvasResize.Height)
                {
                    canvasResize = new Bitmap(canvasResize.Width, canvasResize.Height);
                }
                objDibujador = Graphics.FromImage(canvasResize);
                objDibujador.Clear(Color.White);
                objDibujador.DrawImage(canvas, 0, 0);
                canvas = canvasResize;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ventanaAcercaDe = new AcercaDe();
            ventanaAcercaDe.Show();
        }

        public void DrawPixel(float x, float y)
        {
            Pen penColor = new Pen(btnColorSeleccionado.BackColor, (float)nudGrosor.Value);
            Rectangle rect = new Rectangle((Int32)x, (Int32)y, 1, 1);
            objDibujador.DrawRectangle(penColor, rect);
        }

        private void btnPaletaDeColores_Click(object sender, EventArgs e)
        {
            if (cdgPaletaDeColores.ShowDialog() == DialogResult.OK)
            {
                btnColorSeleccionado.BackColor = cdgPaletaDeColores.Color;
            }
            switch (figuraActiva)
            {
                case Figuras.Linea:
                    btnLinea.Select();
                    break;
                case Figuras.Circulo:
                    btnCirculo.Select();
                    break;
                case Figuras.Arco:
                    btnArco.Select();
                    break;
                case Figuras.Triangulo:
                    btnTriangulo.Select();
                    break;
                case Figuras.TrianguloCirculo:
                    btnTrianguloCirculo.Select();
                    break;
                case Figuras.Cuadrado:
                    btnCuadrado.Select();
                    break;
                case Figuras.CuadradoCirculo:
                    btnCuadradoCirculo.Select();
                    break;
                case Figuras.Rectangulo:
                    btnRectangulo.Select();
                    break;
                case Figuras.Pentagono:
                    btnPentagono.Select();
                    break;
                case Figuras.PentagonoCirculo:
                    btnPentagonoCirculo.Select();
                    break;
                case Figuras.Poligono:
                    btnPoligono.Select();
                    break;
                case Figuras.FinPoligono:
                    btnLinea.Select();
                    break;
                default:
                    break;
            }
        }

        private void btnColorSeleccionado_Click(object sender, EventArgs e)
        {
            btnPaletaDeColores_Click(sender, e);
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Linea;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X,puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Circulo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Arco;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Triangulo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnTrianguloCirculo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.TrianguloCirculo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Cuadrado;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnCuadradoCirculo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.CuadradoCirculo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Rectangulo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Pentagono;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnPentagonoCirculo_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.PentagonoCirculo;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            btnBotonActivo.BackgroundImage = ((Button)sender).BackgroundImage;
            figuraActiva = Figuras.Poligono;
            if (puntos.Count > 0)
            {
                paintArea.Image = (Image)canvas;
                objDibujador = Graphics.FromImage(canvas);
                lineaDeBresenham(puntos.First().X, puntos.First().Y, puntos.Last().X, puntos.Last().Y);
                contadorPoligono = 0;
            }
            puntos.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objDibujador.Clear(paintArea.BackColor = Color.White);
            btnColorSeleccionado.BackColor = Color.Black;
            paintArea.Refresh();
            puntos.Clear();
            contadorPoligono = 0;
            switch (figuraActiva)
            {
                case Figuras.Linea:
                    btnLinea.Select();
                    break;
                case Figuras.Circulo:
                    btnCirculo.Select();
                    break;
                case Figuras.Arco:
                    btnArco.Select();
                    break;
                case Figuras.Triangulo:
                    btnTriangulo.Select();
                    break;
                case Figuras.TrianguloCirculo:
                    btnTrianguloCirculo.Select();
                    break;
                case Figuras.Cuadrado:
                    btnCuadrado.Select();
                    break;
                case Figuras.CuadradoCirculo:
                    btnCuadradoCirculo.Select();
                    break;
                case Figuras.Rectangulo:
                    btnRectangulo.Select();
                    break;
                case Figuras.Pentagono:
                    btnPentagono.Select();
                    break;
                case Figuras.PentagonoCirculo:
                    btnPentagonoCirculo.Select();
                    break;
                case Figuras.Poligono:
                    btnPoligono.Select();
                    break;
                case Figuras.FinPoligono:
                    btnLinea.Select();
                    break;
                default:
                    break;
            }
        }

        private void paintArea_MouseDown(object sender, MouseEventArgs e)
        {
            primerX = e.X;
            primerY = e.Y;
        }

        private void paintArea_MouseClick(object sender, MouseEventArgs e)
        {
            PointF[] punto = puntos.ToArray();
            if (figuraActiva == Figuras.Poligono)
            {
                contadorPoligono++;
                if (contadorPoligono == 1)
                {
                    puntos.Add(new PointF(e.X, e.Y));
                    lineaDeBresenham(e.X, e.Y, e.X, e.Y);
                }
                else
                {
                    for (int i = 0; i <= contadorPoligono; i++)
                    {
                        if (contadorPoligono == i)
                        {
                            puntos.Add(new PointF(e.X, e.Y));
                            punto = puntos.ToArray();
                            if ((punto[0].X - 10 - (float)nudGrosor.Value <= e.X && punto[0].Y - 10 - (float)nudGrosor.Value <= e.Y) && (punto[0].X + 10 + (float)nudGrosor.Value >= e.X && punto[0].Y + 10 + (float)nudGrosor.Value >= e.Y))
                            {
                                lineaDeBresenham(punto[i - 2].X, punto[i - 2].Y, punto[0].X, punto[0].Y);
                                contadorPoligono = 0;
                                puntos.Clear();
                                btnLinea.Select();
                                btnBotonActivo.BackgroundImage = btnLinea.BackgroundImage;
                                figuraActiva = Figuras.FinPoligono;
                            }
                            else
                            {
                                lineaDeBresenham(punto[i - 2].X, punto[i - 2].Y, punto[i - 1].X, punto[i - 1].Y);
                            }          
                        }
                    }
                }
            }
        }



        private void paintArea_MouseUp(object sender, MouseEventArgs e)
        {
            
            segundoX = e.X;
            segundoY = e.Y;

            switch (figuraActiva)
            {
                case Figuras.Linea:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                    break;
                case Figuras.Circulo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    distancia = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(dx * dx + dy * dy)));
                    circuloDeBresenham(primerX+(segundoX - primerX)/2, primerY + (segundoY - primerY)/2 , distancia/2);
                    break;
                case Figuras.Arco:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    distancia = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(dx * dx + dy * dy)));
                    circuloDeBresenham(primerX + (segundoX - primerX) / 2, primerY + (segundoY - primerY) / 2, distancia / 2);
                    break;
                case Figuras.Triangulo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    
                    float puntoMedioX = ((segundoX) + (primerX)) / 2;
                    float puntoMedioY = ((segundoY) + (primerY)) / 2;

                    float deltaX = (-1) * ((segundoX) - (primerX));
                    float deltaY = ((segundoY) - (primerY));

                    float catetoX = (float)(deltaX * Math.Cos(30 * Math.PI / 180));
                    float catetoY = (float)(deltaY * Math.Cos(30 * Math.PI / 180));

                    lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                    lineaDeBresenham(segundoX, segundoY, puntoMedioX + catetoY, puntoMedioY + catetoX);
                    lineaDeBresenham(primerX, primerY, puntoMedioX + catetoY, puntoMedioY + catetoX);
                    break;
                case Figuras.TrianguloCirculo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    float pMedioX = ((segundoX) + (primerX)) / 2;
                    float pMedioY = ((segundoY) + (primerY)) / 2;
                    distancia = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(dx * dx + dy * dy))) / 2;
                    PointF[] puntoTriangulo = getPoligonVertices(3, distancia, new Point((Int32)pMedioX, (Int32)pMedioY));

                    lineaDeBresenham(puntoTriangulo[0].X, puntoTriangulo[0].Y, puntoTriangulo[1].X, puntoTriangulo[1].Y);
                    lineaDeBresenham(puntoTriangulo[1].X, puntoTriangulo[1].Y, puntoTriangulo[2].X, puntoTriangulo[2].Y);
                    lineaDeBresenham(puntoTriangulo[0].X, puntoTriangulo[0].Y, puntoTriangulo[2].X, puntoTriangulo[2].Y);
                    break;
                case Figuras.Cuadrado:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    if (primerX <= segundoX && primerY >= segundoY)
                    {
                        lineaDeBresenham(primerX, primerY, primerX - dy, primerY - dx);
                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(segundoX, segundoY, segundoX - dy, segundoY - dx);
                        lineaDeBresenham(primerX - dy, primerY - dx, segundoX - dy, segundoY - dx);
                    }
                    if (primerX >= segundoX && primerY >= segundoY)
                    {
                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(primerX, primerY, primerX - dy, primerY + dx);
                        lineaDeBresenham(segundoX, segundoY, segundoX - dy, segundoY + dx);
                        lineaDeBresenham(primerX - dy, primerY + dx, segundoX - dy, segundoY + dx);
                    }
                    if (primerX >= segundoX && primerY <= segundoY)
                    {
                        lineaDeBresenham(primerX, primerY, primerX + dy, primerY + dx);
                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(segundoX, segundoY, segundoX + dy, segundoY + dx);
                        lineaDeBresenham(primerX + dy, primerY + dx, segundoX + dy, segundoY + dx);
                    }
                    if (primerX <= segundoX && primerY <= segundoY)
                    {
                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(primerX, primerY, primerX + dy, primerY - dx);
                        lineaDeBresenham(segundoX, segundoY, segundoX + dy, segundoY - dx);
                        lineaDeBresenham(primerX + dy, primerY - dx, segundoX + dy, segundoY - dx);
                    }
                    break;
                case Figuras.CuadradoCirculo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    float pcMedioX = ((segundoX) + (primerX)) / 2;
                    float pcMedioY = ((segundoY) + (primerY)) / 2;
                    distancia = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(dx * dx + dy * dy))) / 2;
                    PointF[] puntoCuadrado = getPoligonVertices(4, distancia, new Point((Int32)pcMedioX, (Int32)pcMedioY));

                    lineaDeBresenham(puntoCuadrado[0].X, puntoCuadrado[0].Y, puntoCuadrado[1].X, puntoCuadrado[1].Y);
                    lineaDeBresenham(puntoCuadrado[1].X, puntoCuadrado[1].Y, puntoCuadrado[2].X, puntoCuadrado[2].Y);
                    lineaDeBresenham(puntoCuadrado[2].X, puntoCuadrado[2].Y, puntoCuadrado[3].X, puntoCuadrado[3].Y);
                    lineaDeBresenham(puntoCuadrado[0].X, puntoCuadrado[0].Y, puntoCuadrado[3].X, puntoCuadrado[3].Y);
                    break;
                case Figuras.Rectangulo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);                   
                    lineaDeBresenham(primerX,primerY,segundoX,primerY);
                    lineaDeBresenham(segundoX, primerY,segundoX,segundoY);
                    lineaDeBresenham(segundoX, segundoY, primerX,segundoY);
                    lineaDeBresenham(primerX, segundoY, primerX, primerY);
                    break;
                case Figuras.Pentagono:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    distancia = (float)Math.Sqrt(Math.Pow(segundoX - primerX, 2) + Math.Pow(segundoY - primerY, 2));

                    float puntoMedioXP = (segundoX + primerX) / 2;
                    float puntoMedioYP = (segundoY + primerY) / 2;

                    float deltaXP = (-1) * (segundoX - primerX);
                    float deltaYP = segundoY - primerY;


                    float angulo = (float)Math.Atan(((double)deltaYP / (double)deltaXP));


                    float catetoPmx = (float)(deltaXP * (Math.Cos(((36) * Math.PI / 180))));
                    float catetoPmy = (float)(deltaYP * (Math.Cos(((36) * Math.PI / 180))));


                    float catetoXP3;
                    float catetoYP3;

                    float punto3x;
                    float punto3y;

                    float catetoXP5;
                    float catetoYP5;

                    if (primerX < segundoX)
                    {
                        catetoXP3 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) - angulo));
                        catetoYP3 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) + angulo));

                        punto3x = (segundoX + catetoYP3) - (float)(distancia * Math.Cos(((36) * Math.PI / 180) - angulo));
                        punto3y = (segundoY + catetoXP3) - (float)(distancia * Math.Cos(((54) * Math.PI / 180) + angulo));

                        catetoXP5 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) + angulo));
                        catetoYP5 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) - angulo));

                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(segundoX, segundoY, segundoX + catetoYP3, segundoY + catetoXP3);
                        lineaDeBresenham(segundoX + catetoYP3, segundoY + catetoXP3, punto3x, punto3y);
                        lineaDeBresenham(punto3x, punto3y, primerX - catetoYP5, primerY + catetoXP5);
                        lineaDeBresenham(primerX - catetoYP5, primerY + catetoXP5, primerX, primerY);
                    }
                    else
                    {
                        catetoXP3 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) + angulo));
                        catetoYP3 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) - angulo));

                        catetoXP5 = -(float)(distancia * Math.Cos(((18) * Math.PI / 180) - angulo));
                        catetoYP5 = (float)(distancia * Math.Cos(((72) * Math.PI / 180) + angulo));

                        punto3x = (segundoX - catetoYP5) + (float)(distancia * Math.Cos(((36) * Math.PI / 180) - angulo));
                        punto3y = (segundoY - catetoXP5) + (float)(distancia * Math.Cos(((54) * Math.PI / 180) + angulo));

                        lineaDeBresenham(primerX, primerY, segundoX, segundoY);
                        lineaDeBresenham(segundoX, segundoY, segundoX - catetoYP5, segundoY - catetoXP5);
                        lineaDeBresenham(segundoX - catetoYP5, segundoY - catetoXP5, punto3x, punto3y);
                        lineaDeBresenham(punto3x, punto3y, primerX + catetoYP3, primerY - catetoXP3);
                        lineaDeBresenham(primerX + catetoYP3, primerY - catetoXP3, primerX, primerY);
                    }
                    break;
                case Figuras.PentagonoCirculo:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);

                    dx = Math.Abs(segundoX - primerX);
                    dy = Math.Abs(segundoY - primerY);
                    float ppMedioX = ((segundoX) + (primerX)) / 2;
                    float ppMedioY = ((segundoY) + (primerY)) / 2;
                    distancia = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(dx * dx + dy * dy))) / 2;
                    PointF[] puntoPentagono = getPoligonVertices(5, distancia, new Point((Int32)ppMedioX, (Int32)ppMedioY));

                    lineaDeBresenham(puntoPentagono[0].X, puntoPentagono[0].Y, puntoPentagono[1].X, puntoPentagono[1].Y);
                    lineaDeBresenham(puntoPentagono[1].X, puntoPentagono[1].Y, puntoPentagono[2].X, puntoPentagono[2].Y);
                    lineaDeBresenham(puntoPentagono[2].X, puntoPentagono[2].Y, puntoPentagono[3].X, puntoPentagono[3].Y);
                    lineaDeBresenham(puntoPentagono[3].X, puntoPentagono[3].Y, puntoPentagono[4].X, puntoPentagono[4].Y);
                    lineaDeBresenham(puntoPentagono[0].X, puntoPentagono[0].Y, puntoPentagono[4].X, puntoPentagono[4].Y);
                    break;
                case Figuras.Poligono:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    break;
                case Figuras.FinPoligono:
                    paintArea.Image = (Image)canvas;
                    objDibujador = Graphics.FromImage(canvas);
                    figuraActiva = Figuras.Linea;
                    break;
                default:
                    break;
            }
        }

        private void paintArea_MouseMove(object sender, MouseEventArgs e)
        {
            stsCoordenadas.Text = e.X.ToString() + " , " + e.Y.ToString() + " px";
        }

        private void lineaDeBresenham(float x1, float y1, float x2, float y2)
        {
            int slope;
            float dx, dy, incE, incNE, d, x, y;
            if (x1 > x2)
            {
                lineaDeBresenham(x2, y2, x1, y1);
                return;
            }

            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) < Math.Abs(dy))
            {
                if (dy < 0)
                {
                    if (dx < 0)
                    {
                        slope = -1;
                        dx = -dx;
                    }
                    else
                    {
                        slope = 1;
                    }
                    incE = 2 * dx;
                    incNE = 2 * dx + 2 * dy;
                    d = 2 * dx + dy;
                    x = x1;
                    for (y = y1; y >= y2; y--)
                    {
                        DrawPixel(x, y);
                        if (d <= 0)
                        {
                            d += incE;

                        }
                        else
                        {
                            d += incNE;
                            x += slope;
                        }
                    }
                }
                else
                {
                    if (dx < 0)
                    {
                        slope = -1;
                        dx = -dx;
                    }
                    else
                    {
                        slope = 1;
                    }
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = x1;
                    for (y = y1; y <= y2; y++)
                    {
                        DrawPixel(x, y);
                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            x += slope;
                        }
                    }
                }
            }
            else
            {
                if (dy < 0)
                {
                    slope = -1;
                    dy = -dy;
                }
                else
                {
                    slope = 1;
                }
                incE = 2 * dy;
                incNE = 2 * dy - 2 * dx;
                d = 2 * dy - dx;
                y = y1;
                for (x = x1; x <= x2; x++)
                {
                    DrawPixel(x, y);
                    if (d <= 0)
                    {
                        d += incE;
                    }
                    else
                    {
                        d += incNE;
                        y += slope;
                    }
                }
            }
        }

        private void circuloDeBresenham(float x, float y, float r)
        {
            //lblGrosor.Text = Math.Atan(-(segundoY - primerY) / (0.0001+segundoX - primerX))*180/Math.PI + "";
            float x1 = 0;
            float y1 = r;
            float d = 3 - 2 * r;
            while (x1 <= y1)
            {
                switch (figuraActiva)
                {
                    case Figuras.Circulo:
                        DrawPixel(x + x1, y + y1);
                        DrawPixel(x - x1, y + y1);
                        DrawPixel(x + x1, y - y1); 
                        DrawPixel(x - x1, y - y1);
                        DrawPixel(x + y1, y + x1);
                        DrawPixel(x - y1, y + x1);
                        DrawPixel(x + y1, y - x1);
                        DrawPixel(x - y1, y - x1);
                        break;
                    case Figuras.Arco:
                        if (primerX>segundoX)
                        {
                            if (primerY > segundoY)
                            {
                                if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= -45 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI >= -90)
                                {
                                    //DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    //DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    //DrawPixel(x + y1, y + x1); //Abajo derecho
                                    DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    //DrawPixel(x + y1, y - x1); //Arriba derecho
                                    DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                                else if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI > -45 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 0)
                                {
                                    DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    //DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    //DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    //DrawPixel(x + y1, y + x1); //Abajo derecho
                                    DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    //DrawPixel(x + y1, y - x1); //Arriba derecho
                                    DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                            }
                            else
                            {
                                if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI > 0 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 45)
                                {
                                    DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    //DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    //DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    DrawPixel(x + y1, y + x1); //Abajo derecho
                                    DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    //DrawPixel(x + y1, y - x1); //Arriba derecho
                                    //DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                                else if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI > 45 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 90)
                                {
                                    DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    //DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    //DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    DrawPixel(x + y1, y + x1); //Abajo derecho
                                    //DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    DrawPixel(x + y1, y - x1); //Arriba derecho
                                    //DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                            }
                        }
                        else
                        {
                            if (primerY<segundoY)
                            {
                                if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI >= -45 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 0)
                                {
                                    //DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    //DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    DrawPixel(x + y1, y + x1); //Abajo derecho
                                    //DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    DrawPixel(x + y1, y - x1); //Arriba derecho
                                    //DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                                else if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI >= -90 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI < -45)
                                {
                                    DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    //DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    //DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    DrawPixel(x + y1, y + x1); //Abajo derecho
                                    //DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    DrawPixel(x + y1, y - x1); //Arriba derecho
                                    //DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                            }
                            else
                            {
                                if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 45 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI >= 0)
                                {
                                    //DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    //DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    //DrawPixel(x + y1, y + x1); //Abajo derecho
                                    //DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    DrawPixel(x + y1, y - x1); //Arriba derecho
                                    DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                                else if (Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI <= 90 && Math.Atan(-(segundoY - primerY) / (0.0001 + segundoX - primerX)) * 180 / Math.PI > 45)
                                {
                                    //DrawPixel(x + x1, y + y1); //Abajo centro derecho
                                    //DrawPixel(x - x1, y + y1); //Abajo centro izquierdo
                                    DrawPixel(x + x1, y - y1); // Arriba centro derecho
                                    DrawPixel(x - x1, y - y1); // Arriba centro izquierdo
                                    //DrawPixel(x + y1, y + x1); //Abajo derecho
                                    DrawPixel(x - y1, y + x1); //Abajo izquierdo
                                    //DrawPixel(x + y1, y - x1); //Arriba derecho
                                    DrawPixel(x - y1, y - x1); //Arriba izquierdo
                                }
                            }     
                        }
                        break;
                    default:
                        break;
                }
                if (d < 0)
                {
                    d += 4 * x1 + 6;
                }
                else
                {
                    d += 4 * (x1 - y1) + 10;
                    y1--;
                }
                x1++;
            }
        }

        private PointF[] getPoligonVertices(int sides, float radius, Point center)
        {
            List<PointF> points = new List<PointF>();
            float step = 360.0f / sides;
            int startingAngle = 90;
            float angle = startingAngle;
            if (sides == 4)
            {
                startingAngle = 45;
                angle = startingAngle;
                for (double i = startingAngle; i < startingAngle + 360.0; i += step)
                {
                    points.Add(DegreesToXY(angle, radius, center));
                    angle += step;
                }
            }
            else
            {
                for (double i = startingAngle; i < startingAngle + 360.0; i += step)
                {
                    points.Add(DegreesToXY(angle, radius, center));
                    angle += step;
                }
            }
            
            return points.ToArray();
        }

        private PointF DegreesToXY(float degrees, float radius, Point origin)
        {
            PointF xy = new PointF();
            double radians = degrees * Math.PI / 180.0;
            xy.X = (float)Math.Cos(radians) * radius + origin.X;
            xy.Y = (float)Math.Sin(-radians) * radius + origin.Y;
            return xy;
        }
    }
}
