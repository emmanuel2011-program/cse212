public static class Arrays
{
     /// <summary>
     /// I have created a class called arrays,
     /// i used 7 as my starting point with 5 as the multiples
     /// i aslo used 1.5 as my starting point with 10 as the multiples
     /// i also used -2 as my starting point with 10 as the multiples
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
    /// I created an empty array of doubles with the given length.
    /// used the loop from 0 to (length - 1)
    /// In each iteration,I multiplied the base number by (i + 1) to get the next multiple.
    /// i  Stored the result in the corresponding index of the array.
    /// After the loop ends, return the filled array.
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
    /// Get the count of items in the list.
    ///  Use modulo (%) to reduce amount in case it's larger than the list size.
    /// If amount is 0, do nothing (no rotation needed).
    /// Use GetRange to copy the last 'amount' elements into a temporary list.
    /// Remove those elements from the end of the original list.
    /// Insert the temporary list elements at the beginning of the original list.
   


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

