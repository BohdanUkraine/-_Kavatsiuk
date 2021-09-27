using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems__1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double I, U, R, l, T, R1, R2, R3, S, h, V, a, t, v, V1, t1, V2, t2, P, x;


            //Problem 1.1
            /*
            Console.Write("Довжина маятника l = ");
            l=Double.Parse(Console.ReadLine());
            T = 2 * Math.PI * Math.Sqrt(l/9.8);
            Console.WriteLine(String.Format("Перiод коливань Т = {0:0.00}c", T));
            Console.ReadLine();
            */


            //Problem 1.2
            /*
            Console.Write("Введiть напругу U = ");
            U = Double.Parse(Console.ReadLine());
            Console.Write("Введiть опiр R = ");
            R = Double.Parse(Console.ReadLine());
            I = U / R;
            Console.WriteLine(String.Format("Сила струму I = {0:0.00}А", I));
            Console.ReadLine();
            */


            //Problem 1.3
            /*
            Console.Write("Введiть напругу U = ");
            U = Double.Parse(Console.ReadLine());
            Console.Write("Введiть cилy струму I = ");
            I = Double.Parse(Console.ReadLine());
            R = U / I;
            Console.WriteLine(String.Format("Oпiр R = {0:0.00}Oм", R));
            Console.ReadLine();
            */


            //Problem 1.4
            /*
            Console.Write("Введiть опiр першого провiдника R1 = ");
            R1 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть опiр другого провiдника R2 = ");
            R2 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть опiр третього провiдника R3 = ");
            R3 = Double.Parse(Console.ReadLine());
            R = R1 + R2 + R3;
            Console.WriteLine(String.Format("Загальний опiр R = {0:0.00}Oм", R));
            Console.ReadLine();
            */


            //Problem 1.5
            /*
            Console.Write("Введiть опiр першого провiдника R1 = ");
            R1 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть опiр другого провiдника R2 = ");
            R2 = Double.Parse(Console.ReadLine());
            R = 1 / (1 / R1 + 1 / R2);
            Console.WriteLine(String.Format("Загальний опiр R = {0:0.00}Oм", R));
            Console.ReadLine();
            */


            //Problem 1.6
            /*
            Console.Write("Введiть висоту цилiндра h = ");
            h = Double.Parse(Console.ReadLine());
            Console.Write("Введiть радiус основи цилiндра R = ");
            R = Double.Parse(Console.ReadLine());
            V = Math.PI * Math.Pow(R, 2) * h;
            Console.WriteLine(String.Format("Об'єм цилiндра V = {0:0.00}куб.од.", V));
            Console.ReadLine();
            */


            //Problem 1.7
            /*
            Console.Write("Введiть висоту конуса h = ");
            h = Double.Parse(Console.ReadLine());
            Console.Write("Введiть радiус основи конуса R = ");
            R = Double.Parse(Console.ReadLine());
            V = (Math.PI * Math.Pow(R, 2) * h) / 3;
            Console.WriteLine(String.Format("Об'єм конуса V = {0:0.00}куб.од.", V));
            Console.ReadLine();
            */


            //Problem 1.8
            /*
            Console.Write("Введiть радiус кулi R = ");
            R = Double.Parse(Console.ReadLine());
            S = Math.PI * Math.Pow(R, 2) * 4;
            V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine(String.Format("Об'єм кулi V = {0:0.00}куб.од., \nПлоща поверхнi кулi S = {1:0.00}кв.од.", V, S));
            Console.ReadLine();
            */


            //Problem 1.9
            /*
            Console.Write("Введiть прискорення a = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Введiть час t = ");
            t = Double.Parse(Console.ReadLine());
            S = (a * Math.Pow(t, 2)) / 2;
            Console.WriteLine(String.Format("Вiдстань, яку пробiг бiгун S = {0:0.00}м.", S));
            Console.ReadLine();
            */


            //Problem 1.10
            /*
            Console.Write("Введiть висоту h = ");
            h = Double.Parse(Console.ReadLine());
            Console.Write("Введiть початкову швидксть v = ");
            v = Double.Parse(Console.ReadLine());
            V = Math.Pow(v, 2) + 19.6 * h;
            t = (Math.Sqrt(V) - v) / 9.8;
            Console.WriteLine(String.Format("Час падiння предмету = {0:0.00}с.", t));
            Console.ReadLine();
            */


            //Problem 1.11
            /*
            Console.Write("Введiть кiлькiсть секунд с = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0}год, {1}хв, {2}с", c/3600, (c % 3600)/60, (c % 3600) % 60));
            Console.ReadLine();
            */


            //Problem 1.12
            /*
            Console.Write("Введiть oб'єм V1 = ");
            V1 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть температуру t1 = ");
            t1 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть oб'єм V2 = ");
            V2 = Double.Parse(Console.ReadLine());
            Console.Write("Введiть температуру t2 = ");
            t2 = Double.Parse(Console.ReadLine());
            t = (V1 * t1 + V2 * t2) / (V1 + V2);
            Console.WriteLine(String.Format("Температуру сумiшi = {0:0.00}°C.", t));
            Console.ReadLine();
            */


            //Problem 1.13
            /*
            Console.Write("Введiть радiус кoлa R = ");
            R = Double.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть кутiв n = ");
            n = int.Parse(Console.ReadLine());
            P = 2 * n * R * Math.Tan((180 / n) * (Math.PI / 180));
            Console.WriteLine(String.Format("Периметр многокутника Р = {0:0.00}м.", P));
            Console.ReadLine();
            */


            //Problem 1.14



            //Problem 1.15
            /*
            Console.Write("Введiть x = ");
            x = Double.Parse(Console.ReadLine());
            R = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 5 * x + 6;
            Console.WriteLine(String.Format("2x^4-3x^3+4x^2-5x+6 = {0:0.00}", R));
            Console.ReadLine();
            */


            //Problem 2.8
            /*
            int s,s1;
            double res = 0;
            Console.Write("Введiть nn = ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Введiть nk = ");
            s1 = int.Parse(Console.ReadLine());
            for (int i=s; i<=s1; i++)
            {
                res += (Math.Pow(i, 2) - 3) / (Math.Pow(i, 2) - Math.Pow(-1, i) * i + 3);
            }
            Console.WriteLine(String.Format("{0:0.00}", s));
            Console.ReadLine();
            */


            //Problem 3.8
            /*
            int s,s1,s2;
            bool ch = true;
            Console.Write("Введiть n1 = ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Введiть n2 = ");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("Введiть n3 = ");
            s2 = int.Parse(Console.ReadLine());

            ch = (s + s1 == 0 ? true : false) || (s2 + s1 == 0 ? true : false) || (s + s2 == 0 ? true : false);

            Console.WriteLine(ch);
            Console.ReadLine();
            */


            //Problem 4.8
            /*
            int s, tmp;
            int[] a1 = new int[999];
            Console.Write("Введiть к-сть елементiв: ");
            s = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                Console.Write(String.Format("a[{0}] = ", i));
                a1[i] = int.Parse(Console.ReadLine());
            }

            int max = a1[0], min = a1[0], maxi = 0, mini = 0;

            for (int i = 0; i < s; i++)
            {
                if (a1[i] > max) { max = a1[i]; maxi = i; }

                if (a1[i] <= min) { min = a1[i]; mini = i; }
            }

            if (maxi < mini)
            {
                tmp = maxi; maxi = mini; mini = tmp;
            }

            int yyy = ((maxi + mini) / 2);

            for (int i = mini; i <= yyy; i++)
            {
                tmp = a1[i]; a1[i] = a1[maxi - (i - mini)]; a1[maxi - (i - mini)] = tmp;
            }

            for (int i = 0; i < s; i++)
            {
                Console.Write(a1[i] + " ");
            }

            Console.ReadLine();
            */


        }
    }
}
