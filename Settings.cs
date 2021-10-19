using System;
using System.Configuration;
using System.Windows.Forms;

namespace PiBox
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void StoreValues()
		{
			try
			{
				if (!string.IsNullOrEmpty(textAccess.Text) && !string.IsNullOrEmpty(textBucket.Text) && !string.IsNullOrEmpty(textSecret.Text) && !string.IsNullOrEmpty(textProfile.Text))
				{
					Setconfig.UpdateAppSettings("AWSProfileName", textProfile.Text);
					Setconfig.UpdateAppSettings("AWSAccessKey", textAccess.Text);
					Setconfig.UpdateAppSettings("AWSSecretKey", textSecret.Text);
					Properties.Settings.Default.bucket = textBucket.Text;
					Properties.Settings.Default.Save();
					MessageBox.Show("Restart the software for the changes to take effect.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}catch(Exception x)
			{
				MessageBox.Show(x.Message, "Error 33", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			StoreValues();
			Close();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			ShowValues();
		}
		private void ShowValues()
		{
			try
			{
				textProfile.Text = ConfigurationManager.AppSettings.Get("AWSProfileName");
				textAccess.Text = ConfigurationManager.AppSettings.Get("AWSAccessKey");
				textSecret.Text = ConfigurationManager.AppSettings.Get("AWSSecretKey");
				textBucket.Text = Properties.Settings.Default.bucket;
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 23", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
