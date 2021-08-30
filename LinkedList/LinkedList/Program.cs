using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            head = removeDuplicates(head);
            Display(head);
            Console.ReadLine();
        }

        public static Node Insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static Node removeDuplicates(Node head)
        {
            Node curr = head;

           
                while (curr.next != null )
                {
                    if (curr.data == curr.next.data)
                    {
                        curr.next = curr.next.next;
                    }
                    else
                    {
                        curr = curr.next;
                    }
                }
            return head;
        }
    }
}
