using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sono presenti 10 ERRORI.
            // NON devi aggiungere NESSUNA riga 
            //    MA SISTEMARE e/o POSIZIONARE MEGLIO le righe presenti.
            //
            int quanti, meno1, meno2;
            do
            {
                Console.Write("Quanti numeri della sequenza vuoi? ");
                quanti = Console.ReadLine();
            } while(quanti>2);
            meno2 = 0;
            meno1 = 0;
            Console.Write("0 ; 1 ") ;
            for (int i=0;i<quanti;i++)
            {
                Console.Write("; "+attuale+" ");
                meno2 = attuale;
                meno1 = meno2;
                attuale = meno1 * meno2;
            }
        Console.ReadLine(); 
        }
    }
}
