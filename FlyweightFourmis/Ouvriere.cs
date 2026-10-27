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
            string[] nourriture = new string[]
            {
                "miche de pain",
                "goutte d'eau",
                "noisette",
                "paille",
                "amande"
            };
            Random indexNourriture = new Random();
            int indexTrouve = indexNourriture.Next(0, nourriture.Length);
            Console.WriteLine($"L'ouvrière a rapporté une {nourriture[indexTrouve]}");
        }
    }
}
