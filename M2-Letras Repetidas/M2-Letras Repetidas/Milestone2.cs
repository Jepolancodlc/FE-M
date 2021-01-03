using System;
using System.Collections.Generic;
using System.Text;

namespace M2_Letras_Repetidas
{
    class Milestone2
    {
        public void exe()
        {
        Console.Write("\nIntroduzca la altura para la escalera de numero: ");
        int altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int z = 1; z < i; z++)
                {
                    Console.Write(z);
                }
                Console.WriteLine(i);
            }

            Console.Write("\nIntroduzca la altura para la piramide de asteriscos: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int y = a; y >= 1; y--)
            {
                for (int x = 1; x <= a - y; x++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= y; x++)
                {
                    Console.Write("*");
                }

                for (int x = 1; x <= y - 1; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        
        }
    }
}
