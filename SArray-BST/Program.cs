using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArray_BST
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] nums = { -10, -3, 0, 5, 9 };
                TreeNode root = SortedArrayToBST(nums, 0, nums.Length - 1);
                PostorderTraversal(root);
                Console.ReadKey();
            }

            static TreeNode SortedArrayToBST(int[] nums, int start, int end)
            {
                if (start > end)
                {
                    return null;
                }
                int mid = (start + end) / 2;
                TreeNode node = new TreeNode(nums[mid]);
                node.left = SortedArrayToBST(nums, start, mid - 1);
                node.right = SortedArrayToBST(nums, mid + 1, end);
                return node;
            }

            static void PostorderTraversal(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }
                PostorderTraversal(node.left);
                PostorderTraversal(node.right);
                Console.Write(node.val + " ");
            }
        
    }
}
