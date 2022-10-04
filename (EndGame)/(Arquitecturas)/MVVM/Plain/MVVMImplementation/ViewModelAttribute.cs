using System;

namespace MVVMImplementation.Attribute
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    
    sealed class ViewModelAttribute : System.Attribute 
    {
        public ViewModelAttribute() { }
        public ViewModelAttribute(bool Activated)
        {
            this.Activated = Activated;
        }
        public bool Activated { get; set; }
    }   
}
