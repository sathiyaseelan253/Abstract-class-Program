using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Program
{
    class UserInput
    {
        public void GetInput()
        {
            Console.WriteLine("Enter the amount:");
            int amount = int.Parse(Console.ReadLine());
            MoneyExchange money = new MoneyExchange();

            Console.WriteLine("Your Converted money in Dollars from rupee:");
            Console.WriteLine(money.RupeeToDollar(amount));
            Console.WriteLine("Your Converted money in Rupees from dollar");
            Console.WriteLine(money.DollarToRupee(amount));
            Console.WriteLine("Your Converted money in Rupees from yen currency:");
            Console.WriteLine(money.RupeeToYen(amount));
            Console.WriteLine("Your Converted money in yen from rupee currency:");
            Console.WriteLine(money.YenToRupee(amount));

        }
    }
}
