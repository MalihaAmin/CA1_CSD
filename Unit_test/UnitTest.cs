using Xunit;

[Collection("BloodPressureTests")]
public class BloodPressureTests
{
    // Test for low blood pressure category when systolic is below 90 and diastolic is below 60
    [Fact]
    public void Category_ShouldBeLow_WhenSystolicBelow90AndDiastolicBelow60()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure { Systolic = 89, Diastolic = 59 };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Low, category);
    }

    // Test for ideal blood pressure category when systolic is between 70 and 119 and diastolic is between 40 and 79
    [Fact]
    public void Category_ShouldBeIdeal_WhenSystolicBetween70And119AndDiastolicBetween40And79()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure { Systolic = 110, Diastolic = 70 };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.Ideal, category);
    }

    // Test for pre-high blood pressure category based on specific systolic and diastolic ranges
    [Fact]
    public void Category_ShouldBePreHigh_WhenSystolicBetween120And139AndDiastolicBelow80OrSystolicBetween81And139AndDiastolicBetween80And89()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure { Systolic = 130, Diastolic = 85 };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.PreHigh, category);
    }

    // Test for high blood pressure category when systolic is between 140 and 190 or diastolic is between 90 and 100
    [Fact]
    public void Category_ShouldBeHigh_WhenSystolicBetween140And190OrDiastolicBetween90And100()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure { Systolic = 150, Diastolic = 95 };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.High, category);
    }

    // Test for not valid blood pressure category when no other category matched
    [Fact]
    public void Category_ShouldBeNotValid_WhenNoOtherCategoryMatched()
    {
        // Arrange
        BloodPressure bloodPressure = new BloodPressure { Systolic = 200, Diastolic = 110 };

        // Act
        BPCategory category = bloodPressure.Category;

        // Assert
        Assert.Equal(BPCategory.NotValid, category);
    }
}
