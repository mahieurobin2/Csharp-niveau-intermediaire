using System;

namespace formationintermediate10
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promoted logic changed.");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
