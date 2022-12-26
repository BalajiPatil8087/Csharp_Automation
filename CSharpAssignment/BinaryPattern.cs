using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class BinaryPattern
    { 
        static void Main22(string[] args)
        {
            int i, j;
            for(i=1;i<=5;i++)
            {
                for (j=0;j <=i; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                    

                }
                
            }
            
        }
    }
}
