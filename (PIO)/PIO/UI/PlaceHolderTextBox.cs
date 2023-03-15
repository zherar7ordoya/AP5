using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    class PlaceHolderTextBox : TextBox
    {
        //------------------------------------------------- EVENTOS Y DELEGADOS

        private void MostrarPlaceHolder(object sender, EventArgs e) => MostrarPlaceHolder();
        private void OcultarPlaceHolder(object sender, EventArgs e) => OcultarPlaceHolder();

        //------------------------------------------------------- CONSTRUCTORES

        public PlaceHolderTextBox()
        {
            GotFocus += OcultarPlaceHolder;
            LostFocus += MostrarPlaceHolder;
        }

        //--------------------------------------------- ATRIBUTOS Y PROPIEDADES

        bool EsPlaceHolder = true;
        string _textoPlaceHolder;

        public string TextoPlaceHolder
        {
            get => _textoPlaceHolder;
            set
            {
                _textoPlaceHolder = value;
                MostrarPlaceHolder();
            }
        }

        public new string Text
        {
            get => EsPlaceHolder ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //------------------------------------------------------------- MÉTODOS

        // El marcador se muestra cuando el TextBox pierde foco.
        private void MostrarPlaceHolder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = TextoPlaceHolder;
                ForeColor = Color.DarkBlue;
                Font = new Font(Font, FontStyle.Italic);
                EsPlaceHolder = true;
            }
        }

        // El marcador se elimina cuando el TextBox adquiere foco.
        private void OcultarPlaceHolder()
        {
            if (EsPlaceHolder)
            {
                base.Text = string.Empty;
                ForeColor = SystemColors.WindowText;
                Font = new Font(Font, FontStyle.Regular);
                EsPlaceHolder = false;
            }
        }
    }
}
