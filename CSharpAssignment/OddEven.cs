using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class OddEven
    {
        static void Main31(string[] args)
        {
            int i = 0;
            int j = 30;
            for (i = 0; i < j; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("it is even number"+ i);
                }
                if(i % 2 != 0)
                {
                    Console.WriteLine("it is odd number" + i);
                }

               
            }
        }
    }
}
