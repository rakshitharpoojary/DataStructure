namespace DataStructurePracticePrograms.Tree
{
    public class BST
    {
        public class Node
        {
            public int data { get; set; }
            public Node? left { get; set; }
            public Node? right { get; set; }

            public Node(int d)
            {
                data = d;
                left = null;
                right = null;
            }
        }

        private Node? root;

        public BST()
        {
            root = null;
        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        public Node InsertRec(Node? node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            }
            if (key < node.data)
            {
                node.left = InsertRec(node.left, key);
            }
            else if (key > node.data)
            {
                node.right = InsertRec(node.right, key);
            }

            return node;
        }

        public void Delete(int key)
        {
            root = DeleteKey(root, key);
        }

        public Node? DeleteKey(Node? node, int key)
        {
            if (node == null)
            {
                return null;
            }

            if (key < node.data)
            {
                node.left = DeleteKey(node.left, key);
            }
            else if (key > node.data)
            {
                node.right = DeleteKey(node.right, key);
            }
            else
            {
                // if node is having single node or no children
                if (node.left == null)
                    return node.right;
                if (node.right == null)
                    return node.left;

                //If nodehas 2 children
                //Find inorder successor
                node.data = InorderSuccessor(node.right);

                //Delete inorder successor
                node.right = DeleteKey(node.right, node.data);
            }
            return node;
        }

        public int InorderSuccessor(Node node)
        {
            int inorderSuccessorNode = node.data;

            while (node.left != null)
            {
                inorderSuccessorNode = node.left.data;
                node = node.left;
            }
            return inorderSuccessorNode;
        }

        public void Inorder(Node? node)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left);
            Console.Write(" => " + node.data);
            Inorder(node.right);
        }

        public static void Main(string[] args)
        {
            BST tree = new BST();

            tree.Insert(8);
            tree.Insert(3);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(10);
            tree.Insert(14);
            tree.Insert(4);

            Console.WriteLine("Inorder traversal: ");
            tree.Inorder(tree.root);

            Console.WriteLine("\n\nAfter deleting 10");
            tree.Delete(3);
            Console.WriteLine("Inorder traversal: ");
            tree.Inorder(tree.root);
        }
    }
}