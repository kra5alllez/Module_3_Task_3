using System;

namespace Module_3_Task_3_Vasylchenko
{
    public class Class1
    {
        public Class1()
        {
            PowDelegat = Pow;
        }

        public Action<bool> ShowHelder { get; set; }

        public Func<int, int, int> PowDelegat { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
