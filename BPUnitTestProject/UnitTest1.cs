using BPCalculator;

namespace BPCalculatorUnitTesting
{
    [TestClass]
    public class BloodPresureTests
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
            //if Systolic = 80 and Diastolic = 80 then it should be 'Low' pressure
            BloodPressure bp = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            Assert.AreEqual(BPCategory.Low, bp.Category);
        }
    }
}