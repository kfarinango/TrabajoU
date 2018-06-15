using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsClases2018.Controles
{
    class encriptacionAES
    {
        
        public void AES()
        {
            AesCryptoServiceProvider encriptar = new AesCryptoServiceProvider();

            encriptar.BlockSize = 128;
            encriptar.KeySize = 256;
            encriptar.GenerateIV();
            encriptar.GenerateKey();
            encriptar.Mode = CipherMode.CBC;
            encriptar.Padding = PaddingMode.PKCS7;
           
        }

        public String encriptacion(String texto)
        {
            AesCryptoServiceProvider encriptar = new AesCryptoServiceProvider();
            ICryptoTransform transformar = encriptar.CreateEncryptor();
            byte[] encriptarByte = transformar.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(texto), 0, texto.Length);


            string letras = Convert.ToBase64String(encriptarByte);
            return letras;
        }

        public String desencriptar(String texto)
        {
            AesCryptoServiceProvider encriptar = new AesCryptoServiceProvider();
            ICryptoTransform transformar = encriptar.CreateDecryptor();
            byte[] byteEncriptado = Convert.FromBase64String(texto);

            byte[] desencriptarByte = transformar.TransformFinalBlock(byteEncriptado, 0, byteEncriptado.Length);
            string letras = ASCIIEncoding.ASCII.GetString(desencriptarByte);

            return letras;
        }
    }
}
