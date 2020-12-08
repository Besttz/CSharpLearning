using System;

namespace TextInput
{
    public class TextInput
    {
        protected char[] text = new char[100];
        private int index = 0;
        public virtual void Add(char c)
        {
            text[index++] = c;
            Console.WriteLine(c);
        }

        public string GetValue()
        {
            return new string(text);
        }
    }

    public class NumericInput : TextInput
    {
        //private char[] text = new char[100];
        private int index = 0;

        public override void Add(char c)
        {
            if (Char.IsDigit(c))
            {
                text[index++] = c;
                Console.WriteLine(c);
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
