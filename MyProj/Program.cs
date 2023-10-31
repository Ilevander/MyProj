using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ecrire un code C# qui demande à l’utilisateur de saisir une chaine de caractères (un mois).
Affiche le nombre de jours de ce mois (28, 30 ou 31).
 */

namespace MyProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> moisEtJour = new Dictionary<String, int>
            {
                {"janvier", 31 },
                {"février", 28 },
                {"Mas" ,31 },
                {"avril1",30 },
                {"mai", 31 },
                {"juin",30 },
                {"août", 31 },
                {"september" , 30 },
                {"october", 31 },
                {"novembre",30 },
                {"décembre",31 }
            };

            Console.Write("Entrer le mois souhaité : ");
            string mois = Console.ReadLine().ToLower();

            if (moisEtJour.ContainsKey(mois))
            {
                int nombreJour = moisEtJour[mois];
                Console.WriteLine($"Le mois que vous avez choisis est : {mois} , son nombre de jour est : {nombreJour}");
            }
            else
                Console.WriteLine("Mois Invalide , RESSAYEZ !! essayer de la saisir de cette manière : (janvier,févrifier......)");
            Console.WriteLine("Tapper qlq chose pour quiter !! ");
            Console.ReadLine();
        }
    }
}
