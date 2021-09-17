using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDiversen01
{
    public partial class Form1 : Form
    {
        //zie https://www.youtube.com/watch?v=PRpYDTegGyo
        //C# Programming - Drawing Using The Graphics Class

        //opgelet: rechterklik op het scherm van Form1 en in de properties naar de events gaan
        //         kies daar Form1_Paint bij het Paint event
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Red);
            //x van 0 (linksboven) tot oplopend
            //y van 0 (linksboven) tot oplopend,omlaag gericht
            //teken een lijn
            g.DrawLine (myPen, 2,2, 400,450);

            //teken een rechthoek
            g.DrawRectangle(myPen, 100, 100, 200, 150);

            //teken een ellipse
            g.DrawEllipse(myPen, 100, 100, 200, 150);

            //teken een cirkel
            g.DrawEllipse(myPen, 150, 300, 70, 70);

            //teken  bogen
            g.DrawArc(myPen,400,100,50,50,0,90);
            g.DrawArc(myPen, 400, 200, 50, 50, 0, -100);

            //teken een string
            string myString = "Example text";
            Font myFont = new Font("Arial", 16);
            PointF drawPoint = new PointF(150.0F, 150.0F);
            e.Graphics.DrawString(myString,myFont,myBrush,drawPoint);

        }
    }
}
