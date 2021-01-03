using System;

namespace M2_Letras_Repetidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|||||||||||||||||||    Milestone 1\n");
            Milestone1 a = new Milestone1();
            Console.WriteLine("----------Fase 1");
            a.fase1();
            Console.WriteLine("----------Fase 2");
            a.fase2();
            Console.WriteLine("----------Fase 3");
            a.fase3();
            Console.WriteLine("----------Fase 4");
            a.fase4();

            Console.WriteLine("\n\n|||||||||||||||||||    Milestone 2");
            Milestone2 b = new Milestone2();
            b.exe();

            Console.WriteLine("\n\n|||||||||||||||||||    Milestone 3\n");
            Milestone3 c= new Milestone3();
            c.exe();
        }
    }
}
