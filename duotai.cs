using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    //get 多个类继承同一个类实现继承/多层继承 实现多态 virtual-override
    //里氏替换原则和开放封闭
    class duotai
    {
        public class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("Animal eat");
            }
        }

        public class Cat : Animal
        {
            //public sealed override void Eat() //如果这里的sealed修饰override方法 那么下面的BlackCat无法重写该方法
            public override void Eat()
            {
                Console.WriteLine("Cat eat");
            }
        }

        //多层继承 实现多态
        public class BlackCat : Cat
        {
            public override void Eat() 
            {
                Console.WriteLine("BlackCat eat");
            }
        }

        public class Pig : Animal
        {
            public new void Eat()
            {
                Console.WriteLine("Pig eat");
            }
        }
    }
}
