using System;
using System.Collections.Generic;
using System.Text;

namespace M1_Variables
{
    class Milestone3
    {
        public void exe()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var temp = array[0];

            //Imprime array normal
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Write("\n");
            
            //Rota el array 1 posicion 
            for (int x = 0; x < array.Length - 1; x++)
            {
                array[x] = array[x+1];
            }
            array[array.Length - 1] = temp;

            //Imprime array rotado
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

    }
}
