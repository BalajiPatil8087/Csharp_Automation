using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmenttt1
{
    public class Agee
    {
        static void Main1(String[] args)
        {
            int smith = 25;
            int John = 45;
            int henry = 65;

            int younger = smith < John ? smith : John;
            int youngest = younger < henry ? younger : henry;

            Console.WriteLine("younger age is" + youngest);
            if (smith == John && John == henry)
            {
                Console.WriteLine("Smith, John, Henry are same age" + smith);
            }

        }
    }
}
