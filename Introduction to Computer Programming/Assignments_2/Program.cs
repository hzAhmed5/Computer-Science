﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // When solving the exercises remember to make sure your program doesn't crash regardless 
            // of user's input.

            // Write a program checking if a number given by the user is even or odd.

            Console.WriteLine("Even or odd.");
            Console.WriteLine("Provide an integer number: ");

            int num;

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Provide an integer number: ");
            }

            bool divisible = num % 2 == 0;

            switch (divisible)
            {
                case true:
                    Console.WriteLine($"Number {num} is even.");
                    break;
                default:
                    Console.WriteLine($"Number {num} is odd.");
                    break;
            }

            // Write a program calculating the following equation a * b / (a+b), 
            // where a and b are values given by the user.

            Console.WriteLine("Program calculating the following equation a * b / (a+b)");

            int a, b;

            Console.WriteLine("Provide an integer number a: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Provide an integer number a: ");
            }

            Console.WriteLine("Provide an integer number b: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Provide an integer number b: ");
            }

            double res = a * b / (a / b);

            Console.WriteLine($"a * b / (a+b) = {res}");

            // Write a program which reads 3 numbers from the user and prints them out 
            // in an ascending order.

            Console.WriteLine("program which reads 3 numbers from the user " +
                "and prints them out in an ascending order.");
            int x, y, z;

            Console.WriteLine("Provide an integer number x: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Provide an integer number x: ");
            }

            Console.WriteLine("Provide an integer number y: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Provide an integer number x: ");
            }

            Console.WriteLine("Provide an integer number z: ");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Provide an integer number x: ");
            }

            // here we initialize sorting network http://pages.ripco.net/~jgamble/nw.html

            int tmp;

            if (x > y) { tmp = x; x = y; y = tmp; }
            if (x > z) { tmp = x; x = z; z = tmp; }
            if (y > z) { tmp = y; y = z; z = tmp; }

            Console.WriteLine($"Sorted: {x}, {y}, {z}");

            // Write a simple calculator, which will allow for basic arithmetic’s 
            // (+, -, *, /) on two numbers.
            // Modify the solution to the previous exercise so that the program runs 
            // as long as the user wants
            Console.WriteLine("Simple calculator allows for basic arithmetic’s (+, -, *, /) on two numbers.");

            int A, B;

            const char plus = '+';
            const char minus = '-';
            const char mult = '*';
            const char div = '/';

            char userSign = default;

            bool signIsCorrect = false;

            while (true)
            {
                Console.WriteLine("Provide first number (A): ");
                while (!int.TryParse(Console.ReadLine(), out A))
                {
                    Console.WriteLine("Provide an integer number A: ");
                }

                Console.WriteLine("Provide first number (B): ");
                while (!int.TryParse(Console.ReadLine(), out B))
                {
                    Console.WriteLine("Provide an integer number B: ");
                }

                while (!signIsCorrect)
                {
                    Console.WriteLine("Provide an operator: ");
                    userSign = Console.ReadLine()[0];
                    signIsCorrect = (userSign == plus) || (userSign == minus) || (userSign == mult)
                        || (userSign == div);
                }

                Console.WriteLine($"Operator provided: {userSign}");

                switch (userSign)
                {
                    case plus:
                        Console.WriteLine($"Sum of A + B = {A + B}");
                        break;
                    case minus:
                        Console.WriteLine($"Difference of A - B = {A - B}");
                        break;
                    case mult:
                        Console.WriteLine($"Multiplication A * B = {A * B}");
                        break;
                    case div:
                        if (A == 0)
                            goto default;
                        Console.WriteLine($"Division A / B = {A / B}");
                        break;
                    default:
                        Console.WriteLine("Division by zero occured. Terminated.");
                        break;
                }

                Console.WriteLine("Type X to quite or any other to continue again.");
                string quite = Console.ReadLine();

                if (quite == "X") break;
            }

            // Write a program which calculates the power of a number from range <1,10> 
            // given by the user.

            Console.WriteLine("Program which calculates the power of a number " +
                "from range <1,10> given by the user.");

            Console.WriteLine("Provide an integer number y: ");
            while (!int.TryParse(Console.ReadLine(), out y) && y <= 10)
            {
                Console.WriteLine("Provide an integer number y: ");
            }

            Console.WriteLine("Provide an integer number x: ");
            while (!int.TryParse(Console.ReadLine(), out x) && z <= 10)
            {
                Console.WriteLine("Provide an integer number x: ");
            }

            double pow = Math.Pow(x, y);

            Console.WriteLine($"x ^ y = {pow}");

            // Write a program which will draw a rectangle out of ‘*’ with width and height 
            // provided by the user.

            int height, width;
            Console.WriteLine("Program which will draw a rectangle out of ‘*’ with width and height");
            Console.WriteLine("Provide an integer number height: ");
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Provide an integer number height: ");
            }

            Console.WriteLine("Provide an integer number width: ");
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Provide an integer number width: ");
            }

            char sign = '*';

            Console.WriteLine($"Rectangle {height} x {width} of {sign} :");
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < width; j++)
                {
                    Console.Write(sign);
                }
            }

            // Write a program which will draw a pyramid out of ‘*’ with the height given by the user.

            Console.WriteLine("\nProgram which draws a pyramid out of ‘*’ with the height " +
                "given by the user.");

            Console.WriteLine("Provide an integer number height: ");
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Provide an integer number height: ");
            }

            for (int j = 0; j <= height; j++)
            {
                // for cycle - spacing
                for (int s = 0; s <= height - j; s++)
                    Console.Write(" ");

                // for triangle - ROW
                for (int i = 1; i <= 2 * j - 1; i++)
                    Console.Write(sign);

                Console.WriteLine("\n");
            }

            // Write a program verifying if a number given by the user is prime.

            Console.WriteLine("Program verifying if a number given by the user is prime.");
            Console.WriteLine("Provide an integer number height: ");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Provide an integer number height: ");
            }

            bool isPrime = true;

            for (int i = 2; i < x; i++)
            {
                if (x % i != 0)
                {
                    isPrime = false;
                    break;
                }
            }

            switch (isPrime)
            {
                case true:
                    Console.WriteLine($"Number {x} is prime.");
                    break;
                default:
                    Console.WriteLine($"Number {x} is not prime.");
                    break;
            }

            // Modify the tic-tac-toe game from the previous set of exercises. 
            // Now, instead of asking the user to provide the whole state of the game at once, 
            // the user should place each symbol one move at a time – just like in a normal tic - tac - toe 
            // game – X and O in turns. 
            // For now, you don’t have to check if anyone has won – just write “Game over!” 
            // when the board is filled. Just remember to prevent the user from making an illegal move! 
            // Below is an example game.

            char[] fields = new char[9]; // array for storing board state
            const char crossSign = 'X';
            const char roundSign = 'O';
            char currentSign = crossSign;
            int index;

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = ' '; // fill array with " " for fancy spacing
            }

            Console.WriteLine("Tic tac toe board: \n");

            for (int i = 0; i < fields.Length; i++)
            {
                Console.WriteLine("Current board state: ");
                Console.WriteLine(" " + fields[0] + " | " + fields[1] + " | " + fields[2] + " ");
                Console.WriteLine("-----------");
                Console.WriteLine(" " + fields[3] + " | " + fields[4] + " | " + fields[5] + " ");
                Console.WriteLine("-----------");
                Console.WriteLine(" " + fields[6] + " | " + fields[7] + " | " + fields[8] + " ");

                Console.Write($"\n {currentSign}'s move >");

                while (!(int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < 9))
                {
                    Console.WriteLine($"{currentSign}, Provide an integer number of index of board: ");
                }

                fields[index] = currentSign;

                currentSign = currentSign == crossSign ? roundSign : crossSign;
            }

            Console.WriteLine("Game over!");
        }
    }
}
