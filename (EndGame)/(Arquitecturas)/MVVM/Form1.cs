/*
  @title        MODELO-VISTA-VISTAMODELO (MVVM)
  @description  Implementación en WinForms de la arquitectura MVVM
  @notes        The term MVVM was first mentioned by the WPF Architect, John
                Gossman, on his blog in 2005 [7]. It was then described in
                depths by Josh Smith in his MSDN article “WPF Apps with the
                Model-View-ViewModel Design Pattern”. Gossman explains that the
                idea of MVVM was built around modern UI architecture where the
                View is the responsibly of the designer rather than the
                developer and therefore contains no code.
  @author       Gerardo Tordoya
  @date         2022-10-05
  @credits      www.c-sharpcorner.com/uploadfile/yougerthen/mvvm-implementation-for-windows-forms/
                www.codeproject.com/Articles/42830/Model-View-Controller-Model-View-Presenter-and-Mod
*/

using System.Windows.Forms;

namespace CSharpCorner
{
    //[ViewModel(true)]

    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
    }
}
