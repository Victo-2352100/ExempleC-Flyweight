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
            Console.WriteLine("Le garde a repoussé 8 intrus!");
        }
    }
}
