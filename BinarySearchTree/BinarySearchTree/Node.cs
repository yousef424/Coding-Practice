using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node Left;
        public Node right;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            Left = null;
            right = null;
        }
    }
}
