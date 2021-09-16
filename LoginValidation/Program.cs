using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutajatunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutajatunnus või parool. Proovi uuesti";

            Console.WriteLine("Sisesta kasutajatunnus:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string Password = Console.ReadLine();

           /* if (UserName == "admin" && Password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
               
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }*/

            if(UserName != "admin" || Password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
