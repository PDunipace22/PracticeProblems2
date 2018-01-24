using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework Week 1cDay 1
            //string firstName = "Peter";
            //string lastName = "Dunipace";
            //string carOne = "Ford";
            //string carTwo = "Mustang";
            //string comic = "Spiderman";
            //Console.WriteLine("My full name is" +" "+ firstName + " "+ lastName);
            //Console.WriteLine("My favorite car is"+" "+ carOne+" "+ carTwo);
            //Console.WriteLine("My favorite comic book hero is"+" "+ comic);

            //Day 2- first attempt
            //int total = 7;
            //int start = 2;
            //Console.WriteLine(total - start + " " + "cups of sugar needed" + ".");
            //start = 13;
            //int individual = 4;
            //Console.WriteLine("The total bill was" + " " + start * individual + " " + "dollars" + ".");
            //total = 40;
            //individual = 8;
            //Console.WriteLine(total / individual + " " + "packages");
            //total = 41;
            //start = 29;
            //Console.WriteLine("Trevon recieved" + " " + (total - start) + " " + "dollars" + ".");
            //total = 47;
            //start = 30;
            //Console.WriteLine("Pranav ran" + " " + (total - start) + " " + "miles" + ".");
            //total = 12;
            //individual = 3;
            //Console.WriteLine(total / individual + " " + "boxes");
            //double current = 27.10;
            //double payed = 5.12;
            //Console.WriteLine("Norachai had" + " " + (current + payed) + " " + "before buying the salad" + ".");

            // In class
            //    double valueOne = 7;
            //    double valueTwo = 2;
            //    Console.WriteLine(valueOne - valueTwo + " " + "cups of sugar needed" + ".");
            //    valueOne = 13;
            //    valueTwo= 4;
            //    Console.WriteLine("The total bill was" + " " + valueOne* valueTwo + " " + "dollars" + ".");
            //    valueOne = 40;
            //    valueTwo = 8;
            //    Console.WriteLine(valueOne / valueTwo + " " + "packages");
            //    valueOne = 41;
            //    valueTwo = 29;
            //    Console.WriteLine("Trevon recieved" + " " + (valueOne-valueTwo) + " " + "dollars" + ".");
            //    valueOne = 47;
            //    valueTwo = 30;
            //    Console.WriteLine("Pranav ran" + " " + (valueOne - valueTwo) + " " + "miles" + ".");
            //    valueOne = 12;
            //    valueTwo = 3;
            //    Console.WriteLine(valueOne / valueTwo + " " + "boxes");
            //    valueOne = 27.10;
            //    valueTwo = 5.12;
            //    Console.WriteLine("Norachai had" + " " + (valueOne + valueTwo) + " " + "before buying the salad" + ".");

            //Day 3
            //double valOne = 7;
            //double valTwo = 2;
            //double total = valOne - valTwo;
            //Console.WriteLine("What is your name");
            //string name = Console.ReadLine();
            //Console.WriteLine(name + " , you need" + " " + total + " more cups of sugar.");

            //valOne = 13;
            //valTwo = 4;
            //total = valOne * valTwo;
            //Console.WriteLine("What are your names");
            //string friend = Console.ReadLine();
            //Console.WriteLine("{0} your total bill is {1} dollars.", friend, total);

            //valOne = 40;
            //valTwo = 8;
            //total = valOne / valTwo;
            //Console.WriteLine("Customer,what is your name");
            //string customer = Console.ReadLine();
            //Console.WriteLine("{1} can buy {0} packages of diapers",total,customer);

            // Week 2 Day 2
            //int[] numbers = new int[25];

            //for(
            //    int i = 0; i < numbers.Length;i++)
            //{
            //    Console.WriteLine("Enter a value for " + i);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            Console.WriteLine("How far would you like to add?");
            int input = int.Parse(Console.ReadLine());
            int[] number = new int[input];
            int numSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                numSum = (numSum + (i + 1));
            }
            Console.WriteLine(numSum);

            }
        } 
    }
