using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            FruitBox f1 = new FruitBox(2.95, 1.5);

            Console.WriteLine(f1.GetBoxContentDescription());

            f1.AddApples(12);
            f1.AddBananas(7);

            Console.WriteLine(f1.GetBoxContentDescription());
            Console.WriteLine("The total price of the fruitbox is {0} kr", f1.GetTotalPrice());

            // The LAST line of code should be ABOVE this line
        }
    }
}
