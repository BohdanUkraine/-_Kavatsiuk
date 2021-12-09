using System;
using System.Collections.Generic;

class Program
{

    private static string reverse(string h)
    {
        string res = "";

        for (int j = h.Length - 1; j >= 0; j--)
        {
            res += h[j];
        }

        return res;
    }

    private static void ref_reverse(ref string h)
    {
        string res = "";

        for (int j = h.Length - 1; j >= 0; j--)
        {
            res += h[j];
        }

        h = res;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int a = Int32.Parse(s);

        while (a != 0)
        {
            Console.Write(a % 10);
            a /= 10;
        }

        Console.WriteLine();

        s = Console.ReadLine();

        for (int j = s.Length-1; j >= 0; j--)
        {
            Console.Write(s[j]);
        }

        Console.WriteLine();

        s = Console.ReadLine();

        int i = 0;

        while(s[i] != '.')
        {
            i++;
        }

        for (int j = i-1; j >= 0; j--)
        {
            Console.Write(s[j]);
        }

        Console.Write('.');

        for (int j = s.Length-1; j > i; j--)
        {
            Console.Write(s[j]);
        }

        Console.WriteLine();

        s = Console.ReadLine();

        Console.WriteLine(reverse(s));


        Console.WriteLine();

        s = Console.ReadLine();

        ref_reverse(ref s);

        Console.WriteLine(s);

    }
}