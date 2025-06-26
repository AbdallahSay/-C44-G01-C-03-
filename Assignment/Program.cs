using System.Diagnostics.Metrics;
using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1-	Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Please Enter Number");
            //bool isParsedNumber = int.TryParse(Console.ReadLine(), out int number);
            //Console.Clear();
            //Console.WriteLine($"isParsedNumber : {isParsedNumber}");
            //Console.WriteLine($"number is : {number}");

            #endregion
            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string name = "Abdol";
            //int Number = Convert.ToInt32(name);
            //Console.WriteLine(Number); // throw format exception
            #endregion
            #region 3 -    Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 3.5f;
            //double num2 = 12.5;
            //Console.WriteLine($"num1 + num2 : {num1 + num2}");//16
            //float num1 = 3;
            //float num2 = 2;
            //Console.WriteLine($"num1 / num2 : {num1 / num2}"); // 1.5
            //Console.WriteLine($"num1 * num2 : {num1 * num2}"); // 6
            //Console.WriteLine($"num1 - num2 : {num1 - num2}"); //1

            #endregion
            #region 4-	Write C# program that Extract a substring from a given string.
            //string originalText = "Luka is the best";
            //string extrected = originalText.Substring(0, 4);
            //Console.WriteLine("Original : "+originalText);
            //Console.WriteLine("Extracted : "+extrected);
            #endregion
            #region 5-     Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 10;
            //int y = 20;
            ////Console.WriteLine(x);//10
            ////Console.WriteLine(y);//20
            //x = y;// 20 20
            ////Console.WriteLine(x);//20
            ////Console.WriteLine(y);//20
            //y = 30;
            //Console.WriteLine(x);//20
            //Console.WriteLine(y);//30
            ////value type (بنساوي value  )


            #endregion
            #region 6-	 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point p1 = new Point() { x = 10, y = 20 };
            //Point p2 = new Point() {x = 30, y = 40 };
            //Console.WriteLine(p1.x);//10
            //Console.WriteLine(p2.x);//30
            //p1 = p2;//( Assign Refrence of p2 to p1)
            ////Console.WriteLine(p1.x);//30
            ////Console.WriteLine(p2.x);//30
            //p2.x = 50;
            //Console.WriteLine(p1.x);//50
            //Console.WriteLine(p2.x);//50
            //p1 old object is a nureacable object( x= 10 , y = 20)


            #endregion
            #region 7-	Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("please enter First Name");
            //string fName = Console.ReadLine();
            //Console.WriteLine("please enter First Name");
            //string lName = Console.ReadLine();
            //Console.WriteLine($"My name is : {fName} {lName}");

            #endregion
            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //Console.WriteLine("please Enter Data");
            //Console.WriteLine("Enter principal amount");
            //double salary;
            //bool isParsedSalary = double.TryParse(Console.ReadLine(), out salary);
            //Console.WriteLine("Enter rate of interest");
            //double rate;
            //bool isParsedInterset = double.TryParse(Console.ReadLine(), out rate);
            //Console.WriteLine("Enter time");
            //double time;
            //bool isParsedTime = double.TryParse(Console.ReadLine(), out time);
            //double interset = (salary * rate * time) / 100;
            //Console.WriteLine($"Your interset = {interset}");

            #endregion
            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.WriteLine("Enter  weight in kilograms");
            //Double weight;
            //bool isParsedWeight = double.TryParse(Console.ReadLine(), out weight);
            //Console.WriteLine("Enter  height in meters");
            //Double height;
            //bool isParsedHeight = double.TryParse(Console.ReadLine(), out height);
            //Double BMI = weight / (height * height);
            //Console.WriteLine($"BMI : {BMI}");

            #endregion
        }
    }
}
