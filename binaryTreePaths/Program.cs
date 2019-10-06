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

           foreach (var item in binaryTreePaths(root))
           {
               Console.WriteLine(item);
           }
        }

        public static List<string> binaryTreePaths(TreeNode root){
            List<string> paths = new List<string>();

            if (root == null ){
                return paths;
            }

            dfs(root,"", paths);

            return paths;

        }

        public static void dfs(TreeNode root, string path, List<string> paths){
            path += root.val;
            
            if(root.left == null  && root.right == null){
                paths.Add(path);
            }
            if(root.left != null){
                dfs(root.left, path + "-->", paths);
            }
            if(root.right != null){
                dfs(root.right, path + "-->", paths);
            }
        }
    }
}
