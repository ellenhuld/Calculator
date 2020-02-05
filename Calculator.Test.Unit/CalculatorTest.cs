using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; //tilføjes automatiskt her
using CalculatorHandInTesting;

using NUnit.Framework.Constraints;



// uut = unit under test, ofte det navn af de variable man arbejder med

namespace CalculatorTestUnit
{
    [TestFixture] //attribute som fortæller Nunit at det er sådan at det er en klasse - angives med [], holder styr på en eller flere tests
    public class CalculatorTest
    {

        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3,2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(2, -2, 0)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Substrack(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        

        [TestCase(4, 2, 2)]
        [TestCase(6, 3, 2)]
        [TestCase(8, 5, 1.6)]
        public void Divide_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a,b), Is.EqualTo(result));
        }

        [TestCase(4, 0)]
        public void Divide_DivedeByZero_ResulExeption(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(a, b));
        }
        
        

        //[TestCase]
        //public void TestSanity()
        //{
        //    Assert.Throws<DivideByZeroException>(new TestDelegate(() => DivideByZero()));
        //}

        //private void DivideByZero()
        //{
        //    // Parse "0" to make sure to get an error at run time, not compile time.
        //    var a = (1 / Double.Parse("0"));
        //}

        //[Test]
        //public void DivideZeroTest()
        //{
        //    _uut = new Calculator();
        //    double n = _uut.Divide(24, 0);
        //    Assert.AreEqual(-999, n);

        //}

        //public double Divide(double a, double b)
        //{
        //    try
        //    {
        //        return a/b;
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        return -999;
        //    }
    }



        //[Test] //integerer ved at skriv et attribute og bagefter en metode uden parameter


        //[SetUp]
        //public void Setup()
        //{
        //    //arrange
        //    var uut = new Calculator();
        //}

        //[TestCase(3, 2, 1)]
        //[TestCase(-3, -2, -1)]
        //[TestCase(-3, 2, -5)]
        //[TestCase(3, -2, 5)]

        // public void AddItem_ResultIsCorrect() // det er min metode skal prøve at teste

        //hvad skal du teste_hvadforventerdu_hvadreturneres 

        //{
        //    //Arrange
        //    //var uut = new Calculator();


        //    Act
        //    uut.Add(4, 6);

        //    Assert
        //    Assert.That(uut.Add(4, 6), Is.EqualTo(10));
        //    Assert.That(uut.Substrack(4, 6), Is.EqualTo(-2));
        //    Assert.That(uut.Multiply(4, 6), Is.EqualTo(24));
        //    Assert.That(uut.Power(4, 6), Is.EqualTo(4096));

        //}


        //kan også skrives på anden måde


        //Assert.That(uut.Add(a,b),Is.EqualTo(result));

    }

