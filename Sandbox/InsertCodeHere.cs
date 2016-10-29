﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CubeCalculator cc = new CubeCalculator(); //opretter et nyt objekt

            String userInput = cc.GetUserInput("Please enter an integer number:");
            if (cc.IsANumber(userInput))
            {
                int value = cc.ConvertToNumber(userInput);
                int result = cc.CalculateCube(value);
                Console.WriteLine($"The cube of {value} is {result}");
            }
            else
            {
                Console.WriteLine("Could not calculate...");
            }



            // The LAST line of code should be ABOVE this line
        }
    }
}
