using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class Garde:TypeFourmi
    {
        string nom;
        public override void Agir()
        {
            //Surveiller les intrus
            Random nbrIntrus = new Random();
            int intrusRepousses = nbrIntrus.Next(0, 6);
            Console.WriteLine($"Le garde {(intrusRepousses == 0 ? "reste proche de la reine et attentif" : "a repoussé " + intrusRepousses + " intrus !")}");
        }
    }
}
