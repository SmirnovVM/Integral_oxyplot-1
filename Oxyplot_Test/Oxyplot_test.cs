using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integral;

namespace Oxyplot_Test
{
    [TestClass]
    public class Oxyplot_test
    {
        [TestMethod]
        public void Test_Integral_XX_0_100()
        {
            double a = 0;
            double b = 100;
            int n= 10000000;
            Func<double, double> f = x => x * x;
            double exact_result = 333333.333;
            Integral_calculate integr = new Integral_calculate();

            double real_result = integr.calcPosl(n, a, b, f);

            Assert.AreEqual(real_result, exact_result, 0.001);
             
        }

        [TestMethod]
        public void Test_Integral_minus_n()
        {
            double a = 0;
            double b = 100;
            int n = -100000;
            Func<double, double> f = x => x * x;
            double exact_result = 333333.333;
            Integral_calculate integr = new Integral_calculate();

            double real_result = integr.calcPosl(n, a, b, f);

            Assert.AreEqual(real_result, exact_result, 0.001);

        }

        [TestMethod]
        public void Test_Integral_a_greater_b()
        {
            double a = 100;
            double b = 0;
            int n = 100000;
            Func<double, double> f = x => x * x;
            double exact_result = 333333.333;
            Integral_calculate integr = new Integral_calculate();

            double real_result = integr.calcPosl(n, a, b, f);
            Assert.AreEqual(real_result, exact_result, 0.001);
        }


    }
}
