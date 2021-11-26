using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
            Console.WriteLine();
            Console.WriteLine("Entrez une combinaison");
            proposition = Console.ReadLine();
        }
        //Cette fonction permet à l'ordinateur de choisir une combinaison de 4 chiffres
        static void ChoixCombi(out int[] combi)
        {
            
            combi = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }

        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(combi[i]);
            }

        

        }
		
		 static void StringToArray(string proposition, out int[] propositionTableau)
        {
            propositionTableau = new int[4];

            for (int i = 0; i <= 3; i++)
            {
                propositionTableau[i] = proposition[i];
            }
        }

        static void VerifierPionsRouges(int[] propositionTableau, int[] combi, out int nombrePionRouge)
		{
            nombrePionRouge = 0;

            for (int i = 0; i <= 3; i++)
			{
                if(propositionTableau[i] == combi[i])
				{
                    nombrePionRouge++;
                    propositionTableau[i] = -1;
                    combi[i] = -2;
                }
                
               

			}

		}
        static void VerifierPionsBlancs(int[] propositionTableau, int[] combi, out int nombrePionBlanc)
        {
            nombrePionBlanc = 0;

            for (int i = 0; i <= 3; i++)
            {
                for (int i =)
                if (propositionTableau[i] == combi[i])
                {
                    nombrePionBlanc++;
                    propositionTableau[i] = -1;
                    combi[i] = -2;
                }
            }

        }
    }
}
    
  