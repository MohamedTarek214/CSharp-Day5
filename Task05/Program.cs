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


            #region Problem3 
            //int? number = null;

            ////  null-coalescing operator
            //int DefaultValue = number ?? 0;
            //Console.WriteLine($"Value using ?? : {DefaultValue}");

            ////  HasValue
            //if (number.HasValue)
            //{
            //    Console.WriteLine("Number have value");
            //}
            //else
            //{
            //    Console.WriteLine("Number is null");
            //}

            ////  Value
            //number = 10;

            //if (number.HasValue)
            //{
            //    Console.WriteLine($"Value property : {number.Value}");
            //} 
            #endregion


            #region Problem4 
            //try
            //{
            //    int[] arr = { 1, 2, 3, 4, 5 };
            //    Console.WriteLine(arr[5]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem5  
            //int[,] arr = new int[3,3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the value for row number {i+1}");
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter values of [{i},{j}]");
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}
            //Console.Clear();    
            //Console.WriteLine("====================");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");


            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Array 3x3");
            //Console.WriteLine("====================");
            //int sum = 0;    
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //       sum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum Row{i+1} = {sum}");
            //    Console.WriteLine();
            //    sum = 0;
            //}
            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum += arr[j, i];
            //    }
            //    Console.WriteLine($"Sum Column{i + 1} = {sum}");
            //    Console.WriteLine();
            //    sum = 0;
            //} 
            #endregion

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
