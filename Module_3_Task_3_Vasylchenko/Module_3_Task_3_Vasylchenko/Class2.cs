using System;

namespace Module_3_Task_3_Vasylchenko
{
    public class Class2
    {
        private readonly Class1 _ob1 = new Class1();
        private int _resut;

        public Predicate<int> Calc(Func<int, int, int> z, int x, int y)
        {
            z = _ob1.Pow;
            _resut = z(x, y);
            Predicate<int> delegatResult = Result;
            return delegatResult;
        }

        public bool Result(int x)
        {
            if (x % _resut == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
