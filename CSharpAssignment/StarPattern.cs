using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class StarPattern
    {
        static void Main(string[] args)
        {
            int length = 15;
            int width = 10;
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= width; j++)
                {
                    if (i == 0 || i == length || j == 0 || j == width)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }



                }
            }

        }
    }
}
