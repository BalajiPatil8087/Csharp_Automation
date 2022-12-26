using Math.CSharpAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class value
    {
        static void Main2(string[] args)
        {
            //Calling Volumn Related Formula
            //printing my name
            double output=Volume.VolumnOfSphere(12);
            Console.WriteLine(output);

            double output1 = Volume.VolumnOfCone(8,12);
            Console.WriteLine(output1);

            Volume Obj = new Volume();

            double output3 = Obj.VolumnOfCuboid(20, 20, 20);
            Console.WriteLine(output3);

            double output4 = Obj.VolumnOfCuboid(10, 10, 10);
            Console.WriteLine(output4);

            double output5= Volume.VolumnOfHemiSphere(7);
            Console.WriteLine(output5);

            String output6 = Volume.AuthorName();
           Console.WriteLine(output6);
        }
    }
}
