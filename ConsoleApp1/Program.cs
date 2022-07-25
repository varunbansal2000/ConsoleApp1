using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public abstract class animal
    {
        public void sound()
        {
            Console.WriteLine("Hi animal");
        }
        public abstract void  mbo();
        
    }

    public abstract class dog : animal
    {
        public void sound()
        {
            Console.WriteLine("Hi dog");
        }
        public override void mbo()
        {

        }
        public abstract void m();
    }

    public class M3 : dog
    {
        public override void m()
        {
            throw new NotImplementedException();
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //animal a = new animal();
            //a.sound();
            //dog d = new dog();
            //d.sound();
            //animal b = new dog();
            ////b.sound2();
            //b.sound();
            //Console.ReadLine();
            //return;


            int [] cv;
           
            Console.WriteLine("Hello !!!");
            func1();
            Console.WriteLine("Enter Num1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ADD :" + add(x, y));
            Console.WriteLine("SUB : "+ sub(x, y));
            Console.WriteLine("MUL :" +mul(x, y));
            Console.WriteLine("Div : " +div(x, y));
            Console.WriteLine("X^Y :" +pow(x, y));
            Console.WriteLine("X^2 : "+sqr(x));
            Console.WriteLine("X^0.5 :" +sqrroot(x));
            //System.Math

            ques4();
            mathOperations(x);
            Console.ReadLine();
        }

        static void func1()
        {
            string s = "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.";
            int lastIndexofa = s.LastIndexOf('a');
            int lastIndexofe = s.LastIndexOf('e');
            int lastIndexofi = s.LastIndexOf('i');
            int lastIndexofo = s.LastIndexOf('o');
            int lastIndexofu = s.LastIndexOf('u');
            Console.WriteLine(s);
            Console.WriteLine("Last index of a " + lastIndexofa);
            Console.WriteLine("Last index of e " + lastIndexofe);
            Console.WriteLine("Last index of i " + lastIndexofi);
            Console.WriteLine("Last index of o " + lastIndexofo);
            Console.WriteLine("Last index of u " + lastIndexofu);

            int count = 0;
            int a = 0;
            while ((a = s.IndexOf("and", a)) != -1)
            {
                a += 3;
                count++;
            }
            
            Console.WriteLine("occurence of 'and' :" + count);
        }
        static int add(int a, int b)
        {
            return a+ b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static double div(int a, int b)
        {
            if (b == 0)
                return 0;
            return (double)a / b;
        }
        static int pow(int a, int b)
        {
           
            return (int)Math.Pow(a,b);
        }
        static int sqr(int a)
        {
            return a*a;
        }
        static double sqrroot(int a)
        {
            if (a < 0)
                return 0;
            double a2 = (double)a;// Convert.ToDouble(a);

            return Math.Sqrt(a2);
        }
        static void ques4()
        {
            Console.WriteLine("Enter num1 :");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num2 :");
            int y = Convert.ToInt16(Console.ReadLine());

            if (x <= 0 || y <= 0)
                Console.WriteLine("Negative or 0 found!!");
            else
                Console.WriteLine("Positive numbers!");
        }
        static void mathOperations(int a)
        {
            Console.WriteLine("Sin a : " + Math.Sin(a));
            Console.WriteLine("Cos a : " + Math.Cos(a));
            Console.WriteLine("Tan a : " + Math.Tan(a));
            Console.WriteLine("Sinh a : " + Math.Sinh(a));
            Console.WriteLine("log a : " + Math.Log10(a));
        }
    }
}
