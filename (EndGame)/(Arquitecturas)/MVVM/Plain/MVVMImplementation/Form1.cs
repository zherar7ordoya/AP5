/*
  @title        MVVM IMPLEMENTATION FOR WINFORMS
  @description  Implementation of MVVM pattern for WinForms
  @author       Gerardo Tordoya
  @date         2022-10-04
  @credits      www.c-sharpcorner.com/uploadfile/yougerthen/mvvm-implementation-for-windows-forms/
*/

using System.Windows.Forms;
using MVVMImplementation.Attribute;

namespace MVVMImplementation
{
    [ViewModel(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
