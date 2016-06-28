using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst.Helper
{
    public static class GenerateurNom
    {
        private static Random rand = new Random(DateTime.Now.Millisecond);
        private static string[] Consonnes = new string[]
        {
            "m",
            "n",
            "r",
            "t",
            "s",
            "l",
            "f",
            "g",
            "z",
            "q",
            "b",
        };

        private static string[] Voyelles = new string[]
        {
            "a",
            "e",
            "i",
            "o",
            "u",
            "y",
        };

        private static string GenererSyllabe()
        {
            return Consonnes[rand.Next(Consonnes.Length)] + Voyelles[rand.Next(Voyelles.Length)];
        }

        public static string GenererNom()
        {
            return (rand.Next(2) == 1 ? "M. " : "Mme ") +
                GenererSyllabe() +
                GenererSyllabe() +
                GenererSyllabe();
        }


    }
}
