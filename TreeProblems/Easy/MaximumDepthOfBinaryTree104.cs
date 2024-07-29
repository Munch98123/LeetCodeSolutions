using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems.Easy
{
    public class MaximumDepthOfBinaryTree104
    {
        public static int GetMaxDepth(TreeNode currentNode)
        {
            int leftDepth = 0, rightDepth = 0;
            if (currentNode == null)
            {
                return 0;
            }
            if(currentNode.left != null) 
            {
                leftDepth = GetMaxDepth(currentNode.left);
            }
            if(currentNode.right != null)
            {
                rightDepth = GetMaxDepth(currentNode.right);
            }
            
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
