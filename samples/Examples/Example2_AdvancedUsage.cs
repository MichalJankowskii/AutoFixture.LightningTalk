namespace LightningTalk.AutoFixture.Examples
{
    using Core;
    using Ploeh.AutoFixture;

    public static class Example2_AdvancedUsage
    {
        public static void Run()
        {
            var fixture = new Fixture();
            var user1 = fixture.Build<User>().With(x => x.Name, "Jan").Create();
            // Result: user1.Name = "Jan"

            var user2 = fixture.Build<User>().Without(x => x.Substitutes).Create();
            // Result: user2.Substitute = null;

            var user3 = fixture.Build<User>().OmitAutoProperties().Create();
            // Result: Properties will have default values

            var user4 = fixture.Build<User>().Do(x => x.Substitutes.Add(user1)).Create();
            // Result: user4.Substitutes: { user1 } 

            var user5 =
                fixture.Build<User>()
                    .With(x => x.Name, "Jan")
                    .With(x => x.Surname, "Kowalski")
                    .Without(x => x.Substitutes)
                    .Create();
            // Result: user5.Name = "Jan", user5.Surname = "Kowalski, user4.Substitutes = null

            fixture.Customize<User>(u => u.With(x => x.Name, "Jan").With(x => x.Surname, "Kowalski"));
            var user6 = fixture.Create<User>();
        }
    }
}