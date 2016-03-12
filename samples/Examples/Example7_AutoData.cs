// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestData.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the TestData type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LightningTalk.AutoFixture.Examples
{
    using Ploeh.AutoFixture.Xunit2;
    using Xunit;

    public class Example7_AutoData
    {
        [Theory, AutoData]
        public void Test1(int arg1, string arg2)
        {
        }

        [Theory]
        [InlineAutoData(10)]
        [InlineAutoData(10, "test1")]
        public void Test2(int arg1, string arg2)
        {
        }
    }
}