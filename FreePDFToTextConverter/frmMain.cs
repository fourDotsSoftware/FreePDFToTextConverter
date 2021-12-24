using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace FreePDFToTextConverter
{
    public partial class frmMain : FreePDFToTextConverter.CustomForm
    {
        public static frmMain Instance = null;

        public DataTable dt = new DataTable("pdfs");

        public frmMain()
        {
            InitializeComponent();
            rdDocumentsFolder.Text = Module.UserDocumentsFolder;
            dgFiles.AutoGenerateColumns = false;

            Instance = this;

            if (Module.IsCommandLine)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //iTextSharp.text.Document doc = new iTextSharp.text.Document();
            /*
            PdfReader reader = new PdfReader(@"c:\4\head first ajax.pdf");

            Document doc = new Document(reader.GetPageSizeWithRotation(1));

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"c:\4\test.pdf",FileMode.Create));
            doc.Open();
            PdfContentByte cb = writer.DirectContent;
            */
            /*
            for (int k = 1; k <= reader.NumberOfPages; k++)
            {
                doc.SetPageSize(reader.GetPageSizeWithRotation(i));
                PdfDictionary pdfdict=pdfReader.GetPageN(k);
                PdfImportedPage imp=pdfWriter.GetImportedPage(pdfReader, k);
                pdfWriter.Add(imp);

            }
            */
        }

        private void AddVisual(string[] argsvisual)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //Module.ShowMessage("Is From Windows Explorer");                                

                for (int k = 0; k < argsvisual.Length; k++)
                {
                    if (System.IO.File.Exists(argsvisual[k]))
                    {
                        AddFile(argsvisual[k]);

                    }
                    else if (System.IO.Directory.Exists(argsvisual[k]))
                    {
                        AddFolder(argsvisual[k]);
                    }
                }
            }
            finally
            {
                this.Cursor = null;
            }
        }

        private void SetupOnLoad()
        {
            this.Text = Module.ApplicationTitle;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = 0;
            AddLanguageMenuItems();

            if (ArgsHelper.FromWindowsExplorer)
            {
                AddVisual(Module.args);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {           
            dt.Columns.Add("filename");
            dt.Columns.Add("password");
            dt.Columns.Add("sizekb");
            dt.Columns.Add("fullfilepath");
            dt.Columns.Add("filedate");
            dt.Columns.Add("settings");
            dt.Columns.Add("encoding");
            dt.Columns.Add("pagerange",typeof(PageRange));

            dgFiles.DataSource = dt;

            SetupOnLoad();            
            


        }

        #region Localization

        private void AddLanguageMenuItems()
        {
            for (int k = 0; k < frmLanguage.LangCodes.Count; k++)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = frmLanguage.LangDesc[k];
                ti.Tag = frmLanguage.LangCodes[k];
                ti.Image = frmLanguage.LangImg[k];
                ti.Click += new EventHandler(tiLang_Click);
                languageToolStripMenuItem.DropDownItems.Add(ti);
            }
        }

        void tiLang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ti = (ToolStripMenuItem)sender;
            string langcode = ti.Tag.ToString();
            ChangeLanguage(langcode);

            for (int k = 0; k < languageToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languageToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }
        }

        private void ChangeLanguage(string language_code)
        {
            string rd = rdDocumentsFolder.Text;

            RegistryKey key = Registry.CurrentUser;
            try
            {
                key = key.OpenSubKey("SOFTWARE\\4dots Software\\PDF To Text Converter", true);

                key.SetValue("Language", language_code);
                Program.SetLanguage();
                key.SetValue("Menu Item Caption", TranslateHelper.Translate("Convert PDF to Text"));
            }
            catch (Exception ex)
            {
                Module.ShowError(ex);
                return;
            }
            finally
            {
                key.Close();
            }

            

            this.Controls.Clear();

            bool t1e = timer1.Enabled;
            bool t2e = timer2.Enabled;
            bool t3e = timer3.Enabled;

            InitializeComponent();

            timer1.Enabled = t1e;
            timer2.Enabled = t2e;
            timer3.Enabled = t3e;

            SetupOnLoad();

            rdDocumentsFolder.Text = rd;
        }

        #endregion
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Module.DialogFilesFilter;
            openFileDialog1.Multiselect = true;
            
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    for (int k = 0; k < openFileDialog1.FileNames.Length; k++)
                    {                        
                        AddFile(openFileDialog1.FileNames[k]);
                    }
                }
                finally
                {
                    this.Cursor = null;
                }
            }
        }

        public bool AddFile(string filepath)
        {
            if (System.IO.Path.GetExtension(filepath).ToLower() != ".pdf")
            {
                Module.ShowMessage("Please add only PDF Files !");
                return false;
            }

            DataRow dr = dt.NewRow();
                        
            FileInfo fi=new FileInfo(filepath);

            long sizekb=fi.Length/1024;
            dr["filename"]=fi.Name;
            dr["fullfilepath"] = filepath;
            dr["sizekb"] = sizekb.ToString() + "KB";
            dr["filedate"] = fi.LastWriteTime.ToString();
            dr["pagerange"] = new PageRange();
            dr["encoding"]="UTF-8";

            string password = "";

            if (dt.Rows.Count > 0)
            {
                password = dt.Rows[dt.Rows.Count - 1]["password"].ToString();
            }

            dr["password"] = password;

            dt.Rows.Add(dr);

            return true;
        }                                                                

        private void btnAddFolder_Click(object sender, EventArgs e)
        {            
            folderBrowserDialog1.SelectedPath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                AddFolder(folderBrowserDialog1.SelectedPath);   
            }
        }

        public void AddFolder(string folder_path)
        {
            string[] filez = null;

            if (Module.IsCommandLine)
            {
                if (Module.CmdAddSubdirectories)
                {
                    filez = System.IO.Directory.GetFiles(folder_path, "*.pdf", SearchOption.AllDirectories);
                }
                else
                {
                    filez = System.IO.Directory.GetFiles(folder_path, "*.pdf", SearchOption.TopDirectoryOnly);
                }
            }
            else
            {

                if (System.IO.Directory.GetDirectories(folder_path).Length > 0)
                {
                    DialogResult dres = Module.ShowQuestionDialog("Would you like to add also Subdirectories ?", "Add Subdirectories ?");

                    if (dres == DialogResult.Yes)
                    {
                        filez = System.IO.Directory.GetFiles(folder_path, "*.pdf", SearchOption.AllDirectories);
                    }
                    else
                    {
                        filez = System.IO.Directory.GetFiles(folder_path, "*.pdf", SearchOption.TopDirectoryOnly);
                    }
                }
                else
                {
                    filez = System.IO.Directory.GetFiles(folder_path, "*.pdf", SearchOption.TopDirectoryOnly);
                }
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int k = 0; k < filez.Length; k++)
                {
                    if (filez[k].ToLower().EndsWith(".pdf"))
                    {
                        AddFile(filez[k]);
                    }
                    
                }
            }
            finally
            {
                this.Cursor = null;
            }

        }

        
                

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = dgFiles.SelectedCells;
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            for (int k = 0; k < cells.Count; k++)
            {
                if (rows.IndexOf(dgFiles.Rows[cells[k].RowIndex]) < 0)
                {
                    rows.Add(dgFiles.Rows[cells[k].RowIndex]);
                }
            }

            for (int k = 0; k < rows.Count; k++)
            {
                dgFiles.Rows.Remove(rows[k]);
            }
                       
        }

        private void tiHelpFeedback_Click(object sender, EventArgs e)
        {
            /*
            frmUninstallQuestionnaire f = new frmUninstallQuestionnaire(false);
            f.ShowDialog();
           */

            System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgFiles.SelectedRows.Count == 0) return;

            System.Diagnostics.Process.Start(dgFiles.SelectedRows[0].Cells["colFullFilepath"].Value.ToString());

        }               

        private bool IsDragging = false;

        /*
        private void lvDocs_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void lvDocs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop,false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lvDocs_DragDrop(object sender, DragEventArgs e)
        {           

            Point pt = lvDocs.PointToClient(Cursor.Position);
            ListViewHitTestInfo hiti = lvDocs.HitTest(pt.X, pt.Y);

            //if (hiti.Item != null)
            //{

            int ind = -1;
            if (hiti.Item != null)
            {
                ind = hiti.Item.Index;
            }

            List<ListViewItem> lst = new List<ListViewItem>();

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);

                for (int k = 0; k < filez.Length; k++)
                {
                    bool isimage = false;                                        

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        AddFile(filez[k]);
                    }
                    finally
                    {
                        this.Cursor = null;
                    }

                    lst.Add(lvDocs.Items[lvDocs.Items.Count - 1]);
                }

                if (hiti.Item != null && (lvDocs.Items.Count != lst.Count))
                {
                    for (int k = 0; k < lst.Count; k++)
                    {
                        lvDocs.Items.Remove(lst[k]);
                    }

                    for (int k = 0; k < lst.Count; k++)
                    {
                        lvDocs.Items.Insert(ind + k, lst[k]);
                    }
                }
            }


            //}

        }
        */                                              

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //ImagesViewHelper.GeneratePreviewItems();
            timer3.Enabled = false;
        }

        private void buyNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Module.StoreUrl);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAdeia f = new frmAdeia();
            //f.ShowDialog();
        }

        protected override void WndProc(ref Message m)
        {
            /*
            if (m.Msg == Program.WM_MULTIPLE_SEARCH_REPLACE)
            {
                MessageBox.Show(m.GetLParam(typeof(string)).ToString());
                lstIncludePaths.Items.Add(m.GetLParam(typeof(string)));
            }
            base.WndProc(ref m);
            */

            if (m.Msg == MessageHelper.WM_COPYDATA)
            {
                MessageHelper.COPYDATASTRUCT mystr = new MessageHelper.COPYDATASTRUCT();
                Type mytype = mystr.GetType();
                mystr = (MessageHelper.COPYDATASTRUCT)m.GetLParam(mytype);
                //MessageBox.Show(mystr.lpData);

                string arg = mystr.lpData;

                //MessageBox.Show("RECEIVED MESSAGE :" + arg);
                string[] args = arg.Split(new string[] { "|||" }, StringSplitOptions.RemoveEmptyEntries);

                //frmClientImages.Instance.ShowSendToMenuForm(args);
                for (int n = 1; n <= args.GetUpperBound(0); n++)
                {
                    //MessageBox.Show(args[n]);
                }

                AddVisual(args);


            }
            else if (m.Msg == MessageHelper.WM_ACTIVATEAPP)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }



            base.WndProc(ref m);
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Module.SelectedLanguage == "en-US")
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Free PDF To Text Converter 4dots - Users Manual.chm");
            }
            else
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\" + Module.SelectedLanguage + "\\Free PDF To Text Converter 4dots - Users Manual.chm");
            }
        }

        private void btnClearMerge_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();                        
            
        }

        private void btnRemovePassword_Click(object sender, EventArgs e)
        {            
            try
            {
                dgFiles.EndEdit();


                if (dt.Rows.Count == 0)
                {
                    Module.ShowMessage("Please add PDF Files first !");
                    return;
                }

                backgroundWorker1.RunWorkerAsync();

                string err = ExtractTextHelper.ExtractText(dt);

                backgroundWorker1.CancelAsync();

                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }

                if (err == String.Empty)
                {                   
                    Module.ShowMessage("Operation completed successfully !");
                    string args = string.Format("/e, /select, \"{0}\"",ExtractTextHelper.FirstOutputFile);
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "explorer";
                    info.UseShellExecute = true;
                    info.Arguments = args;
                    Process.Start(info);
                }
                else
                {
                    frmMessage f = new frmMessage();
                    f.lblMsg.Text = TranslateHelper.Translate("Operation completed with Errors !");
                    f.txtMsg.Text = err;

                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Module.ShowError("Error", ex);
            }
            finally
            {
                
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            int bsize = btnConvertToText.Width + 20 + btnExit.Width;
            btnConvertToText.Left = (this.ClientRectangle.Width / 2) - (bsize / 2);
            btnExit.Left = btnConvertToText.Right + 20;

            
        }

        private void dgFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);

                for (int k = 0; k < filez.Length; k++)
                {
                    bool isimage = false;

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        AddFile(filez[k]);
                    }
                    finally
                    {
                        this.Cursor = null;
                    }                    
                }                
            }

        }

        private void dgFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void dgFiles_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void downloadMultipleSearchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.multiplereplace.com");
        }

        private void downloadPDFMergeSplitToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdfmergesplittool/");

        }

        private void downloadFreeFileUnlockerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.freefileunlocker.com");
        }

        private void downloadImgTransformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.imgtransformer.com");
        }

        private void downloadFreeImagemapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/imagemapper2/");
        }

        private void downloadCopyPathToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/copypathtoclipboard/");
        }

        private void downloadCopyTextContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/copytextcontents/");
        }

        private void downloadOpenCommandPromptHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/open_command_prompt_here/");
        }

        private void downloadFreeColorwheelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/colorwheel/");
        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com");
        }


        private void downloadDocusTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/freedocustree/");
        }

        

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            dgFiles.EndEdit();

            if (rdSameFolder.Checked)
            {
                if (dt.Rows.Count == 0)
                {
                    Module.ShowMessage("Please add a PDF File first !");

                }
                else
                {
                    string dirpath = "";
                    string filepath = "";

                    if (dgFiles.SelectedCells.Count == 0)
                    {
                        dirpath = System.IO.Path.GetDirectoryName(dgFiles.Rows[0].Cells["colFullfilepath"].Value.ToString());
                        
                    }
                    else
                    {
                        dirpath = System.IO.Path.GetDirectoryName(dgFiles.SelectedCells[0].OwningRow.Cells["colFullfilepath"].Value.ToString());
                        
                    }
                                        
                    //string args = string.Format("/e, /select, \"{0}\"",dirpath);
                    string args = dirpath;
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "explorer";
                    info.UseShellExecute = true;
                    info.Arguments = args;
                    Process.Start(info);
                    
                    /*
                    return;
                    List<IntPtr> lst = new List<IntPtr>();
                    IntPtr pidlFolder = IntPtr.Zero;
                    IntPtr[] pidl = new IntPtr[] { IntPtr.Zero };

                    

                    UInt32 a = 0;

                    if (Module.SHParseDisplayName(filepath, IntPtr.Zero,out pidlFolder,(UInt32) 0, out (UInt32)a) != 0)
                    {
                        lst.Add(pidlFolder);
                        pidl = lst.ToArray();
                        Module.SHOpenFolderAndSelectItems(pidlFolder, (UInt32)pidl.Length,pidl, (UInt32) 0);
                    }
                    */
                }
            }
            else
            {
                
                    if (!System.IO.Directory.Exists(rdDocumentsFolder.Text))
                    {
                        System.IO.Directory.CreateDirectory(rdDocumentsFolder.Text);
                    }

                    System.Diagnostics.Process.Start(rdDocumentsFolder.Text);               
                    
            }
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                rdDocumentsFolder.Text = folderBrowserDialog2.SelectedPath;
                frmMain_Resize(null, null);
            }
        }

        private void rdDocumentsFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDocumentsFolder.Checked)
            {
                System.IO.Directory.CreateDirectory(rdDocumentsFolder.Text);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            frmProgress fp = new frmProgress();
            fp.Show();

            while (true)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    fp.Close();
                    return;
                }

                Application.DoEvents();
                
            }
        }

        private void dgFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colSettings.Index)
            {
                if (e.RowIndex != -1)
                {
                    DataTable dt = (DataTable)dgFiles.DataSource;
                    frmDocOptions f = new frmDocOptions((PageRange)(dt.Rows[e.RowIndex]["pagerange"]), dt.Rows[e.RowIndex]["fullfilepath"].ToString(), dt.Rows[e.RowIndex]["password"].ToString());
                    f.ShowDialog();
                }
            }
        }

        private void downloadFreePDFPasswordRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdf_password_remover/");
        }

        private void downloadFreePDFMetadatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdf_metadata_editor/");
        }

        private void downloadFreePDFProtectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdfencrypter/");
        }



    }
}

