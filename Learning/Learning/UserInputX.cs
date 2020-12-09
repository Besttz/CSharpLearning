using System;
namespace X
{
    using System.Collections.Generic;
    using System;

    public class TextInput
    {
        public List<char> list = new List<char>();

        public virtual void Add(char c)
        {
            list.Add(c);
        }

        public string GetValue()
        {
            string r = "";
            foreach (char l in list)
            {
                r = r + l;
            }
            return r;
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (c < '0' || c > '9') { }
            else
                list.Add(c);
        }
    }

    public class UserInput
    {
        public static void aMain(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}
