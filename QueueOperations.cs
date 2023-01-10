namespace Day14StaQueue
{

    public class QNode
    {
        public int data;
        public QNode next;
        public QNode(int value)
        {
            this.data = value;
            this.next = null;
        }
    }
    public class MyQueue
    {
        public QNode head;
        public QNode tail;
        public int count;
        public MyQueue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public int size()
        {
            return this.count;
        }
        public bool isEmpty()
        {
            return this.count == 0;
        }
        // Add new node of queue
        public void enqueue(int value)
        {
            // Create a new node
            var node = new QNode(value);
            if (this.head == null)
            {
                // Add first element into queue
                this.head = node;
            }
            else
            {
                // Add node at the end using tail 
                this.tail.next = node;
            }
            Console.WriteLine("the data is: "+node.data);
            this.count++;
            this.tail = node;
        }
        // Delete a element into queue
        public int dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            // Pointer variable which are storing 
            // the address of deleted node
            var temp = this.head;
            // Visit next node 
            this.head = this.head.next;
            this.count--;
            if (this.head == null)
            {
                // When deleting a last node of linked list
                this.tail = null;
            }
            return temp.data;
        }
        // Get front node
        public int peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            return this.head.data;
        }
        public static void Main(String[] args)
        {
            var task = new MyQueue();
            // Initially number of element
          //  Console.WriteLine("isEmpty : " + task.isEmpty());
            // Add element into queue
            task.enqueue(56);
            task.enqueue(30);
            task.enqueue(70);
            
            // Test other function
           
                Console.WriteLine();
                Console.WriteLine("size : " + task.size());
                Console.WriteLine("peek : " + task.peek());
                Console.WriteLine("dequeue : " + task.dequeue());
                Console.WriteLine("size : " + task.size());
                Console.WriteLine("peek : " + task.peek());
                Console.WriteLine("isEmpty : " + task.isEmpty());
            
        }
    }
}
