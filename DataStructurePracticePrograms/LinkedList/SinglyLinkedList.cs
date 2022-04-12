namespace DataStructurePracticePrograms.LinkedList
{
    internal class Node
    {
        public int data { get; set; }
        public Node? next { get; set; }

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class SinglyLinkedList
    {
        private Node? head;

        public static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();

            linkedList.head = new Node(1);

            Node secondNode = new Node(2);
            linkedList.head.next = secondNode;

            Node thirdNode = new Node(3);
            secondNode.next = thirdNode;

            Node fourthNode = new Node(4);
            thirdNode.next = fourthNode;

            while (linkedList.head != null)
            {
                Console.WriteLine(linkedList.head.data);
                linkedList.head = linkedList.head.next;
            }
        }
    }
}