using System;

namespace Module_3_Task_3_Vasylchenko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new Class1();
            var b = new Class2();
            a.ShowHelder = Show;
            a.ShowHelder(b.Calc(a.PowDelegat, 2, 3).Invoke(2));
        }

        public static void Show(bool b)
        {
            Console.WriteLine(b);
        }
    }
}
