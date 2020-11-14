using System;

namespace _16.operatorsBreakContinueGoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int outerConter = 0;

            for (int outer = 0; outer <= 10 ; outer++)
            {
                for (int inner = 0; inner <= 10; inner++)
                {
                    if (inner % 3 == 0)
                    {
                        continue;
                    }
                    if (outer == 7)
                    {
                        break;
                    }
                    if ( (inner + outer) > 9 )
                    {
                        goto breakOut;
                    }
                    
                }
                breakOut:
                outerConter++;

            }
            
            Console.WriteLine("Hi" + " " + outerConter);
        }
    }
}
