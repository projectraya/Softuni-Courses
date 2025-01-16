using SimpleTreeNode;
using System.Runtime.Versioning;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetEmployee = Console.ReadLine();


            TreeNode<string> companyTree =
                new TreeNode<string>("Boss",
                    new TreeNode<string>("Sarah",
                        new TreeNode<string>("Lora"),
                        new TreeNode<string>("Viktor")),
                    new TreeNode<string>("Evan",
                        new TreeNode<string>("Cole",
                            new TreeNode<string>("Mary"),
                            new TreeNode<string>("Clare")),
                        new TreeNode<string>("Nicole",
                            new TreeNode<string>("Alex",
                                new TreeNode<string>("Peter")),
                            new TreeNode<string>("Anya"))),
                    new TreeNode<string>("Mike"));

            TraverseBFS(companyTree, targetEmployee);
        }

        public static void TraverseBFS(TreeNode<string> tree, string keyName)
        {
            Queue<TreeNode<string>> queue = new Queue<TreeNode<string>>();

            queue.Enqueue(tree);

            while(queue.Count > 0)
            {
                TreeNode<string> current = queue.Dequeue();
                Console.WriteLine(current.Value);

                if(current.Value == keyName)
                {
                    return;
                }

                foreach(var child in current.ChildNodes)
                {
                    queue.Enqueue(child);

                }
            }
        }
    }
}
