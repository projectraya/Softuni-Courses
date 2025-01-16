using SimpleTreeNode;
using System;
using System.Collections.Generic;

namespace Exam.Data_Structures_Vol2
{
    public class Program
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

            
            BFS(companyTree, targetEmployee);
        }

        
        public static void BFS(TreeNode<string> root, string target)
        {
            
            Queue<TreeNode<string>> queue = new Queue<TreeNode<string>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode<string> currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Value);

                
                if (currentNode.Value == target)
                {
                    break;
                }

                foreach (var child in currentNode.ChildNodes)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
