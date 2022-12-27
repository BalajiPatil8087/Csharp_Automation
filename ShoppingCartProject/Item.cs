using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Item
    {
        public int FieldID;
        public string Descr;
        public int Quantity;
        public double Price;
        public void PrintItemDetails()
        {
            Console.WriteLine("Field ID: " + FieldID);
            Console.WriteLine("Description: " + Descr);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price: " + Price);

        }
        public void PrintDiscountPrice()
        {
            if (Quantity == 2)
            {
                Console.WriteLine(Price + (Price * 10 / 100));
            }
            else if(Quantity>=3 && Quantity <= 5)
            {
                Console.WriteLine(Price + (Price * 15 / 100));
            }
            else if (Quantity >= 5)
            {
                Console.WriteLine(Price + (Price * 25 / 100));
            }
            else
            {
                Console.WriteLine("No Discount");
            }
        }
    }
}
