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
            string name;
            name = "Abdol";
            Console.WriteLine(name.ToString()); // abdol (1/ Call ToSring object , 2/ Call back Tostring string type because Behavior string Types override Tostring dafault behavior)
            #endregion
            #endregion

        }
    }
}
