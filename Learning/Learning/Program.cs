using System;

namespace TextInput
{
    public class TextInput
    {
        protected char[] text = new char[100];
        protected int index = 0;
        public virtual void Add(char c)
        {
            text[index++] = c;
        }

        public string GetValue()
        {
            return new string(text);
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (Char.IsDigit(c))
            {
                text[index++] = c;
            }
        }
    }

    class Program
    {
        public static void aMain(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadLine();
        }
    }


}
