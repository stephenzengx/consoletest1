﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    /*
     学习 C#的static 关键字

     static关键字主要用于修饰类 字段 方法 属性 运算符 事件 构造函数(静态代码块)
     static关键字不可修饰 索引器 或类以外的类型

     1-静态类中只能还有静态方法
     2- 静态方法和非静态方法区别 一个通过类名调用一个通过对象调用 但是在内存中都是只有一份
     3-静态成员在系统第一次调用时，进行初始化 分配内存 且内存会一直存放知道程序关闭 / 非静态成员在实例化时才会有内存空间
    -------------------------------
    4.静态修饰符应用场景
    4.1 静态变量的应用场景，例 系统登陆用户总数 系统配置信息 系统设置
    4.2 静态类及方法应用场景: 如果一个方法的功能为 输入变量的操作，
    如类中其它变量并无关联，则建议此类设置为静态类(例 字符串分隔方法 两个输入变量的比较)
    */
    class StaticTest
    {
    }
}
