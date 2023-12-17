using BPCalculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Test
{
    [Binding]
    public class BloodPressureSteps
    {
        private BloodPressure _bloodPressure;
        private BPCategory _resultCategory;

        [Given("the systolic is (.*) and diastolic is (.*)")]
        public void GivenTheBloodPressureIs(int systolic, int diastolic)
        {
            _bloodPressure = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
        }

        [When("the blood pressure is calculated")]
        public void WhenTheBloodPressureIsCalculated()
        {
            _resultCategory = _bloodPressure.Category;
        }

        [Then("the category should be (.*)")]
        public void ThenTheCategoryShouldBe(BPCategory expectedCategory)
        {
            Assert.AreEqual(expectedCategory, _resultCategory);
        }
    }
}