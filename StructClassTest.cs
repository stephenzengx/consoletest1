using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    class StructClassTest
    {
        /*结构体和类比较 get 实践理解背诵
         https://www.cnblogs.com/highven/p/3191775.html
         * 
        //语法上
         1-结构体是值类型 内存分配在栈上 作用域内结束后会立刻回收内存
           而类分配生成的对象是引用类型，内存分配在堆上，作用域结束内存由GC管理回收

         2-结构体中的字段不能有默认值,而类可以有

         3-结构体不能显示定义无参构造方法(默认带有隐式构造方法)，而结构体可以显示定义无参构造方法  
         4-结构体定义显示定义有参构造函数必须对所有的字段赋初始值

        //使用上
        结构存储在栈中,栈空间较小,访问速度较快 /堆空间较大,访问速度相对较慢
        用结构体来定义一些轻量级对象
        用类来定义重量级对象.

        如果进行参数传递的时候 希望进行对象的拷贝而不是对象引用的拷贝，那么就可以用结构体
        */
        class Person
        {
            private string name="11";
            /*等价于
            public Person()
            {
                this.name="11";
            }
                 */
            private int age;

            public void SayHi()
            {
                Console.WriteLine("Hello,My Name is " + this.name + ",My Age is " + this.age);
            }
        }

        struct Rectangle
        {
            private int width;//结构体中的字段不能有初始值
            private int height;
            private string name;

            //报错  结构体不能显示定义无参构造方法(默认带有隐式构造方法 并且在隐式构造函数中将值类型 字段 赋值为0，引用类型赋值为null)
            //public Rectangle()
            //{
            //    width = 1;
            //    height = 2;
            //}

            
            //结构体有参构造方法中 必须为所有字段进行初始化操作
            public Rectangle(int width, int height, string name)
            {
                this.width = width;
                this.height = height;
                this.name = name;
            }

            public int _width
            {
                get {
                    return width;
                }

                set {
                    _width = value;
                }

            }

            public int GetArea()
            {
                return this.width * height;
            }
        }
    }
}
