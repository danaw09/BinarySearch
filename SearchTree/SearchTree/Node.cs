using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Node
    {
        public int data;
        public Node rightBranch;
        public Node leftBranch;
           

        public Node(int data)
        {
            this.data = data;
            rightBranch = default;
            leftBranch = default;
        }
       
        public void NodeInsert ()
        {

        }
    }
}
