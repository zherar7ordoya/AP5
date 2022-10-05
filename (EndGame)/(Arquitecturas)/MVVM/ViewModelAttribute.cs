/* This is a little bit optional step, but it could be very helpful in cases
 * that are more complex than this one. In this step we will use some
 * reflection to indicate when the ViewModel is activated, then the business
 * logic is coupled with the user interface. For this purpose, we have
 * developed a CLASS-ATTRIBUTE (ViewModelAttribute) that has one unique boolean
 * property (Activated property) that will be used as flag to indicate if the
 * ViewModel is activated or not. */

using System;

namespace CSharpCorner
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]

    sealed class ViewModelAttribute : Attribute
    {
        public bool Activated { get; set; }
        public ViewModelAttribute(bool activated) => Activated = activated;
    }
}
