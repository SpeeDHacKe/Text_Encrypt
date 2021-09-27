using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64_Encrypt
{
    public partial class frm_Main : Form
    {
        EncryptType encryptType;
        enum EncryptType { Base64 = 1, PBKDF2 = 2, WebPassword = 3 }
        public frm_Main()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string value)
        {
            var paintTextBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(paintTextBytes);
        }

        public static string Base64Decode(string value)
        {
            try
            {
                var Base64EncodeBytes = Convert.FromBase64String(value);
                return Encoding.UTF8.GetString(Base64EncodeBytes);

            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return value;
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (encryptType)
            {
                case EncryptType.Base64:
                    encryptType = EncryptType.Base64;
                    result = Base64Encode(txt_inputEncode.Text);
                    break;
                case EncryptType.PBKDF2:
                    encryptType = EncryptType.PBKDF2;
                    break;
                case EncryptType.WebPassword:
                    encryptType = EncryptType.WebPassword;
                    break;
                default:
                    encryptType = EncryptType.Base64;
                    result = Base64Encode(txt_inputEncode.Text);
                    break;
            }

            txt_outputEncode.Text = result;
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            txt_outputDecode.Text = Base64Decode(txt_inputDecode.Text);
        }

        private void rdo_Base64_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Encrypt.Text = "Base64 Encrypt :";
            lbl_Decrypt.Text = "Base64 Decrypt :";
        }

        private void rdo_PBKDF2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Encrypt.Text = "PBKDF2 Encrypt :";
            lbl_Decrypt.Text = "PBKDF2 Decrypt :";
        }

        private void rdo_WebPassword_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Encrypt.Text = "WebPassword Encrypt :";
            lbl_Decrypt.Text = "WebPassword Decrypt :";
        }
    }
}
