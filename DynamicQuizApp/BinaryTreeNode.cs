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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuizApp
{
    /// <summary>
    /// A node in a binary tree is represented by an instance of BinaryTreeNode, 
    /// which inherits from the TreeNode generic class
    /// </summary>
    /// <typeparam name="T"> The user should specify the datatype </typeparam>
    public class BinaryTreeNode <T> : TreeNode<T>
    {
        /// <summary>
        /// the collection of child nodes contains exactly two items, initially set to null
        /// </summary>
        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>() { null, null };
        }

        /// <summary>
        /// Left Child
        /// </summary>
        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        /// <summary>
        /// Right Child
        /// </summary>
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

       
    }
}
