using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{
	public class S3CreateFolder
	{
		public string bucketName { get; set; }
		public string folderName { get; set; }
		public string filePath { get; set; }
		public void CreateFolderInS3()
		{
			try
			{
				var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

				PutObjectRequest putRequest = new PutObjectRequest
				{
					BucketName = bucketName,
					Key = Path.Combine(filePath, folderName) + "/"
				};

				PutObjectResponse response = client.PutObject(putRequest);
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 200", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
