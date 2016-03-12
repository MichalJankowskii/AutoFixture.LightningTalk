namespace LightningTalk.AutoFixture.Examples
{
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using Ploeh.AutoFixture;

    public static class Example6_CircularPath
    {
        public static void Solution1()
        {
            var fixture = new Fixture();
            fixture.Behaviors
                .OfType<ThrowingRecursionBehavior>()
                .ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var user1 = fixture.Build<User>()
                .With(x => x.Name, "Jan")
                .Create();
        }

        public static void Solution2()
        {
            var fixture = new Fixture();
            var user1 = fixture.Build<User>()
                .With(x => x.Name, "Jan")
                .Without(x => x.Substitutes)
                .Create();
        }

        public static void Solution3()
        {
            var fixture = new Fixture();
            var user1 = fixture.Build<User>()
                .With(x => x.Name, "Jan")
                .With(x => x.Substitutes, new List<User> {new User()})
                .Create();
        }
    }
}