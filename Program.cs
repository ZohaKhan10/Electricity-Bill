using System;

namespace Electricbill
{
    public abstract class ElectricBill
        {
        public int unit;
        public double totalAmount;
        public double tax;
        public int getUnit()
            
        {
            return unit;
        }

        public void setUnit()
        {
            Console.WriteLine("Enter the number of units consumed");
            unit = Convert.ToInt32(Console.ReadLine());
        }

        public abstract double Bill();

    }

    class Residential:ElectricBill
    {
       

        public override double Bill()
        {
            if (unit <= 100)
            {
                totalAmount = (unit * 5);
            }
            else if (unit > 100 && unit <= 200)
            {
                totalAmount = (100 * 5) + (unit - 100) * 17;
            }

            else if (unit > 200 && unit <= 500)
            {
                totalAmount = (100 * 5) + (100 * 17) + (unit - 200) * 23;
            }

            else if (unit > 500)
            {
                totalAmount = (100 * 5) + (100 * 17) + (100 * 10) + (unit - 500) * 69;
            }

            else
            {
                Console.WriteLine("Theammount entered is incorrect");
            }

            totalAmount = totalAmount * 0.17;

            return totalAmount;
        }


    }

    class Commercial:ElectricBill
    {
      
             public override double Bill()
        {
            if (unit <= 100)
            {
                totalAmount = (unit * 8);
            }
            else if (unit > 100 && unit <= 200)
            {
                totalAmount = (100 * 5) + (unit - 100) * 21;
            }

            else if (unit > 200 && unit <= 500)
            {
                totalAmount = (100 * 5) + (100 * 17) + (unit - 200) * 23;
            }

            else if (unit > 500)
            {
                totalAmount = (100 * 5) + (100 * 17) + (100 * 10) + (unit - 500) * 79;
            }

            else
            {
                Console.WriteLine("Theammount entered is incorrect");
            }

            totalAmount = totalAmount * 0.13;

            return totalAmount;
        }


}


    class Program
    {
        static void Main(string[] args)
        {
            ElectricBill E = new Residential();
           
            E.setUnit();
            Console.WriteLine("The Total bill for residential is:"+E.Bill());

            ElectricBill C = new Commercial();
            Console.WriteLine("The Total bill for commercial is:" + C.Bill());

        }
    }
}
