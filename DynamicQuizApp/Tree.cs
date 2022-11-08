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
    /// represents the whole tree
    /// </summary>
    /// <typeparam name="T"> Must be specified while creating an insatance of the class</typeparam>
    public class Tree<T>
    {
        /// <summary>
        /// can be used to get access to the root node, 
        /// and then you can use its Children property to obtain data of other nodes located in the tree
        /// </summary>
        public TreeNode<T> Root { get; set; } = new TreeNode<T>();

    }
}
