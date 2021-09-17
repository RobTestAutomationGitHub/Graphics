using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTSM
{
    public partial class Form1 : Form
    {

        Graphics g = null;
        int aantalKnopen = 8;  //aantal bij starten app
        Knoop[] knopen_gen; //  coordinaten, random gegenereerde punten
        Knoop[] knopen_calc; // coordinaten, puntenvolgorde volgens een berekende route
        bool tekenRoute = false; //alleen de route tekenen nadat een route is berekend


        public Form1()
        {
            InitializeComponent();
            //eerste coordinaat naar rechts, tussen 0 en 1200
            //tweede coordinaat omlaag, tussen 0 en 1000
            this.Width = 1200;
            this.Height = 1000;
            if (aantalKnopen == 6)
            {
                btn_min.Enabled = false;
            }

            _lengteTextveld.Text = " ";
            _aantalTextveld.Text = aantalKnopen.ToString();
            knopen_gen = GenereerKnopen(aantalKnopen);  //genereer de set knopen waartussen later de route wordt berekend
        }

        //event wordt aangeroepen bij opstarten en na berekenen van een route via de opdracht panel2.refresh
        //dit event is aan het tweede panel gehangen via properties->klik op events->paint
        //in dit event wordt echt het scherm ververst
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            g = panel2.CreateGraphics();
            TekenKnopen(knopen_gen);
            if (tekenRoute)
            {
                TekenRoute();
                tekenRoute = false;
            }
        }

        Knoop[] GenereerKnopen(int aantalKnopen)
        {
            Knoop[] knopen = new Knoop[aantalKnopen];
            KnopenGenerator KG = new KnopenGenerator();
            knopen = KG.GeneerKnopen(aantalKnopen);
            return knopen;
        }

        private void _btn_route1_Click(object sender, EventArgs e)
        {
            knopen_calc = new Knoop[aantalKnopen];
            knopen_calc = BerekenRoute1(knopen_gen);

            //toon de lengte van de route
            _lengteTextveld.Text = GeefTotaleAfstand(knopen_calc).ToString();
            tekenRoute = true;
            panel2.Refresh();  //belangrijk!! anders wordt de route niet echt getoond
        }

        private void _btn_route2_Click(object sender, EventArgs e)
        {
            knopen_calc = new Knoop[aantalKnopen];
            knopen_calc = BerekenRoute2(knopen_gen);

            //toon de lengte van de route
            _lengteTextveld.Text = GeefTotaleAfstand(knopen_calc).ToString();
            tekenRoute = true;
            panel2.Refresh();
        }

        void TekenKnopen(Knoop[] knopen_gen)
        {
            //teken de gegenereerde knopen 
            PointF[]   _knopen = new PointF[knopen_gen.Length];
            //hevel gegenereerde coordinaten over naar grafische punten
            for (int i = 0; i <= knopen_gen.Length - 1; i++)
            {
                _knopen[i] = (new PointF(knopen_gen[i].getX(), knopen_gen[i].getY()));
            }


            Brush aBrush = (Brush)Brushes.Red;
            Brush bBrush = (Brush)Brushes.Black;
            //eerste knoop rood, de rest zwart
            g.FillRectangle(aBrush, _knopen[0].X, _knopen[0].Y, 10, 10);
            for (var i = 1; i < _knopen.Length; i++)
            {
                g.FillRectangle(bBrush, _knopen[i].X, _knopen[i].Y, 10, 10);
            }

        }

        void TekenRoute()
        {
            //het echte tonen gebeurt pas na aanroep van Panel2_Paint via panel2.refresh()

            Point[] lijnpunten = new Point[knopen_calc.Length];
           
            for (int i=0; i< knopen_calc.Length; i++)
            {
                lijnpunten[i] = new Point(knopen_calc[i].getX(), knopen_calc[i].getY());
            }
            //eerste lijnstuk
            Pen myPen = new Pen(Color.Red);
            g.DrawLine(myPen, lijnpunten[0].X, lijnpunten[0].Y, lijnpunten[1].X, lijnpunten[1].Y);
            //overige lijnstukken 
            myPen = new Pen(Color.Black);
            for (int i = 2; i < lijnpunten.Length; i++)
            {
                g.DrawLine(myPen, lijnpunten[i-1].X, lijnpunten[i-1].Y, lijnpunten[i].X, lijnpunten[i].Y);
            }
            //laatste lijnstuk naar de oorsprong ter sluiting
            g.DrawLine(myPen, lijnpunten[lijnpunten.Length-1].X, lijnpunten[lijnpunten.Length-1].Y, lijnpunten[0].X, lijnpunten[0].Y);

        }

        //brute force, alles doorrekenen
        Knoop[] BerekenRoute1(Knoop[] knopen_gen)
        {
            RouteBerekenaar1 RB1 = new RouteBerekenaar1();
            Knoop[] knopen_calc = RB1.ZoekRoute(knopen_gen);  
            return knopen_calc;
        }

        //nearest neighbour, gaat snel maar bij lage waarden niet beter dan brute force
        Knoop[] BerekenRoute2(Knoop[] knopen_gen)
        {
            RouteBerekenaar2 RB2 = new RouteBerekenaar2();
            Knoop[] knopen_calc = RB2.ZoekRoute(knopen_gen);
            return knopen_calc;
        }

        int GeefTotaleAfstand(Knoop[] knopen_calc)
        {
            return Afstandsberekenaar.BerekenRouteLengte(knopen_calc);
        }


        //ophogen aantal punten
        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (aantalKnopen == 8)
            {
                aantalKnopen = aantalKnopen + 3;
            }
            else
            {
                aantalKnopen = aantalKnopen + 2;
            }
            _aantalTextveld.Text = aantalKnopen.ToString();
            if (aantalKnopen > 6)
            {
                btn_min.Enabled = true;
            }
            else
            {
                btn_min.Enabled = false;
            }
            if (aantalKnopen >= 25)
            {
                btn_plus.Enabled = false;
                _btn_route1.Enabled = false;
            }
            //brute force bij max 11 knopen, duurt duurt te lang
            if (aantalKnopen >11)
            {
                _btn_route1.Enabled = false;
            }
            else
            {
                _btn_route1.Enabled = true;
            }

            knopen_gen = GenereerKnopen(aantalKnopen);

            _lengteTextveld.Text = "";
            panel2.Refresh(); //triggert Panel2_Paint en daarmee hertekenen

        }

        //verlagen aantal punten
        private void btn_min_Click(object sender, EventArgs e)
        {
            if (aantalKnopen == 11)
            {
                aantalKnopen = aantalKnopen - 3;
            }
            else
            {
                aantalKnopen = aantalKnopen - 2;
            }
            _aantalTextveld.Text = aantalKnopen.ToString();
            if (aantalKnopen == 6)
            {
                btn_min.Enabled = false;
            }
            if (aantalKnopen < 25)
            {
                btn_plus.Enabled = true;
            }
            knopen_gen = GenereerKnopen(aantalKnopen);

            _lengteTextveld.Text = "";
            panel2.Refresh();
        }
    }
}