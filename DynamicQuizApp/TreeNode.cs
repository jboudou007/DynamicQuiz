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
    /// declared as the generic class to provide a developer with the ability to specify the type of data stored in each node. 
    /// Thus, you can create the strongly-typed solution, which eliminates the necessity of casting objects to target types. 
    /// </summary>
    /// <typeparam name="T"> must be specified while creating an instance of the class </typeparam>
    public class TreeNode<T>
    {
        /// <summary>
        /// the data stored in the node (Data) of the type T
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// reference to the parent node
        /// </summary>
        public TreeNode<T>? Parent { get; set; }

        /// <summary>
        /// collection of references to child nodes
        /// </summary>
        public List<TreeNode<T>>? Children { get; set; }

        /// <summary>
        /// the TreeNode class contains the GetHeight method, which returns a height of the node, that is, the distance to the root node.
        /// </summary>
        /// <returns> a height of the node, that is, the distance to the root node </returns>
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }

    }
}
