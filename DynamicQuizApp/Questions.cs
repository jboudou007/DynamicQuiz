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
    /// the QuizItem class to represent a single item, such as a question or an answer. 
    /// Each item contains only the textual content, stored as a value of the Text property.
    /// </summary>
    public class Questions
    {
        public string Text { get; set; } = string.Empty;

        public Questions(string text)
        {
            Text = text;
        }



    }
}
