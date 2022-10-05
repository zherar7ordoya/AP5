using System;
using System.Windows.Forms;
using System.Linq;

namespace CSharpCorner
{
    public class ViewModel
    {
        readonly Form1 _form1;

        // ─── CONSTRUCTOR ────────────────────────────────────────────────────
        /* As we can see here, the ViewModel class contains a private field 
         * (_form1) which is used to get the controls and do all the business
         * at the ViewModel class. This class also contains a constructor. */
        public ViewModel(Form1 form1)
        {
            _form1 = form1;
            
            foreach (var item in from Control item in _form1.Controls
                                 where item is Button
                                 select item)
            {
                (item as Button).Click += new EventHandler(ViewModel_Click);
            }
            /* As we can observe, a Form1 instance could be injected through
* the constructor. This one will play the role of the binder
* between the ViewModel and the user interface. */
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
                    if (int.TryParse((item as TextBox).Text, out int acumulador))
                    {
                        result += acumulador;
                    }
                }
            }

            foreach (var item in from Control item in _form1.Controls
                                 where item is Label && item.TabIndex == 7
                                 select item)
            {
                (item as Label).Text = result.ToString();
            }
        }
    }
}
