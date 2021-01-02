using System;

namespace M1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone1 c= new Milestone1();
            Console.WriteLine("     Milestone 1");
            Console.WriteLine("---------Fase 1");
            c.fase1();
            Console.WriteLine("\n---------Fase 2");
            c.fase2y3();
            Console.WriteLine("\n---------Fase 4");
            c.fase4();

            Console.WriteLine("\n       Milestone 2");
            Milestone2 a = new Milestone2();
            a.exe();


            Console.WriteLine("\n       Milestone 3");
            Milestone3 b = new Milestone3();
            b.exe();
        }
    }
}
