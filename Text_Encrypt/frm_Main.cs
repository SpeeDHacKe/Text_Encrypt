using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;
using WebPasswordEncryption;

namespace Text_Encrypt
{
    public partial class frm_Main : Form
    {
        enum EncryptType { Base64 = 1, MD5 = 2, PBKDF2 = 3, WebPassword = 4 }
        EncryptType encryptType;
       
        public frm_Main()
        {
            InitializeComponent();
        }

        private void rdo_Base64_CheckedChanged(object sender, EventArgs e)
        {
            encryptType = EncryptType.Base64;
            lbl_Encrypt.Text = "Base64 Encrypt :";
            lbl_Decrypt.Text = "Base64 Decrypt :";
        }

        private void rdo_MD5_CheckedChanged(object sender, EventArgs e)
        {
            encryptType = EncryptType.MD5;
            lbl_Encrypt.Text = "MD5 Encrypt :";
            lbl_Decrypt.Text = "MD5 Decrypt :";
        }

        private void rdo_PBKDF2_CheckedChanged(object sender, EventArgs e)
        {
            encryptType = EncryptType.PBKDF2;
            lbl_Encrypt.Text = "PBKDF2 Encrypt :";
            lbl_Decrypt.Text = "PBKDF2 Decrypt :";
        }

        private void rdo_WebPassword_CheckedChanged(object sender, EventArgs e)
        {
            encryptType = EncryptType.WebPassword;
            lbl_Encrypt.Text = "WebPassword Encrypt :";
            lbl_Decrypt.Text = "WebPassword Decrypt :";
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (encryptType)
            {
                case EncryptType.Base64:
                    encryptType = EncryptType.Base64;
                    result = txt_inputEncrypt.Text.Base64Encrypt();
                    break;
                case EncryptType.MD5:
                    encryptType = EncryptType.MD5;
                    result = txt_inputEncrypt.Text.MD5Encrypt();
                    //result = Encrypt(txt_inputEncrypt.Text);
                    break;
                case EncryptType.PBKDF2:
                    encryptType = EncryptType.PBKDF2;
                    result = txt_inputEncrypt.Text.PBKDF2Encrypt();
                    break;
                case EncryptType.WebPassword:
                    encryptType = EncryptType.WebPassword;
                    //result = txt_inputEncrypt.Text.WebPassEncrypt();
                    ClassPasswordEncryption encPassword = new ClassPasswordEncryption();
                    //result = HttpUtility.UrlEncode(encPassword.Encrypt_Password((string)txt_inputEncrypt.Text));
                    result = encPassword.Encrypt_Password((string)txt_inputEncrypt.Text);
                    break;
                default:
                    encryptType = EncryptType.Base64;
                    result = txt_inputEncrypt.Text.Base64Encrypt();
                    break;
            }

            txt_outputEncrypt.Text = result;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (encryptType)
            {
                case EncryptType.Base64:
                    encryptType = EncryptType.Base64;
                    result = txt_inputDecrypt.Text.Base64Decrypt();
                    break;
                case EncryptType.MD5:
                    encryptType = EncryptType.MD5;
                    result = txt_inputDecrypt.Text.MD5Decrypt();
                    //result = Decrypt(txt_inputDecrypt.Text);
                    break;
                case EncryptType.PBKDF2:
                    encryptType = EncryptType.PBKDF2;
                    result = txt_inputDecrypt.Text.PBKDF2Decrypt();
                    break;
                case EncryptType.WebPassword:
                    encryptType = EncryptType.WebPassword;
                    ClassPasswordEncryption encPassword = new ClassPasswordEncryption();
                    //result = txt_inputDecrypt.Text.WebPassDecrypt();
                    result = HttpUtility.UrlDecode(encPassword.Decrypt_Password(txt_inputDecrypt.Text));
                    //result = encPassword.Decrypt_Password((string)txt_inputDecrypt.Text);
                    break;
                default:
                    encryptType = EncryptType.Base64;
                    result = txt_inputDecrypt.Text.Base64Decrypt();
                    break;
            }

            txt_outputDecrypt.Text = result;
        }

        public static string Encrypt(string text, string key = null)
        {
            var data = Encoding.UTF8.GetBytes(text);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
                using (var tripDes = new TripleDESCryptoServiceProvider { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var transform = tripDes.CreateEncryptor();
                    var results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string Decrypt(string cipher, string key = null)
        {
            var data = Convert.FromBase64String(cipher);
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(key));

                using (var tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    var transform = tripDes.CreateDecryptor();
                    var results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}

