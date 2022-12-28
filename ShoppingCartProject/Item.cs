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
        private int quantity;
        public double Price;


        //public Item()
        //{
        //    quantity = 1;
        //    Console.WriteLine("Object Created");
        //}

        public Item(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
             set
            {
                //write
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity cannot be negative ");
                }
            }
        }
        public void PrintItemDetails()
        {
            Console.WriteLine("Field ID: " + FieldID);
            Console.WriteLine("Description: " + Descr);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + Price);

        }
        public void PrintDiscountPrice()
        {
            //Discount calculation
            if (quantity == 2)
            {
                double price = (Price - (Price * 10 / 100)) * quantity;
                Console.WriteLine(price);

            }
            else if (quantity >= 3 && quantity < 5)
            {
                double price = (Price - (Price * 15 / 100)) * quantity;
                Console.WriteLine(price);

            }
            else if (quantity >= 5)
            {

                double price = (Price - (Price * 25 / 100)) * quantity;
                Console.WriteLine(price);
            }
            else
            {
                Console.WriteLine("No Discount");
            }
        }
    }
}
