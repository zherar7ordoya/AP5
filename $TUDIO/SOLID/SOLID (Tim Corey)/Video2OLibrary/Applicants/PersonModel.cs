namespace Video2OLibrary
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
        public IAccount AccountProcessor { get; set; } = new Account();
    }
}
