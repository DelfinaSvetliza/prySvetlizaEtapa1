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
        private Point previousPoint;
        private bool isMouseDrawing = false;
        private Bitmap signatureBitmap;
        private string fondo;
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
            signatureBitmap = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = signatureBitmap;
            Graphics g = Graphics.FromImage(pctFirma.Image);
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
                using (Graphics g = Graphics.FromImage(pctFirma.Image))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }
                previousPoint = e.Location;
                pctFirma.Invalidate();
            }
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDrawing = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
