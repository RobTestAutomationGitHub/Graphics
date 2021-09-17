using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDiversen02
{

    //zie https://www.youtube.com/watch?v=Jc5eXYwTROg
    //C# How to Use Paint and the C# Graphics Class to Draw Lines
    //opgelet: er is een event aan het onderste panel (genaamd canvas) gekoppeld, canvas_Paint
    //de naam canvas hier heeft niets te maken met het canvas dat je ziet bij sommige android-tekeningen
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;
        static int start_x, start_y;
        static int end_x, end_y;

        static int my_length = 0;
        static int my_angle = 0;
        static int my_amount = 0;

        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            my_length = Int32.Parse(length.Text);
            my_angle = Int32.Parse(angle.Text);
            my_amount = Int32.Parse(increment.Text);

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            canvas.Refresh();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

            myPen.Width = 1;
            my_length = Int32.Parse(length.Text);
            g = canvas.CreateGraphics();
            for (int i = 0; i < Int32.Parse(number_of_lines.Text); i++)

                drawline();
        }

        private void drawline()
        {

            my_angle = my_angle + Int32.Parse(angle.Text);
            my_length = my_length + Int32.Parse(increment.Text);

            end_x = (int)(start_x + Math.Cos(my_angle * .017453292519) * my_length);
            end_y = (int)(start_y + Math.Sin(my_angle * .017453292519) * my_length);

            Point[] points =
            {
                new Point(start_x, start_y),
                new Point(end_x, end_y)

            };

            start_x = end_x;
            start_y = end_y;


            g.DrawLines(myPen, points);

        }

    }
}
