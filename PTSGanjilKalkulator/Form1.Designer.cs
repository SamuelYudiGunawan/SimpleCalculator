
namespace PTSKalkuator
{
    partial class Form1
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
            this.txtNilai1 = new System.Windows.Forms.Label();
            this.txtNilai2 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNilai1
            // 
            this.txtNilai1.AutoSize = true;
            this.txtNilai1.Location = new System.Drawing.Point(13, 18);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(47, 17);
            this.txtNilai1.TabIndex = 0;
            this.txtNilai1.Text = "Nilai 1";
            // 
            // txtNilai2
            // 
            this.txtNilai2.AutoSize = true;
            this.txtNilai2.Location = new System.Drawing.Point(13, 46);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(47, 17);
            this.txtNilai2.TabIndex = 1;
            this.txtNilai2.Text = "Nilai 2";
            // 
            // txtHasil
            // 
            this.txtHasil.AutoSize = true;
            this.txtHasil.Location = new System.Drawing.Point(13, 78);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(39, 17);
            this.txtHasil.TabIndex = 2;
            this.txtHasil.Text = "Hasil";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(76, 15);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(162, 22);
            this.txtValue1.TabIndex = 3;
            this.txtValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue1_KeyPress);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(76, 43);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(162, 22);
            this.txtValue2.TabIndex = 4;
            this.txtValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue2_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(76, 76);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(162, 22);
            this.txtResult.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(16, 119);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(40, 40);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(76, 119);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(40, 40);
            this.btnKurang.TabIndex = 7;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(138, 119);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(40, 40);
            this.btnKali.TabIndex = 8;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(198, 119);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(40, 40);
            this.btnBagi.TabIndex = 9;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 240);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtNilai2);
            this.Controls.Add(this.txtNilai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNilai1;
        private System.Windows.Forms.Label txtNilai2;
        private System.Windows.Forms.Label txtHasil;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

