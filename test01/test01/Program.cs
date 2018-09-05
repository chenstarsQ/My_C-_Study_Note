using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = mymain1();
            Console.WriteLine("a 的值是{0}",a);
            mymain();
            mymain1();
            fun();
            fun1();
            Console.ReadKey();
            

        }

        static int mymain()
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = a + b;
            Console.WriteLine("c 的值是{0}",c);
            return 0;
            
        }
        static int mymain1()
        {
            int a = 3;
            return a;
        }
        static void fun()
        {
            int a = 100;
            int b = 200;
            int c, d;
            c = a == b ? 10 : 20;
            d = a > b ? 30 : 40;
            Console.WriteLine("c的值是{0}\nd的值是{1}", c, d);
        }
        static void fun1()
        {
            int a, c;
            a = 1;
            //b = ++a;
            c = a++;
            //Console.WriteLine("b的值是{0},c的值是{1}", b,c);
            Console.WriteLine("c的值是{0}", c);
        }

    }
}
