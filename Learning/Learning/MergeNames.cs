using System;
namespace Learning
{

    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            int duplicate = 0;
            for (int i = 0; i < names1.Length; i++)
            {
                for (int j = 0; j < names2.Length; j++)
                {
                    if (names1[i] == names2[j])
                    {
                        duplicate++;
                        break;
                    }
                }
            }

            int total = names1.Length + names2.Length - duplicate;
            string[] result = new string[total];
            for (int i = 0; i < names1.Length; i++)
            {
                result[i] = names1[i];
            }
            int index = names1.Length;
            for (int i = 0; i < names2.Length; i++)
            {
                bool isDuplicated = false;
                for (int j = 0; j < names1.Length; j++)
                {
                    if (result[j] == names2[i])
                    {
                        isDuplicated = true;
                        break;
                    }
                }
                if (!isDuplicated)
                {
                    result[index++] = names2[i];
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}
