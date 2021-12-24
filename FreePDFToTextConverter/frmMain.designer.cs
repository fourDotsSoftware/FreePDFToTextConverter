namespace FreePDFToTextConverter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadPDFMergeSplitToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreePDFPasswordRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreePDFMetadatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreePDFProtectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadMultipleSearchAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreeFileUnlockerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadImgTransformerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreeImagemapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDocusTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadCopyPathToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadCopyTextContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadOpenCommandPromptHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFreeColorwheelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiHelpFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visit4dotsSoftwareWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnClearMerge = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnConvertToText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.colFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSettings = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncoding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdSameFolder = new System.Windows.Forms.RadioButton();
            this.rdDocumentsFolder = new System.Windows.Forms.RadioButton();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkOneFile = new System.Windows.Forms.CheckBox();
            this.chkHTML = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.documentSettingsToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::FreePDFToTextConverter.Properties.Resources.folder;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // documentSettingsToolStripMenuItem
            // 
            this.documentSettingsToolStripMenuItem.Name = "documentSettingsToolStripMenuItem";
            resources.ApplyResources(this.documentSettingsToolStripMenuItem, "documentSettingsToolStripMenuItem");
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            resources.ApplyResources(this.duplicateToolStripMenuItem, "duplicateToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::FreePDFToTextConverter.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadPDFMergeSplitToolToolStripMenuItem,
            this.downloadFreePDFPasswordRemoverToolStripMenuItem,
            this.downloadFreePDFMetadatToolStripMenuItem,
            this.downloadFreePDFProtectorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.downloadMultipleSearchAndReplaceToolStripMenuItem,
            this.downloadFreeFileUnlockerToolStripMenuItem,
            this.downloadImgTransformerToolStripMenuItem,
            this.downloadFreeImagemapperToolStripMenuItem,
            this.downloadDocusTreeToolStripMenuItem,
            this.downloadCopyPathToClipboardToolStripMenuItem,
            this.downloadCopyTextContentsToolStripMenuItem,
            this.downloadOpenCommandPromptHereToolStripMenuItem,
            this.downloadFreeColorwheelToolStripMenuItem});
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            resources.ApplyResources(this.downloadToolStripMenuItem, "downloadToolStripMenuItem");
            // 
            // downloadPDFMergeSplitToolToolStripMenuItem
            // 
            this.downloadPDFMergeSplitToolToolStripMenuItem.Name = "downloadPDFMergeSplitToolToolStripMenuItem";
            resources.ApplyResources(this.downloadPDFMergeSplitToolToolStripMenuItem, "downloadPDFMergeSplitToolToolStripMenuItem");
            this.downloadPDFMergeSplitToolToolStripMenuItem.Click += new System.EventHandler(this.downloadPDFMergeSplitToolToolStripMenuItem_Click);
            // 
            // downloadFreePDFPasswordRemoverToolStripMenuItem
            // 
            this.downloadFreePDFPasswordRemoverToolStripMenuItem.Name = "downloadFreePDFPasswordRemoverToolStripMenuItem";
            resources.ApplyResources(this.downloadFreePDFPasswordRemoverToolStripMenuItem, "downloadFreePDFPasswordRemoverToolStripMenuItem");
            this.downloadFreePDFPasswordRemoverToolStripMenuItem.Click += new System.EventHandler(this.downloadFreePDFPasswordRemoverToolStripMenuItem_Click);
            // 
            // downloadFreePDFMetadatToolStripMenuItem
            // 
            this.downloadFreePDFMetadatToolStripMenuItem.Name = "downloadFreePDFMetadatToolStripMenuItem";
            resources.ApplyResources(this.downloadFreePDFMetadatToolStripMenuItem, "downloadFreePDFMetadatToolStripMenuItem");
            this.downloadFreePDFMetadatToolStripMenuItem.Click += new System.EventHandler(this.downloadFreePDFMetadatToolStripMenuItem_Click);
            // 
            // downloadFreePDFProtectorToolStripMenuItem
            // 
            this.downloadFreePDFProtectorToolStripMenuItem.Name = "downloadFreePDFProtectorToolStripMenuItem";
            resources.ApplyResources(this.downloadFreePDFProtectorToolStripMenuItem, "downloadFreePDFProtectorToolStripMenuItem");
            this.downloadFreePDFProtectorToolStripMenuItem.Click += new System.EventHandler(this.downloadFreePDFProtectorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // downloadMultipleSearchAndReplaceToolStripMenuItem
            // 
            this.downloadMultipleSearchAndReplaceToolStripMenuItem.Name = "downloadMultipleSearchAndReplaceToolStripMenuItem";
            resources.ApplyResources(this.downloadMultipleSearchAndReplaceToolStripMenuItem, "downloadMultipleSearchAndReplaceToolStripMenuItem");
            this.downloadMultipleSearchAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.downloadMultipleSearchAndReplaceToolStripMenuItem_Click);
            // 
            // downloadFreeFileUnlockerToolStripMenuItem
            // 
            this.downloadFreeFileUnlockerToolStripMenuItem.Name = "downloadFreeFileUnlockerToolStripMenuItem";
            resources.ApplyResources(this.downloadFreeFileUnlockerToolStripMenuItem, "downloadFreeFileUnlockerToolStripMenuItem");
            this.downloadFreeFileUnlockerToolStripMenuItem.Click += new System.EventHandler(this.downloadFreeFileUnlockerToolStripMenuItem_Click);
            // 
            // downloadImgTransformerToolStripMenuItem
            // 
            this.downloadImgTransformerToolStripMenuItem.Name = "downloadImgTransformerToolStripMenuItem";
            resources.ApplyResources(this.downloadImgTransformerToolStripMenuItem, "downloadImgTransformerToolStripMenuItem");
            this.downloadImgTransformerToolStripMenuItem.Click += new System.EventHandler(this.downloadImgTransformerToolStripMenuItem_Click);
            // 
            // downloadFreeImagemapperToolStripMenuItem
            // 
            this.downloadFreeImagemapperToolStripMenuItem.Name = "downloadFreeImagemapperToolStripMenuItem";
            resources.ApplyResources(this.downloadFreeImagemapperToolStripMenuItem, "downloadFreeImagemapperToolStripMenuItem");
            this.downloadFreeImagemapperToolStripMenuItem.Click += new System.EventHandler(this.downloadFreeImagemapperToolStripMenuItem_Click);
            // 
            // downloadDocusTreeToolStripMenuItem
            // 
            this.downloadDocusTreeToolStripMenuItem.Name = "downloadDocusTreeToolStripMenuItem";
            resources.ApplyResources(this.downloadDocusTreeToolStripMenuItem, "downloadDocusTreeToolStripMenuItem");
            this.downloadDocusTreeToolStripMenuItem.Click += new System.EventHandler(this.downloadDocusTreeToolStripMenuItem_Click);
            // 
            // downloadCopyPathToClipboardToolStripMenuItem
            // 
            this.downloadCopyPathToClipboardToolStripMenuItem.Name = "downloadCopyPathToClipboardToolStripMenuItem";
            resources.ApplyResources(this.downloadCopyPathToClipboardToolStripMenuItem, "downloadCopyPathToClipboardToolStripMenuItem");
            this.downloadCopyPathToClipboardToolStripMenuItem.Click += new System.EventHandler(this.downloadCopyPathToClipboardToolStripMenuItem_Click);
            // 
            // downloadCopyTextContentsToolStripMenuItem
            // 
            this.downloadCopyTextContentsToolStripMenuItem.Name = "downloadCopyTextContentsToolStripMenuItem";
            resources.ApplyResources(this.downloadCopyTextContentsToolStripMenuItem, "downloadCopyTextContentsToolStripMenuItem");
            this.downloadCopyTextContentsToolStripMenuItem.Click += new System.EventHandler(this.downloadCopyTextContentsToolStripMenuItem_Click);
            // 
            // downloadOpenCommandPromptHereToolStripMenuItem
            // 
            this.downloadOpenCommandPromptHereToolStripMenuItem.Name = "downloadOpenCommandPromptHereToolStripMenuItem";
            resources.ApplyResources(this.downloadOpenCommandPromptHereToolStripMenuItem, "downloadOpenCommandPromptHereToolStripMenuItem");
            this.downloadOpenCommandPromptHereToolStripMenuItem.Click += new System.EventHandler(this.downloadOpenCommandPromptHereToolStripMenuItem_Click);
            // 
            // downloadFreeColorwheelToolStripMenuItem
            // 
            this.downloadFreeColorwheelToolStripMenuItem.Name = "downloadFreeColorwheelToolStripMenuItem";
            resources.ApplyResources(this.downloadFreeColorwheelToolStripMenuItem, "downloadFreeColorwheelToolStripMenuItem");
            this.downloadFreeColorwheelToolStripMenuItem.Click += new System.EventHandler(this.downloadFreeColorwheelToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpGuideToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.buyNowToolStripMenuItem,
            this.tiHelpFeedback,
            this.toolStripMenuItem1,
            this.registerToolStripMenuItem,
            this.visit4dotsSoftwareWebsiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpGuideToolStripMenuItem
            // 
            this.helpGuideToolStripMenuItem.Image = global::FreePDFToTextConverter.Properties.Resources.help2;
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            resources.ApplyResources(this.helpGuideToolStripMenuItem, "helpGuideToolStripMenuItem");
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::FreePDFToTextConverter.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buyNowToolStripMenuItem
            // 
            this.buyNowToolStripMenuItem.Image = global::FreePDFToTextConverter.Properties.Resources.check;
            this.buyNowToolStripMenuItem.Name = "buyNowToolStripMenuItem";
            resources.ApplyResources(this.buyNowToolStripMenuItem, "buyNowToolStripMenuItem");
            this.buyNowToolStripMenuItem.Click += new System.EventHandler(this.buyNowToolStripMenuItem_Click);
            // 
            // tiHelpFeedback
            // 
            this.tiHelpFeedback.Image = global::FreePDFToTextConverter.Properties.Resources.edit;
            this.tiHelpFeedback.Name = "tiHelpFeedback";
            resources.ApplyResources(this.tiHelpFeedback, "tiHelpFeedback");
            this.tiHelpFeedback.Click += new System.EventHandler(this.tiHelpFeedback_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            resources.ApplyResources(this.registerToolStripMenuItem, "registerToolStripMenuItem");
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // visit4dotsSoftwareWebsiteToolStripMenuItem
            // 
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Name = "visit4dotsSoftwareWebsiteToolStripMenuItem";
            resources.ApplyResources(this.visit4dotsSoftwareWebsiteToolStripMenuItem, "visit4dotsSoftwareWebsiteToolStripMenuItem");
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visit4dotsSoftwareWebsiteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 30000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnClearMerge
            // 
            resources.ApplyResources(this.btnClearMerge, "btnClearMerge");
            this.btnClearMerge.Image = global::FreePDFToTextConverter.Properties.Resources.brush4;
            this.btnClearMerge.Name = "btnClearMerge";
            this.btnClearMerge.UseVisualStyleBackColor = true;
            this.btnClearMerge.Click += new System.EventHandler(this.btnClearMerge_Click);
            // 
            // btnAddFolder
            // 
            resources.ApplyResources(this.btnAddFolder, "btnAddFolder");
            this.btnAddFolder.Image = global::FreePDFToTextConverter.Properties.Resources.folder_add;
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnRemoveFile
            // 
            resources.ApplyResources(this.btnRemoveFile, "btnRemoveFile");
            this.btnRemoveFile.Image = global::FreePDFToTextConverter.Properties.Resources.delete;
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFiles
            // 
            resources.ApplyResources(this.btnAddFiles, "btnAddFiles");
            this.btnAddFiles.Image = global::FreePDFToTextConverter.Properties.Resources.add;
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnConvertToText
            // 
            resources.ApplyResources(this.btnConvertToText, "btnConvertToText");
            this.btnConvertToText.Image = global::FreePDFToTextConverter.Properties.Resources.flash;
            this.btnConvertToText.Name = "btnConvertToText";
            this.btnConvertToText.UseVisualStyleBackColor = true;
            this.btnConvertToText.Click += new System.EventHandler(this.btnRemovePassword_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Image = global::FreePDFToTextConverter.Properties.Resources.exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dgFiles
            // 
            this.dgFiles.AllowDrop = true;
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgFiles, "dgFiles");
            this.dgFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilename,
            this.colSettings,
            this.colPassword,
            this.colEncoding,
            this.colSize,
            this.colFileDate,
            this.colFullFilePath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgFiles.GridColor = System.Drawing.Color.Black;
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.RowHeadersVisible = false;
            this.dgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiles_CellContentClick);
            this.dgFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgFiles_DragDrop);
            this.dgFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgFiles_DragEnter);
            this.dgFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.dgFiles_DragOver);
            // 
            // colFilename
            // 
            this.colFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFilename.DataPropertyName = "filename";
            resources.ApplyResources(this.colFilename, "colFilename");
            this.colFilename.Name = "colFilename";
            this.colFilename.ReadOnly = true;
            // 
            // colSettings
            // 
            this.colSettings.DataPropertyName = "settings";
            resources.ApplyResources(this.colSettings, "colSettings");
            this.colSettings.Name = "colSettings";
            this.colSettings.Text = "...";
            this.colSettings.UseColumnTextForButtonValue = true;
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPassword.DataPropertyName = "password";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.colPassword, "colPassword");
            this.colPassword.Name = "colPassword";
            // 
            // colEncoding
            // 
            this.colEncoding.DataPropertyName = "encoding";
            resources.ApplyResources(this.colEncoding, "colEncoding");
            this.colEncoding.Name = "colEncoding";
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "sizekb";
            resources.ApplyResources(this.colSize, "colSize");
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // colFileDate
            // 
            this.colFileDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFileDate.DataPropertyName = "filedate";
            resources.ApplyResources(this.colFileDate, "colFileDate");
            this.colFileDate.Name = "colFileDate";
            this.colFileDate.ReadOnly = true;
            // 
            // colFullFilePath
            // 
            this.colFullFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFullFilePath.DataPropertyName = "fullfilepath";
            resources.ApplyResources(this.colFullFilePath, "colFullFilePath");
            this.colFullFilePath.Name = "colFullFilePath";
            this.colFullFilePath.ReadOnly = true;
            // 
            // rdSameFolder
            // 
            resources.ApplyResources(this.rdSameFolder, "rdSameFolder");
            this.rdSameFolder.BackColor = System.Drawing.Color.Transparent;
            this.rdSameFolder.Checked = true;
            this.rdSameFolder.Name = "rdSameFolder";
            this.rdSameFolder.TabStop = true;
            this.rdSameFolder.UseVisualStyleBackColor = false;
            // 
            // rdDocumentsFolder
            // 
            resources.ApplyResources(this.rdDocumentsFolder, "rdDocumentsFolder");
            this.rdDocumentsFolder.BackColor = System.Drawing.Color.Transparent;
            this.rdDocumentsFolder.Name = "rdDocumentsFolder";
            this.rdDocumentsFolder.UseVisualStyleBackColor = false;
            this.rdDocumentsFolder.CheckedChanged += new System.EventHandler(this.rdDocumentsFolder_CheckedChanged);
            // 
            // btnOpenFolder
            // 
            resources.ApplyResources(this.btnOpenFolder, "btnOpenFolder");
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnChangeFolder
            // 
            resources.ApplyResources(this.btnChangeFolder, "btnChangeFolder");
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.UseVisualStyleBackColor = true;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnChangeFolder);
            this.groupBox1.Controls.Add(this.rdDocumentsFolder);
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.rdSameFolder);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chkOneFile
            // 
            resources.ApplyResources(this.chkOneFile, "chkOneFile");
            this.chkOneFile.BackColor = System.Drawing.Color.Transparent;
            this.chkOneFile.Name = "chkOneFile";
            this.chkOneFile.UseVisualStyleBackColor = false;
            // 
            // chkHTML
            // 
            resources.ApplyResources(this.chkHTML, "chkHTML");
            this.chkHTML.BackColor = System.Drawing.Color.Transparent;
            this.chkHTML.Name = "chkHTML";
            this.chkHTML.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.chkHTML);
            this.Controls.Add(this.chkOneFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearMerge);
            this.Controls.Add(this.btnConvertToText);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowInTaskbar = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem tiHelpFeedback;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnClearMerge;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnConvertToText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadMultipleSearchAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadPDFMergeSplitToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFreeFileUnlockerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadImgTransformerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFreeImagemapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadCopyPathToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadCopyTextContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadOpenCommandPromptHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFreeColorwheelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadDocusTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visit4dotsSoftwareWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdSameFolder;
        public System.Windows.Forms.RadioButton rdDocumentsFolder;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilename;
        private System.Windows.Forms.DataGridViewButtonColumn colSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncoding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullFilePath;
        public System.Windows.Forms.CheckBox chkOneFile;
        public System.Windows.Forms.CheckBox chkHTML;
        private System.Windows.Forms.ToolStripMenuItem downloadFreePDFPasswordRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem downloadFreePDFMetadatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFreePDFProtectorToolStripMenuItem;
    }
}
