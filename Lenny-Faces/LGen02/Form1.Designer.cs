namespace LGen02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headBool = new System.Windows.Forms.CheckBox();
            this.eyesBool = new System.Windows.Forms.CheckBox();
            this.mouthBool = new System.Windows.Forms.CheckBox();
            this.headBox = new System.Windows.Forms.ComboBox();
            this.eyesBox = new System.Windows.Forms.ComboBox();
            this.mouthBox = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headBool
            // 
            this.headBool.AutoSize = true;
            this.headBool.Checked = true;
            this.headBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headBool.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.headBool.Location = new System.Drawing.Point(309, 68);
            this.headBool.Name = "headBool";
            this.headBool.Size = new System.Drawing.Size(59, 26);
            this.headBool.TabIndex = 0;
            this.headBool.Text = "head";
            this.headBool.UseVisualStyleBackColor = true;
            this.headBool.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // eyesBool
            // 
            this.eyesBool.AutoSize = true;
            this.eyesBool.Checked = true;
            this.eyesBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eyesBool.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.eyesBool.Location = new System.Drawing.Point(308, 127);
            this.eyesBool.Name = "eyesBool";
            this.eyesBool.Size = new System.Drawing.Size(56, 26);
            this.eyesBool.TabIndex = 1;
            this.eyesBool.Text = "eyes";
            this.eyesBool.UseVisualStyleBackColor = true;
            this.eyesBool.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // mouthBool
            // 
            this.mouthBool.AutoSize = true;
            this.mouthBool.Checked = true;
            this.mouthBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mouthBool.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.mouthBool.Location = new System.Drawing.Point(308, 184);
            this.mouthBool.Name = "mouthBool";
            this.mouthBool.Size = new System.Drawing.Size(70, 26);
            this.mouthBool.TabIndex = 2;
            this.mouthBool.Text = "mouth";
            this.mouthBool.UseVisualStyleBackColor = true;
            this.mouthBool.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // headBox
            // 
            this.headBox.AutoCompleteCustomSource.AddRange(new string[] {
            "()b"});
            this.headBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.headBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headBox.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.headBox.FormattingEnabled = true;
            this.headBox.IntegralHeight = false;
            this.headBox.Items.AddRange(new object[] {
            "()",
            "()b",
            "qp",
            "☞☞",
            "¯\\__/¯",
            "\\/",
            "(）╯︵ ┻━┻",
            "()╭∩╮",
            "()⊃━☆ﾟ.*",
            "༼  ༽",
            "[̲̅$̲̅(̲̅)̲̅$̲̅]",
            "─=≡Σᕕ()ᕗ",
            "✺◟()◞✺",
            "()ｂ",
            "╭()و",
            "ε＝┏()┛",
            "｢(「)三",
            "()ψ",
            "==",
            "(☞)☞",
            "(つ)つ",
            "⊂()⊃",
            "〴 〵",
            "へ(へ)",
            "ʕʔ",
            "()=ε/̵͇̿̿/\'̿",
            "┬┴┤)"});
            this.headBox.Location = new System.Drawing.Point(125, 54);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(166, 41);
            this.headBox.TabIndex = 4;
            this.headBox.TextChanged += new System.EventHandler(this.sth_Changed);
            // 
            // eyesBox
            // 
            this.eyesBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.eyesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eyesBox.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.eyesBox.FormattingEnabled = true;
            this.eyesBox.IntegralHeight = false;
            this.eyesBox.Items.AddRange(new object[] {
            " ͡° ͡°",
            "´••`",
            "òó",
            "꘠꘠",
            "◉◉",
            "⚆⚆",
            ">>",
            "TT",
            "^ ^",
            "$ $",
            "σ σ",
            "の の",
            "￢ ￢",
            "▰ ▰",
            "ᗒ ᗕ",
            "⇀ ↼",
            "• •",
            "─ ─",
            " ͡° ^"});
            this.eyesBox.Location = new System.Drawing.Point(125, 116);
            this.eyesBox.Name = "eyesBox";
            this.eyesBox.Size = new System.Drawing.Size(166, 41);
            this.eyesBox.TabIndex = 5;
            this.eyesBox.TextChanged += new System.EventHandler(this.sth_Changed);
            // 
            // mouthBox
            // 
            this.mouthBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mouthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouthBox.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.mouthBox.FormattingEnabled = true;
            this.mouthBox.IntegralHeight = false;
            this.mouthBox.Items.AddRange(new object[] {
            " ͜ʖ",
            "͟ʖ",
            "ʖ̯",
            "ω",
            "Д",
            "෴",
            "ಎ",
            "o",
            "ヘ",
            "ツ",
            "Ꮂ",
            "Ѡ",
            "ᴥ",
            "ᗜ",
            "ᗝ",
            "v",
            "‿",
            "‿‿",
            "╭╮",
            "ε",
            "_",
            "人",
            "▾",
            "∀",
            "~"});
            this.mouthBox.Location = new System.Drawing.Point(125, 173);
            this.mouthBox.Name = "mouthBox";
            this.mouthBox.Size = new System.Drawing.Size(166, 41);
            this.mouthBox.TabIndex = 6;
            this.mouthBox.TextChanged += new System.EventHandler(this.sth_Changed);
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBox.Location = new System.Drawing.Point(64, 247);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(304, 62);
            this.resultBox.TabIndex = 7;
            this.resultBox.Text = "(つ ͡° ͜ʖ ͡°)つ";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultBox.Click += new System.EventHandler(this.resultBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 345);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.mouthBox);
            this.Controls.Add(this.eyesBox);
            this.Controls.Add(this.headBox);
            this.Controls.Add(this.mouthBool);
            this.Controls.Add(this.eyesBool);
            this.Controls.Add(this.headBool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 384);
            this.MinimumSize = new System.Drawing.Size(445, 384);
            this.Name = "Form1";
            this.Text = "LennyFs Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox headBool;
        private System.Windows.Forms.CheckBox eyesBool;
        private System.Windows.Forms.CheckBox mouthBool;
        private System.Windows.Forms.ComboBox headBox;
        private System.Windows.Forms.ComboBox eyesBox;
        private System.Windows.Forms.ComboBox mouthBox;
        private System.Windows.Forms.TextBox resultBox;
    }
}

