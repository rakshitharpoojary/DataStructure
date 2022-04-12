namespace DataStructurePracticePrograms.Queue
{
    internal class Queue
    {
        private int[] arr;
        private int capacity;
        private int Front;
        private int Rear;

        public Queue(int size)
        {
            arr = new int[size];
            capacity = size;
            Front = -1;
            Rear = -1;
        }

        public void Enqueue(int val)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                Console.ReadLine();
                return;
            }
            if (Front == -1)
                Front = 0;
            arr[++Rear] = val;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Removed: " + arr[++Front]);
        }

        public bool IsFull()
        {
            return Front == 0 && Rear == capacity - 1;
        }

        public bool IsEmpty()
        {
            return Front == -1;
        }

        public void PrintElements()
        {
            for (int i = Front; i <= Rear; i++)
            {
                Console.WriteLine(arr[i] + "\n");
            }
        }

        public static void Main()
        {
            Queue queue = new Queue(4);

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