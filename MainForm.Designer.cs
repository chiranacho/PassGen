namespace PasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer btn_generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_generate = new Button();
            btn_copy = new Button();
            pwdLabel = new Label();
            groupBoxOptions = new GroupBox();
            labelOptionError = new Label();
            labelTrackbarValue = new Label();
            checkBoxSymbols = new CheckBox();
            checkBoxDigits = new CheckBox();
            checkBoxUppercase = new CheckBox();
            checkBoxLowecase = new CheckBox();
            trackBar1 = new TrackBar();
            labelAppName = new Label();
            labelAuthor = new Label();
            labelPwdCopied = new Label();
            groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btn_generate
            // 
            btn_generate.Location = new Point(453, 36);
            btn_generate.Name = "btn_generate";
            btn_generate.Size = new Size(112, 34);
            btn_generate.TabIndex = 0;
            btn_generate.Text = "Generate";
            btn_generate.UseVisualStyleBackColor = true;
            btn_generate.Click += btn_generate_Click;
            // 
            // btn_copy
            // 
            btn_copy.Location = new Point(571, 36);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(112, 34);
            btn_copy.TabIndex = 1;
            btn_copy.Text = "Copy";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // pwdLabel
            // 
            pwdLabel.BorderStyle = BorderStyle.FixedSingle;
            pwdLabel.Font = new Font("Segoe UI", 14F);
            pwdLabel.Location = new Point(22, 27);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(425, 53);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "Your password will show here!";
            pwdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(labelOptionError);
            groupBoxOptions.Controls.Add(labelTrackbarValue);
            groupBoxOptions.Controls.Add(checkBoxSymbols);
            groupBoxOptions.Controls.Add(checkBoxDigits);
            groupBoxOptions.Controls.Add(checkBoxUppercase);
            groupBoxOptions.Controls.Add(checkBoxLowecase);
            groupBoxOptions.Controls.Add(trackBar1);
            groupBoxOptions.Location = new Point(22, 103);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(661, 189);
            groupBoxOptions.TabIndex = 3;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            groupBoxOptions.Enter += groupBox1_Enter;
            // 
            // labelOptionError
            // 
            labelOptionError.AutoSize = true;
            labelOptionError.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOptionError.ForeColor = Color.Red;
            labelOptionError.Location = new Point(48, 164);
            labelOptionError.Name = "labelOptionError";
            labelOptionError.Size = new Size(0, 21);
            labelOptionError.TabIndex = 9;
            labelOptionError.TextAlign = ContentAlignment.MiddleCenter;
            labelOptionError.Click += labelOptionError_Click;
            // 
            // labelTrackbarValue
            // 
            labelTrackbarValue.AutoSize = true;
            labelTrackbarValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTrackbarValue.Location = new Point(581, 39);
            labelTrackbarValue.Name = "labelTrackbarValue";
            labelTrackbarValue.Size = new Size(26, 30);
            labelTrackbarValue.TabIndex = 5;
            labelTrackbarValue.Text = "8";
            labelTrackbarValue.Click += label1_Click;
            // 
            // checkBoxSymbols
            // 
            checkBoxSymbols.AutoSize = true;
            checkBoxSymbols.Location = new Point(498, 121);
            checkBoxSymbols.Name = "checkBoxSymbols";
            checkBoxSymbols.Size = new Size(106, 29);
            checkBoxSymbols.TabIndex = 4;
            checkBoxSymbols.Text = "Symbols";
            checkBoxSymbols.UseVisualStyleBackColor = true;
            checkBoxSymbols.CheckedChanged += checkBoxSymbols_CheckedChanged;
            // 
            // checkBoxDigits
            // 
            checkBoxDigits.AutoSize = true;
            checkBoxDigits.Location = new Point(370, 121);
            checkBoxDigits.Name = "checkBoxDigits";
            checkBoxDigits.Size = new Size(84, 29);
            checkBoxDigits.TabIndex = 3;
            checkBoxDigits.Text = "Digits";
            checkBoxDigits.UseVisualStyleBackColor = true;
            checkBoxDigits.CheckedChanged += checkBoxDigits_CheckedChanged;
            // 
            // checkBoxUppercase
            // 
            checkBoxUppercase.AutoSize = true;
            checkBoxUppercase.Checked = true;
            checkBoxUppercase.CheckState = CheckState.Checked;
            checkBoxUppercase.Location = new Point(204, 121);
            checkBoxUppercase.Name = "checkBoxUppercase";
            checkBoxUppercase.Size = new Size(121, 29);
            checkBoxUppercase.TabIndex = 2;
            checkBoxUppercase.Text = "Uppercase";
            checkBoxUppercase.UseVisualStyleBackColor = true;
            checkBoxUppercase.CheckedChanged += checkBoxUppercase_CheckedChanged;
            // 
            // checkBoxLowecase
            // 
            checkBoxLowecase.AutoSize = true;
            checkBoxLowecase.Checked = true;
            checkBoxLowecase.CheckState = CheckState.Checked;
            checkBoxLowecase.Location = new Point(55, 121);
            checkBoxLowecase.Name = "checkBoxLowecase";
            checkBoxLowecase.Size = new Size(119, 29);
            checkBoxLowecase.TabIndex = 1;
            checkBoxLowecase.Text = "Lowercase";
            checkBoxLowecase.UseVisualStyleBackColor = true;
            checkBoxLowecase.CheckedChanged += checkBoxLowecase_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 2;
            trackBar1.Location = new Point(48, 39);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 8;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(526, 69);
            trackBar1.TabIndex = 8;
            trackBar1.Value = 8;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAppName.Location = new Point(22, 295);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(95, 21);
            labelAppName.TabIndex = 4;
            labelAppName.Text = "PassGen v1.0";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAuthor.Location = new Point(533, 295);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(150, 21);
            labelAuthor.TabIndex = 5;
            labelAuthor.Text = "Author: Daniel Balezi";
            // 
            // labelPwdCopied
            // 
            labelPwdCopied.AutoSize = true;
            labelPwdCopied.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPwdCopied.ForeColor = Color.DarkGreen;
            labelPwdCopied.Location = new Point(499, 79);
            labelPwdCopied.Name = "labelPwdCopied";
            labelPwdCopied.Size = new Size(0, 21);
            labelPwdCopied.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 319);
            Controls.Add(labelPwdCopied);
            Controls.Add(labelAuthor);
            Controls.Add(labelAppName);
            Controls.Add(groupBoxOptions);
            Controls.Add(pwdLabel);
            Controls.Add(btn_copy);
            Controls.Add(btn_generate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "PassGen v1.0";
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_generate;
        private Button btn_copy;
        private Label pwdLabel;
        private GroupBox groupBoxOptions;
        private TrackBar trackBar1;
        private CheckBox checkBoxSymbols;
        private CheckBox checkBoxDigits;
        private CheckBox checkBoxUppercase;
        private CheckBox checkBoxLowecase;
        private Label labelTrackbarValue;
        private Label labelAppName;
        private Label labelAuthor;
        private Label labelPwdCopied;
        private Label labelOptionError;
    }
}
