using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class Fourmi
    {
        private double taille;
        private Color couleur;
        //public TypeFourmis type;
        public Fourmi(double taille, Color couleur)
        {
            this.taille = taille;
            this.couleur = couleur;
        }
        public Color GetCouleur()
        {
            return couleur;
        }
        public double GetTaille()
        {
            return taille;
        }
    }
}
