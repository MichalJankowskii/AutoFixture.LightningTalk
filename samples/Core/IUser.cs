namespace LightningTalk.AutoFixture.Core
{
    using System.Collections.Generic;

    public interface IUser
    {
        string Name { get; set; }

        List<User> Substitutes { get; set; }

        string Surname { get; set; }
    }
}