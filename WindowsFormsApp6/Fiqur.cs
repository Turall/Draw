using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Fiqur : IFiqur
    {
        public Form newForm;
        Pen pen;
        Graphics graphics;
        public void Circle( Color color)
        {
            newForm = new Form();
            newForm.Text = "Circle";
            newForm.Size = new Size(300, 300);
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            newForm.Show();
            graphics = newForm.CreateGraphics();
            pen = new Pen(color);
            graphics.DrawEllipse(pen, 80, 80, 80, 80);
            graphics.Dispose();
        }

        public void Rectangle( Color color)
        {
            newForm = new Form();
            newForm.Text = "Rectanglewindow";
            newForm.Size = new Size(300, 300);
            newForm.Visible = true;
            newForm.Show();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            graphics = newForm.CreateGraphics();
            pen = new Pen(color);
            graphics.DrawRectangle(pen, 80, 80, 80, 80);
            
            //graphics.Dispose();
        }

        public void Romb(Color color)
        {
            newForm = new Form();
            newForm.Text = "Romb";
            newForm.Size = new Size(300, 300);
            newForm.Visible = true;
            newForm.Show();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            graphics = newForm.CreateGraphics();
            pen = new Pen(color);
            
        }
    }
}
