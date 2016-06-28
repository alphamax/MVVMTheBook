using BusinessIntelligence.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst.Helper
{
    public static class GenerateurNote
    {
        private static Random rand = new Random(DateTime.Now.Millisecond);
        private static string[] Academies = new string[]
        {
            "Versailles",
            "Paris",
            "Créteil",
            "Toulouse",
            "Bordeaux",
            "Lyon",
            "Strasbourg",
        };

        public static Note GenererNote()
        {
            return new Note()
            {
                Academie = Academies[rand.Next(Academies.Length)],
                Valeur = rand.Next(21),
            };
        }


    }
}
