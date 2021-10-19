using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{
	public partial class NewFolder : Form
	{
		public string fldrName { get; set; }
		public NewFolder()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CreateFolder();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void CreateFolder()
		{

			try
			{
				if (!string.IsNullOrEmpty(textBox1.Text))
				{
					var result = Regex.Match(textBox1.Text, @"^[a-zA-Z0-9-]*$");
					if (result.Success)
					{
						this.fldrName = textBox1.Text;
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
					else
					{
						MessageBox.Show("Please use only digits, alphabet, and dashes in the folder name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
						textBox1.Text = string.Empty;
					}

				}
			}catch(Exception x)
			{
				MessageBox.Show(x.Message, "Error 100", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
