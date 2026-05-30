using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace BDDistribuida
{
    public partial class Gráfo : Form
    {

        public Gráfo()
        {
            InitializeComponent();
            Paint += Gráfo_Paint;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gráfo_Load(object sender, EventArgs e)
        {

        }

        private void Gráfo_Paint(object? sender, PaintEventArgs e)
        {
            using (Pen pluma = new Pen(Color.DarkSlateGray, 3))
            {
                pluma.EndCap = LineCap.ArrowAnchor;

                DibujarFlecha(e.Graphics, pluma, Localidad1, Localidad2);
                DibujarFlecha(e.Graphics, pluma, Localidad2, Localidad3);
                DibujarFlecha(e.Graphics, pluma, Localidad3, Localidad6);
                DibujarFlecha(e.Graphics, pluma, Localidad1, Localidad5);
                DibujarFlecha(e.Graphics, pluma, Localidad5, Localidad6);
                DibujarFlecha(e.Graphics, pluma, Localidad4, Localidad5);
                DibujarFlecha(e.Graphics, pluma, Localidad4, Localidad7);
                DibujarFlecha(e.Graphics, pluma, Localidad7, Localidad8);
                DibujarFlecha(e.Graphics, pluma, Localidad8, Localidad9);
                DibujarFlecha(e.Graphics, pluma, Localidad5, Localidad9);


            }
        }

        private void DibujarFlecha(Graphics g, Pen p, Control origen, Control destino)
        {

            Point p1 = new Point(origen.Left + (origen.Width / 2), origen.Top + (origen.Height / 2));


            Point p2 = new Point(destino.Left + (destino.Width / 2), destino.Top + (destino.Height / 2));


            g.DrawLine(p, p1, p2);
        }



        public void ResaltarNodos(List<string> nombresNodos)
        {
            foreach (Control c in this.Controls)
            {

                if (c.Name.StartsWith("Localidad"))
                {
                    // Asumiendo que el texto dentro del cuadro es "L1", "L2", etc.
                    if (nombresNodos.Contains(c.Text))
                        c.BackColor = Color.LightGreen; // Nodo activo
                    else
                        c.BackColor = Color.LightGray;  // Nodo inactivo
                }

                c.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
