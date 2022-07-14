using System;

namespace ClassWork12July
{



    public abstract class Class2
    {
        public virtual void method1()
        {
            Console.WriteLine("Public Virtual Method in abstract class");
        }
        protected virtual void method2()
        {
            Console.WriteLine("Protected Virtual Method in abstract class");
        }
        private virtual void method3()
        {
            //Error No private method in abstact class.
        }

        static void method4()
        {
            Console.WriteLine("Static members in abstract class");
        }
    }

    public class Derived1 : Class2
    {
        public override void method1()
        {
            base.method1();
        }
        protected override void method2()
        {
            base.method2();
        }
    }
    public class Derived2 : Class2
    {
        public override void method1()
        {
            base.method1();
        }
        public override void method2()
        {
            base.method2();
        }
    }

    public abstract class Derived3 : Class2
    {

        public abstract void method10();
        public void method11()
        {
            Console.WriteLine();
        }

    }

    public sealed class Derived4 : Derived3
    {
        public override void method10()
        {

        }
        public override void method1()
        {
            base.method1();
        }
    }

    public class class3
    {
        public abstract void method1();

        public virtual void method2()
        {
            Console.WriteLine("Virtual method in non abstarct class");
        }

    }

    public sealed class seal
    {
        public void method1()
        {

        }
        protected void Method2()
        {

        }

        public virtual void method8()
        {

        }
        //public abstract void method9();

        private void method3()
        {

        }
    }

    public class Class5
    {

        public static int x = 5;
        public Class5()
        {
            Console.WriteLine("i am called");
        }
        static Class5()
        {
            Console.WriteLine("i am Called static");
        }
        public void method()
        {
            Console.WriteLine("method called!");
        }

    }
    public class deriv : Class5
    {
        public void met()
        {

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Class5 c = new Class5();
            deriv d = new deriv();
            Class5 e = new deriv();
            //c = d;
            d.met();
            e.method();
            d.method();
            e.met();
            //d = (deriv)c;
            //deriv f = new Class5();
            Console.WriteLine(Class5.x);
            Console.WriteLine(".................");
            //Class5.method();
            Console.Read();
        }
    }


}
