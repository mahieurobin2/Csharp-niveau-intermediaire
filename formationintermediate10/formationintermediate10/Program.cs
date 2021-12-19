using System;

namespace formationintermediate10
{
    class Program
    {
        public class GoldCustimer: Customer
        {
            public void OfferVouchar()
            {
                var rating = this CalculateRating(excludeOrders: true);
            }

            private void CalculateRating(bool excludeOrders)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
