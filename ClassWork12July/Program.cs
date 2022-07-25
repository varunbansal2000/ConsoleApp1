using System;

namespace ClassWork12July
{


//ques1
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
  //ques 3
        static void method4()
        {
            Console.WriteLine("Static members in abstract class");
        }
    }
  //ques 2
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
        protected override void method1()
        {
            base.method1();
        }
        public override void method2()
        {
            base.method2();
        }
    }
//ques 4 and 11
    public abstract class Derived3 : Class2
    {
        static Derived3()
        {

        }
        public static void methoddd()
        {

        }
        public abstract void method10();
        public void method11()
        {
            Console.WriteLine();
        }

    }
    //ques 12
    public sealed class Derived4 : Derived3
    {
        static Derived4()
        {

        }
        public static void methodddd()
        {

        }
        public override void method10()
        {

        }
        public override void method1()
        {
            base.method1();
        }
    }
//ques 5
    public class class3
    {
        public abstract void method1();

        public virtual void method2()
        {
            Console.WriteLine("Virtual method in non abstarct class");
        }

    }
//ques 7 and 8 and 9
    public  sealed class seal : class3
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
        public abstract void method9();

        private void method3()
        {

        }
    }


  //ques 10

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
            c = d;
            d.met();
            e.method();
            d.method();
            e.met();
            d = (deriv)c;
            //deriv f = new Class5();
            Console.WriteLine(Class5.x);
            Console.WriteLine(".................");
            //Class5.method();
            Console.Read();
        }
    }


}



//1)Can we have Private and Protectd virtual methods in Abstract class?
//Ans: Protected methods in abstract class -yes
//     Private methods in abstract class -No Private virtual and abstract methods
//    We unable to use that method anywhere.

//2)If Yes, then with which access specifier should we use to overrride these method from derived class?
//Ans : Protected(Same access specifier in derived class as that of base class)

//3)Can we have static members in abstract class?
//Ans: Yes(static not work on instance of class)

//4)Can the derived class be an abstract class?
//Ans: yes

//5)Can we have abstract and virtual methods in non -abstract class?
//Ans: abstract -No

//    Virtual - Yes
//6) Can we type-cast the derive class instance to base class?
//Ans:yes.

//7)Can sealed class contain Protected methods?
//Ans: Yes no error but it gives warning as we unable to inherit it.

//8) Can we have virtual or abtsract methods in sealed class?
//Ans: No

//9) Can the sealed class be a derived class?
//Ans : Yes

//10) Can we have static Constructors in a class and if yes then how many times they are called and what will be the use of it?
//Ans: Yes, It is called only once before first instance or static memeber, used to intialize any static data.

//11) Can we have static constructor and methods in Abstract class?
//Ans: Yes

//12)Can we have static constructor and methods in sealed class?
//Ans: Yes











