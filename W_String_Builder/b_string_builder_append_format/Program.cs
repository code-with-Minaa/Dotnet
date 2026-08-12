﻿namespace b_string_builder_append_format;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder strbldr = new StringBuilder("The cost price of this mobile phone is :");
        // strbldr.Append(1000);
        strbldr.AppendFormat("{0:c}", 1000);
        Console.WriteLine(strbldr);
    }
}