using System;
using System.Data;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Creates FruitBox object and prints description
            FruitBox f1 = new FruitBox(2.95, 1.5);

            Console.WriteLine(f1.GetBoxContentDescription());

            //Adding fruit
            f1.AddApples(12);
            f1.AddBananas(7);

            Console.WriteLine(f1.GetBoxContentDescription());

            // Gets total price of FruitBox
            Console.WriteLine("The total price of the fruitbox is {0} kr", f1.GetTotalPrice());

            // Updates price of banana and apple and prints new total

            f1.NewBananaPrice(1);
            f1.NewApplePrice(1);
            Console.WriteLine("The total price of the fruitbox is {0} kr", f1.GetTotalPrice());


            // The LAST line of code should be ABOVE this line
        }
    }
}
