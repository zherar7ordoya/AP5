using System;

namespace MVPExample.Presenters
{
    public interface ICalcPresenter
    {
        void Add(object sender, EventArgs e);
        void Reset(object sender, EventArgs e);
        decimal TryGetNumber(string input);
    }
}