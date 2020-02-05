using System;

namespace Abstract_class_Program
{

    public class MoneyExchange : Convertor
    {
        public override double RupeeToDollar(double amount)
        {
            return amount = amount * 70;

        }
        public override double DollarToRupee(double amount)
        {

            return amount = amount / 70;

        }

        public override double RupeeToYen(double amount)
        {
            return amount = amount * 1.54;
        }
        public override double YenToRupee(double amount)
        {
            return amount = amount / 1.54;
        }
    }
}

