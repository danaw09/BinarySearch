using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Node
    {
        
        
            public int number;
            public Node right;
            public Node left;

            public Node(int number)
            {
                this.number = number;
                right = default;
                left = default;
            }

        public int value { get; internal set; }

        public void InsertNode(ref Node root, int input)
            {
                if (root == null)
                {
                    root = new Node(input);
                }
                else if (root.number > input)
                {
                    InsertNode(ref root.left, input);
                }
                else if (root.number < input)
                {
                    InsertNode(ref root.right, input);
                }
            }

            public void ReceiveNumber(Node node)
            {
                if (node == null)
                    return;
                ReceiveNumber(node.left);
                ReceiveNumber(node.right);


            }
        
}    }
