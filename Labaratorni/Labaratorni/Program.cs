using System;
using System.Collections.Generic;

class disk_phone
{
    public string Self_Number { get; set; }
    public string brand { get; set; }

    public virtual void Call(string number)
    {
        Console.WriteLine("Rotating disk and calling to " + number + "...");
    }
}

class button_phone : disk_phone
{
    public override void Call(string number)
    {
        Console.WriteLine("Pushing buttons and calling to " + number + "...");
    }
}

class black_white_phone : button_phone
{
    public int resolution { get; set; }
}

class colorful_phone : black_white_phone
{
    public long Color_Amounts { get; set; }
}

class smartphone : colorful_phone
{
    public override void Call(string number)
    {
        Console.WriteLine("Touching the screen and calling to " + number + "...");
    }
}



class execute
{
    static void print( smartphone print)
    {
        Console.WriteLine(print.Self_Number);
        Console.WriteLine(print.brand);
        Console.WriteLine(print.resolution);
        Console.WriteLine(print.Color_Amounts);
    }

    static void Main(string[] args)
    {
        smartphone Iphone = new smartphone();

        Iphone.Self_Number = "0967726977";
        Iphone.brand = "Apple";
        Iphone.resolution = 4000;
        Iphone.Color_Amounts = 6000000000;

        print(Iphone);
        Iphone.Call("1024567");
        
    }
}