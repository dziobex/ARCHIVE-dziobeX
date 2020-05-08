namespace Converter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dec = new System.Windows.Forms.TextBox();
            this.bin = new System.Windows.Forms.TextBox();
            this.hex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.WarningOct = new System.Windows.Forms.Label();
            this.WarningHex = new System.Windows.Forms.Label();
            this.WarningBin = new System.Windows.Forms.Label();
            this.WarningDec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dec.Location = new System.Drawing.Point(44, 98);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(379, 29);
            this.dec.TabIndex = 0;
            this.dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dec.TextChanged += new System.EventHandler(this.dec_TextChanged);
            this.dec.Enter += new System.EventHandler(this.dec_Enter);
            // 
            // bin
            // 
            this.bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bin.Location = new System.Drawing.Point(44, 171);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(379, 29);
            this.bin.TabIndex = 1;
            this.bin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bin.TextChanged += new System.EventHandler(this.bin_TextChanged);
            this.bin.Enter += new System.EventHandler(this.bin_Enter);
            // 
            // hex
            // 
            this.hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hex.Location = new System.Drawing.Point(44, 250);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(379, 29);
            this.hex.TabIndex = 2;
            this.hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hex.TextChanged += new System.EventHandler(this.hex_TextChanged);
            this.hex.Enter += new System.EventHandler(this.hex_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(388, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "dec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(393, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "bin";
            // 
            // oct
            // 
            this.oct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oct.Location = new System.Drawing.Point(44, 336);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(379, 29);
            this.oct.TabIndex = 5;
            this.oct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oct.TextChanged += new System.EventHandler(this.oct_TextChanged);
            this.oct.Enter += new System.EventHandler(this.oct_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(393, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "hex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(393, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "oct";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(308, 384);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 47);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear all";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // WarningOct
            // 
            this.WarningOct.AutoSize = true;
            this.WarningOct.BackColor = System.Drawing.SystemColors.Window;
            this.WarningOct.ForeColor = System.Drawing.Color.Red;
            this.WarningOct.Location = new System.Drawing.Point(50, 345);
            this.WarningOct.Name = "WarningOct";
            this.WarningOct.Size = new System.Drawing.Size(0, 13);
            this.WarningOct.TabIndex = 9;
            // 
            // WarningHex
            // 
            this.WarningHex.AutoSize = true;
            this.WarningHex.BackColor = System.Drawing.SystemColors.Window;
            this.WarningHex.ForeColor = System.Drawing.Color.Red;
            this.WarningHex.Location = new System.Drawing.Point(50, 261);
            this.WarningHex.Name = "WarningHex";
            this.WarningHex.Size = new System.Drawing.Size(0, 13);
            this.WarningHex.TabIndex = 10;
            // 
            // WarningBin
            // 
            this.WarningBin.AutoSize = true;
            this.WarningBin.BackColor = System.Drawing.SystemColors.Window;
            this.WarningBin.ForeColor = System.Drawing.Color.Red;
            this.WarningBin.Location = new System.Drawing.Point(50, 182);
            this.WarningBin.Name = "WarningBin";
            this.WarningBin.Size = new System.Drawing.Size(0, 13);
            this.WarningBin.TabIndex = 11;
            // 
            // WarningDec
            // 
            this.WarningDec.AutoSize = true;
            this.WarningDec.BackColor = System.Drawing.SystemColors.Window;
            this.WarningDec.ForeColor = System.Drawing.Color.Red;
            this.WarningDec.Location = new System.Drawing.Point(50, 109);
            this.WarningDec.Name = "WarningDec";
            this.WarningDec.Size = new System.Drawing.Size(0, 13);
            this.WarningDec.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 443);
            this.Controls.Add(this.WarningDec);
            this.Controls.Add(this.WarningBin);
            this.Controls.Add(this.WarningHex);
            this.Controls.Add(this.WarningOct);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.dec);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dec;
        private System.Windows.Forms.TextBox bin;
        private System.Windows.Forms.TextBox hex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label WarningOct;
        private System.Windows.Forms.Label WarningHex;
        private System.Windows.Forms.Label WarningBin;
        private System.Windows.Forms.Label WarningDec;
    }
}

