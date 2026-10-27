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
        private TypeFourmi type;
        //public TypeFourmis type;
        public Fourmi(double taille, Color couleur, TypeFourmi type)
        {
            this.taille = taille;
            this.couleur = couleur;
            this.type = type;
        }
        public Color GetCouleur()
        {
            return couleur;
        }
        public double GetTaille()
        {
            return taille;
        }
        public TypeFourmi GetType()
        {
            return type;
        }
        public void Agir()
        {
            type.Agir();
        }
    }
}
