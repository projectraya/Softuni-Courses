namespace ChatBasedChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree1 = new TreeNode(10);
            tree1.Left = new TreeNode(6);
            tree1.Right = new TreeNode(15);

            tree1.Left.Left = new TreeNode(3);
            tree1.Left.Right = new TreeNode(8);
            tree1.Right.Right = new TreeNode(20);

            int sum = 0;
            tree1.PostOrder(tree1, ref sum);

            Console.WriteLine(sum);
        }
    }
}
