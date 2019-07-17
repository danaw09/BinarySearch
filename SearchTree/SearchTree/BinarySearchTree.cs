using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class BinarySearchTree
    {
        Node root;
        int count = 0;
        public BinarySearchTree()
        {
            root = null;
        }
        public void AddNode(int number)
        {
            if (root == null)
            {
                root = new Node(number);
            }
            else
            {
                root.InsertNode(ref root, number);
            }
            count++;
        }
        public void Display()
        {
            root.ReceiveNumber(root);
        }
        public bool search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            if (node.value == data)
            {
                return true;
            }
            else if (node.value < data)
            {
                return search(node.left, data);
            }
            else if (node.value > data)
            {
                return search(node.right, data);
            }
            return false;
        }
    }   }   
