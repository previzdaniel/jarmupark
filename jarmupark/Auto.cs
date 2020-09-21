using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        public double UZEMANYAG
        {
            get { return uzemAnyag; }
        }

        private double fogyaszt;
        private double km;
        public double KM 
        {
            get { return km; }
        }

        private double megtehetoKm;
        public double MEGTEHETOKM
        {
            get { return megtehetoKm; }
        }

        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
        }

        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }

        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            Megteheto();
        }

        private void Megteheto()
        {
            megtehetoKm = uzemAnyag / fogyaszt * 100;
        }

        public void Allapot()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km}km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag}l");
            Console.WriteLine($"Megthető km: {megtehetoKm}km");
            Console.WriteLine("-----------------------------------");
        }
    }
}
