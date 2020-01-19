namespace Service_Project
{
    partial class IdentityControlForm
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
            this.mskdTcknn = new System.Windows.Forms.MaskedTextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdTckn = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdDogumYil = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskdTcknn
            // 
            this.mskdTcknn.Location = new System.Drawing.Point(142, 43);
            this.mskdTcknn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskdTcknn.Mask = "00000000000";
            this.mskdTcknn.Name = "mskdTcknn";
            this.mskdTcknn.Size = new System.Drawing.Size(76, 20);
            this.mskdTcknn.TabIndex = 0;
            this.mskdTcknn.ValidatingType = typeof(int);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(142, 78);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(76, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(142, 120);
            this.txtSoyIsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(76, 20);
            this.txtSoyIsim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TcKn";
            // 
            // mskdTckn
            // 
            this.mskdTckn.AutoSize = true;
            this.mskdTckn.Location = new System.Drawing.Point(71, 80);
            this.mskdTckn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mskdTckn.Name = "mskdTckn";
            this.mskdTckn.Size = new System.Drawing.Size(25, 13);
            this.mskdTckn.TabIndex = 4;
            this.mskdTckn.Text = "İsim";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(71, 124);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Soyİsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Yılı";
            // 
            // mskdDogumYil
            // 
            this.mskdDogumYil.Location = new System.Drawing.Point(142, 158);
            this.mskdDogumYil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskdDogumYil.Mask = "0000";
            this.mskdDogumYil.Name = "mskdDogumYil";
            this.mskdDogumYil.Size = new System.Drawing.Size(76, 20);
            this.mskdDogumYil.TabIndex = 7;
            this.mskdDogumYil.ValidatingType = typeof(int);
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(154, 186);
            this.btnDogrula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(63, 25);
            this.btnDogrula.TabIndex = 8;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // IdentityControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 221);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.mskdDogumYil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mskdTckn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.mskdTcknn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IdentityControlForm";
            this.Text = "IdentityControlForm";
            this.Load += new System.EventHandler(this.IdentityControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdTcknn;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mskdTckn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdDogumYil;
        private System.Windows.Forms.Button btnDogrula;
    }
}