using System.Drawing;

namespace Demo2
{
    internal class Program
    {
        //static void Print<G>(G Value){  // Generics hold any taype After 2005
        //    Console.WriteLine(Value);
        //}
        //static void TestPrint()
        //{
        //    Print(10);
        //    Print("Abdallah");
        //    Print(true);
        //    Print(3.5f); //Float
        //    Print(30.5); //Double

        //}
        //    static void PrintObj(object obj)
        //{
        //    Console.WriteLine(obj);
        //}
        //    static void TestPrintObj()
        //{
        //    PrintObj(10);//Boxing
        //    PrintObj("Abdallah"); // Boxing
        //    PrintObj(true); //Boxing
        //}
        static void Main(string[] args)
        {
            #region Demo
            #region Object
            //TestPrint(); // Call Generic
            //TestPrintObj();
            //object obj;
            //obj = 20; // Boxing
            //int Number = (int)obj; // UnBoxing
            //Console.WriteLine(Number); // 20 (Successful Casting)
            //object obj;
            //obj  = "Abdallah";
            //int Number = 20;
            //int Result = Number + (int)obj; //inValid (Remove Type Safety)
            //Console.WriteLine(Result); // Runtime Erorr
            #endregion
            #region ToString
            //object o = null;
            //string s = o.ToString(); // runtime error (NullReferenceException) 
            // لازم تتاكد ان object != Null 
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x.ToString()+y.ToString()); // 1020 Beacuse X , Y Represent as String Not int
            //Point p1 = new Point() { x = 4, y = 8 }; //  Initializer Object
            //Point p2 = new Point() { x = 410 , y = 30 };

            //Console.WriteLine(p1.ToString());//Demo2.Point // Default Implementaion (Default Behavior (Object) )
            //Console.WriteLine(p2.ToString()); // Object (Return Path Default Behavior)

            //Most type override this method
            //int x = 10;
            //Console.WriteLine(x.ToString()); // 10 (1/ Call ToSring object , 2/ Call back Tostring Int32 because Behavior struct Types override Tostring dafault behavior)
            //string name;
            //name = "Abdol";
            //Console.WriteLine(name.ToString()); // abdol (1/ Call ToSring object , 2/ Call back Tostring string type because Behavior string Types override Tostring dafault behavior)
            //#endregion
            #endregion
            #region Equals
            //Point p1 = new Point() { x = 10, y = 20 };
            //Point p2 = new Point() { y = 10, x = 20 };
            //Console.WriteLine(p1.Equals(p2)); // Compare Reference (Return False)
            //p1 = p2; // reference p1 = reference p2
            //Console.WriteLine(p1.Equals(p2)); // true
            // Override String ,  value type to compare values
            //object num1 = 20;
            //object num2 = 20;
            //Console.WriteLine(num1.Equals(num2)); // true compare based on value
            //object name1 = "Abdallah";
            //object name2 = "Abdallah";
            //Console.WriteLine(name1.Equals(name2));
            //object name1 = "Abdallah";
            //object name2 = "abdallah";
            //Console.WriteLine(name1.Equals(name2)); // false (Case sensitive)
            #endregion
            #region GetHashCode
            //Generate based on Reference address
            //Point p1 = new Point() { x = 10, y = 20 };
            //Point p2 = new Point() { y = 10, x = 20 };
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            //p1 = p2;
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            // int return value
            //object num = 10;
            //object num2 = 12;
            //Console.WriteLine(num.GetHashCode());
            //Console.WriteLine(num2.GetHashCode());
            //object num3 = 12.2f;
            //Console.WriteLine(num3.GetHashCode());// ?? 
            //object name= "Abdol";
            //Console.WriteLine(name.GetHashCode());


