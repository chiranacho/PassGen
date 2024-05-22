namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (!checkBoxUppercase.Checked && !checkBoxLowecase.Checked && !checkBoxDigits.Checked && !checkBoxSymbols.Checked)
            {
                labelOptionError.Text = $"Select at least one option!".ToString();
                pwdLabel.Text = string.Empty;
                labelPwdCopied.Text = string.Empty;
            }
            else
            {
                labelPwdCopied.Text = string.Empty;
                labelOptionError.Text = string.Empty;
                GenerateConfig config = getGenerateConfig();
                pwdLabel.Text = PasswordGenHelper.GeneratePassword(config);
            }
        }

        private GenerateConfig getGenerateConfig()
        {
            GenerateConfig config = new GenerateConfig();
            config.Length = trackBar1.Value;
            config.IsLowerCase = checkBoxLowecase.Checked;
            config.IsUpperCase = checkBoxUppercase.Checked;
            config.IsDigits = checkBoxDigits.Checked;
            config.IsSymbols = checkBoxSymbols.Checked;
            return config;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {

            if (pwdLabel.Text == string.Empty && !checkBoxUppercase.Checked && !checkBoxLowecase.Checked && !checkBoxDigits.Checked && !checkBoxSymbols.Checked)
            {
                labelOptionError.Text = $"Select options and generate password before copying it!";
            }
            else if (pwdLabel.Text == string.Empty && (checkBoxUppercase.Checked || checkBoxLowecase.Checked || checkBoxDigits.Checked || checkBoxSymbols.Checked))
            {
                labelOptionError.Text = $"Generate password before copying it!";
            }
            else
            {
                Clipboard.SetText(pwdLabel.Text);
                labelPwdCopied.Text = $"Password Copied!".ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrackbarValue.Text = trackBar1.Value.ToString();
        }

        private void labelOptionError_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxLowecase_CheckedChanged(object sender, EventArgs e)
        {
            labelOptionError.Text = string.Empty;
        }

        private void checkBoxUppercase_CheckedChanged(object sender, EventArgs e)
        {
            labelOptionError.Text = string.Empty;
        }

        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e)
        {
            labelOptionError.Text = string.Empty;
        }

        private void checkBoxSymbols_CheckedChanged(object sender, EventArgs e)
        {
            labelOptionError.Text = string.Empty;
        }
    }
}
