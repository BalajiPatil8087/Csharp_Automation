using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class AddEvenCount
    {
        static void Main39(string[] args)
        {
            int count1 = 0, count2 = 0;
            int i = 1;
            for (; i <= 30; i++)
            {

                if ((5 * i) % 2 == 0)
                {
                    Console.WriteLine("it is even number" + 5*i);
                    count1++;
                }

                else
                {
                    Console.WriteLine("it is odd number" + 5*i);
                    count2++;

                }
                    Console.WriteLine(count1);

                }
            }


        }
    }

  


