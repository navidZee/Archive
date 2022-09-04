namespace Archive
{
    partial class SinglyLinkedList
    {
        public class Node
        {
            public Node()
            {
                Next = null;
            }

            public object Data { get; set; }
            public Node Next { get; set; }
        }

        private Node First { get => null; }

        public void Push(object data)
        {
            var newNode = new Node()
            {
                Data = data,
                Next = First
            };

        }

        public Node List
        {
            get
            {
                Node current = First;
                if (current == null)
                    return null;

                while (current.Next != null)
                    current = current.Next;

                return current;
            }
        }
    }
}