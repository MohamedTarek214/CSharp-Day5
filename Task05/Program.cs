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

            // problem2
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

            #region Problem6  
            //int[][] arr = new int[3][];

            //arr[0] = new int[3];
            //arr[1] = new int[5];
            //arr[2] = new int[2];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter values for row number {i + 1}");

            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"Enter value [{i},{j}]: ");
            //        arr[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine("====================");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("===================="); 
            #endregion

            #region Problem7  
            // my solution
            //Console.Write("enter your string:  ");
            //string? input = Console.ReadLine();
            //if (string.IsNullOrEmpty(input))
            //{
            //    Console.WriteLine("input is empty ");
            //}
            //else
            //{
            //    Console.WriteLine($"Your input is : {input}");
            //}

            //-----------------------------------
            // gpt
            //Console.Write("Enter your input: ");

            //string? input = Console.ReadLine();

            //string? message;

            //if (input == "yes")
            //{
            //    message = "Hello";
            //}
            //else
            //{
            //    message = null;
            //}

            //if (message != null)
            //{
            //    Console.WriteLine(message!);
            //}
            //else
            //{
            //    Console.WriteLine("message is null");
            //}

            #endregion

            #region Problem8  
            //// Boxing
            //int X = 10;
            //object O1 = X;

            //// Unboxing
            //int Y = (int)O1;

            //// Invalid Cast
            //try
            //{
            //    double Z = (double)O1;
            //    Console.WriteLine(Z);
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem9   
            //int Sum, Multiply;
            //SumAndMultiply(3, 3 , out Sum , out Multiply);
            //Console.WriteLine($"Sum = {Sum}");
            //Console.WriteLine($"Multiply = {Multiply}"); 
            #endregion

            //Problem10
            //PrintString("Hello World"  , Count:3);

            #region Problem11  
            //int[]? arr = null;
            //Console.WriteLine($"{arr?.Length}"); 
            #endregion

            #region Problem12    
            //Console.Write("Enter Day: ");
            //string day = Console.ReadLine();
            //int number = day switch
            //{
            //    "Saturday" => 1,
            //    "Sunday" => 2,
            //    "Monday" => 3,
            //    "Tuesday" => 4,
            //    "Wednesday" => 5,
            //    "Thursday" => 6,
            //    "Friday" => 7,

            //};
            //Console.WriteLine($"{day} DayNumber {number}"); 
            #endregion

            #region Problem13
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine($"Sum Element in Array = {SumArray(arr)}");
            //Console.WriteLine($"Sum Element in Array = {SumArray(4, 5, 6)}"); 
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

        #region Problem2  
        public static int TestDefensiveCode()
        {

            int X, Y, Z;
            do
            {
                Console.Write("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
            do
            {
                Console.Write("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            return Z = X / Y;

        }
        #endregion

        #region Problem9
        public static void SumAndMultiply(int num1, int num2, out int sum, out int multiply)
        {
            sum = num1 + num2;

            multiply = num1 * num2;

        }
        #endregion

        #region Problem10
        public static void PrintString(string sString, int Count = 5)
        {
            for (int i = 1; i <= Count; i++)
            {
                Console.WriteLine(sString);
            }
        }
        #endregion

        #region Problem13
        public static int SumArray(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        } 
        #endregion

    }
}
