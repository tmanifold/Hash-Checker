namespace Hash_Checker
{
    partial class frmHashChekerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashTextBox = new System.Windows.Forms.TextBox();
            this.btnCheckHashButton = new System.Windows.Forms.Button();
            this.txtHashCheckTextBox = new System.Windows.Forms.TextBox();
            this.btnBrowseButton = new System.Windows.Forms.Button();
            this.txtFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHashTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hash";
            // 
            // txtHashTextBox
            // 
            this.txtHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHashTextBox.Location = new System.Drawing.Point(27, 134);
            this.txtHashTextBox.Multiline = true;
            this.txtHashTextBox.Name = "txtHashTextBox";
            this.txtHashTextBox.ReadOnly = true;
            this.txtHashTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHashTextBox.Size = new System.Drawing.Size(445, 52);
            this.txtHashTextBox.TabIndex = 3;
            this.txtHashTextBox.TabStop = false;
            this.txtHashTextBox.TextChanged += new System.EventHandler(this.txtHashTextBox_TextChanged);
            // 
            // btnCheckHashButton
            // 
            this.btnCheckHashButton.Location = new System.Drawing.Point(483, 163);
            this.btnCheckHashButton.Name = "btnCheckHashButton";
            this.btnCheckHashButton.Size = new System.Drawing.Size(87, 23);
            this.btnCheckHashButton.TabIndex = 7;
            this.btnCheckHashButton.Text = "Check";
            this.btnCheckHashButton.UseVisualStyleBackColor = true;
            this.btnCheckHashButton.Click += new System.EventHandler(this.btnCheckHashButton_Click);
            // 
            // txtHashCheckTextBox
            // 
            this.txtHashCheckTextBox.Location = new System.Drawing.Point(27, 108);
            this.txtHashCheckTextBox.Name = "txtHashCheckTextBox";
            this.txtHashCheckTextBox.Size = new System.Drawing.Size(445, 20);
            this.txtHashCheckTextBox.TabIndex = 8;
            // 
            // btnBrowseButton
            // 
            this.btnBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseButton.Location = new System.Drawing.Point(483, 35);
            this.btnBrowseButton.Name = "btnBrowseButton";
            this.btnBrowseButton.Size = new System.Drawing.Size(87, 23);
            this.btnBrowseButton.TabIndex = 4;
            this.btnBrowseButton.Text = "...";
            this.btnBrowseButton.UseVisualStyleBackColor = true;
            this.btnBrowseButton.Click += new System.EventHandler(this.btnBrowseButton_Click);
            // 
            // txtFileTextBox
            // 
            this.txtFileTextBox.Location = new System.Drawing.Point(27, 37);
            this.txtFileTextBox.Name = "txtFileTextBox";
            this.txtFileTextBox.Size = new System.Drawing.Size(445, 20);
            this.txtFileTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // cmbHashTypeComboBox
            // 
            this.cmbHashTypeComboBox.FormattingEnabled = true;
            this.cmbHashTypeComboBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "RIPEMD160"});
            this.cmbHashTypeComboBox.Location = new System.Drawing.Point(483, 108);
            this.cmbHashTypeComboBox.Name = "cmbHashTypeComboBox";
            this.cmbHashTypeComboBox.Size = new System.Drawing.Size(87, 21);
            this.cmbHashTypeComboBox.TabIndex = 5;
            // 
            // frmHashChekerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHashTypeComboBox);
            this.Controls.Add(this.txtFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseButton);
            this.Controls.Add(this.txtHashCheckTextBox);
            this.Controls.Add(this.btnCheckHashButton);
            this.Controls.Add(this.txtHashTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHashChekerForm";
            this.Text = "Hash Checker";
            this.Load += new System.EventHandler(this.frmHashChekerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHashTextBox;
        private System.Windows.Forms.Button btnCheckHashButton;
        private System.Windows.Forms.TextBox txtHashCheckTextBox;
        private System.Windows.Forms.Button btnBrowseButton;
        private System.Windows.Forms.TextBox txtFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHashTypeComboBox;
    }
}

