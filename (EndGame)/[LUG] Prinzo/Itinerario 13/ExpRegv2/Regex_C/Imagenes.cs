using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_C
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

       Bitmap mBMP ;

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOf = new OpenFileDialog();
           // var _with1 = mOf;
            mOf.Multiselect = false;
            mOf.CheckFileExists = true;
            mOf.ShowReadOnly = false;
            mOf.Filter = "Todos los archivos|*.*|Imagenes|*.bmp;*.gif;*.jpg;";
            mOf.FilterIndex = 2;
            if (mOf.ShowDialog() == DialogResult.OK)
            {
                mBMP = new Bitmap(mOf.FileName);

                Graphics mGr = this.CreateGraphics();

                mGr.DrawImage(mBMP, 200, 50);

                mGr.Dispose();
            }

        }

        private void btnDeformar_Click(object sender, EventArgs e)
        {
            if ((mBMP != null))
            {
                Graphics mGr = this.CreateGraphics();
                Point[] mPuntos = {
            new Point(300, 100),
            new Point(300 + Convert.ToInt32(this.txtAncho.Text), 100),
            new Point(300 + Convert.ToInt32(this.txtAncho.Text), 100 + Convert.ToInt32(this.txtAlto.Text))
        };
                mGr.DrawImage(mBMP, mPuntos);
                mGr.Dispose();
            }
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {

        }


        private void Button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog mSD = new SaveFileDialog();
                mSD.Filter = "Imagenes|*.bmp;*.gif;*.jpg;";
            mSD.OverwritePrompt = true;
            if (mSD.ShowDialog() == DialogResult.OK)
            {
                switch (System.IO.Path.GetExtension(mSD.FileName).ToLower())
                {
                    case ".gif":
                        mBMP.Save(mSD.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case ".jpg":
                        mBMP.Save(mSD.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        mBMP.Save(mSD.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        mBMP.Save(mSD.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }

            }
        }

        private void Imaging_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Color mColor = default(Color);
            if (e.X >= 300 & e.X <= 300 + mBMP.Width & e.Y >= 100 & e.Y <= 100 + mBMP.Height)
            {
                mColor = mBMP.GetPixel(e.X - 300, e.Y - 100);
            }

            mBMP.MakeTransparent(mColor);


            Graphics mGr = this.CreateGraphics();
            mGr.Clear(this.BackColor);
            mGr.DrawImage(mBMP, 300, 100);
            mGr.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((mBMP != null))
            {
                ColorDialog mCS = new ColorDialog();
                mCS.AllowFullOpen = true;
                mCS.AnyColor = true;
                if (mCS.ShowDialog() == DialogResult.OK)
                {
                    mBMP.MakeTransparent(mCS.Color);
                    Graphics mGr = this.CreateGraphics();

                    mGr.DrawImage(mBMP, 300, 100);
                    mGr.Dispose();
                }
            }
        }
    }


}
