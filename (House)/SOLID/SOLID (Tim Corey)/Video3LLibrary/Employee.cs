namespace Video3LLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            // Need other tasks here.
            // Otherwise,it's a property set (not a method).
            Manager = manager;
        }
    }
}
