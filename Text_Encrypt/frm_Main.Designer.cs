
namespace Text_Encrypt
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_WebPassword = new System.Windows.Forms.RadioButton();
            this.rdo_PBKDF2 = new System.Windows.Forms.RadioButton();
            this.rdo_Base64 = new System.Windows.Forms.RadioButton();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_outputDecrypt = new System.Windows.Forms.TextBox();
            this.txt_inputDecrypt = new System.Windows.Forms.TextBox();
            this.txt_outputEncrypt = new System.Windows.Forms.TextBox();
            this.txt_inputEncrypt = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt = new System.Windows.Forms.Label();
            this.lbl_Encrypt = new System.Windows.Forms.Label();
            this.rdo_MD5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_MD5);
            this.groupBox1.Controls.Add(this.rdo_WebPassword);
            this.groupBox1.Controls.Add(this.rdo_PBKDF2);
            this.groupBox1.Controls.Add(this.rdo_Base64);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 68);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt Type";
            // 
            // rdo_WebPassword
            // 
            this.rdo_WebPassword.AutoSize = true;
            this.rdo_WebPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_WebPassword.Location = new System.Drawing.Point(652, 30);
            this.rdo_WebPassword.Name = "rdo_WebPassword";
            this.rdo_WebPassword.Size = new System.Drawing.Size(106, 20);
            this.rdo_WebPassword.TabIndex = 3;
            this.rdo_WebPassword.Text = "WebPassword";
            this.rdo_WebPassword.UseVisualStyleBackColor = true;
            this.rdo_WebPassword.CheckedChanged += new System.EventHandler(this.rdo_WebPassword_CheckedChanged);
            // 
            // rdo_PBKDF2
            // 
            this.rdo_PBKDF2.AutoSize = true;
            this.rdo_PBKDF2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_PBKDF2.Location = new System.Drawing.Point(438, 30);
            this.rdo_PBKDF2.Name = "rdo_PBKDF2";
            this.rdo_PBKDF2.Size = new System.Drawing.Size(68, 20);
            this.rdo_PBKDF2.TabIndex = 2;
            this.rdo_PBKDF2.Text = "PBKDF2";
            this.rdo_PBKDF2.UseVisualStyleBackColor = true;
            this.rdo_PBKDF2.CheckedChanged += new System.EventHandler(this.rdo_PBKDF2_CheckedChanged);
            // 
            // rdo_Base64
            // 
            this.rdo_Base64.AutoSize = true;
            this.rdo_Base64.Checked = true;
            this.rdo_Base64.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_Base64.Location = new System.Drawing.Point(30, 30);
            this.rdo_Base64.Name = "rdo_Base64";
            this.rdo_Base64.Size = new System.Drawing.Size(66, 20);
            this.rdo_Base64.TabIndex = 0;
            this.rdo_Base64.Text = "Base64";
            this.rdo_Base64.UseVisualStyleBackColor = true;
            this.rdo_Base64.CheckedChanged += new System.EventHandler(this.rdo_Base64_CheckedChanged);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(388, 384);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(44, 171);
            this.btn_Decrypt.TabIndex = 17;
            this.btn_Decrypt.Text = "=>";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(388, 133);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(44, 171);
            this.btn_Encrypt.TabIndex = 16;
            this.btn_Encrypt.Text = "=>";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txt_outputDecrypt
            // 
            this.txt_outputDecrypt.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txt_outputDecrypt.Location = new System.Drawing.Point(435, 385);
            this.txt_outputDecrypt.Multiline = true;
            this.txt_outputDecrypt.Name = "txt_outputDecrypt";
            this.txt_outputDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_outputDecrypt.Size = new System.Drawing.Size(369, 169);
            this.txt_outputDecrypt.TabIndex = 15;
            // 
            // txt_inputDecrypt
            // 
            this.txt_inputDecrypt.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txt_inputDecrypt.Location = new System.Drawing.Point(16, 385);
            this.txt_inputDecrypt.Multiline = true;
            this.txt_inputDecrypt.Name = "txt_inputDecrypt";
            this.txt_inputDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_inputDecrypt.Size = new System.Drawing.Size(369, 169);
            this.txt_inputDecrypt.TabIndex = 14;
            // 
            // txt_outputEncrypt
            // 
            this.txt_outputEncrypt.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txt_outputEncrypt.Location = new System.Drawing.Point(435, 134);
            this.txt_outputEncrypt.Multiline = true;
            this.txt_outputEncrypt.Name = "txt_outputEncrypt";
            this.txt_outputEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_outputEncrypt.Size = new System.Drawing.Size(369, 169);
            this.txt_outputEncrypt.TabIndex = 13;
            // 
            // txt_inputEncrypt
            // 
            this.txt_inputEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_inputEncrypt.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txt_inputEncrypt.Location = new System.Drawing.Point(16, 134);
            this.txt_inputEncrypt.Multiline = true;
            this.txt_inputEncrypt.Name = "txt_inputEncrypt";
            this.txt_inputEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_inputEncrypt.Size = new System.Drawing.Size(369, 169);
            this.txt_inputEncrypt.TabIndex = 12;
            // 
            // lbl_Decrypt
            // 
            this.lbl_Decrypt.AutoSize = true;
            this.lbl_Decrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Decrypt.Location = new System.Drawing.Point(12, 361);
            this.lbl_Decrypt.Name = "lbl_Decrypt";
            this.lbl_Decrypt.Size = new System.Drawing.Size(71, 17);
            this.lbl_Decrypt.TabIndex = 10;
            this.lbl_Decrypt.Text = "Decrypt :";
            // 
            // lbl_Encrypt
            // 
            this.lbl_Encrypt.AutoSize = true;
            this.lbl_Encrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Encrypt.Location = new System.Drawing.Point(12, 110);
            this.lbl_Encrypt.Name = "lbl_Encrypt";
            this.lbl_Encrypt.Size = new System.Drawing.Size(71, 17);
            this.lbl_Encrypt.TabIndex = 11;
            this.lbl_Encrypt.Text = "Encrypt :";
            // 
            // rdo_MD5
            // 
            this.rdo_MD5.AutoSize = true;
            this.rdo_MD5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_MD5.Location = new System.Drawing.Point(234, 30);
            this.rdo_MD5.Name = "rdo_MD5";
            this.rdo_MD5.Size = new System.Drawing.Size(50, 20);
            this.rdo_MD5.TabIndex = 1;
            this.rdo_MD5.Text = "MD5";
            this.rdo_MD5.UseVisualStyleBackColor = true;
            this.rdo_MD5.CheckedChanged += new System.EventHandler(this.rdo_MD5_CheckedChanged);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txt_outputDecrypt);
            this.Controls.Add(this.txt_inputDecrypt);
            this.Controls.Add(this.txt_outputEncrypt);
            this.Controls.Add(this.txt_inputEncrypt);
            this.Controls.Add(this.lbl_Decrypt);
            this.Controls.Add(this.lbl_Encrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_WebPassword;
        private System.Windows.Forms.RadioButton rdo_PBKDF2;
        private System.Windows.Forms.RadioButton rdo_Base64;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_outputDecrypt;
        private System.Windows.Forms.TextBox txt_inputDecrypt;
        private System.Windows.Forms.TextBox txt_outputEncrypt;
        private System.Windows.Forms.TextBox txt_inputEncrypt;
        private System.Windows.Forms.Label lbl_Decrypt;
        private System.Windows.Forms.Label lbl_Encrypt;
        private System.Windows.Forms.RadioButton rdo_MD5;
    }
}

