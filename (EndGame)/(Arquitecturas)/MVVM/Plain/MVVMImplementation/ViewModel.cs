using System;
using System.Windows.Forms;

namespace MVVMImplementation
{
    /// <summary>
    /// This is the view model class
    /// </summary>
    public class ViewModel
    {
        //The form1 instance will be set once the view model is instanciated
        Form1 _form1;
        /// <summary>
        /// Cosntructor
        /// </summary>
        /// <param name="form1">This form1 will be injected in the view model</param>
        public ViewModel(Form1 form1)
        {
            _form1 = form1;
            /*The loop is leveraged to search the button among controls
            And once it is found, the click event of that related button
             * will be raised */
            foreach (Control item in _form1.Controls)
            {
                if (item is Button)
                { 
                    (item as Button).Click+=new EventHandler(ViewModel_Click);
                }
            }
            //This will lunch the form1 instance
            Application.Run(_form1);
        }
        /// <summary>
        /// This event handler will be triggered when the button is
        /// clicked, the addtion operation will be leveraged and then
        /// the result will be displayed in the targeted label
        /// </summary>
        protected void ViewModel_Click(object sender, EventArgs args)
        {
            int result = 0;
            int cumul;
            foreach (Control item in _form1.Controls)
            {
                if (item is TextBox)
                { 
                    if(int.TryParse((item as TextBox).Text,out cumul))
                    {
                        result += cumul;
                    }
                }
            }
            foreach (Control item in _form1.Controls)
            {
                /* As we remark here, we use the TabIndex property
                 * to precise which label will be used to dislpay the
                 result as we have three labels in the scène */
                if (item is Label && item.TabIndex ==5)
                {
                    (item as Label).Text = result.ToString();
                }
            }
        }
    }
}
