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
    /// represents the whole binary tree.
    /// </summary>
    /// <typeparam name="T"> By using the generic class, you can easily specify a type of data stored in each node</typeparam>
    public class BinaryTree<T>
    {
        /// <summary>
        /// indicates the root node (as an instance of the BinaryTreeNode class)
        /// </summary>
        public BinaryTreeNode<T> Root { get; set; } = new BinaryTreeNode<T>();

        /// <summary>
        /// the total number of nodes placed in the tree
        /// </summary>
        public int Count { get; set; }
    }
}
