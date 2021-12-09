using System;
using System.Collections.Generic;

class execute
{ 

    static void Main(string[] args)
    {

        // Variant 8
        string s;

        s = Console.ReadLine();

        int n = Int32.Parse(s);
        int[] a = new int[n];
        int min = 9999, max = -9999, mini = 0, maxi = 0;

        for(int i=0; i<n; i++)
        {
            s = Console.ReadLine();
            a[i] = Int32.Parse(s);
            if(a[i] < min)
            {
                min = a[i];
                mini = i;
            }
            if(a[i] > max)
            {
                max = a[i];
                maxi = i;
            }
        }

        if(mini > maxi)
        {
            int temp = maxi;
            maxi = mini;
            mini = temp;
        }

        int j = 0;
        for(int i=mini; i<=maxi/2; i++)
        {
            int temp = a[i];
            a[i] = a[maxi - j];
            a[maxi - j] = temp;
            j++;
        }

        for(int i=0; i<n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}