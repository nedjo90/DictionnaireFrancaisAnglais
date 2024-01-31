using System;
using System.Collections.Generic;
using System.IO;

namespace DictionnaireFrançaisAnglais
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictionnaire = new Dictionary<string, string>();
            StreamReader reader = new StreamReader("/Users/necatihan/RiderProjects/DictionnaireFrançaisAnglais/5000_wordlist_french.csv");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] tab = line.Split(',');
                string key = tab[1];
                string value = "";
                for (int i = 2; i < tab.Length; i++)
                {
                    value += tab[i] + " ";
                }
                dictionnaire.Add(key, value);
            }

            bool choix = true;
            while (choix)
            {
                Console.Write("Choisir un mot à traduire en anglais (stop pour arrêter le prgramme):\t");
                string mot = Console.ReadLine();
                if (mot == "stop")
                {
                    choix = false;
                }
                else if (dictionnaire[mot] != null)
                {
                    Console.WriteLine(dictionnaire[mot]);
                }
                else
                {
                    Console.WriteLine("Ce mot n'est pas dans le dictionnaire");
                }
            }
        }
    }
}