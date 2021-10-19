using Amazon.S3;
using Amazon.S3.IO;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{
	public class S3BucketView
	{
		public string bucketName { get; set; }
		public ListObjectsResponse ListFolders()
		{
			//var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);

			ListObjectsResponse response;
			ListObjectsResponse result ;
			IAmazonS3 client;
			try
			{
				using (client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2))
				{
					ListObjectsRequest listRequest = new ListObjectsRequest
					{
						BucketName = bucketName,
					};
					do
					{
						response = client.ListObjects(listRequest);


						IEnumerable<S3Object> folders = response.S3Objects.Where(x => x.Key.EndsWith(@"/") && x.Size == 0);
						result = new ListObjectsResponse();
						foreach (S3Object x in folders)
						{
							result.S3Objects.Add(x);
						}
						if (response.IsTruncated)
						{
							listRequest.Marker = response.NextMarker;
						}
						else
						{
							listRequest = null;
						}
					} while (listRequest != null);


				}
			}catch (Exception x)
			{
				MessageBox.Show(x.Message, "Erorr 1");
				result = null;
			}

			return result;
		}
		public S3DirectoryInfo ListFiles(string folder)
		{
			var client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);
			var dir = new S3DirectoryInfo(client, bucketName, folder);


			ListObjectsRequest listRequest = new ListObjectsRequest
			{
				BucketName = bucketName,
				Prefix = folder
			};


			return dir;
		}
	}
}
