using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {

        void Calculator()
        {
            // Instantiate variable
            float num1 =0;
            float num2;
            float answer;


            // User requires to input any number 
            // "Convert.ToInt32" convert the given input into integer
            // Ex. num2 = Convert.ToInt32(Console.ReadLine());
            // It will detect any word it reset itself and require a number
            // 

            Console.Write("Please enter the first integer: ");

            if (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invaild input");
                return;
            }

            Console.Write("Please enter the second integer: ");

            if (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invaild input");
                return;
            }




            Console.Write("Please enter an operand (+, -, /, *): ");



            // Get input from user
            string input = Console.ReadLine();


            // Press one this operator it show the answer.
            while (true)
            {
                // Addition
                if (input == "+")
                {
                    answer = num1 + num2;
                    break;
                }

                // Subtract
                else if (input == "-")
                {
                    answer = num1 - num2;
                    break;
                }

                // Multiply
                else if (input == "*")
                {
                    answer = num1 * num2;
                    break;
                }

                // Divide
                else if (input == "/")
                {
                    answer = num1 / num2;
                    break;
                }
                return;
            }


            // Show user their answer
            Console.WriteLine("Answer: " + answer);

            // Unused code
            // Console.WriteLine("Attempted to divide by zero");

        }
        public void Run()
        {

            // Stop the program
            bool stop = false;

            while (!stop)
            {
                
                Calculator();
                stop = true;
            }


        }
    }
}
