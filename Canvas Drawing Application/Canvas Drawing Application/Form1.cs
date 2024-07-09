using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point lastPoint;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = drawingPanel.CreateGraphics();
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Pen pen = new Pen(Color.Black, 2);
                graphics.DrawLine(pen, lastPoint, e.Location);
                lastPoint = e.Location;
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
