using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework1
{
    public class Exercises
    {
        // 1.Write a method that reads from the console three numbers of type int and prints their sum.
        public void Sum()
        {
            Console.WriteLine("Introduceti primmul numar");
            string numarul1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar");
            string numarul2 = Console.ReadLine();
            Console.WriteLine("Introduceti al treilea numar");
            string numarul3 = Console.ReadLine();
            int firstNumber = int.Parse(numarul1);
            int secondNumber = int.Parse(numarul2);
            int thirdNumber = int.Parse(numarul3);
            Console.WriteLine("Suma este: " + (firstNumber + secondNumber + thirdNumber));
        }
        //2.Write a method that reads five numbers from the console and prints the greatest of them.
        public void Greatest()
        {
            Console.WriteLine("Write the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Write the second number");
            string number2 = Console.ReadLine();
            Console.WriteLine("Write the third number");
            string number3 = Console.ReadLine();
            Console.WriteLine("Write the fourth number");
            string number4 = Console.ReadLine();
            Console.WriteLine("Write the fifth number");
            string number5 = Console.ReadLine();
            int firstNumber = int.Parse(number1);
            int secondNumber = int.Parse(number2);
            int thirdNumber = int.Parse(number3);
            int fourthNumber = int.Parse(number4);
            int fifthNumber = int.Parse(number5);
            if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + firstNumber);
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
            {
                Console.WriteLine("The greateste number is " + secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + thirdNumber);
            }
            else if (fourthNumber > fifthNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + fourthNumber);
            }
            else
            {
                Console.WriteLine("The greatest number is " + fifthNumber);
            }

        }
        // 3.Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        public void Area()
        {
            double r, Perimeter, Area;
            double PI = 3.14;
            Console.WriteLine("Please write the radius of your circle: ");
            r = int.Parse(Console.ReadLine());
            Perimeter = 2 * PI * r;
            Console.WriteLine("The perimeter of your circle is: " + Perimeter);
            Area = PI * Math.Pow(r, 2);
            Console.WriteLine("The area of your circle is: " + Area);

        }
        /* 4.Write a method that reads from the console two integer numbers (int) and prints how many numbers
        between them exist that are divisible with 5. such that the remainder of their division by 5 is 0. 
        Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.*/

        public void Divizibil()
        {
            int number1; int number2; int num;
            Console.WriteLine("Type the range of numbers");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            for (num = number1; num <= number2; num++)
            {
                if (num % 5 == 0)

                    Console.WriteLine("There numbers divisible with 5 are: " + num);
            }
        }
        /*5. Write a method that reads two numbers from the console and prints the greater of them.
        Solve the problem without using conditional statements and with conditional statements.*/

        public void Mare()
        {
            Console.WriteLine("Please write the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the secund number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Math.Max(num1, num2), Math.Min(num1, num2));
        }
        /*6. Write a method that reads five integer numbers and prints their sum. 
         * If an invalid number is entered the method should prompt the user to enter another number(only once)*/

        public void IntSum()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduceti un numar");
                string input = Console.ReadLine();

                int numbers;
                bool checkParse = int.TryParse(input, out numbers);

                if (checkParse == false)
                {
                    Console.WriteLine("Invalid. Reincercati!");
                    i--;
                    continue;
                }
                else
                {
                    sum += numbers;
                }
            }
            Console.WriteLine("Suma este: " + sum);

        }
        //7. Write a method that prints on the console the numbers from 1 to N.The number N should be read from the standard input.

        public void Numbers()
        {
            Console.WriteLine("Introduceti un numar");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(i);
            }
        }
        /*8. Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
         * The number N should be read from the standard input.*/

        public void Divizibil37()
        {
            Console.WriteLine("Type the numbers");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 1; i < lenght; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
        //9. Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.

        public void Interge()
        {
            Console.WriteLine("Input first integer:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input fourth integer:");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the fifth integer:");
            int number5 = int.Parse(Console.ReadLine());

            int[] array = { number1, number2, number3, number4, number5 };
            Console.WriteLine("Largest of five: " + array.Max());
            Console.WriteLine("Lowest of five: " + array.Min());

        }
        /*10. Write method that outputs a triangle made of stars with variable size, depending on an input parameter. 
         * Look at the examples to get   an idea.
        The input comes as a string number, which needs to be parsed to a number.
        The output is a series of lines printed on the console, forming a triangle of variable size.*/
        public void Triangle()
        {
            Console.WriteLine("Type a number : ");
            int num = int.Parse(Console.ReadLine());
            int a, b;
            for (a = 1; a <= num; a++)
            {

                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (a = num - 1; a >= 0; a--)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //11* . Write a method that converts a given number from decimal to binary notation (numeral system).
        public void Dectobin()
        {
            Console.WriteLine("Type a number :");
            int[] array = new int[10];
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (n > 0)
            {
                array[i] = n % 2;
                n = n / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
                Console.Write(array[j]);
        }
        //12*. Write a method that by a given integer N prints the numbers from 1 to N in random order

        public void Random()
        {
            Random rdn = new Random();
            int difnum, randomNumber;
            Console.WriteLine("Type a number :");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (int i in array)
            {
                randomNumber = rdn.Next(0, n);
                difnum = array[i];
                array[i] = array[randomNumber];
                array[randomNumber] = difnum;

            }
            foreach (int i in array) Console.WriteLine(array[i]);

        }
        /*13*. A method which iterates the integers from 1 to 50 
        For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
        For numbers which are multiples of both three and five print "FizzBuzz".*/
        public void FizzBuzz()
        {
            Console.WriteLine("Type a number");
            int n = int.Parse(Console.ReadLine());
            int a = 3;
            int b = 5;
            for (int i = 1; i < n; i++)
            {
                string s = "";

                if (i == a)
                {
                    a = a + 3;
                    s = s + "Fizz";
                }
                if (i == b)
                {
                    b = b + 5;
                    s = s + "Buzz";
                }
                if (s == "")
                    Console.WriteLine(i);
                else
                    Console.WriteLine(s);
            }

        }

        /*14** A given company has name, address, phone number, fax number, web site and manager. 
        The manager has name, surname and phone number. Write a program that reads information about
            the company and its manager and then prints it on the console.*/
        public void Company()
        {
            Console.WriteLine("Company name: ");
            string companyname = Console.ReadLine();

            Console.WriteLine("Company address: ");
            string companyadress = Console.ReadLine();

            Console.WriteLine("Company phone number: ");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Company fax number: ");
            string faxnumber = Console.ReadLine();

            Console.WriteLine("Company web site");
            string companysite = Console.ReadLine();

            Console.WriteLine("Manager name: ");
            string managername = Console.ReadLine();

            Console.WriteLine("Manager surname: ");
            string managersurname = Console.ReadLine();

            Console.WriteLine("Manager phone number:");
            string managerphone = Console.ReadLine();

            Console.WriteLine($"Company:\n Company name: {companyname}\n Adress: {companyadress}\n Phone Number: {phonenumber}\n Fax: {faxnumber}\n Site {companysite}\n Manager: {managersurname} {managername}\n Manager Phone Number: {managerphone}");
        }
    }
}




