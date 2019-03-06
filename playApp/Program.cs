// assignment 1
//  create a string value of 'n' that is the output the sum of 'n'
//  Assignment 2
// add elements in array - create an array of interger and add few user inputs.
using System;

namespace playApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Assignment #1 - the value of 'n'
                        string inputString = "";
                        string outputString = "";

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
            /*  Assignment #2 - Array of integer  */
            int[] arr = new int[1];
            
            // see examples in tutorialspoint for apps and loops
            for (int i = 0; i < arr.length; i++)
            {
                Console.WriteLine("contents: {0}", i);
            }
            Console.ReadLine();
        }
    }
}
