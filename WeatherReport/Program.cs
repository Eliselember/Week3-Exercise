using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on;
            //kui õues on rohkrm kui 35 kraadi, programm kuvab "Boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot";
            //kui õues on 20 kuni 30 kraadi, programm kuvab "Nice";
            //kui õues on 10 kuni 20 kraadi, programm kuvab "Chilly";
            //kui õues on 0 kuni 10 kraadi, programm kuvab "Cold";

            Console.WriteLine("mitu kraadi õues on?");
            int temp = Convert.ToInt32(Console.ReadLine());
            
            if (temp >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (temp >= 30 && temp < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("Nice");
            }
            else if (temp > 10 && temp < 20)
            {
                Console.WriteLine("Chilly");
            }
            else if (temp >=0 && temp < 10)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("Freezing Gold.");
            }
        }
    }
}
