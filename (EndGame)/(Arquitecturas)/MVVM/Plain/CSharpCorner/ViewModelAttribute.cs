using System;

namespace CSharpCorner
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]

    sealed class ViewModelAttribute : Attribute
    {
        public bool Activated { get; set; }

        public ViewModelAttribute()
        {
            ;
        }

        public ViewModelAttribute(bool activated) => Activated = activated;
    }
}
