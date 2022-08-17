using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    /// <summary>
    /// 
    /// TEXTBOX CON PLACEHOLDER
    /// 
    /// </summary>
    /// 
    /// <author>Gerardo Tordoya</author>
    /// <created>2022-07-04</created>
    /// <edited>2022-08-05</edited>

    class CajaTextoProvisional : TextBox
    {
        // *---------------------------------------------=> EVENTOS & DELEGADOS

        private void MostrarTextoProvisional(object sender, EventArgs e) => MostrarTextoProvisional();
        private void OcultarTextoProvisional(object sender, EventArgs e) => OcultarTextoProvisional();

        // *-----------------------------------------------------=> CONSTRUCTOR

        public CajaTextoProvisional()
        {
            GotFocus += OcultarTextoProvisional;
            LostFocus += MostrarTextoProvisional;
        }

        // *-----------------------------------------=> ATRIBUTOS & PROPIEDADES

        bool EsTextoProvisional = true;
        string textoProvisional;

        public string TextoProvisional
        {
            get => textoProvisional;
            set
            {
                textoProvisional = value;
                MostrarTextoProvisional();
            }
        }

        public new string Text
        {
            get => EsTextoProvisional ? string.Empty : base.Text;
            set => base.Text = value;
        }

        // *---------------------------------------------------------=> MÉTODOS

        /*       El marcador se muestra cuando el TextBox pierde foco.       */
        private void MostrarTextoProvisional()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = TextoProvisional;
                ForeColor = Color.Gray;
                Font = new Font(Font, FontStyle.Bold);
                EsTextoProvisional = true;
            }
        }

        /*      El marcador se elimina cuando el TextBox adquiere foco.      */
        private void OcultarTextoProvisional()
        {
            if (EsTextoProvisional)
            {
                base.Text = string.Empty;
                ForeColor = SystemColors.WindowText;
                Font = new Font(Font, FontStyle.Regular);
                EsTextoProvisional = false;
            }
        }

        // *------------------------------------------------------=> Ç'EST FINI

    }
}
