using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2_Letras_Repetidas
{
    class Milestone1
    {
        List<char> nomList = new List<char>();
        List<char> apellidoList = new List<char>();
        char[] nom = { 'J', 'O', 'H', 'N' };

        //Fase 1
        public void fase1()
        {
            for (int i = 0; i < nom.Length; i++)
            {
                Console.Write(nom[i]);
            }
            Console.WriteLine(" ");
        }



        public void fase2()
        {
            char[] vocales = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

            nomList.Add('J');
            nomList.Add('O');
            nomList.Add('H');
            nomList.Add('N');

            apellidoList.Add('P');
            apellidoList.Add('O');
            apellidoList.Add('L');
            apellidoList.Add('A');
            apellidoList.Add('N');
            apellidoList.Add('C');
            apellidoList.Add('O');

            // Fase 2
            foreach (char letra in nomList)
            {

                if (vocales.Contains(letra))
                {
                    Console.WriteLine("Vocal");
                }
                else if (char.IsNumber(letra))
                {
                    Console.WriteLine("Los nombres no contienen numeros!");
                }
                else
                {
                    Console.WriteLine("Consonante");
                }
            }
        }

        public void fase3()
        {
            Dictionary<char, int> nomListMap = new Dictionary<char, int>();

            foreach (char c in nomList)
            {
                if (nomListMap.ContainsKey(c))
                {

                    nomListMap[c]++;
                }
                else
                {
                    nomListMap.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in nomListMap)
            {
                Console.WriteLine("Caracter {0} se repite {1} veces",
                   kvp.Key, kvp.Value);
            }

        }


        public void fase4()
        {
            List<char> nomCompleto = new List<char>();

            for (int i = 0; i < nomList.Count; i++)
            {
                char letra = nomList[i];
                nomCompleto.Add(letra);
            }


            nomCompleto.Add(' ');

            foreach (char letra in apellidoList)
            {
                nomCompleto.Add(letra);
            }

            foreach (char letra in nomCompleto)
            {
                Console.Write(letra);
            }
        }
        
    }
}
