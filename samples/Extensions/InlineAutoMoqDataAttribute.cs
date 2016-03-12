namespace LightningTalk.AutoFixture.Extensions
{
    using System;
    using Ploeh.AutoFixture.Xunit2;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InlineAutoMoqDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoMoqDataAttribute(params object[] values)
            : this(new AutoMoqDataAttribute(), values)
        {
        }

        public InlineAutoMoqDataAttribute(AutoMoqDataAttribute autoDataAttribute, params object[] values)
            : base(autoDataAttribute, values)
        {
        }
    }
}
