using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyInterface;
using System.IO;
using System.Reflection;


namespace MyFactory
{
    public class Factory
    {
        public static ICaculatable Create(string oper, int num1, int num2)
        {
            //当前exe所在的文件夹
            string path = AppDomain.CurrentDomain.BaseDirectory;

            path = Path.Combine(path, "Method");

            string[] files = Directory.GetFiles(path, "*.dll");

            foreach (string file in files)
            {
                //加载程序集
                Assembly ass = Assembly.LoadFile(file);

                //获取程序集中所有公共的类型
                Type[] types = ass.GetExportedTypes();

                foreach (Type type in types)
                {
                    //判断type 是否可以接收 t类型的对象
                   if(!type.IsAbstract&&typeof(ICaculatable).IsAssignableFrom(type))
                   {
                       //创建该类型的对象
                       ICaculatable ical = Activator.CreateInstance(type, num1, num2) as ICaculatable;

                       if(oper==ical.Opertation)
                       {
                           return ical;
                       }
                   }
                }
            }

            return null;
        }
    }
}
