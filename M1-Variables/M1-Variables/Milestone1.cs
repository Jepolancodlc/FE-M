using System;
using System.Collections.Generic;
using System.Text;

namespace M1_Variables
{
    class Milestone1
    {    
        //Fase 1
        string nom = "John", apellido1 = "Polanco", apellido2 = "De La Cruz";
        int dia = 01, mes = 01, año = 2021;
        public void fase1()
        {
   
            Console.WriteLine("{0} {1} {2}", nom, apellido1, apellido2);
            Console.WriteLine("{0} / {1} / {2}", dia, mes, año);
        }
        //Fase 2 y 3

        int AÑOBIS = 1948, MIAÑO = 2000;
        int contadorAñosbi = 0;
        //bool esAñoBi = false;  <--  "Hecho ya que  el enunciado lo pide, pero dado a que "DateTime.IsLeapYear" es ya un bool no me hace falta "
        string siEs = "Mi año de nacimiento SI es bisiesto", noEs = "Mi año de nacimiento NO es bisiesto";

        public void fase2y3()
        {

         
            for (int i = AÑOBIS; i <= MIAÑO; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    contadorAñosbi++;
                }
            }
            Console.WriteLine("El numero de años bisiestos entre {0} y {1} es {2}", AÑOBIS, MIAÑO, contadorAñosbi);
            if (DateTime.IsLeapYear(MIAÑO) == true)
            {
                // esAñoBi = true;
                Console.WriteLine(siEs);
            }
            else
            {
                Console.WriteLine(noEs);
            }
        }

        //Fase 4

        public void fase4()
        {
            string nombre = nom +" "+ apellido1;
            string fechaDeNac = dia + "/" + mes +"/" + año;
            Console.WriteLine(nombre);
            Console.WriteLine(fechaDeNac);
            Console.WriteLine(siEs);
        }

    }
}
