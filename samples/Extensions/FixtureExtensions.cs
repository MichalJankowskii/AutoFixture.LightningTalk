namespace LightningTalk.AutoFixture.Extensions
{
    using Moq;
    using Ploeh.AutoFixture;

    public static class FixtureExtensions
    {
        public static Mock<T> FreezeMoq<T>(this IFixture fixture) where T : class
        {
            var mock = new Mock<T>();
            fixture.Register(() => mock.Object);
            return mock;
        }
    }
}