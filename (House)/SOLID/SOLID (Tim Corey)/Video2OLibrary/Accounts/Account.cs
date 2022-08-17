namespace Video2OLibrary
{
    public class Account : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName.Substring(0, 1)}" +
                $"{person.LastName}@acme.com"
            };

            return output;
        }
    }
}
