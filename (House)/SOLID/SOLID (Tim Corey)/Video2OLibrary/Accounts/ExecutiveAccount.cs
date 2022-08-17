namespace Video2OLibrary
{
    public class ExecutiveAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName}." +
                $"{person.LastName}@corp.com",
                IsManager = true,
                IsExecutive = true
            };

            return output;
        }
    }
}
