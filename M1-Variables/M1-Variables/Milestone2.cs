using System;
using System.Collections.Generic;
using System.Text;

namespace M1_Variables
{
    class Milestone2
    {
        public void exe()
        {
            double D=12.2312;
            int I;
            float F;
            string S;

            I = (int)D;
            F = (float)D;
            S = D.ToString();

            Console.WriteLine("Int : {0}", I);
            Console.WriteLine("Float: {0}", F);
            Console.WriteLine("String : {0}",S);
        }
    }
}
