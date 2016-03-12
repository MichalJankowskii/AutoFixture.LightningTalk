namespace LightningTalk.AutoFixture.Examples
{
    using Core;
    using Extensions;
    using Ploeh.AutoFixture;

    public static class Example4_Hydrator
    {
        public static void AutoFixtureHydrator()
        {
            var fixture = new Fixture().Customize(new ObjectHydratorCustomization());
            var person = fixture.Create<Person>();
        }
    }
}