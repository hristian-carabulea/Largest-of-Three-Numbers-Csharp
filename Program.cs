 class LargestOfThreeNumbers
    {
    /// <summary>
    /// find the largest number from the tree
    /// num1 = 1
    /// num2 = 3
    /// num3 = 2
    /// Output: 3
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        //int num1 = 0, num2 = 0, num3 = 0, tempNum = 0; // using instead inline declarations

        System.Console.WriteLine("Program will output the highest number from three values.");

        System.Console.Write("Enter first integer number: ");
        string num1String = System.Console.ReadLine();
        // display error message if input not a number
        if (!System.Int32.TryParse(num1String, out int num1))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        {
            System.Console.Write("Enter second integer number: ");
            string num2String = System.Console.ReadLine();
            if (!System.Int32.TryParse(num2String, out int num2))
            {
                System.Console.WriteLine("Wrong input");
            }
            else
            {
                System.Console.Write("Enter third integer number: ");
                string num3String = System.Console.ReadLine();
                if (!System.Int32.TryParse(num3String, out int num3))
                {
                    System.Console.WriteLine("Wrong input");
                }
                else
                {
                    int tempNum = num1;

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
