using System;
using NUnit.Framework;
using TestGenerator;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        public void Test1()
        {
            string input = @"
            using System;

            namespace AoAoAo
            {
                public class OaOaOa
                {

                }
            }
            ";
            TestElement[] elements = TestGenerator.TestGenerator.GenerateTests(input);
            //Console.WriteLine(elements[0].TestName);
            Assert.AreEqual("OaOaOaTest", elements[0].TestName);
        }
        [Test]
        public void Test2()
        {
            string input = @"
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

            namespace TestProject
            {
                public class AnotherTestClass
                {
                    public int returnInt()
                    {
                        return 1;
                    }
                    public double returnDouble()
                    {
                        return 2.0;
                    }
                    public string returnString()
                    {
                        return " + "\"" + "asdasdasdasd" + "\"" + @";
                    }
                }
            }
            ";
            TestElement[] elements = TestGenerator.TestGenerator.GenerateTests(input);
            Assert.AreEqual(1, elements.Length);
        }
    }
}

