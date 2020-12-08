
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    using System;
using System.Text;

public class TextInput {
    private char[] text = new char[100];
    private int index = 0;
    public virtual void Add(char c) {
        text[index++] = c;
                Console.WriteLine(c);


    }
    
    public string GetValue() {
        return new string(text);
    }
}

public class NumericInput : TextInput {
    private char[] text = new char[100];
    private int index = 0;
    
    public override void Add(char c) {
        if (Char.IsDigit(c)){
        text[index++] = c;
            Console.WriteLine(c);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}
    
 
}