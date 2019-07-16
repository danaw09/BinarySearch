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

        public int Right { get; set }
        

        public int Left { get; set }

        public Node()
        {
                
        }
    }
}
