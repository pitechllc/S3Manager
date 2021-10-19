using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{
	public class S3BucketDelete
	{
        public string bucketName { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }

        public void DeleteFile()
        {
			try
			{
                var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

                DeleteObjectRequest delRequest = new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = Path.Combine(filePath, fileName)  // Delete file at the path
                };

                DeleteObjectResponse response = client.DeleteObject(delRequest);
            }catch(Exception x)
			{
                MessageBox.Show(x.Message);
			}
        }
        public void DeleteFolder()
        {
            var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

            DeleteObjectRequest delRequest = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = Path.Combine(filePath, fileName) + "/" // Delete folder
            };

            DeleteObjectResponse response = client.DeleteObject(delRequest);
        }


    }
}
