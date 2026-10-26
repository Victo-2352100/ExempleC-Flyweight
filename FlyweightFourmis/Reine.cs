using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class Reine: TypeFourmi
    {
        string nom;
        public override void Agir()
        {
            //Pondre des oeufs
            Random nbrOeufs = new Random();
            nbrOeufs.Next(6, 24);
            Console.WriteLine($"La reine a pondu {nbrOeufs} oeufs!");
        }
    }
}
