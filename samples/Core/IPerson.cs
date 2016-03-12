namespace LightningTalk.AutoFixture.Core
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string Company { get; set; }


        string AddressLine { get; set; }

        string HomePhone { get; set; }

        string City { get; set; }
    }
}
