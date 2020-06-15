using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static ConsoleClientApp.AbsInterface;
using static ConsoleClientApp.duotai;


/*
    using 的三种用法
    (一).作为指令，用于为命名空间创建别名或导入其他命名空间中定义的类型。
    using MyDOtai = ConsoleClientApp.duotai;
    
    (二).作为语句，用于定义一个范围，在此范围的末尾将释放对象。
    //数据连接，开启事务，文件打开
    using(Db1 db = new Db1)
    {
    }
*/

namespace ConsoleClientApp
{
    //1-new 方法的作用
    /*
     1-调用构造方法 创建实例
     2-在用作修饰符时，new 关键字可以显式隐藏从基类继承的成员。
     3-用于在泛型声明中约束可能用作类型参数的参数的类型。
     */
    class Program
    {
        //new 的第三种用法  泛型参数T必须是有公共的无参构造方法
        public class TestNew3<T> //where T : new()
        {
            //public T GetItem()
            //{
            //    return new T(); //where T : new() 没有new 约束的话 无法创建泛型实例类型
            //}
        }

        public class TestNew4<T> where T : new()
        {
            public T GetItem()
            {
                return new T(); 
            }
        }

        abstract public class contact
        {
            public virtual void prinf()
            {
                Console.WriteLine("contact 虚方法");
            }

            public void print1()
            {
                Console.WriteLine("contact  print1方法");
            }
        }
        public class class1 : contact
        {
            //private class1()
            //{ 
            
            //}
            public override void prinf()
            {
                Console.WriteLine("class1 print方法");
            }

            public void print1()
            {
                Console.WriteLine("class1 虚方法");
            }
        }
        public class class2 : contact
        {
            //new 关键字在作为修饰符用于向基类成员隐藏继承成员时，
            //对于派生类该关键字指示方法是重写的新方法，但是关闭了多态性。具体调用的方法为声明时变量的方法。
            public new void prinf()
            {
                //base.prinf();
                Console.WriteLine("class2 print方法");
            }
        }

        //测试多态
        public static void testDuotai()
        {
            Animal ai = new Animal();
            ai.Eat();
            ai = new Cat();
            ai.Eat();

            ai = new BlackCat();
            ai.Eat();

            ai = new Pig();
            ai.Eat(); // Pig中的Eat 方法用了new修饰 破坏了多态性

            //using MyDOtai = ConsoleClientApp.duotai; using的用法 对引用的命名空间进行重命名
            //MyDOtai.Animal ai = new MyDOtai.Animal();
        }

        static void Main(string[] args)
        {
            //1-new 方法的作用
            /*
             1- 调用构造方法 创建实例
             2-在用作修饰符时，new 关键字可以显式隐藏从基类继承的成员。
             3-用于在泛型声明中约束可能用作类型参数的参数的类型。
             */


            /*contact 为申明类  class1为实例类
             当调用一个对象的函数时，系统会直接去检查这个对象申明定义的类，即申明类，看所调用的函数是否为虚函数；
             如果不是虚函数，那么它就直接执行该函数。而如果有virtual关键字，也就是一个虚函数，那么这个时候它就不会立刻执行该函数了，
             而是转去检查对象的实例类。
             contact中print方法为虚方法，所以不会执行 而是去执行class1中的print方法
             */
            contact ct1 = new class1();
            ct1.prinf();
            ct1.print1(); //但是contact 中的print1就没有定义为虚方法 所以就会直接调用 contact print1

            class2 cls2 = new class2();
            cls2.prinf();

            //虽然 contact中printf 为虚方法，按照上面的理解 按理是说执行class2 中的 print方法
            //但是！！由于 class2中的printf 用new修饰了 所以等同于class2重新定义了一个printf方法 和父类的printf没有任何联系了
            //(也就是我们说的隐藏了 父类的方法，准确来说 子类中用new 修饰和父类同名同签名的方法 会破坏多态性
            contact ct2 = cls2;    
            ct2.prinf();


            //1-泛型T有new约束  class1虽然未定义无参构造函数，但是类默认都有无参构造方法(隐式构造函数)，
            //如果显示把无参构造方法定义为private，则会报错
               //泛型参数中的T 不能为抽象类,接口
            TestNew4<class1> tn4 = new TestNew4<class1>();
            //2-无泛型约束 T泛型可以放抽象类和接口
            TestNew3<absAnimal> tn31 = new TestNew3<absAnimal>();
            TestNew3<IEat> tn32 = new TestNew3<IEat>();


            string[] a = new string[4];
            List<string> a1 = a.ToList();
            //List<string> a2 = a as List<string>; 无法进行拆箱装箱操作 

            //2-多态：通过继承实现的不同对象调用相同的方法，表现出不同的行为，称之为多态。 virtual 和 Override
            testDuotai();

            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
