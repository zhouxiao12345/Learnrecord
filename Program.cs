// 异常处理
/*
// 当除以零时抛出异常的实例
using System;
namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:{0}", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
*/


/*
// 自定义异常
using System;
namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException:{0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
public class TempIsZeroException: ApplicationException
{
    public TempIsZeroException(string message): base(message)
    {

    }
}
public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature:{0}", temperature);
        }
    }
}
*/


/*
// File Stream类的用法
using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte) i);
            }
            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
*/


/*
// 文本文件的读写
using System;
using System.IO;

namespace FileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader("F:/readme.txt"))
                {
                    string line;

                    // 从文件读取并显示，直到文件的末尾
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
*/


/*
// 使用 StreamWriter 类向文件写入文本数据
using System;
using System.IO;

namespace FileApplication
{
    class program
    {
        static void Main(string[] agrs)
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // 文件中读取并显示每行
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
       
        }
    }
}
*/


/*
// 二进制文件的读写
using System;
using System.IO;

namespace BinaryFileApplication
{
    class program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            // 创建文件
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            // 写入文件
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file");
                return;
            }
            bw.Close();
            // 读取文件
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data:{0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data:{0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data:{0}", b);
                s = br.ReadString();
                Console.WriteLine("String data:{0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
*/

/*
// Windows 文件系统的操作
using System;
using System.IO;

namespace WindowsFileApplication
{
    class program
    {
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            DirectoryInfo mydir = new DirectoryInfo(@"c:\windows");

            // 获取目录中的文件及它们的名称和大小
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name:{0} Size: {1}", file.Name, file.Length);
            }
            Console.ReadKey();
        }
    }
}
*/



// //// 特性
/*
// Conditional
#define DEBUG
using System;
using System.Diagnostics;

public class Myclass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}
class Test
{
    static void function1()
    {
        Myclass.Message("In Function 1.");
        function2();
    }
    static void function2()
    {
        Myclass.Message("In Function 2.");
    }
    public static void Main()
    {
        Myclass.Message("In Main function.");
        function1();
        Console.ReadKey();
    }

}
*/


/*
// Obsolete
using System;
public class Myclass
{
    [Obsolete("Don't use OldMethod, use NewMethod instead.", true)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method.");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method.");
    }
    public static void Main()
    {
        OldMethod();            // 报错？？？？
    }
}
*/

/*
// 构建自定义特性
// 一个自定义特性 BugFix 被赋给类及其成员        
using System;
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property, AllowMultiple = true)]

public class DeBugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DeBugInfo(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developer = dev;
        this.lastReview = d;
    }
    public int BugNo
    {
        get
        {
            return bugNo;
        }
    }
    public string Developer
    {
        get
        {
            return developer;
        }
    }
    public string LastReview
    {
        get
        {
            return lastReview;
        }
    }
    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}
// 报错：错误 CS5001  程序不包含适合于入口点的静态 "Main" 方法 project4
*/


/*
// 应用自定义特性

[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
class Rectangle
{
    // 成员变量
    protected double length;
    protected double width;
    public Rectangle(double l,double w)
    {
        length = l;
        width = w;
    }
    [DeBugInfo(55, "Zara Ali", "19/10/2012",Message = "Return type mismatch")]
    public double GetArea()
    {
        return length * width;
    }
    [DeBugInfo(56, "Zara Ali", "19/10/2012")]
    public void Display()
    {
        Console.WriteLine("Length:{0}", length);
        Console.WriteLine("width:{0}", width);
        Console.WriteLine("Area:{0}", GetArea());
    }
}
*/


/*
// 反射
using System;
[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
    public readonly String Url;
    public string Topic  // Topic 是一个命名（named）参数
    {
        get
        {
            return topic;
        }
        set
        {
            topic = value;
        }
    }

    public HelpAttribute(string url)        // url 是一个定位（positional）参数
    {
        this.Url = url;
    }
    private string topic;
}
[HelpAttribute("Information on the class MyClass")]
class MyClass
{

}

namespace AttributeAppl
{
    class program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}
*/


