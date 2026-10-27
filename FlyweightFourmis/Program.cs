// See https://aka.ms/new-console-template for more information
using FlyweightFourmis;

Console.WriteLine("Simulation de fourmis\n");
Fourmiliere fourmiliere = new Fourmiliere();

fourmiliere.AjouterFourmi(5.1, System.Drawing.Color.Black, new Garde());
fourmiliere.AjouterFourmi(5.1, System.Drawing.Color.Gray, new Ouvriere());
fourmiliere.AjouterFourmi(7.2, System.Drawing.Color.Red, new Reine());
bool reineAjoutee = false;
for (int i=0;i<1500;i++)
{
    Random rnd = new Random();
    int modeleChoisi = rnd.Next(0,3);
    //Une seule reine par fourmilière
    if (!reineAjoutee && modeleChoisi == 2)
    {
        //Ajouter une reine
        fourmiliere.NaissanceFourmi(2);
        
        reineAjoutee=true;    
    } 
    else
    {
        fourmiliere.NaissanceFourmi(
            modeleChoisi == 2 ? modeleChoisi = rnd.Next(0, 1) : modeleChoisi);
    }
    //Faire agir la nouvelle fourmi
    FourmiSimulee fourmisNouvelle = fourmiliere.fourmisSimulees.Last();
    fourmisNouvelle.GetTypeFourmi().Agir();
    Thread.Sleep(125);
}
