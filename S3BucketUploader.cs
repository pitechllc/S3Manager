using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{
	public class S3BucketUploader
	{
        public string bucketName { get; set; }
        public string keyName { get; set; }
        public string filePath { get; set; }
        public string fileDestination { get; set; }

        public void UploadFile()
        {
          try
			{
                var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

                PutObjectRequest putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName,
                    FilePath = filePath,
                    ContentType = "text/plain"
                };

                PutObjectResponse response = client.PutObject(putRequest);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error 101", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UploadFileToFolder()
        {
			try
			{
                var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

                PutObjectRequest putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = Path.Combine(fileDestination, keyName),
                    FilePath = filePath,
                    ContentType = "text/plain"
                };

                PutObjectResponse response = client.PutObject(putRequest);
            }catch(Exception x)
			{
                MessageBox.Show(x.Message, "Error 100", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  async Task UploadFileAsync()
        {
            try
            {
                var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);
                var fileTransferUtility = new TransferUtility(client);

                var request = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    Key = Path.Combine(fileDestination, keyName),
                    PartSize = 6291456, // 6 MB.
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AES256
                };

                await fileTransferUtility.UploadAsync(request);
            }
            catch (AmazonS3Exception s3Exception)
            {
                MessageBox.Show(s3Exception.Message, "Error 102", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 103", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
