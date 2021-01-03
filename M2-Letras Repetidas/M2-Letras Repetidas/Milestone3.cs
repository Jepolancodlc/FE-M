using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace M2_Letras_Repetidas
{
    class Milestone3
    {
        public void exe()
        {
            for (int h = 00; h <= 23; h++)
            {
                for (int m = 00; m <= 59; m++)
                {
                    for (int s = 00; s <= 59; s++)
                    {
                        Thread.Sleep(1000);
                        string segundo = s.ToString().PadLeft(2, '0');
                        string minuto = m.ToString().PadLeft(2, '0');
                        string hora = h.ToString().PadLeft(2, '0');
                        Console.WriteLine("{0}:{1}:{2}",hora,minuto,segundo);

                        if (h == 23 && m == 59 && s == 59)
                        {
                            Console.WriteLine(" 00:00:00");
                            h = 0; m = 0; s = 0;
                        }
                    }

                }
            }
        }
    }
}
