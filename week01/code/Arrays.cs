public static class Arrays
{
     /// <summary>
     /// I have created a class called arrays,
     /// i used 7 as my starting point with 5 as the multiples
     /// i created my function to be called Run()
     /// This function will run the tests for the MultiplesOf 7,5,starting from 7, and terminating at 5th multiples. 
     /// also used 1.5 and 10, and also -2, and 10 respectively.
     /// 
     /// </summary>
    public static void Run()
    {
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}
        /// I have created a a list called numbers,
        /// i used 1,2,3,4,5,6,7,8,9 as my starting point
        /// i rotatelistRight to the right by various numbers,  
        /// i rotate by 1, the last element in this case 9 moves to the front, rotate by 5 the last 5 elements moves to the front, and by three last 3 element , and 9 every element goes to it original position as it where respectively.
        /// I used the Console.WriteLine to print the results of the rotation.
        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
        
    }

    ///<sumamry>
    /// i created the result array
    /// used the loop to determine the start and the end of the array result created
    /// i filled each index with the next multiple
    /// i then return the filled array  which is result
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;

       
    }

    
    
    ///<summary>
    /// created variable count
    /// used modulo(%) to handle cases where amount > length i.e rotating by 18 on the  list of 9
    ///  used range to get the last amount element
    /// remove the e,lement from the end
    /// insert them at the beginning


    public static void RotateListRight(List<int> data, int amount)

    {

        int count = data.Count;
        amount %= count;
        if (amount == 0) return;

        List<int> tail = data.GetRange(count - amount, amount);
        data.RemoveRange(count - amount, amount);
        data.InsertRange(0, tail);


    }
}

