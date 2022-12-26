using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class OddLimit
    {
        static void Main6(string[] args)
        {
          
            int sum = 0;
            for (int i = 1; i <= 15; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine("The sum of the all odd from 1 to 10 is : " + sum);

        }
    }
}
