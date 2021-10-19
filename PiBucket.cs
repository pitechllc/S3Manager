using Amazon.S3.IO;
using Amazon.S3.Model;
using NETWORKLIST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiBox
{

	public partial class PiBucket : Form
	{
		String fullName;
		String objectName;
		string S3FileName;
		string S3Type;
		public string fldrName { get; set; }
		public PiBucket()
		{
			InitializeComponent();
			PopulateTreeView();
			PopulateS3Tree();
		}

		private void DeleteFromS3()
		{
			S3BucketDelete s3Del = new S3BucketDelete();

			s3Del.bucketName = Properties.Settings.Default.bucket;

			foreach (ListViewItem lSv in listView2.CheckedItems)
			{
				if (lSv.SubItems[1].Text == "Directory")
				{
					s3Del.fileName = lSv.SubItems[0].Text;
					s3Del.filePath = treeView2.SelectedNode.Text;
					s3Del.DeleteFolder();
					return;
				}
				s3Del.fileName = lSv.Text;
				if (!string.IsNullOrEmpty(toolSelected.Text))
				{
					s3Del.filePath = toolSelected.Text + "/";
				}
				else
				{
					s3Del.filePath = "//";
				}

				s3Del.DeleteFile();
				lSv.Checked = false;
				lSv.Remove();
			}
		}
		private void PopulateTreeView()
		{
			//get a list of the drives
			foreach (var drive in Environment.GetLogicalDrives())
			{
				DriveInfo di = new DriveInfo(drive);
				int driveImage;

				switch (di.DriveType)    //set the drive's icon
				{
					case DriveType.CDRom:
						driveImage = 3;
						break;
					case DriveType.Network:
						driveImage = 26;
						break;
					case DriveType.NoRootDirectory:
						driveImage = 8;
						break;
					case DriveType.Unknown:
						driveImage = 8;
						break;
					default:
						driveImage = 4;
						break;
				}

				TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
				DirectoryInfo info = new DirectoryInfo(drive);
				node.Tag = info;

				if (di.IsReady == true)
					node.Nodes.Add("...");

				treeView1.Nodes.Add(node);
			}
		}
		private void PopulateS3Tree()
		{
			S3BucketView myBucket = new S3BucketView();
			myBucket.bucketName = Properties.Settings.Default.bucket;
			ListObjectsResponse response = myBucket.ListFolders();
			int driveImage = 41;
			TreeNode nextNode = null;

			treeView2.Nodes.Clear();
			//Main Node
			TreeNode mainNode = new TreeNode("/", driveImage, driveImage);


			if (response == null)
			{
				MessageBox.Show("Please check your crdentials and try again!", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
				settingsToolStripMenuItem.PerformClick();
				return;
			}
			foreach (S3Object obj in response.S3Objects)
			{
				if (obj.Key.EndsWith(@"/") && obj.Size == 0)
				{
					nextNode = new TreeNode(obj.Key, 38, 39);
					DirectoryInfo myinfo = new DirectoryInfo(obj.Key);
					nextNode.Tag = myinfo;
					mainNode.Nodes.Add(nextNode);
				}
			}
			treeView2.Nodes.Add(mainNode);
		}
		private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
		{
			TreeNode aNode;
			DirectoryInfo[] subSubDirs;
			try
			{
				foreach (DirectoryInfo subDir in subDirs)
				{
					aNode = new TreeNode(subDir.Name, 0, 0);
					aNode.Tag = subDir;
					aNode.ImageIndex = 36;
					subSubDirs = subDir.GetDirectories();
					if (subSubDirs.Length != 0)
					{
						GetDirectories(subSubDirs, aNode);
					}
					nodeToAddTo.Nodes.Add(aNode);
				}
			}
			catch (UnauthorizedAccessException x)
			{
				MessageBox.Show(x.Message);
			}
		}
		private void loadLocalFileFolders()
		{

			ListViewItem selected = listView1.SelectedItems[0];
			DirectoryInfo nodeDirInfo = new DirectoryInfo(toolLocalPath.Text); //new DirectoryInfo(Path.Combine(toolLocalPath.Text, selected.Text));
			ListViewItem.ListViewSubItem[] subItems;
			ListViewItem item = null;



			try
			{
				listView1.Items.Clear();

				item = new ListViewItem("..", 38);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, ""), new ListViewItem.ListViewSubItem(item, "") };
				item.SubItems.AddRange(subItems);
				listView1.Items.Add(item);
				foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
				{
					item = new ListViewItem(dir.Name, 38);
					subItems = new ListViewItem.ListViewSubItem[]
						{new ListViewItem.ListViewSubItem(item, "Directory"),
			 new ListViewItem.ListViewSubItem(item,
				dir.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
				foreach (FileInfo file in nodeDirInfo.GetFiles())
				{
					item = new ListViewItem(file.Name, 1);
					subItems = new ListViewItem.ListViewSubItem[]
						{ new ListViewItem.ListViewSubItem(item, "File"),
			 new ListViewItem.ListViewSubItem(item,
				file.LastAccessTime.ToShortDateString()),
					new ListViewItem.ListViewSubItem(item,
				file.Length.ToString())
						};


					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
			}
			catch (UnauthorizedAccessException)
			{
				//newSelected.ImageIndex = 40;
				//newSelected.SelectedImageIndex = 40;
			}
			toolLocalPath.Text = nodeDirInfo.FullName.ToString();


			fullName = nodeDirInfo.FullName.ToString();
			listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TreeNode newSelected = e.Node;
			listView1.Items.Clear();
			DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
			ListViewItem.ListViewSubItem[] subItems;
			ListViewItem item = null;


			item = new ListViewItem("..", 38);
			subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, ""), new ListViewItem.ListViewSubItem(item, "") };
			item.SubItems.AddRange(subItems);
			item.Tag = fullName;


			listView1.Items.Add(item);

			try
			{
				foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
				{
					item = new ListViewItem(dir.Name, 38);

					item.Tag = nodeDirInfo.FullName;

					subItems = new ListViewItem.ListViewSubItem[]
						{new ListViewItem.ListViewSubItem(item, "Directory"),
			 new ListViewItem.ListViewSubItem(item,
				dir.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					item.Tag = nodeDirInfo.FullName;


					listView1.Items.Add(item);
				}
				foreach (FileInfo file in nodeDirInfo.GetFiles())
				{
					item = new ListViewItem(file.Name, 1);
					subItems = new ListViewItem.ListViewSubItem[]
						{ new ListViewItem.ListViewSubItem(item, "File"),
			 new ListViewItem.ListViewSubItem(item,
				file.LastAccessTime.ToShortDateString()),
					new ListViewItem.ListViewSubItem(item,
				file.Length.ToString())
						};


					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
			}
			catch (UnauthorizedAccessException)
			{
				newSelected.ImageIndex = 40;
				newSelected.SelectedImageIndex = 40;
			}
			//label1.Text = nodeDirInfo.FullName.ToString();
			toolLocalPath.Text = nodeDirInfo.FullName.ToString();


			fullName = nodeDirInfo.FullName.ToString();
			listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{

			if (e.Node.Nodes.Count > 0)
			{
				if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
				{
					e.Node.Nodes.Clear();

					//get the list of sub direcotires
					string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

					foreach (string dir in dirs)
					{
						DirectoryInfo di = new DirectoryInfo(dir);
						TreeNode node = new TreeNode(di.Name, 0, 1);

						try
						{
							//keep the directory's full path in the tag for use later
							node.Tag = di;

							//if the directory has sub directories add the place holder
							if (di.GetDirectories().Count() > 0)
								node.Nodes.Add(null, "...", 38, 39);
						}
						catch (UnauthorizedAccessException)
						{
							//display a folder icon
							node.ImageIndex = 39;
							node.SelectedImageIndex = 39;
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "DirectoryLister",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							node.ImageIndex = 38;
							node.SelectedImageIndex = 39;
							e.Node.Nodes.Add(node);
						}
					}
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//foreach (ListViewItem selected in listView1.SelectedItems)
			//{
			//	objectName = selected.Text.ToString();
			//	//label1.Text = fullName + "\\" + objectName;
			//	toolLocalPath.Text = fullName + "\\" + objectName;
			//}
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UploadFileToS3();
		}
		private async void UploadFileToS3()
		{
			try
			{
				S3BucketUploader s3 = new S3BucketUploader();
				s3.bucketName = s3.bucketName = Properties.Settings.Default.bucket;
				if (!string.IsNullOrEmpty(toolLocalPath.Text))
				{

					foreach (ListViewItem lv in listView1.SelectedItems)
					{

						s3.keyName = lv.Text;
						s3.filePath = toolLocalPath.Text;

						if (!string.IsNullOrEmpty(toolSelected.Text))
						{
							s3.fileDestination = toolSelected.Text + "/";
						}
						else
						{
							s3.fileDestination = "/";
						}

						toolProcess.Text = "Upload in progress...";
						await s3.UploadFileAsync();
						toolProcess.Text = "Upload Complete";
					}
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 20", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private async void DownloadFileToS3()
		{
			try
			{
				S3BucketDownload s3 = new S3BucketDownload();
				s3.bucketName = s3.bucketName = Properties.Settings.Default.bucket;
				if (!string.IsNullOrEmpty(toolLocalPath.Text))
				{

					foreach (ListViewItem lv in listView2.SelectedItems)
					{
						s3.keyName = lv.Text;
						s3.filePath = toolLocalPath.Text;

						if (!string.IsNullOrEmpty(toolSelected.Text))
						{
							s3.fileDestination = toolSelected.Text + "/";
						}
						else
						{
							s3.fileDestination = "/";
						}


						toolProcess.Text = "Download in progress...";
						await s3.DownoadFileAsync();
						toolProcess.Text = "Download Complete";
					}
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 21", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private void loadFilesFolders(string p)
		{
			S3BucketView myBucket = new S3BucketView();
			listView2.Items.Clear();
			myBucket.bucketName = Properties.Settings.Default.bucket;
			S3DirectoryInfo nodeDirInfo = myBucket.ListFiles(p);

			ListViewItem.ListViewSubItem[] subItems;
			ListViewItem item = null;

			try
			{
				item = new ListViewItem("..", 38);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, ""), new ListViewItem.ListViewSubItem(item, "") };
				item.SubItems.AddRange(subItems);
				listView2.Items.Add(item);
				foreach (S3DirectoryInfo dir in nodeDirInfo.GetDirectories())
				{
					item = new ListViewItem(dir.Name, 38);
					subItems = new ListViewItem.ListViewSubItem[]
						{new ListViewItem.ListViewSubItem(item, "Directory"),
				 new ListViewItem.ListViewSubItem(item,
					dir.LastWriteTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView2.Items.Add(item);
				}

				foreach (S3FileInfo file in nodeDirInfo.GetFiles())
				{
					item = new ListViewItem(file.Name, 1);
					subItems = new ListViewItem.ListViewSubItem[]
						{ new ListViewItem.ListViewSubItem(item, "File"),
				 new ListViewItem.ListViewSubItem(item,
					file.LastWriteTime.ToShortDateString()),
						new ListViewItem.ListViewSubItem(item,
					file.Length.ToString())
						};

					item.SubItems.AddRange(subItems);
					listView2.Items.Add(item);
				}
			}
			catch (UnauthorizedAccessException x)
			{
				MessageBox.Show(x.Message, "Error 45", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			toolProcess.Text = ". . .";
			listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{			
			try
			{
				TreeNode newSelected = e.Node;
				S3BucketView myBucket = new S3BucketView();
				listView2.Items.Clear();
				myBucket.bucketName = Properties.Settings.Default.bucket;
				S3DirectoryInfo nodeDirInfo = myBucket.ListFiles(newSelected.Text.Remove(newSelected.Text.Length - 1));



				ListViewItem.ListViewSubItem[] subItems;
				ListViewItem item = null;

				toolSelected.Text = newSelected.Text.Remove(newSelected.Text.Length - 1);


				item = new ListViewItem("..", 38);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, ""), new ListViewItem.ListViewSubItem(item, "") };
				item.SubItems.AddRange(subItems);
				listView2.Items.Add(item);

				foreach (S3DirectoryInfo dir in nodeDirInfo.GetDirectories())
				{
					item = new ListViewItem(dir.Name, 38);
					subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastWriteTime.ToShortDateString()) };
					item.SubItems.AddRange(subItems);
					listView2.Items.Add(item);
				}

				foreach (S3FileInfo file in nodeDirInfo.GetFiles())
				{
					item = new ListViewItem(file.Name, 1);
					subItems = new ListViewItem.ListViewSubItem[]
						{ new ListViewItem.ListViewSubItem(item, "File"),
				 new ListViewItem.ListViewSubItem(item,
					file.LastWriteTime.ToShortDateString()),
						new ListViewItem.ListViewSubItem(item,
					file.Length.ToString())
						};

					item.SubItems.AddRange(subItems);
					listView2.Items.Add(item);
				}
				toolProcess.Text = ". . .";
				listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 50", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
		}
		private void listView2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				foreach (ListViewItem selected in listView2.SelectedItems)
				{
					S3Type = selected.SubItems[1].Text;
					S3FileName = selected.Text;
					toolProgress.Text = selected.Text;
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 55", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string folderName;
			try
			{
				using (var form = new NewFolder())
				{
					var result = form.ShowDialog();
					if (result == DialogResult.OK)
					{
						folderName = form.fldrName;

						CreateFolderInS3(folderName);

						toolProcess.Text = "New folder creation complete";
					}
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 60", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
		private void CreateFolderInS3(string f)
		{
			try
			{
				S3CreateFolder s3 = new S3CreateFolder();

				if (!string.IsNullOrEmpty(f))
				{
					s3.bucketName = Properties.Settings.Default.bucket;
					s3.folderName = f;
					s3.filePath = treeView2.SelectedNode.Text;
					s3.CreateFolderInS3();
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 65", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure you want to delete selcted file(s)?", "Delete Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					DeleteFromS3();
					toolProcess.Text = "Delete process complete";
				}
				else
				{
					toolProcess.Text = "Delete process was canceled";
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 70", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DownloadFileToS3();
		}

		private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			try
			{
				if (e.IsSelected && (e.Item.SubItems[1].Text == "Directory" || string.IsNullOrEmpty(e.Item.SubItems[1].Text)))
				{
					if (String.IsNullOrEmpty(toolSelected.Text))
					{
						if (e.Item.Text == "..")
						{
							toolSelected.Text = string.Empty;
						}
						else
							toolSelected.Text = e.Item.Text;
					}
					else
					{
						if (e.Item.Text == "..")
						{
							toolSelected.Text = pathFinder();
						}
						else
							toolSelected.Text = toolSelected.Text + "/" + e.Item.Text;
					}
					loadFilesFolders(toolSelected.Text);
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 75", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private string pathFinder()
		{
			string thePath = null;
			string backUp;
			string currentPath;
			string[] paths;

			if (!String.IsNullOrEmpty(toolSelected.Text))
			{
				currentPath = toolSelected.Text;
				if (currentPath.IndexOf("/") > 0)
				{
					paths = currentPath.Split('/');
					if (paths.Length > 0)
					{
						backUp = paths[paths.Length - 1];
						backUp = "/" + backUp;
						thePath = currentPath.Replace(backUp, "");
					}
					else
					{
						thePath = "\\";
					}
				}
			}

			return thePath;
		}
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings mySettings = new Settings();
			mySettings.ShowDialog();

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			try
			{
				foreach (ListViewItem selected in listView1.SelectedItems)
				{
					ListViewItem mySelection = listView1.SelectedItems[0];
					if (mySelection.SubItems[1].Text == "Directory" || mySelection.SubItems[1].Text != "File")
					{
						if (mySelection.SubItems[0].Text == "..")
						{
							//toolLocalPath.Text = Path.GetFullPath(Path.Combine(fullName, @"..\" + fullName));
							toolLocalPath.Text = Directory.GetParent(fullName).ToString();
						}
						else
						{
							//mySelection.SubItems[1].Tag = fullName;
							toolLocalPath.Text = Path.Combine(fullName, mySelection.SubItems[0].Text);
						}

						fullName = toolLocalPath.Text;
						loadLocalFileFolders();
					}
					else
					{
						objectName = selected.Text.ToString();
						//label1.Text = fullName + "\\" + objectName;
						toolLocalPath.Text = fullName + "\\" + objectName;
					}
				}
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error 80", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void toolS3Path_Click(object sender, EventArgs e)
		{
			PopulateS3Tree();
		}

		private void PiBucket_Shown(object sender, EventArgs e)
		{
			NetworkProperties();
		}
		private void NetworkProperties()
		{
			var manager = new NetworkListManagerClass();
			var connectedNetworks = manager.GetNetworks(NLM_ENUM_NETWORK.NLM_ENUM_NETWORK_CONNECTED).Cast<INetwork>();
			foreach (var network in connectedNetworks)
			{
				toolNetwork.Text = network.GetName() + " ";
				var cat = network.GetCategory();
				if (cat == NLM_NETWORK_CATEGORY.NLM_NETWORK_CATEGORY_PRIVATE)
					toolNetwork.Text = toolNetwork.Text + "[PRIVATE]";
				else if (cat == NLM_NETWORK_CATEGORY.NLM_NETWORK_CATEGORY_PUBLIC)
					toolNetwork.Text = toolNetwork.Text + "[PUBLIC]";
				else if (cat == NLM_NETWORK_CATEGORY.NLM_NETWORK_CATEGORY_DOMAIN_AUTHENTICATED)
					toolNetwork.Text = toolNetwork.Text + "[DOMAIN]";
			}
		}
	}
}
