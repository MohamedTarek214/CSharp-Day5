namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1  
            //try
            //{
            //    Console.WriteLine("========================");
            //    Console.WriteLine("enter 2 integer numbers");
            //    Console.WriteLine("========================");
            //    Console.Write("enter number 1: ");
            //    int Number1;
            //    bool Flag = int.TryParse(Console.ReadLine(), out Number1);
            //    while (!Flag)
            //    {
            //        Console.WriteLine("Please enter a valid integer for the first number:");
            //        Flag = int.TryParse(Console.ReadLine(), out Number1);
            //    }
            //    Console.Write("enter number 2: ");
            //    int Number2;
            //    bool Flag2 = int.TryParse(Console.ReadLine(), out Number2);
            //    while (!Flag2)
            //    {
            //        Console.WriteLine("Please enter a valid integer for the scond number:");
            //        Flag2 = int.TryParse(Console.ReadLine(), out Number2);
            //    }

            //    Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
            //}
            //catch (DivideByZeroException Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            #endregion

            // Console.WriteLine(TestDefensiveCode()); 



            Console.ReadKey();
        }
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("Enter first Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
        //    do
        //    {
        //        Console.WriteLine("Enter Second Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 0);

        //    Z = X / Y;

        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 69)
        //        arr[69] = 90;
        //}

        #region Priblem2  
        //public static int TestDefensiveCode()
        //{

        //    int X, Y, Z;
        //    do
        //    {
        //        Console.Write("Enter first Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
        //    do
        //    {
        //        Console.Write("Enter Second Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //   return Z = X / Y;

        //} 
        #endregion

    }
}
