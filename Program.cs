 class LargestOfThreeNumbers
    {
    /// <summary>
    /// num1 = 60
    /// num2 = 45
    /// num3 = 123
    /// Output: 123
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0, num3 = 0, tempNum = 0;

        System.Console.WriteLine("Program will output the highest number from three values.");

        System.Console.Write("Enter first integer number: ");
        string num1String = System.Console.ReadLine();
        // display error message if input not a number
        if (!System.Int32.TryParse(num1String, out num1))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        {
            System.Console.Write("Enter second integer number: ");
            string num2String = System.Console.ReadLine();
            if (!System.Int32.TryParse(num2String, out num2))
            {
                System.Console.WriteLine("Wrong input");
            }
            else
            {
                System.Console.Write("Enter third integer number: ");
                string num3String = System.Console.ReadLine();
                if (!System.Int32.TryParse(num3String, out num3))
                {
                    System.Console.WriteLine("Wrong input");
                }
                else
                {
                    tempNum = num1;

                    if (num1 < num2) { 
                        tempNum = num2;
                    }

                    if (tempNum < num3) { 
                        tempNum = num3;
                    }
                    System.Console.WriteLine(tempNum);
                }
            }
        }
        System.Console.WriteLine("Press any key to end program.");
        System.Console.ReadKey();
    }
}
