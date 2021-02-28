using System;

namespace AlgorithmProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            Node nod7 = new Node(1, null, null);
            Node nod6 = new Node(1, null, null);
            Node nod5 = new Node(1, nod7, nod6);
            Node nod4 = new Node(0, null, null);
            Node nod3 = new Node(0, nod5, nod4);
            Node nod2 = new Node(1, null, null);
            Node nod1 = new Node(0, nod2, nod3);

            Console.WriteLine(univalTrees(nod1).Item1);
            Console.ReadLine();

            /* int univalTrees(Node root)
             {
                 if (root == null) return 0;  //base case


                 if (root.left == null & root.right == null) return 1;
                 else if (root.left.value == root.right.value) return univalTrees(root.left) + univalTrees(root.right) + 1; //to add one on the sm but still recurse

                 else return univalTrees(root.left) + univalTrees(root.right);

             }*/
            Tuple<int, bool> univalTrees(Node root) //Item1 is for the count of unival trees and Item2 is to determine whether the current tree is unival or not
            {
                if (root == null) return new Tuple<int, bool>(0, true); //base case, item2 is true because it is a unival tree but it doesnt add to count cause the count counts number of non-empty uni trees
                Tuple<int, bool> left_values = univalTrees(root.left);
                Tuple<int, bool> right_values = univalTrees(root.right);

                //motsägelsebevis
                bool isUnival = true;
                if (!left_values.Item2 || !right_values.Item2) isUnival = false;   //if neither or of root's children is unival then root isnt unival
                if (root.left != null && root.left.value != root.value) isUnival = false; //both children value must match root value
                if (root.right != null && root.right.value != root.value) isUnival = false; //both children value must match root value

                if (isUnival) return new Tuple<int, bool>(left_values.Item1 + right_values.Item1 + 1, true); //item1 is += 1 cause the current unival tree is no empty
                else return new Tuple<int, bool>(left_values.Item1 + right_values.Item1, false);

            }

        }
    }
}
