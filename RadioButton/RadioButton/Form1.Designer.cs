namespace RadioButton
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
            this.rdBtnAv = new System.Windows.Forms.RadioButton();
            this.rdBtnAb = new System.Windows.Forms.RadioButton();
            this.rdBtnVp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRez = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnAv
            // 
            this.rdBtnAv.AutoSize = true;
            this.rdBtnAv.Location = new System.Drawing.Point(0, 16);
            this.rdBtnAv.Name = "rdBtnAv";
            this.rdBtnAv.Size = new System.Drawing.Size(64, 21);
            this.rdBtnAv.TabIndex = 0;
            this.rdBtnAv.TabStop = true;
            this.rdBtnAv.Text = "Avion";
            this.rdBtnAv.UseVisualStyleBackColor = true;
            // 
            // rdBtnAb
            // 
            this.rdBtnAb.AutoSize = true;
            this.rdBtnAb.Location = new System.Drawing.Point(0, 43);
            this.rdBtnAb.Name = "rdBtnAb";
            this.rdBtnAb.Size = new System.Drawing.Size(81, 21);
            this.rdBtnAb.TabIndex = 1;
            this.rdBtnAb.TabStop = true;
            this.rdBtnAb.Text = "Autobus";
            this.rdBtnAb.UseVisualStyleBackColor = true;
            // 
            // rdBtnVp
            // 
            this.rdBtnVp.AutoSize = true;
            this.rdBtnVp.Location = new System.Drawing.Point(0, 73);
            this.rdBtnVp.Name = "rdBtnVp";
            this.rdBtnVp.Size = new System.Drawing.Size(123, 21);
            this.rdBtnVp.TabIndex = 2;
            this.rdBtnVp.TabStop = true;
            this.rdBtnVp.Text = "Vlastiti prijevoz";
            this.rdBtnVp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnAb);
            this.groupBox1.Controls.Add(this.rdBtnAv);
            this.groupBox1.Controls.Add(this.rdBtnVp);
            this.groupBox1.Location = new System.Drawing.Point(194, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberi vrstu prijevoza";
            // 
            // btnRez
            // 
            this.btnRez.Location = new System.Drawing.Point(218, 229);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(153, 55);
            this.btnRez.TabIndex = 4;
            this.btnRez.Text = "Rezerviraj";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(194, 309);
            this.txtBx.Multiline = true;
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(248, 87);
            this.txtBx.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnAv;
        private System.Windows.Forms.RadioButton rdBtnAb;
        private System.Windows.Forms.RadioButton rdBtnVp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.TextBox txtBx;
    }
}

