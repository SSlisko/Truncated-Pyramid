using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyramidenstumpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pyramid p1 = new Pyramid();

        public void btnRechnen_Click(object sender, EventArgs e)
        {
            double DeckseiteA = Convert.ToDouble(txtDeckseiteA.Text);
            double DeckseiteB = Convert.ToDouble(txtDeckseiteB.Text);
            double BasisseiteA = Convert.ToDouble(txtBasisseiteA.Text);
            double BasisseiteB = Convert.ToDouble(txtBasisseiteB.Text);
            double Hoehe = Convert.ToDouble(txtHoehe.Text);

            p1.DeckseiteA = DeckseiteA;
            p1.DeckseiteB = DeckseiteB;
            p1.BasisseiteA = BasisseiteA;
            p1.BasisseiteB = BasisseiteB;
            p1.Hoehe = Hoehe;

            double Volume = p1.PyramidVolume;
            double LateralSurface = p1.PyramidLateralSurface;
            double BasisflaecheAB = p1.Basisseiteab;
            double Basisflaecheab = p1.Deckseiteab;

            txtVolumen.Text = Volume.ToString();
            txtManteflaeche.Text = LateralSurface.ToString();
            txtBasisflaecheAB.Text = BasisflaecheAB.ToString();
            txtBasisflaecheAB2.Text = Basisflaecheab.ToString();
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            txtDeckseiteA.Clear();
            txtDeckseiteB.Clear();
            txtBasisseiteA.Clear();
            txtBasisseiteB.Clear();
            txtHoehe.Clear();
            txtVolumen.Clear();
            txtManteflaeche.Clear();
            txtBasisflaecheAB.Clear();
            txtBasisflaecheAB2.Clear();
        }
    }
}
