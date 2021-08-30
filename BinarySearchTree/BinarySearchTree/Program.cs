using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
                
            }

            LevelOrderTraversal(root);
            Console.ReadLine();
        }

        public static Node insert(Node root, int data)
        {
            if(root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                
                if(data<=root.data)
                {
                    cur = insert(root.Left, data);
                    root.Left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
            }
            return root;

        }

        public static void InOrderTraversal(Node root)
        {
            if(root.Left != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Left.data + "   Left   ");
                
            }
            if(root.right !=null)
            {
                InOrderTraversal(root.right);
                Console.Write(root.right.data + "    right   ");
            }
        }

        public static void InOrder( Node root)
        {
            if(root !=null)
            {
                InOrder(root.Left);
                if(root.Left == root.right)
                {
                    root.right = null;
                }
                Console.WriteLine(root.data);
                InOrder(root.right);
            }
        }

        public static void LevelOrderTraversal(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();

            if (root != null)
            {
                nodes.Enqueue(root);

                while (nodes.Count != 0)
                {
                    Node curr = nodes.Dequeue();
                    Console.Write(curr.data+" ");

                    if (curr.Left != null)
                    {
                        nodes.Enqueue(curr.Left);
                    }
                    if (curr.right != null)
                    {
                        nodes.Enqueue(curr.right);
                    }
                  
                }
            }
        }

        public static Node removeDuplicates(Node head)
        {
            if(head == null)
            {
                return null;
            }
            Node curr = head;

            while(curr.next != null)
            {
                if(curr.next==curr.next.next)
                {
                    curr.next.next = null;
                }
            }
            return head;
        }
    }
}
