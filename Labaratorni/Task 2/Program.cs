using System;
using System.Collections.Generic;

class Program
{

    
    static void Main(string[] args)
    {
        string s,s1,s2,s3;
        int a;
        /*
        s = Console.ReadLine();

        if( s.Length == 2 && Int32.Parse(s) % 2 == 0)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");



        s = Console.ReadLine();

        if (s.Length == 3 && Int32.Parse(s) % 2 != 0)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");


        s1 = Console.ReadLine();
        s2 = Console.ReadLine();
        s3 = Console.ReadLine();

        if (s1 == s2 || s1 == s3 || s2 == s3)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");


        s1 = Console.ReadLine();
        s2 = Console.ReadLine();
        s3 = Console.ReadLine();
        int a, a1, a2, a3;
        a1 = Int32.Parse(s1);
        a2 = Int32.Parse(s2);
        a3 = Int32.Parse(s3);

        if (a1 == -a2 || a1 == -a3 || a2 == -a3)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");


        s = Console.ReadLine();
        a = Int32.Parse(s);

        if (s.Length == 3)
        {
            if ((a/100 + a%100 + ((a / 10) - ((a / 100) * 10))) % 2 == 0)
                Console.WriteLine("True");
            else 
                Console.WriteLine("False");
        }
        else
            Console.WriteLine("False");
        */

        s = Console.ReadLine();
        a = Int32.Parse(s);

        if (s.Length == 4)
        {
            Console.WriteLine(a / 1000);
            Console.WriteLine(((a % 1000) / 100));
            Console.WriteLine(((a % 100) / 10));
            Console.WriteLine(a % 10);

            if ((a / 1000 + ((a % 1000) / 100)) == (((a % 100) / 10) + a % 10)) {
                
                Console.WriteLine("True"); }
            else
                Console.WriteLine("False");
        }
        else
            Console.WriteLine("False");

    }
}