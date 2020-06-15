using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    //get 面试需要背...

    /*C# 抽象类和接口的区别 https://www.cnblogs.com/wphl-27/p/7124334.html
     相同点：
     1. 都不能直接实例化，都可以通过继承实现其方法
     2. 接口和抽象类 都不能密封 或者静态  (不能用 sealed,static 修饰)
     3.都不能使用new 生成实例

     3. 都是面向抽象编程的技术基础，实现了诸多的设计模式?? to do?
     不同点:
     1- 一个类只能继承1个抽象类，但可以实现多个接口(C# 不支持多继承)
     2-一个类继承抽象类可以不实现它的抽象方法 只需要在定义为抽象类就可以了
        但是一个类实现了接口 就必须实现接口的所有方法

     3-接口中的所有成员不带访问修饰符，隐式规定为public. 而抽象类中的可以带访问修饰符
     4- 接口只能包含 方法，属性(本质上就是一个方法包含 get set)，索引器，事件的签名四种成员类型，
        接口不能包含实例字段和已经实现的方法 / 
        
        而 抽象方法中除了以上4种， 字段，已经实现的方法/ 构造函数， 析构函数，静态成员，常量.

        事件 event to odo....

    5-接口可以用于支持回调；抽象类不能实现回调，因为继承不支持 ？？？回调 是什么意思？
    */
    public class AbsInterface
    {
        public abstract class absAnimal
        {
            int a = 0;
            public abstract void Eat();
            private void test()
            {

            }
           

            int this[string day]
            {
                get {
                    return 1;
                }
            }

            
        }

        public interface IEat
        {
            //int a; 字段
            //属性
           int Num {get;set;}
            //接口中的方法在8以下 不能用 public abstract static 修饰
           void Eat1();

            int this[string day] { get; } //不能有默认实现
        }

    }
}
