using SimpleTreeNode;

namespace Trees_Lab_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode<char> tree = new TreeNode<char>('A',
                new TreeNode<char>('B',
                    new TreeNode<char>('D',
                        new TreeNode<char>('H',
                        new TreeNode<char>('I')))));
            new TreeNode<char>('E',
        new TreeNode<char>('C',
            new TreeNode<char>('F',
                new TreeNode<char>('J',
            new TreeNode<char>('G')))));
        }
    }
}