            #endregion
            #region GetType
            //Point p1 = new Point() { x = 0, y = 0 };    
            //Point p2 = new Point() { y = 0, x = 0 };
            //Console.WriteLine(p1.GetType()); //Demo2.point ()
            //object num = 20;
            //Console.WriteLine(num.GetType());//System.Int32(BCL)
            //object name = "Abdol"; //System.String(BCL)
            //Console.WriteLine(name.GetType());
            #endregion
            #region Fraction &Discard
            //float (Size =  4 byte , 7 digits)
            //float num = 1023.444f;
            //Console.WriteLine(num);//1023.444
            //num = 1.22234566776654343f;
            //Console.WriteLine(num);//1.2223457(هيطلع 7 ارقام واخر رقم هيقربه)
            //float num = 10;
            //Console.WriteLine(num);
            //float Result = 3 / 2;
            //Console.WriteLine(Result);//1 (Logical error -------- int ل implict cast هيعمل  )
            //float Result1 = 3.0f / 2;
            //Console.WriteLine(Result1);
            /**/
            //Double (Default , Most commen used , 8 byte , 15-16 digits)
            //double number = 333_333_333_2.333_332;
            //Console.WriteLine(number);
            //number = 33333322.23456789699;
            //Console.WriteLine(number);
            //decimal (16 byte , 28-29 digits)
            //decimal number = 12.555m;
            //Console.WriteLine(number);
            //number = 222.33333333455555555555555555555555555555555555322222222222M;
            //Console.WriteLine(number);
            /**/
            //Dicard(_)  ,Digit sperator (_)
            //int num = 123_343_222;
            //Console.WriteLine(num);123343222 Digit sperator
            //int.TryParse(Console.ReadLine(), out _); // تجاهلنا parameter
            /*/*/
            //Format $
            //int num = 100_000_000;
            //Console.WriteLine($"{num:c}");

            #endregion
            #region Casting
            //implict casting [Save]
            //int x = 1000233;
            //long y = x;
            //Console.WriteLine(y); //[Save]
            //explicit casting
            //long x = 123454423;
            //int y = (int)x;
            //Console.WriteLine(y); // تمام علشان الرقم قادر يتخزن في 4 بايت
            //long x = 1234544213244112423;
            //int y = (int)x;
            //Console.WriteLine(y); // Arithmatic Overflow
            //checked
            //{
            //    long x = 1234544213244112423;
            //    int y = (int)x;
            //    unchecked
            //    {
            //        Console.WriteLine(y); // throw exception
            //    }
            // Min - Max
            //long x = 123454;
            //if(x > int.MaxValue || x < int.MinValue)
            //{
            //    Console.WriteLine("Exception");
            //}
            //else
            //{
            //    int y = (int)x;
            //    Console.WriteLine(y);
            //}
            //object num = 1234;
            //if(num.GetType() == typeof(int))
            //{
            //    int y = (int)num;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.WriteLine("Exception");
            //}

            //}

            #endregion
            #region Convert & Parse & TryParse
            //Conver [Class]
            //EX: take name and age and salary from user and print
            //Console.WriteLine("Plase Enter Your Data");
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine(); // No problem 
            //Console.WriteLine("Enter Your Age");
            //int age = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Enter Your salary");
            //double salary =Convert.ToDouble( Console.ReadLine());
            //Console.Clear();
            //Console.Beep(100, 1500);
            //Console.WriteLine($"Name   : {name}");
            //Console.WriteLine($"Age    : {age}");
            //Console.WriteLine($"Salary : {salary}");
            //Parse
            //EX: take name and age and salary from user and print
            //Console.WriteLine("Plase Enter Your Data");
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine(); // No problem 
            //Console.WriteLine("Enter Your Age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your salary");
            //double salary = double.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(100, 1500);
            //Console.WriteLine($"Name   : {name}");
            //Console.WriteLine($"Age    : {age}");
            //Console.WriteLine($"Salary : {salary}");
            //tryparse
            //Console.WriteLine("Plase Enter Your Data");
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age");
            //int age; // declare varible
            //bool isParsedAge = int.TryParse(Console.ReadLine(), out age); // (out age) ageوبعدين حطها في int وحولها ل ReadLIne يعني خد القيمه اللي هتجيلك من 
            //Console.WriteLine("Enter your Salary");
            //bool isParsedSalary = double.TryParse(Console.ReadLine(), out double salary);
            //Console.Clear();
            //Console.WriteLine($"Name = {name}");
            //Console.WriteLine($"Is Parsed Age = {isParsedAge}");
            //Console.WriteLine($"Age = {age}");
            //Console.WriteLine($"Is Parsed salary = {isParsedSalary}");
            //Console.WriteLine($"salary = {salary}");
            #endregion
            #endregion

        }
    }
}
