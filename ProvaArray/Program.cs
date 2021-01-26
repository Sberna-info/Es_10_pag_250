using System;
using GestioneArray;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Se vuoi riempire l'array casualmente digita 1, Se invece lo vuoi riempire manualmente digita 2: ");
            bool riempi = Console.ReadLine() == "1";
            Gestione.Riempimento(riempi);
            Console.Write("Se vuoi visualizzare l'array da destra verso sinistra digita 1, se invece lo vuoi vedere da sinistra verso destra digita 2: ");
            bool stampa = Console.ReadLine() == "1";
            Gestione.Stampa(stampa);
            Console.ReadLine();

        }
    }
}
