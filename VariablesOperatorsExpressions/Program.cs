using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings - use double quotes

            string name = "Karen";
            //Console.WriteLine(name);
            name = "Bob"; //changing the value of the variable from the originally assigned name
            //Console.WriteLine(name);
            //when this runs, it goes from top to bottom, so will put out both

            string Name = "Jordan";//case matters - name is not the same as Name or NAME
           // Console.WriteLine(Name);

            string birthMonth = "August";
            //  Console.WriteLine(birthMonth);

            // integers
            int birthMonthNumber = 8;
       //     Console.WriteLine(birthMonthNumber);
            int age = 48;
            int population = 100000;
           
            //floating type variables - different data types have different amounts of precision
            float number = 2.164403304897294383961032f;//f = float will give 6 decimal places
            double someNumber = 2.164403304897294383961032d;//d = double will give 12 decimal places
            decimal partialNumber = 2.164403304897294383961032m;//m = decimal will give 24 decimal places
            Console.WriteLine(number);
            Console.WriteLine(someNumber);
            Console.WriteLine(partialNumber);

            //Boolean variables are true or false values
            bool isPresent = true;

            //Character or char uses single quotes - denotes a single character value
            char lastLetter = 'f';

            //Operators

            //example 1 - translating english to code
            //Jessica is 23 years old.
            //Sam is 47.
            // Jessica is younger than Sam.

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);//returns a boolean value of true or false

            //example 2 - mike and 3 friends want to decide bill evenly, each person paid $13 what was total bill?
            int billShare = 13;
            int numFriends = 4;
            Console.WriteLine(billShare * numFriends);
            int totalBill = billShare * numFriends; //another way to do this same thing
            Console.WriteLine(totalBill);
            

            //example 3 - lisa is cooking muffins. recipe needs 7 c. sugar. She already put in 2 c. how many left?
            



        }
    }
}
