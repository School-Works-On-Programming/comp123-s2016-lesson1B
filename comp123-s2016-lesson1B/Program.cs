﻿//class#2: practice to perform how to do unit test and Github publish.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author:Christopher Ritchil 
 * Date: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300702644
 * 
 * Description: This program demonstrates Github and version control
 * 
 * Version: 0.6 - Refactored OutputStringToConsole
 */
namespace comp123_s2016_lesson1B
{
    /**
     * This is the driver class for our program 
     * 
     * @class rogram 
     */
    public class Program
    {
        /**
         * Main Method for class Program 
         * 
         * @param {string[]} args
         * @constructor Main
         */
        static void Main(string[] args)
        {
            GetUserName(); 
        }

        /**
         * This method reads the UserName from the Console
         * 
         * @method GetUserNmae
         * @return {string} UserName
         */
        public static string GetUserName()
        {
            //Initializa variables
            string userName = "";

            OutputStringToConsole("Enter UserName: ", false);
            userName = Console.ReadLine();

            Console.WriteLine("\n=========================");
            Console.WriteLine("You Entered: " + userName + "\n");

            return userName;
        }

        /**
         * This method writes a string to the console. Parameters allow the user to choose to add a newline character.
         * 
         * @method OutputStringToConsole
         * @param {string} outPutString
         * @param {bool} hasNewLine
         * @return {string} outputString
         */

        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            //Refactored using the ternary operator

            string suffixString = hasNewLine ? "\n" : "";
            Console.Write(outputString + suffixString);

            return outputString; 
        }
    }
}
