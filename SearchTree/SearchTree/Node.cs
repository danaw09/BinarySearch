using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Node
    {
        public int value;
        public Node right;
        public Node left;
        

        public Node(int value)
        {
            this.value = value;
            right = null;
            left = null;
        }

        public void InsertNode(ref Node root, int input)
        {
            if (root == null)
            {
                root = new Node(input);
            }
            else if (root.value > input)
            {
                InsertNode(ref root.left, input);
            }
            else if (root.value < input)
            {
                InsertNode(ref root.right, input);
            }
        }
    }
}
