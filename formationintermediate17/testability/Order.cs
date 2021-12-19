namespace testability
{
    internal class Order
    {
        public object Shipment { get; set; }
        public bool IsShipped { get; internal set; }
    }
}