using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müşteri müşteri1 = new Müşteri();
            müşteri1.MüşteriAdı = "ahmet";
            müşteri1.Kredisi = "ihtiyaç kredisi";
            müşteri1.limiti = 15000;
            
            

            Müşteri müşteri2 = new Müşteri();
            müşteri2.MüşteriAdı = "başak";
            müşteri2.Kredisi = "nakit destek kredisi";
            müşteri2.limiti = 40000;
            

            Müşteri müşteri3 = new Müşteri();
            müşteri3.MüşteriAdı = "damla";
            müşteri3.Kredisi = "sezonluk malzeme kredisi";
            müşteri3.limiti = 50000;
           

            Müşteri müşteri4 = new Müşteri();
            müşteri4.MüşteriAdı = "tayfun";
            müşteri4.Kredisi = "araç alım kredisi";
            müşteri4.limiti = 60000;
            

            Müşteri[] müşteriler = new Müşteri[] {müşteri1,müşteri2,müşteri3,müşteri4 };

            foreach (Müşteri müşteri in müşteriler)
            {
                Console.WriteLine(müşteri.MüşteriAdı);
                Console.WriteLine(müşteri.Kredisi);
                Console.WriteLine(müşteri.limiti);
                Console.WriteLine("--------------------------");
            }

            İşlemManager işlemManager = new İşlemManager();
            işlemManager.Müşteri(müşteri1);
            işlemManager.Müşteri(müşteri2);
            işlemManager.Müşteri(müşteri3);
            işlemManager.Müşteri(müşteri4);
            Console.WriteLine("---------------");

            işlemManager.Müşteriler("tümü");

            









        }
    }
}
