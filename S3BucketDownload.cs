using Amazon.S3;
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
	public class S3BucketDownload
	{
		public string bucketName { get; set; }
        public string keyName { get; set; }
		public string filePath { get; set; }
		public string fileDestination { get; set; }
        public async Task DownoadFileAsync()
        {
            try
            {
                var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);
                var fileTransferUtility = new TransferUtility(client);

                var request = new TransferUtilityDownloadRequest
                {
                    BucketName = bucketName,
                    FilePath = Path.Combine(filePath, keyName),
                  //  Key = Path.Combine(fileDestination, keyName),
                    Key = fileDestination+keyName,
                    //PartSize = 6291456, // 6 MB.
                    //ServerSideEncryptionMethod = ServerSideEncryptionMethod.AES256
                };

                await fileTransferUtility.DownloadAsync(request);
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
