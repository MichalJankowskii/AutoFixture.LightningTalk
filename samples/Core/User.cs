namespace LightningTalk.AutoFixture.Core
{
    using System.Collections.Generic;

    public class User : IUser
    {
        public string Name { get; set; }

        public List<User> Substitutes { get; set; }

        public string Surname { get; set; }
    }
}