/*
// 使用反射（Reflection）来读取 Rectangle 类中的元数据
using System;
using System.Reflection;
namespace BugFixApplication
{
    // 一个自定义特性 BugFix 被赋给类及其成员
    [AttributeUsage(AttributeTargets.Class |
     AttributeTargets.Constructor |
     AttributeTargets.Method |
     AttributeTargets.Property,
     AllowMultiple = true)]

    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string l)
        {
            bugNo = bg;
            developer = dev;
            lastReview = l;
        }
        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
    [DeBugInfo(45, "Jack", "16/7/2020", Message = "Return type mismatch")]
    [DeBugInfo(49, "Alic", "19/7/2020", Message = "Unused variable")]
    class Rectangle
    {
        // 成员变量
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        [DeBugInfo(55, "Jack", "23/7/2020", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Alic", "23/7/2020")]
        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", GetArea());
        }
    }   // end class rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);
            // 遍历 rectangle 类的特性
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no:{0}", dbi.BugNo);
                    Console.WriteLine("Developer:{0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed:{0}", dbi.LastReview);
                    Console.WriteLine("Remarks:{0}", dbi.Message);
                }
            }

            // 遍历方法特性
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach(Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi = (DeBugInfo)a;
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no:{0}, for Method:{1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer:{0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed:{0}", dbi.LastReview);
                        Console.WriteLine("Remarks:{0}", dbi.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
*/



// 属性
/*
// 属性（Property）--完整代码
using System;
namespace runoob
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // 声明类型为 string 的 code 属性
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // 声明类型为 string 的 name 属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // 声明类型为 int 的 age属性
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code =" + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class Example
    {
        public static void Main()
        {
            // 创建一个新的 student 对象
            Student s = new Student();

            // 设置 student 的 code、name和age
            s.Code = "001";
            s.Name = "Alic";
            s.Age = 8;
            Console.WriteLine("Student Info:{0}", s);
            // 增加年龄
            s.Age += 1;
            Console.WriteLine("Student Info:{0}", s); 
            Console.ReadKey();
        }
    }
}
*/


/*
// 抽象属性--简化版
using System;
using System.Net.Cache;

namespace runoob
{
    class program
    {
        public abstract class Person
        {
            public abstract string Name { get; set; }
            public abstract int Age { get; set; }
        }
        public class Student : Person
        {
            public string Code { get; set; } = "N.A";
            public override string Name { get; set; } = "N.A";
            public override int Age { get; set; } = 0;
            public override string ToString()
            {
                return $"Code:{Code}, Name:{Name}, Age:{Age}";
            }
        }
         
        static void Main(string[] args)
        {
            var s = new Student(){ Code = "001", Name = "Alic", Age = 8 };
            System.Console.WriteLine($"Student Info:={s}");

            s.Age++;
            System.Console.WriteLine($"Student Info:={s}");
        }
    }
}
*/


// 索引器（Indexer）
// 1.类成员变量是数组的情况
/*
using System;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 8;
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N.A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size-1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size -1)
                {
                    namelist[index] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
*/

/*
// 2.类成员变量是多个基本类型
using System;

namespace IndexerApplication
{
    class Employee
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string this [string index]
        {
            set
            {
                switch(index)
                {
                    case "a":firstName = value;
                        break;
                    case "b":middleName = value;
                        break;
                    case "c":lastName = value;
                        break;
                    default:throw new ArgumentOutOfRangeException("index");

                }
            }
            get
            {
                switch(index)
                {
                    case "a":return firstName;
                    case "b":return middleName;
                    case "c":return lastName;
                    default:throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        static void Main(string[] args)
        {
            Employee em = new Employee();
            em.firstName = "胡";
            em.middleName = "一";
            em.lastName = "统";

            Console.WriteLine("我的名字叫：{0}{1}{2}", em["a"], em["b"], em["c"]);
        }
    }
}
*/


// 重载索引器（Indexer）
/*
// 
using System;
using System.Drawing;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N.A.";
            }
        }
        public string this [int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size-1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if(index >= 0 && index <= size-1)
                {
                    namelist[index] = value;
                }
            }
        }
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if(namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            // 使用带有int参数的第一个索引器
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);

            }
            // 使用带有string参数的第二个索引器
            Console.WriteLine(names["Nuha"]);
            Console.ReadKey();
        }
    }
}
*/


// 委托
/*
// 演示委托的声明、实例化和使用，该委托可用于引用带有一个整型参数的方法，并返回一个整型值。
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static  int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            // 创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            // 使用委托对象调用方法
            nc1(25);
            Console.WriteLine("Value of Num:{0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num:{0}", getNum());
            Console.ReadKey();
        }
    }
}
*/


/*
// 委托的多播
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return q;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            // 创建委托实例
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;
            // 调用多播
            nc(5);
            Console.WriteLine("Value of Num:{0}", getNum());
            Console.ReadKey();
        }
    }
}
*/


// 使用这委托调用两个方法，第一个把字符串打印到控制台，第二个把字符串打印到文件
using System;
using System.IO;
using System.Security.Cryptography;

namespace DelegateAppl
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;
        // 委托声明
        public delegate void printString(string s);
         
        // 该方法打印到控制台
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is:{0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("F:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }
        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}