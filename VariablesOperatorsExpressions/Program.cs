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
            /* comment these lines off
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

   end comment section */

            
    //Operators

            //example 1 - translating english to code
            //Jessica is 23 years old.
            //Sam is 47.
            // Jessica is younger than Sam.

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine("Is Jessica younger than Sam?");
            Console.WriteLine(jessicaAge < samAge);//returns a boolean value of true or false

            //example 2 - mike and 3 friends want to decide bill evenly, each person paid $13 what was total bill?
            int billShare = 13;
            int numFriends = 4;
            Console.WriteLine("The total bill was (two different ways)");

            Console.WriteLine(billShare * numFriends);
            int totalBill = billShare * numFriends; //another way to do this same thing
            Console.WriteLine(totalBill);


            //example 3 - lisa is cooking muffins. recipe needs 7 c. sugar. She already put in 2 c. how many left?
            int sugarTotal = 7;
            int sugarIn = 2;
            int sugarLeft = sugarTotal - sugarIn;
            Console.WriteLine("The amount of sugar remaining is " + sugarLeft);

            //example 4 - how many packages of diapers can you buy with $40 if each is $8
            float costDiapers = 8.00f;
            float totalMoney = 40.00f;
            float numDiapers = totalMoney / costDiapers;
            Console.WriteLine("You can buy " + numDiapers + " packages of diapers");

            //example 5 - last friday Trevon had $29. over the weekend he cleaned the attic. He now has $41. How much did he receive?
            float startMoney = 29.00f;
            float nowMoney = 41.00f;
            float moneyMade = nowMoney - startMoney;
            Console.WriteLine("Trevor made $" + moneyMade);

            //example 6 - Julia ran 30 miles more than pranav. Julia ran 47 miles. How many miles did Pranav run?

            double juliaRun = 47d;
            double juliaRunMoreThanPranav = 30d;
            double pranavRun = juliaRun - juliaRunMoreThanPranav;
            Console.WriteLine("Pranav ran " + pranavRun + " miles");

            //example 7 mow many boxes of envelopes can you buy with $12 if one box costs $3
            float envelopeCost = 3.00f;
            float totalMoney7 = 12.00f;
            float canBuy = totalMoney7 / envelopeCost;
            Console.WriteLine("You can buy " + canBuy + " boxes of envelopes");

            //example 8 after paying $5.12 for a salad Norachai has $57.10. How much did he have to start?
            float saladCost = 5.12f;
            float norachaiFinalAmt = 57.10f;
            float norachaiStartAmt = norachaiFinalAmt + saladCost;
            Console.WriteLine("start amount was $" + norachaiStartAmt);

            //example page 2-1 331 students went on a field trip there were 6 buses and 7 students left in cars. how many people per bus?
            int numStudents = 331;
            int numBuses = 6;
            int studentsInCars = 7;
            int studentsPerBus = (numStudents - studentsInCars) / numBuses;
            Console.WriteLine("The number of students in each bus is " + studentsPerBus);

            //example 2-2 aliyah spent









        }
    }
}
