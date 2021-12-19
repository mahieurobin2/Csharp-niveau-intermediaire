namespace formationintermediate17
{
    public class Order
    {
        public float TotalPrice { get; internal set; }
        public bool IsShipped { get; internal set; }
        public Shipment Shipment { get; internal set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}