using System;
namespace Name
{
    

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        string[] result = new string[10];
        names1.CopyTo(result,0);
        foreach (var item in result)
        {
        Console.WriteLine(item);
        }
    }
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}
}