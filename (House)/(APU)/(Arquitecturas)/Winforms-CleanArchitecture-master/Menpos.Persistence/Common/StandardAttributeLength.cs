using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Persistence.Common
{
    public static class StandardAttributeLength
    {
        /// <summary>
        /// 25 Caracteres Max
        /// </summary>
        public static short SmallString = 50;

        /// <summary>
        /// 100 Caracteres Max
        /// </summary>
        public static short MediumString = 100;

        /// <summary>
        /// 200 Caracteres Max
        /// </summary>
        public static short LargeString = 200;

        /// <summary>
        /// 400 Caracteres Max
        /// </summary>
        public static short ExtraLargeString = 400;

        /// <summary>
        /// 800 Caracteres Max
        /// </summary>
        public static short SuperExtraLargeString = 800;

        /// <summary>
        /// 18 Digitos de precision
        /// </summary>
        public static short MoneyPrecision = 18;

        /// <summary>
        /// 6 Digitos de escala
        /// </summary>
        public static short MoneyScale = 6;
    }
}
