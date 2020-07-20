using System;

/*
//打印出 "Hello World" 的简单的代码
namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
         // 我的第一个 C# 程序
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}
*/


/*
//获取任何机器上 int 类型的存储尺寸
namespace DataTypeApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Size of int: {0}", sizeof(int));
         Console.ReadLine();
      }
   }
}
*/


/*
//显式的类型转换
namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
           
        }
    }
}
*/


/*
//把不同值的类型转换为字符串类型
namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
           
        }
    }
}
*/


/*
 //使用各种类型的变量
 namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b ;
            double c;

            //实际初始化
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
*/


/*
 //在程序中定义和使用常量
 public class ConsTest
{ 
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;
        public SampleClass (int p1,int p2)
        {
            x = p1;
            y = p2;
        }

        static void Main()
        {
            SampleClass mC = new SampleClass(11, 22);
            Console.WriteLine("x = {0},y = {1}",mC.x,mC.y);
            Console.WriteLine("c1 = {0},c2 = {1}", SampleClass.c1, SampleClass.c2);
        }
    }
}
*/


/*
//算数运算符
namespace PperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;
            c = a + b;
            Console.WriteLine("Line 1 - c 的值是 {0}", c);
            c = a - b;
            Console.WriteLine("Line 2 - c 的值是 {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            //++a 先进行自增运算再赋值
            c = ++a;
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            //此时 a 的值是22
            //--a 先进行自减运算
            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);
            Console.ReadLine();
        }
    }
}

//++a,a++,--a,a--的区别
namespace OperatorAppl
{
    class Program
    {
        static void Main(string [] args)
        {
            int a = 1;
            int b;

            //a++ 先赋值再自增运算
            b = a++;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            //++a 先进行自增运算再赋值
            a = 1;  //重新初始化a
            b = ++a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            //a-- 先进行赋值再进行自减运算
            a = 1;
            b = a--;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            //--a 先进行自减运算再赋值
            a = 1;  //重新初始化a
            b = --a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();
        }
    }
}
*/


/*
//关系运算符
class Program
{
    static void Main(string[] args)
    {
        int a = 21;
        int b = 10;
        if (a == b)
        {
            Console.WriteLine("Line 1 - a 等于 b");
        }
        else
        {
            Console.WriteLine("Line 1 - a 不等于 b");
        }
        if(a < b)
        {
            Console.WriteLine("Line 2 - a 小于 b");
        }
        else
        {
            Console.WriteLine("Line 2 - a 不小于 b");
        }
        if(a > b)
        {
            Console.WriteLine("Line 3 - a 大于 b");
        }
        else
        {
            Console.WriteLine("Line 3 - a 不大于 b");
        }
        //改变 a 和 b 的值
        a = 5;
        b = 20;
        if(a <= b)
        {
            Console.WriteLine("Line 4 - a 小于或等于 b");
        }
        if(b >= a)
        {
            Console.WriteLine("Line 5 - b 大于或等于 a");
        }
    }
}
*/


/*
//可用的逻辑运算符
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            if(a && b)
            {
                Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - 条件为真");
            }
            //改变 a 和 b 的值
            a = false;
            b = true;
            if(a && b)
            {
                Console.WriteLine("Line 3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if(!(a && b))
            {
                Console.WriteLine("Line 4 - 条件为真");
            }
            Console.ReadLine();
        }
    }
}
*/


/*
//可用的位运算符
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;            // 60 = 0011 1100 
            int b = 13;            // 13 = 0000 1101 
            int c = 0;

            c = a & b;             // 12 = 0000 1100
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            c = a | b;             // 61 = 0011 1101 
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            c = a ^ b;             // 49 = 0011 0001 
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            c = ~a;                // -61 = 1100 0011
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            c = a << 2;            // 240 = 1111 0000 
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            c = a >> 2;            // 15 = 0000 1111 
            Console.WriteLine("Line 6 - c 的值是 {0}", c);
            Console.ReadLine();
        }
    }
}
*/


/*
//可用的赋值运算符
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int c;

            c = a;
            Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
            Console.ReadLine();
        }
    }
}
*/


