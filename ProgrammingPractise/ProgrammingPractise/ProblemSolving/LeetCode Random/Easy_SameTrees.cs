using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    internal class Easy_SameTrees
    {
        bool result = false;
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if ((p == null && q != null) || (p != null && q == null))
            {
                return false;
            }
            if (p != null && q != null && p.val != q.val)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            
            
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

    }
}
