using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int data;
         public Node next;
        public Node previous;

        public Node(int mydata)
        {
            data = mydata;
            next = null;
        }
        public Node(int mydata,Node nextNode)
        {
            data = mydata;
            next = nextNode;
        }

        public int GetData()
        {
            return data;
        }
        public Node GetNext()
        {
            return next;
        }
        public void SetData(int myData)
        {
            data = myData;
        }
        public void SetNext(Node myNext)
        {
            next = myNext;
        }
    }
}
