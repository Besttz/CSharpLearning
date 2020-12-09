using System;
using System.Collections.Generic;
using System.Linq;


public class UniqueNumbers
{
    public static IEnumerable<int> FindUniqueNumbers(IEnumerable<int> numbers)
    {
        // var results = new List<int>();
        // var dup = new List<int>();
        // foreach (var num in numbers)
        // {
        //     if (dup.Contains(num))
        //     {
        //         continue;
        //     }
        //     if (results.Contains(num))
        //     {
        //         dup.Add(num);
        //         results.Remove(num);
        //     } else {
        //         results.Add(num);
        //     }
        // }
        // return results;

        int ones = 0, twos = 0;
        int common_bit_mask;


        foreach (int i in numbers)
        {
            twos = twos | (ones & i);
            ones = ones ^ i;
            common_bit_mask = ~(ones & twos);
            ones &= common_bit_mask;
             twos &= common_bit_mask;
        }
        for (int i = 0; i < n; i++)
        {
            // "one & arr[i]" gives the bits 
            // that are there in both 'ones' 
            // and new element from arr[]. 
            // We add these bits to 'twos' 
            // using bitwise OR 
            twos = twos | (ones & arr[i]);

            // "one & arr[i]" gives the bits 
            // that are there in both 'ones' 
            // and new element from arr[]. 
            // We add these bits to 'twos' 
            // using bitwise OR 
            ones = ones ^ arr[i];

            // The common bits are those bits 
            // which appear third time So these 
            // bits should not be there in both 
            // 'ones' and 'twos'. common_bit_mask 
            // contains all these bits as 0, 
            // so that the bits can be removed 
            // from 'ones' and 'twos' 
            common_bit_mask = ~(ones & twos);

            // Remove common bits (the bits that 
            // appear third time) from 'ones' 
            ones &= common_bit_mask;

            // Remove common bits (the bits that 
            // appear third time) from 'twos' 
            twos &= common_bit_mask;
        }
        return ones;
    }


    public static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 1, 3 };
        foreach (var number in FindUniqueNumbers(numbers))
            Console.WriteLine(number);
    }
}