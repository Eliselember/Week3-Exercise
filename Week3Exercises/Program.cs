using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //Kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesdta oma PIN-kood:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if (userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
            
            
            

        }
    }
}
