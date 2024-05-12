using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace prySvetlizaEtapa1
{
    public partial class Form1 : Form
    {
        private Point previousPoint; //almacena coordenas del punto anterior del dibujo
        private bool isMouseDrawing = false; //detecta si se esta dibujando o no
        private Bitmap signatureBitmap; //para tener la imagen que se esta dibujando
        
        public Form1()
        {
            InitializeComponent();
            InitializeSignaturePictureBox();
            pctFirma.MouseDown += new MouseEventHandler(pctFirma_MouseDown);
            pctFirma.MouseMove += new MouseEventHandler(pctFirma_MouseMove);
            pctFirma.MouseUp += new MouseEventHandler(pctFirma_MouseUp);

        }
        private void InitializeSignaturePictureBox()
        {
            signatureBitmap = new Bitmap(pctFirma.Width, pctFirma.Height); //donde se va a dibujar
            pctFirma.Image = signatureBitmap;
            Graphics g = Graphics.FromImage(pctFirma.Image);//obtener un objeto que se utiliza para dibujar
            g.Clear(Color.White);
            g.Dispose();
        }

        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDrawing)
            {
                //crea un objeto a partir de la imagen de pctbox
                using (Graphics g = Graphics.FromImage(pctFirma.Image))
                {
                    
                    g.SmoothingMode = SmoothingMode.AntiAlias;//apariencia del lapiz
                    using (Pen pen = new Pen(Color.Black, 2))//color y grueso del lapiz
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }
                previousPoint = e.Location;//que el punto inicial sea la ubicacion de e
                pctFirma.Invalidate();//para que se muestre la linea que se dibujo
            }
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDrawing = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            string fecha = DateTime.Now.ToString("yyyy_MM_dd_HHmmss") + ".png";

            // Construir la ruta del archivo
            string carpeta = "../../Resources/FIRMA";
            string nombreArchivo = $"dibujo_{fecha}";
            string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

            try
            {
                // Crear la carpeta si no existe
                Directory.CreateDirectory(carpeta);

                // Crear un bitmap del mismo tamaño que el PictureBox
                Bitmap bmp = new Bitmap(pctFirma.Width, pctFirma.Height);

                // Dibujar el contenido del PictureBox en el bitmap
                pctFirma.DrawToBitmap(bmp, pctFirma.ClientRectangle);

                // Guardar el bitmap en un archivo
                bmp.Save(rutaCompleta);

                // Liberar recursos
                bmp.Dispose();

                MessageBox.Show("Firma guardada correctamente en " + rutaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la firma: " + ex.Message);
            }

        }

        private void btnOtraFirma_Click(object sender, EventArgs e)
        {
            // Limpiar el PictureBox para permitir una nueva firma
            pctFirma.Image = new Bitmap(pctFirma.Width, pctFirma.Height);
            Graphics g = Graphics.FromImage(pctFirma.Image);//obtener un objeto que se utiliza para dibujar
            g.Clear(Color.White);
            g.Dispose();
            pctFirma.Invalidate();
        }
    }
    
}
