namespace SRPSTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            DemoTestClass demoTestClass = new DemoTestClass();
            int input1 = 5;
            int input2 = 15;
            int expectedValue = 20;

            //Act

            int AddedValue = demoTestClass.Add(input1, input2);

            //Assert
            
            Assert.Equal(expectedValue, AddedValue);

        }
    }
}