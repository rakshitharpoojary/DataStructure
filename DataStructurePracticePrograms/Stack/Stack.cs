namespace DataStructurePracticePrograms.Stack
{
    internal class Stack
    {
        private int[] array;
        private int capacity;
        private int top;

        public Stack(int size)
        {
            array = new int[size];
            capacity = size;
            top = -1;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                Console.ReadLine();
                return 1;
            }
            return array[top--];
        }

        public void Push(int val)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Inserting " + val);
            array[++top] = val;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Peek: " + array[top] + "\n");
        }

        public void PrintElementsOfStack()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(array[i] + "\n");
            }
        }

        public static void Main(string[] args)
        {
            Stack stack = new Stack(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.PrintElementsOfStack();

            stack.Pop();
            Console.WriteLine("After popping\n");
            stack.PrintElementsOfStack();

            stack.Peek();
        }
    }
}