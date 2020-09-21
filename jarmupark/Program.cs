using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros", "Lada 2112", 11);
            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();

            Console.Write("Mennyit megy a lada? ");
            double km1 = double.Parse(Console.ReadLine());
            lada.Megy(km1);

            Console.WriteLine("fsjlkdjfé: {0}", lada.KM);
            Console.WriteLine("fsjlkdjfé: {0}", lada.MEGTEHETOKM);

            Console.Write("Mennyit megy a trabanrt? ");
            double km2 = double.Parse(Console.ReadLine());
            trabant.Megy(km2);

            Console.WriteLine("fsjlkdjfé: {0}", trabant.KM);
            Console.WriteLine("fsjlkdjfé: {0}", trabant.MEGTEHETOKM);


            Console.ReadKey();
        }
    }
}
