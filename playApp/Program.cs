// assignment 1
//  create a string value of 'n' that is the output the sum of 'n'
//  Assignment 2
// add elements in array - create an array of interger and add few user inputs.
using System;
using System.Collections.Generic;

namespace playApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Assignment #1 - the value of 'n'
                        string inputString = "";
                        string outputString = "";
            //  section #1   ##################################################################################
            /*
                        Console.WriteLine("Hello, Please enter something: or type 'exit' to end program");
                        inputString = Console.ReadLine();
                        while (inputString.ToLower() != "exit")
                        {
                            if (inputString == "")
                            {
                                Console.WriteLine("Uh nothing is NOT something");
                            }
                            outputString += inputString;
                            Console.WriteLine(outputString);
                            Console.WriteLine("Please enter something else or type 'exit' to end program");
                            inputString = Console.ReadLine();
                        }
                        Console.WriteLine("Goodbye!!!");
                        Console.ReadLine();
             */
             //########################################################################
            
            /*  Assignment #2 - Array of integer  */
            //  Request user to enter an integer
            // Section #2 #############################################################
       // /*
            Console.WriteLine(@"Hello, Please enter an integer and then the enter key.  
                                 When finished adding intergers please enter 'done'");
            inputString = Console.ReadLine();
            
            //  instantiating a list instead of an array because unsure of length.  Can convert to Array if needed
            List<int> arrList = new List<int>();
            
            //  set to lowercase and check if user entered exit to end entry.  If so then end and display array contents
            while (inputString.ToLower() != "done")
            {
                if (inputString == "")
                {
                    Console.WriteLine("Uh nothing is NOT an Integer");
                }
                else
                {

                    int.TryParse(inputString, out int numStr);
                    arrList.Add(numStr);
                    Console.WriteLine("Please enter another integer or type 'done' to finish array element input");
                    inputString = Console.ReadLine();
                }
            }


            // for loop to view the contents of the list or array if converted. NOTE need to change the Count to Length also 
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine("contents: {0}", arrList[i]);
            }
            Console.ReadLine();
      //      */
//  End of section #2 #########################################

        }
    }
}
