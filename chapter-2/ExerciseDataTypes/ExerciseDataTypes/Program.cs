using System;

namespace ExerciseDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int length, width, area;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Enter the length of the rectangle ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            width = int.Parse(Console.ReadLine());
            area = length * width;
            Console.WriteLine("the area of the rectangle is " + area);

            float mpg, miles, gallon;
            Console.WriteLine("Enter total miles to drive for a trip?");
            miles = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter total gallon of gas you have consumed");
            gallon = float.Parse(Console.ReadLine());
             mpg = miles / gallon;
            Console.WriteLine("Your mpg is  " + mpg);
            */
            string firstString = "Alice was beginning to get very tired of sitting by her sister on the bank";
            Console.WriteLine("Enter the word to search");
            string searchWord = Console.ReadLine();
            bool result = firstString.ToLower().Contains(searchWord.ToLower());
            Console.WriteLine(result + " is found ");

             int name = firstString.ToLower().IndexOf(searchWord.ToLower());
            Console.WriteLine(searchWord +  " is in position " + name + "and the length is " + searchWord.Length);
        }
        
    }
}
