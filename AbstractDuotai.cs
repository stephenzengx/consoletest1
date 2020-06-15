using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    //get  abstract-override

    /*抽象类和接口的区别
     抽象:是对相同属性和方法的提炼而得
    接口:是对相同行为不同实现方法的提炼
    */

    /*
    1-抽象类是不能被实例化的。
    2-抽象方法只有 无实现(方法体)；
    3-如果一个类包含了抽象方法，那么该类也必须用abstract声明为抽象类。
    
    4-抽象类可以被继承, 派生类如果不实现所继承的抽象类的抽象方法，那么该派生类也要被声明为抽象类
    总结
    abstract-override可以和virtual-override一样地实现多态，包括多层继承也是一样的。
    不同之处：包含虚拟方法的类可以被实例化，而包含抽象方法的类不能被实例化。    

    我们选择使用虚方法实现多态还是抽象类抽象方法实现多态，取决于我们是否需要使用基类实例化的对象.
    */

    public abstract class absAnimal
    {
        public abstract void Eat();

        //
        public void test()
        {
            
        }
    }

    public class Cat1 : absAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eat");
        }
    }

    public class Dog1 : absAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog eat");
        }
    }

    public class WolfDog1 : Dog1
    {
        public override void Eat()
        {
            Console.WriteLine("Wolfdog eat");
        }
    }
}
