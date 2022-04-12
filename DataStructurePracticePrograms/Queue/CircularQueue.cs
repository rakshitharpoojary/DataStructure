namespace DataStructurePracticePrograms.Queue
{
    internal class CircularQueue
    {
        private int[] queue;
        private int front;
        private int rear;
        private int capacity;

        public CircularQueue(int size)
        {
            queue = new int[size];
            front = -1;
            rear = -1;
            capacity = size;
        }

        public void Enqueue(int val)
        {
            if ((rear + 1) % capacity == front)
            {
                Console.WriteLine("Queue is full");
            }
            else if (front == -1 && rear == -1)
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity;
            }
            queue[rear] = val;
        }

        public void Dequeue()
        {
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else if (front == rear)
            {
                Console.WriteLine("Dequeued element: " + queue[front]);
                front = -1;
                rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;
                Console.WriteLine("Dequeued element: " + queue[front]);
            }
        }

        public void PrintElements()
        {
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("The elements are:");
                int i = front;
                while (i <= rear)
                {
                    Console.WriteLine(queue[i]);
                    if (i == rear)
                    {
                        break;
                    }
                    i = (i + 1) % capacity;
                }
            }
        }

        public static void Main(string[] args)
        {
            CircularQueue queue = new CircularQueue(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.PrintElements();

            queue.Dequeue();

            queue.PrintElements();
        }
    }
}