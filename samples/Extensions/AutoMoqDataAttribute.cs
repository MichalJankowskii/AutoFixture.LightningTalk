namespace LightningTalk.AutoFixture.Extensions
{
    using System;
    using System.Linq;
    using Conditions;
    using Ploeh.AutoFixture;
    using Ploeh.AutoFixture.AutoMoq;
    using Ploeh.AutoFixture.Xunit2;

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : this(new Fixture())
        {
        }

        public AutoMoqDataAttribute(Type fixtureType)
            : this((IFixture) Activator.CreateInstance(fixtureType))
        {
        }

        public AutoMoqDataAttribute(IFixture fixture)
            : base(Condition.Requires(fixture).IsNotNull().Value.Customize(new AutoConfiguredMoqCustomization()))
        {
            // Do not throw exception on circular references
            fixture.Behaviors
                .OfType<ThrowingRecursionBehavior>()
                .ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));

            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            fixture.Register<IFixture>(() => fixture);
        }
    }
}