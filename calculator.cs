using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator(); 
        }

        // ParseInt function 
        static void parseInt(string s) 
        {
            if(!int.TryParse(s, out int result))
            {
                throw new Exception("Invalid Input");
            };

            return;
        }

        // calculator function 
        static void calculator()
        {
            // Declare Variables 
            string[] operators = { "+", "-", "%", "x" }; 
            string numberOne;
            string numberTwo;
            int equation;

            // Request first number 
            Console.WriteLine("Please Enter Number One:"); 
            numberOne = Console.ReadLine();

            // Parse entry 
            parseInt(numberOne); 
           
            // Request Operator 
            Console.WriteLine("Please chose an operator. (+, -, %, or x");
            string operatorInput = Console.ReadLine();

            if (!operators.Any(x => x == operatorInput))
            {
                throw new Exception("Please type a operator.");
            }

            // Request second number 
            Console.WriteLine("Please Enter Number Two:");
            numberTwo = Console.ReadLine();

            // Parse entry 
            parseInt(numberTwo);

            // Switch case for operators
            switch(operatorInput)
            {
                case "+":
                    equation = Int32.Parse(numberOne) + Int32.Parse(numberTwo);
                    Console.WriteLine(numberOne + operatorInput + numberTwo + " = " + equation);
                    break; 
                case "-":
                    equation = Int32.Parse(numberOne) - Int32.Parse(numberTwo);
                    Console.WriteLine(numberOne + operatorInput + numberTwo + " = " + equation);
                    break;
                case "%":
                    equation = Int32.Parse(numberOne) / Int32.Parse(numberTwo);
                    Console.WriteLine(numberOne + operatorInput + numberTwo + " = " + equation);
                    break;
                case "x":
                    equation = Int32.Parse(numberOne) * Int32.Parse(numberTwo);
                    Console.WriteLine(numberOne + operatorInput + numberTwo + " = " + equation);
                    break;
            }
        }
    }
}
