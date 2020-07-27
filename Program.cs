// 处理整数和浮点数

/*
using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // add
            int c = a + b;
            Console.WriteLine(c);

            // sub
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        } 

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);

        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
        }
    }
}
*/


/*
using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // add
            int c = a + b;
            Console.WriteLine(c);

            // sub
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quetient:{d}");
            Console.WriteLine($"quetient:{e}");
        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
        }
    }
}
*/


/*
using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // add
            int c = a + b;
            Console.WriteLine(c);

            // sub
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }
    }
}
*/


/*
using System;
using System.ComponentModel.DataAnnotations;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            int what = max + 3;
            Console.WriteLine($"An example of overflow:{what}");
            // 答案非常接近最小负整数，与min+2相同
        }
    } 
}
*/


/*
// 使用双精度类型
using System;
namespace NumbersInCSharp
{
    class Program
    {
        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

        }
        static void Main(string[] args)
        {
            WorkWithDoubles();
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }
    }
}
*/


// 使用十进制数
/*
using System;
namespace NumbersInCSharp
{
    class Program
    {
        static void WorkWithDecimal()
        {
            double a = 1.0;
            double b = 3.0;
            double c = 1.0 / 3.0;
            Console.WriteLine(c);

            decimal e = 1.0M;       // M后缀表明使用decimal十进制类型
            decimal f = 3.0M;
            Console.WriteLine(e / f);
        }
        static void Main(string[] args)
        {
            WorkWithDecimal();
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }
    }
}
*/


/*
// 编写代码来计算圆面积（其中，半径为 2.50 厘米），请注意，圆面积是用半径的平方乘以 PI 进行计算。 
using System;

namespace CalculatedApplication
{
    class Program
    {
        static void GetArea()
        {
            double r = 2.5;
            double area = Math.PI * r * r;
            Console.WriteLine("半径2.5的圆面积是：{0}", area);
        }
        static void Main(string[] args)
        {
            GetArea();
            
        }
    }
}
*/



