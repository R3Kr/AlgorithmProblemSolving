using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblemSolving
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}
