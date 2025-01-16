using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBasedChallenge
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void PostOrder(TreeNode node, ref int sum)
        {
            if (node == null) return;

            
            PostOrder(node.Left, ref sum);
            PostOrder(node.Right, ref sum);

            if (node.Left == null && node.Right == null)
            {
                sum += node.Value;
            }

            

        }
    }
}
