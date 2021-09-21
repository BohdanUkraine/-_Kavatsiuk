using System;
using System.Collections.Generic;



public class MagazineIsFullException : Exception
{
    public MagazineIsFullException()
    {
    }
}

public class MagazineIsEmptyException : Exception
{
    public MagazineIsEmptyException()
    {
    }
}

public enum bullet_type{
        FMJ = 1, //Full Metal Jacket
        T = 2, //Tracer
        US = 3 //Under Sonic
    }

public interface Ibullet {
}

public class bullet_fmj : Ibullet{
    bullet_type b = bullet_type.FMJ;
    public int speed = 350;
    public double accuracy = 0.78;
}
public class bullet_t : Ibullet{
    bullet_type b = bullet_type.T;
    public int speed = 310;
    public double accuracy = 0.95;
}
public class bullet_us : Ibullet{
    bullet_type b = bullet_type.US;
    public int speed = 270;
    public double accuracy = 0.6;
}

public class magazine{
    public enum mag_type{
        glock = 9,
        ak = 30
    }
    private int num = 0;
    public magazine(mag_type Magazine){
        num = (int)Magazine;
    }
    public Stack<Ibullet> ammo = new Stack<Ibullet>();
    //private Ibullet[] a = new Ibullet[num];

    public Ibullet Shoot(){
        if(ammo.Count > 0){
            Ibullet tmp = ammo.Peek();
            ammo.Pop();
            return tmp;
        }
        else throw new MagazineIsEmptyException();
    }

    public void Load(Ibullet bullet){
        if(ammo.Count < num){
            ammo.Push(bullet);
            Console.WriteLine("  №=" + ammo.Count.ToString() + "/" + num.ToString());
            }
        else throw new MagazineIsFullException();
    }
}

public class program
{
    static Random rand = new Random();
    public static string calculate_hit(int speed, double accuracy, int distance){
        int hit = rand.Next(101);

        if (8.66*(double)speed < (double)distance)   // 8.66 sec - time for bullet to fall, t*v is travel distance
            return "The target is too far away";

        if (hit > (accuracy-distance/1000)*100)
            return "You missed";
        else 
            return "You got it";
    }
    public static void Main(string[] args)
    {
        String s;
        magazine mag = new magazine(magazine.mag_type.glock);
        Console.Write("Ammo types:\n1)FMJ - regular, fast ang heavy bullet;\n2)T - traced bullet: more accurate, ");
        Console.WriteLine("because you can see the tracer;\n3)US - very quiet and slow bullet;");
        s = Console.ReadLine();
        //Loading 

        foreach(char c in s){
            int b = int.Parse(c.ToString());
            Ibullet tmp = new bullet_us();

            if (b == (int)bullet_type.FMJ) tmp = new bullet_fmj(); else
            if (b == (int)bullet_type.T) tmp = new bullet_t();

            try {
                Console.Write("Loaded " + c + ", ");
                mag.Load(tmp);
            }
            catch (MagazineIsFullException) {
                Console.WriteLine();
                Console.WriteLine("Magazine is full");
                break;
            }
        }

        Console.WriteLine("Enter distance to the target (Recommended 100-300m)");
        int distance = int.Parse(Console.ReadLine());
        Console.WriteLine("loaded, press Enter to shoot");

        while(true){
            Console.Read();

            bullet_fmj fmj = new bullet_fmj();
            bullet_t t = new bullet_t();
            bullet_us us = new bullet_us();

            try {
                Ibullet tmp = mag.Shoot();

                if (Object.ReferenceEquals(tmp.GetType(), fmj.GetType())){
                    Console.WriteLine("BOOM (fmj)");
                    Console.Write(calculate_hit(fmj.speed, fmj.accuracy, distance));
                }

                if (Object.ReferenceEquals(tmp.GetType(), t.GetType())){
                    Console.WriteLine("BOOM (t) ---------------->");
                    Console.Write(calculate_hit(t.speed, t.accuracy, distance));
                }
                if (Object.ReferenceEquals(tmp.GetType(), us.GetType())){
                    Console.WriteLine("PSSST (us)");
                    Console.Write(calculate_hit(us.speed, us.accuracy, distance));
                }
            }
            catch (MagazineIsEmptyException) {
                Console.WriteLine("Magazine is empty");
                break;
            }
        }

        //Console.WriteLine ("Hello Mono World");
    }
}