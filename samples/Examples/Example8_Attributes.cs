namespace LightningTalk.AutoFixture.Examples
{
    using Core;
    using Extensions;
    using Xunit;

    public class Example8_Attributes
    {
        [Theory]
        [AutoMoqData]
        public void AutoMoqData_Test(User user)
        {
        }

        [Theory]
        [InlineAutoMoqData(1)]
        [InlineAutoMoqData(2)]
        public void InlineAutoMoqData_Test(int number, User user)
        {
        }

        [Theory]
        [MemberAutoMoqData("TestData1", MemberType = typeof (TestData))]
        [MemberAutoMoqData("TestData2", MemberType = typeof (TestData))]
        public void MemberAutoMoqData_Test(string text, User user1, User user2)
        {
        }

        public static class TestData
        {
            public static object[] TestData1()
            {
                return new object[] {new[] {"aa"}, new[] {"ab"}, new[] {"ac"}};
            }

            public static object[] TestData2()
            {
                return new object[] {new[] {"ba"}, new[] {"bb"}, new[] {"bc"}};
            }
        }
    }
}