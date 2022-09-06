namespace Video2OLibrary.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProcessor { get; set; }
    }
}
