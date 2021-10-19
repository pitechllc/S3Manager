
namespace PiBox
{
	partial class PiBucket
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiBucket));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolFileName = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolProgress = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolS3Path = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolSelected = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolLocal = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolLocalPath = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolProcess = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolNetwork = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileName,
            this.toolProgress,
            this.toolS3Path,
            this.toolSelected,
            this.toolLocal,
            this.toolLocalPath,
            this.toolProcess,
            this.toolNetwork});
			this.statusStrip1.Location = new System.Drawing.Point(0, 625);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
			this.statusStrip1.Size = new System.Drawing.Size(934, 53);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolFileName
			// 
			this.toolFileName.BackColor = System.Drawing.Color.AliceBlue;
			this.toolFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolFileName.ForeColor = System.Drawing.Color.MidnightBlue;
			this.toolFileName.Image = ((System.Drawing.Image)(resources.GetObject("toolFileName.Image")));
			this.toolFileName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolFileName.Name = "toolFileName";
			this.toolFileName.Size = new System.Drawing.Size(81, 48);
			this.toolFileName.Text = "File";
			// 
			// toolProgress
			// 
			this.toolProgress.BackColor = System.Drawing.Color.AliceBlue;
			this.toolProgress.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolProgress.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.toolProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolProgress.Name = "toolProgress";
			this.toolProgress.Size = new System.Drawing.Size(20, 48);
			this.toolProgress.Text = "...";
			// 
			// toolS3Path
			// 
			this.toolS3Path.BackColor = System.Drawing.Color.AliceBlue;
			this.toolS3Path.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolS3Path.ForeColor = System.Drawing.Color.MidnightBlue;
			this.toolS3Path.Image = ((System.Drawing.Image)(resources.GetObject("toolS3Path.Image")));
			this.toolS3Path.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolS3Path.Name = "toolS3Path";
			this.toolS3Path.Size = new System.Drawing.Size(57, 48);
			this.toolS3Path.Text = "S3";
			this.toolS3Path.Click += new System.EventHandler(this.toolS3Path_Click);
			// 
			// toolSelected
			// 
			this.toolSelected.BackColor = System.Drawing.Color.AliceBlue;
			this.toolSelected.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolSelected.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.toolSelected.Name = "toolSelected";
			this.toolSelected.Size = new System.Drawing.Size(4, 48);
			// 
			// toolLocal
			// 
			this.toolLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolLocal.ForeColor = System.Drawing.Color.MidnightBlue;
			this.toolLocal.Image = ((System.Drawing.Image)(resources.GetObject("toolLocal.Image")));
			this.toolLocal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolLocal.Name = "toolLocal";
			this.toolLocal.Size = new System.Drawing.Size(92, 48);
			this.toolLocal.Text = "Local";
			// 
			// toolLocalPath
			// 
			this.toolLocalPath.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolLocalPath.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.toolLocalPath.Name = "toolLocalPath";
			this.toolLocalPath.Size = new System.Drawing.Size(4, 48);
			// 
			// toolProcess
			// 
			this.toolProcess.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolProcess.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolProcess.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.toolProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolProcess.ForeColor = System.Drawing.Color.Black;
			this.toolProcess.Name = "toolProcess";
			this.toolProcess.Size = new System.Drawing.Size(616, 48);
			this.toolProcess.Spring = true;
			this.toolProcess.Text = ". . .";
			// 
			// toolNetwork
			// 
			this.toolNetwork.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolNetwork.Image = global::PiBox.Properties.Resources.network1;
			this.toolNetwork.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolNetwork.Name = "toolNetwork";
			this.toolNetwork.Padding = new System.Windows.Forms.Padding(5);
			this.toolNetwork.Size = new System.Drawing.Size(42, 48);
			this.toolNetwork.ToolTipText = "Connected Network";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(934, 25);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitContainer2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 265);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 360);
			this.panel1.TabIndex = 5;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.treeView2);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.listView2);
			this.splitContainer2.Size = new System.Drawing.Size(934, 360);
			this.splitContainer2.SplitterDistance = 310;
			this.splitContainer2.TabIndex = 0;
			// 
			// treeView2
			// 
			this.treeView2.BackColor = System.Drawing.Color.AliceBlue;
			this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView2.ImageIndex = 0;
			this.treeView2.ImageList = this.imageList1;
			this.treeView2.Location = new System.Drawing.Point(0, 0);
			this.treeView2.Margin = new System.Windows.Forms.Padding(4);
			this.treeView2.Name = "treeView2";
			this.treeView2.SelectedImageIndex = 0;
			this.treeView2.Size = new System.Drawing.Size(310, 360);
			this.treeView2.TabIndex = 0;
			this.treeView2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "ico1.ico");
			this.imageList1.Images.SetKeyName(1, "ico2.ico");
			this.imageList1.Images.SetKeyName(2, "ico3.ico");
			this.imageList1.Images.SetKeyName(3, "ico6.ico");
			this.imageList1.Images.SetKeyName(4, "ico8.ico");
			this.imageList1.Images.SetKeyName(5, "ico10.ico");
			this.imageList1.Images.SetKeyName(6, "ico11.ico");
			this.imageList1.Images.SetKeyName(7, "ico12.ico");
			this.imageList1.Images.SetKeyName(8, "ico13.ico");
			this.imageList1.Images.SetKeyName(9, "ico100.ico");
			this.imageList1.Images.SetKeyName(10, "ico101.ico");
			this.imageList1.Images.SetKeyName(11, "ico133.ico");
			this.imageList1.Images.SetKeyName(12, "ico134.ico");
			this.imageList1.Images.SetKeyName(13, "ico135.ico");
			this.imageList1.Images.SetKeyName(14, "ico165.ico");
			this.imageList1.Images.SetKeyName(15, "ico167.ico");
			this.imageList1.Images.SetKeyName(16, "ico1001.ico");
			this.imageList1.Images.SetKeyName(17, "ico1002.ico");
			this.imageList1.Images.SetKeyName(18, "ico1003.ico");
			this.imageList1.Images.SetKeyName(19, "ico1004.ico");
			this.imageList1.Images.SetKeyName(20, "ico1005.ico");
			this.imageList1.Images.SetKeyName(21, "ico1008.ico");
			this.imageList1.Images.SetKeyName(22, "ico1009.ico");
			this.imageList1.Images.SetKeyName(23, "ico1010.ico");
			this.imageList1.Images.SetKeyName(24, "ico1011.ico");
			this.imageList1.Images.SetKeyName(25, "ico5330.ico");
			this.imageList1.Images.SetKeyName(26, "sico10.ico");
			this.imageList1.Images.SetKeyName(27, "sico101.ico");
			this.imageList1.Images.SetKeyName(28, "sico1001.ico");
			this.imageList1.Images.SetKeyName(29, "sico1002.ico");
			this.imageList1.Images.SetKeyName(30, "sico1003.ico");
			this.imageList1.Images.SetKeyName(31, "sico1004.ico");
			this.imageList1.Images.SetKeyName(32, "sico1005.ico");
			this.imageList1.Images.SetKeyName(33, "sico1006.ico");
			this.imageList1.Images.SetKeyName(34, "sico1007.ico");
			this.imageList1.Images.SetKeyName(35, "sico1008.ico");
			this.imageList1.Images.SetKeyName(36, "ico4.ico");
			this.imageList1.Images.SetKeyName(37, "ico210.ico");
			this.imageList1.Images.SetKeyName(38, "close_folder.png");
			this.imageList1.Images.SetKeyName(39, "open_folder.png");
			this.imageList1.Images.SetKeyName(40, "unaccess_folder.png");
			this.imageList1.Images.SetKeyName(41, "s3.png");
			// 
			// listView2
			// 
			this.listView2.BackColor = System.Drawing.Color.AliceBlue;
			this.listView2.CheckBoxes = true;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.listView2.ContextMenuStrip = this.contextMenuStrip2;
			this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(0, 0);
			this.listView2.Margin = new System.Windows.Forms.Padding(4);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(620, 360);
			this.listView2.SmallImageList = this.imageList1;
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
			this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Name";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Type";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Last modified";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Size";
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.downloadToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(135, 70);
			// 
			// newFolderToolStripMenuItem
			// 
			this.newFolderToolStripMenuItem.Image = global::PiBox.Properties.Resources.newfolder;
			this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
			this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.newFolderToolStripMenuItem.Text = "&New Folder";
			this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::PiBox.Properties.Resources.trash;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// downloadToolStripMenuItem
			// 
			this.downloadToolStripMenuItem.Image = global::PiBox.Properties.Resources.downarrow;
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.downloadToolStripMenuItem.Text = "D&ownload";
			this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(934, 240);
			this.splitContainer1.SplitterDistance = 310;
			this.splitContainer1.TabIndex = 7;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Margin = new System.Windows.Forms.Padding(4);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(310, 240);
			this.treeView1.TabIndex = 0;
			this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Margin = new System.Windows.Forms.Padding(4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(620, 240);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Type";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last Modified";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Size";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::PiBox.Properties.Resources.uparrow;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.copyToolStripMenuItem.Text = "&Upload";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// PiBucket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 678);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PiBucket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "S3 Bucket Storage Management";
			this.Shown += new System.EventHandler(this.PiBucket_Shown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolProgress;
		private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolSelected;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolFileName;
		private System.Windows.Forms.ToolStripStatusLabel toolS3Path;
		private System.Windows.Forms.ToolStripStatusLabel toolLocal;
		private System.Windows.Forms.ToolStripStatusLabel toolLocalPath;
		private System.Windows.Forms.ToolStripStatusLabel toolProcess;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolNetwork;
	}
}

