using System;

namespace formationintermediate19
{
    public class UiControl
    {
        public class TextBox : UiControl, Size, IDraggable, IDroppable
        {
            public void Drag()
            {
                throw new NotImplementedException();
            }

            public void Drop()
            {
                throw new NotImplementedException();
            }
        }
        public string Id { get; set; }
        public Size Size{ get; set; }
        public Position TopLeft { get; set; }

        public void Draw()
        {

        }

        public void focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}
