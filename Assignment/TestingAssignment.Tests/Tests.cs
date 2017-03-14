using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Tests
{
    [TestFixture]

    public class Tests
    {
        public CaculatePremium cp = new CaculatePremium();

        [Test]
        public void Test1()
        {
            string Gender = "Female";
            int Age = 20;
            double expectedResult = 5;
            Assert.That(cp.CalcPremium(Age,Gender), Is.EqualTo(expectedResult));

        }
        [Test]
        public void Test2()
        {
            string Gender = "Female";
            int Age = 12;
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test3()
        {
            string Gender = "Female";
            int Age = 35;
            double expectedResult = 2.5;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test4()
        {
            string Gender = "Female";
            int Age = 56;
            double expectedResult = 0.375;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test5()
        {
            string Gender = "Female";
            int Age = -4;
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test6()
        {
            string Gender = "Female";
            string Age = "x";
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(0, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test7()
        {
            string Gender = "Male";
            int Age = 22;
            double expectedResult = 6;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test8()
        {
            string Gender = "Male";
            int Age = 16;
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test9()
        {
            string Gender = "Male";
            int Age = 42;
            double expectedResult = 5;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test10()
        {
            string Gender = "Male";
            int Age = 55;
            double expectedResult = 0.75;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test11()
        {
            string Gender = "Male";
            int Age = -2;
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(Age, Gender), Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test12()
        {
            string Gender = "Male";
            string Age = "z";
            double expectedResult = 0;
            Assert.That(cp.CalcPremium(0, Gender), Is.EqualTo(expectedResult));
        }
    }

}
