﻿using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
        }
        //Cette fonction permet à l'ordinateur de choisir une combinaison de 4 chiffres
        static void Choix combi() {
            combi = new int[4];
            for (int i = 0; i <= 3; i++) {
                Random rnd = new Random();
                //int valeur = rnd.Next(1. 7);
                combi[i] = valeur;
            }
        }

        static void Afficher() {
            for (int i = 0; i <= 3; i++)

                Console.Write(combi[i]);
        }
    } 
    
  