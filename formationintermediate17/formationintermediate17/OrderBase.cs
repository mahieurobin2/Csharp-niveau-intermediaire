namespace formationintermediate17
{
    public class OrderBase
    {
        public bool IsShipped { get; internal set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}