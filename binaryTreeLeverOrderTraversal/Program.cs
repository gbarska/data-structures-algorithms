using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace binaryTreeLeverOrderTraversal
{
    class Program
    {
        public class TreeNode{
            public int val;
            public TreeNode left;
            public TreeNode right;
           public TreeNode(int x) {val = x;}
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left = new TreeNode(2);

            root.left.right = new TreeNode(5);
          
            var retorno = levelOrderTraversal(root);

            foreach (var level in retorno)
            {
                

                foreach (var item in level)
                {
                    Console.WriteLine(item);
                }    
                Console.WriteLine("__");          
            }
        }

        public static List<List<int>> levelOrderTraversal(TreeNode root){
            List<List<int>> result = new List<List<int>>();
          
            if(root == null){
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while(!(queue.Count == 0)){
                
                int size = queue.Count;

                List<int> currentLevel = new List<int>();

                for (int i = 0; i < size; i++)
                {
                  TreeNode current = queue.Dequeue();

                  currentLevel.Add(current.val);
                  
                   if(current.left != null){
                       queue.Enqueue(current.left);
                   } 
                   if(current.right != null){
                       queue.Enqueue(current.right);
                   } 
                }
                result.Add(currentLevel);
            }

            return result;
        }
    }
}
