using BPCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BPCalculatorUnitTesting
{
    [TestClass]
    public class BloodPressureTests
    {
        [TestMethod]
        public void Test_High()
        {
            //if Systolic = 150 and Diastolic = 95 then it should be 'High' pressure
            BloodPressure bp = new BloodPressure() { Systolic = 150, Diastolic = 95 };
            Assert.AreEqual(BPCategory.High, bp.Category);
        }

        [TestMethod]
        public void Test_PreHigh()
        {
            //if Systolic = 125 and Diastolic = 85 then it should be 'PreHigh' pressure
            BloodPressure bp = new BloodPressure() { Systolic = 125, Diastolic = 85 };
            Assert.AreEqual(BPCategory.PreHigh, bp.Category);
        }

        [TestMethod]
        public void Test_Ideal()
        {
            //if Systolic = 115 and Diastolic = 70 then it should be 'Ideal' pressure
            BloodPressure bp = new BloodPressure() { Systolic = 115, Diastolic = 70 };
            Assert.AreEqual(BPCategory.Ideal, bp.Category);
        }

        [TestMethod]
        public void Test_Low()
        {
            //if Systolic = 80 and Diastolic = 50 then it should be 'Low' pressure
            BloodPressure bp = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            Assert.AreEqual(BPCategory.Low, bp.Category);
        }

        // Additional Tests

        [TestMethod]
        public void Test_Invalid()
        {
            // Test for invalid values
            // if Systolic = 200 and Diastolic = 23, it should be 'invalid'
            BloodPressure bp = new BloodPressure() { Systolic = 200, Diastolic = 23 };
            Assert.AreEqual(BPCategory.Invalid, bp.Category);
        }

        [TestMethod]
        public void Test_Outside_High_Range()
        {
            // Test for values outside the high range
            // if Systolic = 140 and Diastolic = 80, it should not be 'High'
            BloodPressure bp = new BloodPressure() { Systolic = 140, Diastolic = 80 };
            Assert.AreNotEqual(BPCategory.High, bp.Category);
        }

        [TestMethod]
        public void Test_Outside_PreHigh_Range()
        {
            // Test for values outside the prehigh range
            // if Systolic = 119 and Diastolic = 79, it should not be 'PreHigh'
            BloodPressure bp = new BloodPressure() { Systolic = 119, Diastolic = 79 };
            Assert.AreNotEqual(BPCategory.PreHigh, bp.Category);
        }

        [TestMethod]
        public void Test_Outside_Ideal_Range()
        {
            // Test for values outside the ideal range
            // if Systolic = 90 and Diastolic = 45, it should not be 'Ideal'
            BloodPressure bp = new BloodPressure() { Systolic = 90, Diastolic = 45 };
            Assert.AreNotEqual(BPCategory.Ideal, bp.Category);
        }

        [TestMethod]
        public void Test_Outside_Low_Range()
        {
            // Test for values outside the low range
            // if Systolic = 75 and Diastolic = 60, it should not be 'Low'
            BloodPressure bp = new BloodPressure() { Systolic = 75, Diastolic = 60 };
            Assert.AreNotEqual(BPCategory.Low, bp.Category);
        }
    }
}
