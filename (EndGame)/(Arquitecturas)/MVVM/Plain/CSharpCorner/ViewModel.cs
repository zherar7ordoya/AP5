using System;
using System.Windows.Forms;

namespace CSharpCorner
{
    public class ViewModel
    {
        Form1 _form1;

        // ─── CONSTRUCTOR ────────────────────────────────────────────────────
        public ViewModel(Form1 form1)
        {
            _form1 = form1;
            
            foreach (Control item in _form1.Controls)
            {
                if (item is Button)
                {
                    (item as Button).Click += new EventHandler(ViewModel_Click);
                }
            }
            Application.Run(_form1);
        }

        // ─── MÉTODO ─────────────────────────────────────────────────────────
        protected void ViewModel_Click(object sender, EventArgs args)
        {
            int result = 0;

            foreach (Control item in _form1.Controls)
            {
                if (item is TextBox)
                {
                    if (int.TryParse((item as TextBox).Text, out int cumul))
                    {
                        result += cumul;
                    }
                }
            }

            foreach (Control item in _form1.Controls)
            {
                if (item is Label && item.TabIndex == 7)
                {
                    (item as Label).Text = result.ToString();
                }
            }
        }
    }
}
