/**
 * Ejemplo dado por el profesor. Lo uso porque no encuentro material donde
 * ampliar los conceptos de modo que haga una implementación diferente del
 * tema.
 */

using System;
using System.Text;
using System.Security.Cryptography;

namespace SEGURIDAD
{
    public class Criptografia
    {
        public static string GenerarMD5(string sCadena)
        {
            try
            {
                //Crear un objeto de codificación para garantizar el estándar de codificación para el texto fuente
                UnicodeEncoding UeCodigo = new UnicodeEncoding();
                //Recuperar una matriz de bytes basado en el texto de origen
                byte[] ByteSourceText = UeCodigo.GetBytes(sCadena);
                //Instancias de un objeto MD5 Proveedor
                MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
                //Calcular el valor hash MD5 de la fuente
                byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
                //Y es convertir a formato de cadena para el retorno
                return Convert.ToBase64String(ByteHash);
            }
            catch (CryptographicException ex) { throw (ex); }
            catch (Exception ex) { throw (ex); }
        }

        public static string GenerarSHA(string sCadena)
        {
            // Objeto de codificación
            UnicodeEncoding ueCodigo = new UnicodeEncoding();
            //Recuperar una matriz de bytes basado en el texto de origen
            byte[] ByteSourceText = ueCodigo.GetBytes(sCadena);
            // Objeto para instanciar las codificación
            SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
            // Calcula el valor hash de la cadena recibida
            byte[] ByteHash = SHA.ComputeHash(ueCodigo.GetBytes(sCadena));
            // Convierte el valor anterior en cadena y lo devuelve
            return Convert.ToBase64String(ByteHash);
        }

        public static string Encriptar(string texto)
        {
            try
            {
                string key = "LUG"; //llave para encriptar datos
                byte[] keyArray;
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
            }
            catch (Exception ex) { throw (ex); }

            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                string key = "LUG";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
                tdes.Clear();
                textoEncriptado = Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception ex) { throw (ex); }

            return textoEncriptado;
        }
    }
}
