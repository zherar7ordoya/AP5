namespace Video2OLibrary
{
    public class ManagerAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName.Substring(0, 1)}" +
                $"{person.LastName}@acmecorp.com",
                IsManager = true
            };

            return output;
        }
    }
}
