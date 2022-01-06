using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebPasswordEncryption;

namespace Text_Encrypt
{
    public static class Extension
    {
        public static string Base64Encrypt(this string text)
        {
            var paintTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(paintTextBytes);
        }

        public static string Base64Decrypt(this string text)
        {
            try
            {
                var Base64EncryptBytes = Convert.FromBase64String(text);
                return Encoding.UTF8.GetString(Base64EncryptBytes);

            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return text;
        }

        public static string MD5Encrypt(this string text, string key = "ESB") 
        {
            //string _salt = "*1234567890!@#$%^&*()14344*";  //คีย์เก่า
            var hashmd5 = new MD5CryptoServiceProvider();
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(text);

            byte[] keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider TripleDesProvider = new TripleDESCryptoServiceProvider();
            TripleDesProvider.Key = keyArray;
            TripleDesProvider.Mode = CipherMode.ECB;
            TripleDesProvider.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = TripleDesProvider.CreateEncryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string MD5Decrypt(this string text, string key = "ESB")
        {
            try
            {
                //string _salt = "*1234567890!@#$%^&*()14344*";  //คีย์เก่า
                var hashmd5 = new MD5CryptoServiceProvider();
                byte[] toEncryptArray = Convert.FromBase64String(text);

                byte[] keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider TripleDesProvider = new TripleDESCryptoServiceProvider();
                TripleDesProvider.Key = keyArray;
                TripleDesProvider.Mode = CipherMode.ECB;
                TripleDesProvider.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = TripleDesProvider.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                TripleDesProvider.Clear();

                return Encoding.UTF8.GetString(resultArray);
                //return Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string PBKDF2Encrypt(this string text, string key = "ESB")
        {
            byte[] salt1 = new byte[8];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt1);
            }

            int myIterations = 1000;
            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(key, salt1, myIterations);

            TripleDES encAlg = TripleDES.Create();
            encAlg.Key = k1.GetBytes(16);

            var encryptionStream = new MemoryStream();
            CryptoStream encrypt = new CryptoStream(encryptionStream, encAlg.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] utfD1 = Encoding.UTF8.GetBytes(text);

            encrypt.Write(utfD1, 0, utfD1.Length);
            encrypt.FlushFinalBlock();
            encrypt.Close();

            byte[] edata1 = encryptionStream.ToArray();
            k1.Reset();

            return $"{System.Convert.ToBase64String(salt1)}|{System.Convert.ToBase64String(encAlg.IV)}|{System.Convert.ToBase64String(edata1)}";
        }

        public static string PBKDF2Decrypt(this string text, string key = "ESB")
        {
            var dText = text.Split('|');
            var salt1 = Convert.FromBase64String(dText[0]);
            var iv = Convert.FromBase64String(dText[1]);
            var edata1 = Convert.FromBase64String(dText[2]);

            Rfc2898DeriveBytes k2 = new Rfc2898DeriveBytes(key, salt1);
            TripleDES decAlg = TripleDES.Create();
            decAlg.Key = k2.GetBytes(16);
            decAlg.IV = iv;
            MemoryStream decryptionStreamBacking = new MemoryStream();
            CryptoStream decrypt = new CryptoStream(decryptionStreamBacking, decAlg.CreateDecryptor(), CryptoStreamMode.Write);
            decrypt.Write(edata1, 0, edata1.Length);
            decrypt.Flush();
            decrypt.Close();
            k2.Reset();

            string data2 = new UTF8Encoding(false).GetString(decryptionStreamBacking.ToArray());
            return data2;
        }

        public static string WebPassEncrypt(this string text)
        {
            ClassPasswordEncryption encPassword = new ClassPasswordEncryption();
            return HttpUtility.UrlEncode(encPassword.Encrypt_Password(text));
        }

        public static string WebPassDecrypt(this string text)
        {
            ClassPasswordEncryption encPassword = new ClassPasswordEncryption();
            return encPassword.Decrypt_Password(text);
        }
    }
}

