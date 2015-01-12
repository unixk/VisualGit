using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunstbryan
{
    public partial class Form1 : Form
    {
        private dbConnectie db = new dbConnectie();
        private Random random = new Random();        

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            List<Figuur> alleFiguren = db.AlleFiguren();

            foreach (Figuur f in alleFiguren)
            {
                if(f._Soort == "Circle")
                {
                    e.Graphics.FillEllipse(Brushes.Red, f._X, f._Y, f._Width, f._Height);
                }
                else if(f._Soort == "Rectangle")
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, f._X, f._Y, f._Width, f._Height);
                }
                else if (f._Soort == "Line")
                {
                    e.Graphics.DrawLine(Pens.Blue, f._X, f._Y, f._Width, f._Height);

                }
            }
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            db.nieuwFiguur("Circle", random.Next(0, panel1.Width), random.Next(0, panel1.Height), random.Next(0, panel1.Height) / 3, random.Next(0, panel1.Height) / 3);
            panel1.Refresh();
        }

        private void btnRechthoek_Click(object sender, EventArgs e)
        {
            db.nieuwFiguur("Rectangle", random.Next(0, panel1.Width), random.Next(0, panel1.Height), random.Next(0, panel1.Height) / 3, random.Next(0, panel1.Height) / 3);
            panel1.Refresh();
        }

        private void btnLijn_Click(object sender, EventArgs e)
        {
            db.nieuwFiguur("Line", random.Next(0, panel1.Width), random.Next(0, panel1.Height), random.Next(0, panel1.Height) / 3, random.Next(0, panel1.Height) / 3);
            panel1.Refresh();
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            db.tabelWissen();
            panel1.Refresh();
        }
    }
}
