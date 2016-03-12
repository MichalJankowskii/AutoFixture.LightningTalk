namespace LightningTalk.AutoFixture.Core
{
    public class Person : IPerson
    {
        public string Email { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string AddressLine { get; set; }
        public string HomePhone { get; set; }
        public string City { get; set; }
    }
}