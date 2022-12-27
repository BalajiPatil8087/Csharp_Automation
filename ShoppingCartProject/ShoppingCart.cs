using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        static void Main(string[] args)
        {
            Item item1= new Item();
            Item item2 = new Item();
            Item item3 = new Item();

            item1.FieldID = 101;
            item1.Descr = "Laptop";
            item1.Quantity = 5;
            item1.Price = 45000;


            item2.FieldID = 102;
            item2.Descr = "Tshirts";
            item2.Quantity = 4;
            item2.Price = 4500;


            item3.FieldID = 103;
            item3.Descr = "Mobile";
            item3.Quantity = 1;
            item3.Price = 45000;

            item1.PrintItemDetails();
            item1.PrintDiscountPrice();


            item2.PrintItemDetails();
            item2.PrintDiscountPrice();


            item3.PrintItemDetails();
            item3.PrintDiscountPrice();

        }
    }
}
