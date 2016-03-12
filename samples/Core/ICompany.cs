namespace LightningTalk.AutoFixture.Core
{
    public interface ICompany
    {
        void Add(IPerson person);

        void AddToTribe(IPerson person, ITribe tribe);
    }
}