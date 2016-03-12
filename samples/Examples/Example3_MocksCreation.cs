namespace LightningTalk.AutoFixture.Examples
{
    using Core;
    using Moq;
    using Ploeh.AutoFixture;
    using Ploeh.AutoFixture.AutoMoq;

    public static class Example3_MocksCreation
    {
        public static void AutoFixtureWithMock1()
        {
            var fixture = new Fixture().Customize(new AutoConfiguredMoqCustomization());
            var personMock = fixture.Create<Mock<IPerson>>();
            personMock.SetupProperty(u => u.FirstName, "dummyFirstName");
        }

        public static void AutoFixtureWithMock2()
        {
            var fixture = new Fixture().Customize(new AutoConfiguredMoqCustomization());
            var person = fixture.Create<IPerson>();
            Mock.Get(person).SetupProperty(u => u.FirstName, "dummyFirstName");
        }
    }
}