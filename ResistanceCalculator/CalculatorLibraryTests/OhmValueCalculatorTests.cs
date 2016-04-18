using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Tests
{
    [TestClass()]
    public class OhmValueCalculatorTests
    {
        [TestMethod()]
        public void Calculate_Ohm_Value_When_Band_C_Is_Silver_Or_Gold()
        {
            OhmValueCalculator calc = new OhmValueCalculator();
            //First Band -> Red = 2
            //Second Band ->Yellow =4
            //Third Band -> Silver = Multipleir ( /100 )
            // Fourth Band -> Brown = 1%
            // Expected output is ((2*10)+4)/10;
            string expectedValue = (2 * 10 + 4)  / 100.00 + " Ohm : Tolernce " + 1 + " % "; ;
            var actualValue =  calc.CalculateOhmValue(ColorBand.Info(Color.Red), ColorBand.Info(Color.Yellow), ColorBand.Info(Color.Silver), ColorBand.Info(Color.Brown));

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void Calculate_Ohm_Value_When_Band_C_Is_Green()
        {
            OhmValueCalculator calc = new OhmValueCalculator();
            //First Band -> Red = 2
            //Second Band ->Yellow =4
            //Third Band -> Green = Multipleir ( /100000 )
            // Fourth Band -> Brown = 1%
            // Expected output is ((2*10)+4)/10;
            string expectedValue = (((2 * 10 + 4) * 100000.00) / 1000)  + " K Ohm : Tolernce " + 1 + " %";
            var actualValue = calc.CalculateOhmValue(ColorBand.Info(Color.Red), ColorBand.Info(Color.Yellow), ColorBand.Info(Color.Green), ColorBand.Info(Color.Brown));

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}