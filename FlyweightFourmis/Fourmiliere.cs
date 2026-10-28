using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class Fourmiliere
    {
        public List<FourmiSimulee> fourmisSimulees;
        private List<Fourmi> fourmis;
        /// <summary>
        /// Méthode qui crée une nouvelle fourmi à sa naissance
        /// </summary>
        /// <returns>La nouvelle fourmi</returns>
        public FourmiSimulee NaissanceFourmi(int indexModele)
        {
            if (fourmisSimulees == null)
                fourmisSimulees = new List<FourmiSimulee>();
            double[] positionFourmi = { 0, 0, 0 };
            FourmiSimulee fourmiNee = new FourmiSimulee(fourmis[indexModele],positionFourmi , 3, 5);
            fourmisSimulees.Add(fourmiNee);
            return fourmiNee;
        }
        /// <summary>
        /// Méthode qui choisi la nouvelle reine selon la taille des candidates
        /// </summary>
        /// <param name="candidates">Liste des candidates à devenir reine</param>
        /// <returns>La fourmi qui deviendra reine</returns>
        private FourmiSimulee NouvelleReine(FourmiSimulee[] candidates)
        {
            FourmiSimulee fourmiChoisie = candidates[0];
            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i].GetTaille() > fourmiChoisie.GetTaille())
                {
                    fourmiChoisie = candidates[i];
                }
            }
            
            return fourmiChoisie;
        }

        public void AjouterFourmi(double taille, Color couleur, TypeFourmi type)
        {
            if (fourmis == null)
            {
                fourmis = new List<Fourmi>();
            }
            fourmis.Add(new Fourmi(taille, couleur, type));
        }
    }
}
