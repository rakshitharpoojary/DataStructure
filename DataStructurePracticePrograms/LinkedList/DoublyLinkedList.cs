namespace DataStructurePracticePrograms.LinkedList
{
    internal class DoublyLinkedListNode
    {
        public int data { get; set; }
        public DoublyLinkedListNode? next { get; set; }
        public DoublyLinkedListNode? prev { get; set; }

        public DoublyLinkedListNode(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }

    internal class DoublyLinkedList
    {
        private DoublyLinkedListNode? head;

        public void InsertNodeAtFront(int data)
        {
            var newNode = new DoublyLinkedListNode(data);

            newNode.next = head;
            newNode.prev = null;

            if (head != null)
                head.prev = newNode;

            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            var newNode = new DoublyLinkedListNode(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            var temp = head;

            //if linked list not empty find last node
            while (temp.next != null)
                temp = temp.next;

            temp.next = newNode;
            newNode.prev = temp;
        }

        public void InsertAfter(DoublyLinkedListNode previousNode, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("Previous node cannot be null");
                return;
            }

            var newNode = new DoublyLinkedListNode(data);

            newNode.next = previousNode.next;
            previousNode.next = newNode;
            newNode.prev = previousNode;

            if (newNode.next != null)
                newNode.next.prev = newNode;
        }

        public void DeleteNode(DoublyLinkedListNode del_node)
        {
            if (head == null || del_node == null)
            {
                return;
            }
            if (head == del_node)
            {
                head = del_node.next;
            }
            if (del_node.prev != null)
            {
                del_node.prev.next = del_node.next;
            }
            if (del_node.next != null)
            {
                del_node.next.prev = del_node.prev;
            }
        }

        public static void Main(string[] args)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList();

            linkedList.head = new DoublyLinkedListNode(1);

            var secondNode = new DoublyLinkedListNode(2);
            linkedList.head.next = secondNode;
            secondNode.prev = linkedList.head;

            var thirdNode = new DoublyLinkedListNode(3);
            secondNode.next = thirdNode;
            thirdNode.prev = secondNode;

            var fourthNode = new DoublyLinkedListNode(4);
            thirdNode.next = fourthNode;
            fourthNode.prev = thirdNode;

            Console.WriteLine("Forward direction:");
            while (linkedList.head != null)
            {
                Console.WriteLine(linkedList.head.data);
                linkedList.head = linkedList.head.next;
            }

            Console.WriteLine("Backward direction:");

            var currentNode = fourthNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.prev;
            }
        }
    }
}