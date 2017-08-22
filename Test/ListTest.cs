using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void ListDataTest()
        {
            var list = new List<MyClass> {
                new MyClass {Name="张三",Id=23 },
                new MyClass {Name="张三",Id=34 },
            };

            var list2 = new List<dynamic> {
                new  {Name="张三",Id=23 },
                new  {Name="张三",Id=34 },
            };

            var list3 = new List<string>
            {
                "张三张三张三",
                "李四"
            };


            var list4 = new List<int>
            {
                1,
                34
            };

            var intType = typeof(int);

            var type = list3.GetType();
            var gType = type.GenericTypeArguments.FirstOrDefault();
            var gTypes = gType.GetProperties();
        }
    }
}