/*
//其他运算符
namespace OperatorsAppl
{
    class Program
    {  
        static void Main(string[] args)
        {
            //sizeof 运算符的实例
            Console.WriteLine("int 的大小是 {0}", sizeof(int));
            Console.WriteLine("short 的大小是 {0}", sizeof(short));
            Console.WriteLine("double 的大小是 {0}", sizeof(double));

            // 三元运算符的实例
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);
            Console.ReadLine();
        }
    }
}
*/


/*
//运算符优先级
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int c = 15;
            int d = 5;
            int e;
            e = (a + b) * c / d;     // ( 30 * 15 ) / 5
            Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

            e = ((a + b) * c) / d;   // (30 * 15 ) / 5
            Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

            e = (a + b) * (c / d);   // (30) * (15/5)
            Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

            e = a + (b * c) / d;    //  20 + (150/5)
            Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
            Console.ReadLine();
        }
    }
}
*/


/*
//无限循环
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Hey! I am Trapped");
            }
        }
    }
}
*/


/*
//Public 访问修饰符
namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }// Rectangle 结束

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
*/



/*
//Private 访问修饰符
namespace RectangleApplication
{
    class Rectangle
{
    //成员变量
    private double length;
    private double width;

    public void Acceptdetails()
    {
        Console.WriteLine("请输入长度：");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入宽度：");
        width = Convert.ToDouble(Console.ReadLine());
    }
    public double GetArea()
    {
        return length * width;
    }
    public void Display()
    {
        Console.WriteLine("长度： {0}", length);
        Console.WriteLine("宽度： {0}", width);
        Console.WriteLine("面积： {0}", GetArea());
    }
}//end class Rectangle    
class ExecuteRectangle
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Acceptdetails();
        r.Display();
        Console.ReadLine();
    }
}
}
*/


/*
//Internal 访问修饰符
namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        internal double length;
        internal double width;

        double GetArea()    //没有指定访问修饰符，使用类成员的默认访问修饰符即 private
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle    
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
*/


/*
//使用方法名调用方法
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            //局部变量声明 
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        static void Main(string[] args)
        {
            //局部变量定义
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //调用 FindMax 方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}", ret);
            Console.ReadLine();
        }
    }
}
*/


/*
//使用类从另一个类中调用其他类
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            // 局部变量声明 
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            // 局部变量定义
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //调用 FindMax 方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}", ret);
            Console.ReadLine();
        }
    }
}
*/


/*
//使用递归函数计算一个数的阶乘
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            //局部变量定义
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //调用factorial
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
            Console.ReadLine();
        }
    }
}
*/


/*
//按值传递参数
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(int x,int y)
        {
            int temp;

            temp = x;   //保存 x 的值
            x = y;      //把 y 赋值给 x
            y = temp;   //把 temp 赋值给 y
        }
        
        static  void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //局部变量定义
            int a = 100;
            int b = 200;
            Console.WriteLine("在交换之前，a 的值：{0}", a);
            Console.WriteLine("在交换之前，b 的值：{0}", b);

            //调用函数来交换值
            n.swap(a, b);

            Console.WriteLine("在交换之后，a 的值：{0}", a);
            Console.WriteLine("在交换之后，b 的值：{0}", b);

            Console.ReadLine();
        }
    }
}
*/

/*
//按引用传递参数
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;   // 保存 x 的值 
            x = y;      // 把 y 赋值给 x 
            y = temp;   //把 temp 赋值给 y 
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //局部变量定义 
            int a = 100;
            int b = 200;

            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            //调用函数来交换值 
            n.swap(ref a, ref b);

            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            Console.ReadLine();

        }
    }
}
*/


/*
//按输出传递参数
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;

            Console.WriteLine("在方法调用前，a的值：{0}", a);

            n.getValue(out a);
            Console.WriteLine("在方法调用后，a的值：{0}", a);
            Console.ReadLine();

        }
    }
}


//从一个参数没有指定初始值的方法中返回值
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            // 局部变量定义
            int a, b;

            // 调用函数来获取值 
            n.getValues(out a, out b);

            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            Console.WriteLine("在方法调用之后，b 的值： {0}", b);
            Console.ReadLine();
        }
    }
}
*/


