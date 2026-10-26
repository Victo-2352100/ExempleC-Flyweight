using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class FourmiSimulee
    {
        private Fourmi fourmi;
        private int niveauFaim;
        private int niveauSante;

        public double GetTaille()
        {
            return fourmi.GetTaille();
        }
        public Color GetCouleur()
        {
            return fourmi.GetCouleur();
        }
        public FourmiSimulee(Fourmi fourmi, int niveauFaim, int niveauSante)
        {
            this.fourmi = fourmi;
            this.niveauFaim = niveauFaim;
            this.niveauSante = niveauSante;
        }
    }
}
