using System.Collections.Generic;
using System;

namespace binaryTreePaths
{
      public class TreeNode{
            public int val;
            public TreeNode left;
            public TreeNode right;
           public TreeNode(int x) {val = x;}
        }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left = new TreeNode(2);

            root.left.right = new TreeNode(5);

           Console.WriteLine(hasPathSum(root, 18));
        }

        public static bool hasPathSum(TreeNode root, int sum){
            if (root == null ){
                return false;
            }
            else if (root.right == null && root.left == null && sum - root.val == 0){
                return true;
            }else {
                return hasPathSum(root.left, sum - root.val) || hasPathSum(root.right, sum - root.val);
            }
        }

    }
}
