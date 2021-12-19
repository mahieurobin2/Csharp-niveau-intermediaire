using System;

namespace testability
{
    internal class OrderProcessor
    {
        public OrderProcessor(FakeShippingCalculator fakeShippingCalculator)
        {
        }

        internal void Process(Order order)
        {
            throw new NotImplementedException();
        }
    }
}