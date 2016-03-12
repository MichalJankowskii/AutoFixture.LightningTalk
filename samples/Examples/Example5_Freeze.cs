namespace LightningTalk.AutoFixture.Examples
{
    using Core;
    using Extensions;
    using Moq;
    using Ploeh.AutoFixture;
    using Ploeh.AutoFixture.AutoMoq;
    using Ploeh.AutoFixture.Xunit2;
    using Xunit;

    public static class Example5_Freeze
    {
        public static void Freeze1()
        {
            var fixture = new Fixture().Customize(new AutoConfiguredMoqCustomization());
            var employeesManagerMock = fixture.Freeze<Mock<IEmployeesManager>>();
            var company = fixture.Create<Company>();
        }

        public static void Freeze2()
        {
            var fixture = new Fixture().Customize(new AutoConfiguredMoqCustomization());
            var employeesManagerMock = fixture.FreezeMoq<IEmployeesManager>();
            var company = fixture.Create<Company>();
        }

        [AutoMoqData, Theory]
        public static void Freeze3(IPerson person, [Frozen] Mock<IEmployeesManager> employeesManagerMock, Company company)
        {
            // Arrange
            // Act
            company.Add(person);
            // Assert
            employeesManagerMock.Verify(x => x.Add(person), Times.Once);
        }
    }
}