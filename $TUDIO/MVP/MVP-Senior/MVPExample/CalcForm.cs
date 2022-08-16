// **********************************************************************
// https://grantwinney.com/its-possible-to-test-a-winforms-app-using-mvp/
// **********************************************************************

using MVPExample.Interfaces;
using System;
using System.Windows.Forms;

namespace MVPExample
{
    public partial class CalcForm : Form, ICalcView
    {
        public event EventHandler Add;
        public event EventHandler Reset;

        public CalcForm()
        {
            InitializeComponent();

            /**
             * I also took the button click event handlers out of the designer
             * file (where they automatically get created), and made those part
             * of the interface as well.
             */
            btnAdd.Click += delegate { Add?.Invoke(this, EventArgs.Empty); };
            btnReset.Click += delegate
            {
                Reset?.Invoke(this, EventArgs.Empty);
                txtNumber1.Focus();
            };
        }

        string ICalcView.Value1
        {
            get => txtNumber1.Text;
            set => txtNumber1.Text = value;
        }

        string ICalcView.Value2
        {
            get => txtNumber2.Text;
            set => txtNumber2.Text = value;
        }

        string ICalcView.Value3
        {
            get => txtNumber3.Text;
            set => txtNumber3.Text = value;
        }

        public string Total
        {
            set => txtTotal.Text = value;
        }

        public string RunningTotal
        {
            set => txtRunningTotal.Text = value;
        }
    }
}
