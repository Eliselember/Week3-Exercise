using System;

namespace AnddExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Mitu punkti sa said matemaatikas?");
            int Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu punkti sa said keemias?");
            int Chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu punkti sa said bioloogias?");
            int biology = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma eksami punktid:");

            if(Math >= 85 && Chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Tubli saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("Ei ole võimalik arstik õppida");
            }
           
             
        }
    }
}
