using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        Node head;
        int count;



        public LinkedList(Node newHead)
        {
            head = newHead;
            count = 1;
        }

        public  void AddNode(int data)
        {
            Node temp = new Node(data);
            if (head == null)
            {
                head = temp;
            }

            Node current = head;

            
          

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(temp);
            count++;
        }

        public int GetIndex(int index)
        {
            if(index<=0)
            {
                return -1;
            }

            Node current = head;
            for(int i=1; i<index; i++)
            {
                current = current.GetNext();
            }
            return current.GetData();
        }

        public int Size()
        { 
            return count;
        }

        public bool IsEmpty()
        {
            return head == null;
        }


        public void Remove()
        {
            Node current = head;

            while(current.GetNext().GetNext()!=null)
            {
                current = current.GetNext();
            }
            current.SetNext(null);
            count--;
        }


















































        public static Node InsertNode(Node head, int data)
        {
            if(head == null)
            {
                Node newHead = new Node(data);
                return newHead;
            }

                Node temp = head;

                while(temp.GetNext()!=null)
                {
                    temp = temp.GetNext();
                }
                temp.SetNext( new Node(data));
            
            return head; 
        }
    }
}
