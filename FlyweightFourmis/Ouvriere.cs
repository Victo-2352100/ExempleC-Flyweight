using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFourmis
{
    public class Ouvriere: TypeFourmi
    {
        string nom;
        public override void Agir()
        {
            //Transporter nourriture vers face
            Console.WriteLine("L'ouvrière a rapporté une miche de pain");
        }
    }
}
