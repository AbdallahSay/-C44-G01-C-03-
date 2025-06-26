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
            #endregion

        }
    }
}
