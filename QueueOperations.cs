namespace Day14StaQueue
{
    class Program
    {
        public class QueueNode
        {
            public int data;
            public QueueNode next;
            public QueueNode(int data)
            {
                this.data = data;
            }
        }

        QueueNode root;
     
        public void Enqueue(int data)
        {
            QueueNode newNode = new QueueNode(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                QueueNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
            Console.WriteLine("Item Enqueueed into stack = " + data);
        }

        public int Dequeue()
        {
            int Dequeued;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            else
            {

                QueueNode temp = root;
                while (root.next != null)
                {
                     temp = root;
                    root = root.next;

                }
                Dequeued = root.data;
                root = temp;
                return Dequeued;
            }
        }

        public int peek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return root.data;
            }
        }

        public static void Main(String[] args)
        {
            Program m = new Program();
            m.Enqueue(10);
            m.Enqueue(20);
            m.Enqueue(30);
            
            Console.WriteLine("Item Dequeueped from stack = " + m.Dequeue());
            Console.WriteLine(m.peek() + " Returned by Peek operation");

        }
    }


}
