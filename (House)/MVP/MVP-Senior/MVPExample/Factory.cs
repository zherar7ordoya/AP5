using MVPExample.Interfaces;
using MVPExample.Models;
using MVPExample.Presenters;

namespace MVPExample
{
    public static class Factory
    {
        public static ICalcPresenter CreateCalcPresenter()
        {
            return new CalcPresenter(CreateCalcForm(), CreateCalcModel());
        }

        public static ICalcView CreateCalcForm()
        {
            return new CalcForm();
        }

        public static ICalcModel CreateCalcModel()
        {
            return new CalcModel();
        }
    }
}
