namespace LightningTalk.AutoFixture.Core
{
    public class Company : ICompany
    {
        private readonly IEmployeesManager employeesManager;
        private readonly ITribeManager tribeManager;

        public Company(IEmployeesManager employeesManager, ITribeManager tribeManager)
        {
            this.employeesManager = employeesManager;
            this.tribeManager = tribeManager;
        }

        public void Add(IPerson person)
        {
            this.employeesManager.Add(person);
        }

        public void AddToTribe(IPerson person, ITribe tribe)
        {
            this.employeesManager.Add(person);
            this.tribeManager.AddToTribe(person, tribe);
        }
    }
}