/*
//可空数据类型
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // 显示值

            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);
            Console.ReadLine();

        }
    }
}
*/


/*
//Null 合并运算符
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();
        }
    }
}
*/



/*
/*
//访问数组元素
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; //是一个带有 10 个整数的数组
            int i, j;


            // 初始化数组 n 中的元素
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            // 输出每个数组元素的值
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }
    }
}
*/


/*
//使用 foreach 循环
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; // 是一个带有 10 个整数的数组 


            //初始化数组 n 中的元素 
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            // 输出每个数组元素的值
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }
    }
}
*/


/*
//创建 String 对象
namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",
            waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.ReadKey();
        }
    }
}
*/


/*
//比较字符串
namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();
        }
    }
}
*/


/*
//字符串包含字符串
namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string str = "This is test";
            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();
        }
    }
}
*/


/*
//获取子字符串
namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();
        }
    }
}
*/


/*
//连接字符串
namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string[] starray = new string[]{"Down the way nights are dark","And the sun shines daily on the mountain top",
          "I took a trip on a sailing ship","And when I reached Jamaica","I made a stop"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
*/


/*
//定义结构体
using System.Text;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {

        Books Book1;        // 声明 Book1，类型为 Books
        Books Book2;        // 声明 Book2，类型为 Books

        // book 1 详述
        Book1.title = "C Programming";
        Book1.author = "Nuha Ali";
        Book1.subject = "C Programming Tutorial";
        Book1.book_id = 6495407;

        // book 2 详述 
        Book2.title = "Telecom Billing";
        Book2.author = "Zara Ali";
        Book2.subject = "Telecom Billing Tutorial";
        Book2.book_id = 6495700;

        // 打印 Book1 信息 
        Console.WriteLine("Book 1 title : {0}", Book1.title);
        Console.WriteLine("Book 1 author : {0}", Book1.author);
        Console.WriteLine("Book 1 subject : {0}", Book1.subject);
        Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

        // 打印 Book2 信息 
        Console.WriteLine("Book 2 title : {0}", Book2.title);
        Console.WriteLine("Book 2 author : {0}", Book2.author);
        Console.WriteLine("Book 2 subject : {0}", Book2.subject);
        Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

        Console.ReadKey();

    }
}
*/


/*
//枚举变量
public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
*/


/*
//类
namespace BoxApplication
{
    class Box
    {
        public double length;   // 长度
        public double breadth;  // 宽度
        public double height;   // 高度
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();        // 声明 Box2，类型为 Box
            double volume = 0.0;         // 体积

            // Box1 详述
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // Box2 详述
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            // Box1 的体积
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2 的体积： {0}", volume);
            Console.ReadKey();
        }
    }
}
*/


/*
//设置和获取一个类中不同的类成员的值
namespace BoxApplication
{
    class Box
    {
        private double length;      // 长度
        private double breadth;     // 宽度
        private double height;      // 高度
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();       // 声明 Box1，类型为 Box
            Box Box2 = new Box();       // 声明 Box2，类型为 Box
            double volume;              // 体积


            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);

            Console.ReadKey();
        }
    }
}
*/


/*
//构造函数
namespace LineApplication
{
    class Line
    {
        private double length;      // 线条的长度
        public Line()
        {
            Console.WriteLine("对象已创建");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
*/


/*
//参数化构造函数
namespace LineApplication
{
    class Line
    {
        private double length;   // 线条的长度
        public Line(double len)  // 参数化构造函数
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line(10.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
*/


/*
//析构函数
namespace LineApplication
{
    class Line
    {
        private double length;      // 线条的长度
        public Line()               // 构造函数
        {
            Console.WriteLine("对象已创建");
        }
        ~Line() //析构函数
        {
            Console.WriteLine("对象已删除");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
        }
    }
}
*/


/*
//静态变量
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
*/


/*
//静态函数
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("变量 num： {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
*/