namespace Base64_Encrypt
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
            this.lbl_Encrypt = new System.Windows.Forms.Label();
            this.lbl_Decrypt = new System.Windows.Forms.Label();
            this.txt_inputEncode = new System.Windows.Forms.TextBox();
            this.txt_outputEncode = new System.Windows.Forms.TextBox();
            this.txt_outputDecode = new System.Windows.Forms.TextBox();
            this.txt_inputDecode = new System.Windows.Forms.TextBox();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Base64 = new System.Windows.Forms.RadioButton();
            this.rdo_PBKDF2 = new System.Windows.Forms.RadioButton();
            this.rdo_WebPassword = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Encrypt
            // 
            this.lbl_Encrypt.AutoSize = true;
            this.lbl_Encrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Encrypt.Location = new System.Drawing.Point(12, 115);
            this.lbl_Encrypt.Name = "lbl_Encrypt";
            this.lbl_Encrypt.Size = new System.Drawing.Size(71, 17);
            this.lbl_Encrypt.TabIndex = 0;
            this.lbl_Encrypt.Text = "Encrypt :";
            // 
            // lbl_Decrypt
            // 
            this.lbl_Decrypt.AutoSize = true;
            this.lbl_Decrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Decrypt.Location = new System.Drawing.Point(12, 366);
            this.lbl_Decrypt.Name = "lbl_Decrypt";
            this.lbl_Decrypt.Size = new System.Drawing.Size(71, 17);
            this.lbl_Decrypt.TabIndex = 0;
            this.lbl_Decrypt.Text = "Decrypt :";
            // 
            // txt_inputEncode
            // 
            this.txt_inputEncode.Location = new System.Drawing.Point(16, 139);
            this.txt_inputEncode.Multiline = true;
            this.txt_inputEncode.Name = "txt_inputEncode";
            this.txt_inputEncode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_inputEncode.Size = new System.Drawing.Size(369, 169);
            this.txt_inputEncode.TabIndex = 1;
            // 
            // txt_outputEncode
            // 
            this.txt_outputEncode.Location = new System.Drawing.Point(435, 139);
            this.txt_outputEncode.Multiline = true;
            this.txt_outputEncode.Name = "txt_outputEncode";
            this.txt_outputEncode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_outputEncode.Size = new System.Drawing.Size(369, 169);
            this.txt_outputEncode.TabIndex = 3;
            // 
            // txt_outputDecode
            // 
            this.txt_outputDecode.Location = new System.Drawing.Point(435, 390);
            this.txt_outputDecode.Multiline = true;
            this.txt_outputDecode.Name = "txt_outputDecode";
            this.txt_outputDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_outputDecode.Size = new System.Drawing.Size(369, 169);
            this.txt_outputDecode.TabIndex = 6;
            // 
            // txt_inputDecode
            // 
            this.txt_inputDecode.Location = new System.Drawing.Point(16, 390);
            this.txt_inputDecode.Multiline = true;
            this.txt_inputDecode.Name = "txt_inputDecode";
            this.txt_inputDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_inputDecode.Size = new System.Drawing.Size(369, 169);
            this.txt_inputDecode.TabIndex = 4;
            // 
            // btn_Encode
            // 
            this.btn_Encode.Location = new System.Drawing.Point(388, 138);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(44, 171);
            this.btn_Encode.TabIndex = 7;
            this.btn_Encode.Text = "=>";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // btn_Decode
            // 
            this.btn_Decode.Location = new System.Drawing.Point(388, 389);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(44, 171);
            this.btn_Decode.TabIndex = 8;
            this.btn_Decode.Text = "=>";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.btn_Decode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_WebPassword);
            this.groupBox1.Controls.Add(this.rdo_PBKDF2);
            this.groupBox1.Controls.Add(this.rdo_Base64);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(16, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt Type";
            // 
            // rdo_Base64
            // 
            this.rdo_Base64.AutoSize = true;
            this.rdo_Base64.Checked = true;
            this.rdo_Base64.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_Base64.Location = new System.Drawing.Point(30, 30);
            this.rdo_Base64.Name = "rdo_Base64";
            this.rdo_Base64.Size = new System.Drawing.Size(67, 20);
            this.rdo_Base64.TabIndex = 0;
            this.rdo_Base64.TabStop = true;
            this.rdo_Base64.Text = "Base64";
            this.rdo_Base64.UseVisualStyleBackColor = true;
            this.rdo_Base64.CheckedChanged += new System.EventHandler(this.rdo_Base64_CheckedChanged);
            // 
            // rdo_PBKDF2
            // 
            this.rdo_PBKDF2.AutoSize = true;
            this.rdo_PBKDF2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_PBKDF2.Location = new System.Drawing.Point(282, 30);
            this.rdo_PBKDF2.Name = "rdo_PBKDF2";
            this.rdo_PBKDF2.Size = new System.Drawing.Size(69, 20);
            this.rdo_PBKDF2.TabIndex = 1;
            this.rdo_PBKDF2.Text = "PBKDF2";
            this.rdo_PBKDF2.UseVisualStyleBackColor = true;
            this.rdo_PBKDF2.CheckedChanged += new System.EventHandler(this.rdo_PBKDF2_CheckedChanged);
            // 
            // rdo_WebPassword
            // 
            this.rdo_WebPassword.AutoSize = true;
            this.rdo_WebPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdo_WebPassword.Location = new System.Drawing.Point(515, 30);
            this.rdo_WebPassword.Name = "rdo_WebPassword";
            this.rdo_WebPassword.Size = new System.Drawing.Size(107, 20);
            this.rdo_WebPassword.TabIndex = 2;
            this.rdo_WebPassword.Text = "WebPassword";
            this.rdo_WebPassword.UseVisualStyleBackColor = true;
            this.rdo_WebPassword.CheckedChanged += new System.EventHandler(this.rdo_WebPassword_CheckedChanged);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Decode);
            this.Controls.Add(this.btn_Encode);
            this.Controls.Add(this.txt_outputDecode);
            this.Controls.Add(this.txt_inputDecode);
            this.Controls.Add(this.txt_outputEncode);
            this.Controls.Add(this.txt_inputEncode);
            this.Controls.Add(this.lbl_Decrypt);
            this.Controls.Add(this.lbl_Encrypt);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

        private System.Windows.Forms.Label lbl_Encrypt;
        private System.Windows.Forms.Label lbl_Decrypt;
        private System.Windows.Forms.TextBox txt_inputEncode;
        private System.Windows.Forms.TextBox txt_outputEncode;
        private System.Windows.Forms.TextBox txt_outputDecode;
        private System.Windows.Forms.TextBox txt_inputDecode;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_WebPassword;
        private System.Windows.Forms.RadioButton rdo_PBKDF2;
        private System.Windows.Forms.RadioButton rdo_Base64;
    }
}

