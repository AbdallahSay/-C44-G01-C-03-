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
        }
    }
}
