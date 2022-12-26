using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class EvenOdd1
    {
        static void Main2(string[] args)
        {
           
            int sum=0;
            int i = 0;
           
            for (i = 0; i <=50; i++)
            {
                if (i % 2 == 0)
                {
                   sum=sum+i;
                   
                }
             }
            Console.WriteLine( "The sum of the all even from 0 to 50 is : " +sum); 
            if(sum%2==0)
            {
                Console.WriteLine("it is even no" + sum);

            }else
            {
                Console.WriteLine("it is odd no" + sum);
            }
            

        }
    }
}
