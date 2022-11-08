///////////////////////////////////////////////////////////////////////////////
//
//  Author: Jean Bilong, bilong@etsu.edu
//         
//  Course: CSCI-2210-001 - Data Structures
//  Assignment: Project 5
//  Description: Binary Trees
//    
//  
///////////////////////////////////////////////////////////////////////////////





using System.Linq.Expressions;
using System.Xml.Linq;

namespace DynamicQuizApp
{
    /// <summary>
    /// Used to run the program
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var tree = GetTree();

            var node = tree.Root;

            while(node != null)
            {
                if(node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text);

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Y:
                            WriteAnswer(" Yes");
                            node = node.Left;
                            break;

                        case ConsoleKey.N:
                            WriteAnswer(" No");
                            node = node.Right;
                            break;

                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }
        }

        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// the GetTree method is used to construct the binary tree with questions and answers
        /// </summary>
        /// <returns> the binary tree questions</returns>

        public static BinaryTree<Questions> GetTree()
        {
            var tree = new BinaryTree<Questions>();

            tree.Root = new()
            {
                Data = new Questions("Do you have experience in developing applications?"),

                Children = new()
                {
                    new BinaryTreeNode<Questions>()
                    {
                        Data = new Questions("Have you worked as a developer for more than 5 years?"),

                        Children = new()
                        {
                            new BinaryTreeNode<Questions>()
                            {
                                Data = new Questions("Apply as a senior developer!")
                            },
                            new BinaryTreeNode<Questions>()
                            {
                                Data= new Questions("Apply as a middle developer!")
                            }
                        }
                    },
                    new BinaryTreeNode<Questions>()
                    {
                        Data = new Questions("Have you completed the university?"),

                        Children = new()
                        {
                            new BinaryTreeNode<Questions>()
                            {
                                Data = new Questions("Apply for a junior developer!")
                            },
                            new BinaryTreeNode<Questions>()
                            {
                                Data = new Questions("Will you find some time during the semester?"),

                                Children = new()
                                {
                                    new BinaryTreeNode<Questions>()
                                    {
                                        Data = new Questions("Apply for our long-time internship program!")
                                    },
                                    new BinaryTreeNode<Questions>()
                                    {
                                        Data = new Questions("Apply for summer internship program!")
                                    }
                                }
                            }

                        }
                    }
                }

                

            };
            tree.Count = 9;
            
            return tree;
            
            

        }
    }
}