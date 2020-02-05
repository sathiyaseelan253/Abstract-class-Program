using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Program
{
    public abstract class Convertor
    {
        protected int amount;
        public abstract double RupeeToDollar(double amount);

        public abstract double DollarToRupee(double amount);

        public abstract double RupeeToYen(double amount);

        public abstract double YenToRupee(double amount);
    }


    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.GetInput();
        }
    }
}
