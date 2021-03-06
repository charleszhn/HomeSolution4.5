﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    class Assemlys
    {
        /*
         * dll与exe区别是exe有入口代码，可以被执行
         * 元数据 
         * 程序集元数据：程序集的基本信息包含{
         * 类型元数据，多少个类，多少个字段}
         * MSIL代码
         * 读取程序集中的类，字段，成员类型成为反射
         * 
         * 读取程序集信息，使用插件，读取插件中内容，内容实现了某个接口，把空间传过去，控件会携带着值
         * 动态加载程序集，获取类中成员
         */

        public void test()
        {
            //description 描述
            Assembly ab = Assembly.LoadFile("");//加载程序集
            ab.GetType();//获取所有类型
            ab.GetExportedTypes();//获取所有的访问修饰符为public 的类型
            var type = ab.GetType("");
            var typec = ab.GetType("");
            type.IsInstanceOfType(type);//判断是不是当前传过来的那种类型，而不是其他的不对应的对象
            bool a = type.IsAssignableFrom(typec);//表示是否可以吧typec赋值给type，type是否继承typec   父类验证
            bool n = type.IsSubclassOf(typec);//type是否是tyopec的子类
            var ss = type.IsAbstract;//获取type类型是否为抽象类，只要不能被实例化就认为是抽象的

            type.GetMethods();//获取程序集中所有方法
            MethodInfo mi = type.GetMethod("方法名");
            object obj = Activator.CreateInstance(type);//创建要传递的参数类型
            object objs = Activator.CreateInstance(type);//创建要调用类的实例构造函数
            mi.Invoke(obj, null);//调用方法

        }
        public void getprivate()
        {
            var niming = new { name = "zhn", age = 18, sex = true };//匿名类型，只读私有
            Assembly aly = Assembly.LoadFile("");
            Type typs = typeof(int);
            MethodInfo mio = typs.GetMethod("", BindingFlags.NonPublic | BindingFlags.Instance);//表示获取一个私有方法
            var s = "sdkk".reg();
        }
    }
}
