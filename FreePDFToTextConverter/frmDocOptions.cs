using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FreePDFToTextConverter
{
    public partial class frmDocOptions : CustomForm
    {
        private PageRange SelectedPageRange;
        private string Filepath = "";
        private string Password = "";

        public frmDocOptions(PageRange pr,string filepath,string password)
        {
            InitializeComponent();
            SelectedPageRange = pr;
            Filepath = filepath;
            Password = password;
        }

        private void frmDocOptions_Load(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                txtDocument.Text = Filepath;
                nudOddFrom.Increment = 2;
                nudOddTo.Increment = 2;
                nudEvenFrom.Increment = 2;
                nudEvenTo.Increment = 2;

                org.apache.pdfbox.pdmodel.PDDocument document =
                 org.apache.pdfbox.pdmodel.PDDocument.load(Filepath);

                if (!String.IsNullOrEmpty(Password) && document.isEncrypted())
                {
                    org.apache.pdfbox.pdmodel.encryption.StandardDecryptionMaterial sdm = new org.apache.pdfbox.pdmodel.encryption.StandardDecryptionMaterial(Password);
                    document.openProtection(sdm); 
                }

                int numpages = document.getNumberOfPages();
                document.close();


                nudEvenTo.Maximum = numpages;

                nudEvenFrom.Value = 2;

                if (numpages % 2 == 0)
                {
                    nudEvenTo.Value = numpages;
                }
                else
                {
                    nudEvenTo.Value = numpages - 1;

                }

                nudEvenTo.Maximum = numpages;
                nudEvenFrom.Maximum = numpages;

                nudOddTo.Maximum = numpages;

                nudFrom.Value = 1;
                nudOddFrom.Value = 1;

                if (numpages % 2 == 0)
                {
                    nudOddTo.Value = numpages  - 1;
                }
                else
                {
                    nudOddTo.Value = numpages;
                }

                nudOddTo.Maximum = numpages;
                nudOddFrom.Maximum = numpages;
                nudFrom.Maximum = numpages;
                nudTo.Maximum = numpages;

                nudTo.Value = numpages;


                nudEvery.Maximum = numpages;
                nudEvery.Value = 2;
                nudEveryFrom.Maximum = numpages;
                nudEveryTo.Maximum = numpages;

                nudEveryFrom.Value = nudFrom.Value;
                nudEveryTo.Value = nudTo.Value;

                txtPages.Text = numpages.ToString();
                SelectedPageRange.NumberOfPages = numpages;




                if (SelectedPageRange.Initialized)
                {

                    txtPages.Text = SelectedPageRange.NumberOfPages.ToString();
                    nudEvenFrom.Value = SelectedPageRange.PagesEvenFrom;
                    nudEvenTo.Value = SelectedPageRange.PagesEvenTo;
                    nudEvery.Value = SelectedPageRange.PagesEveryValue;
                    nudEveryFrom.Value = SelectedPageRange.PagesEveryFrom;
                    nudEveryTo.Value = SelectedPageRange.PagesEveryTo;
                    nudFrom.Value = SelectedPageRange.PagesFrom;
                    nudTo.Value = SelectedPageRange.PagesTo;
                    nudOddFrom.Value = SelectedPageRange.PagesOddFrom;
                    nudOddTo.Value = SelectedPageRange.PagesOddTo;

                    chkEven.Checked = SelectedPageRange.PagesEven;
                    chkEvery.Checked = SelectedPageRange.PagesEvery;
                    chkOdd.Checked = SelectedPageRange.PagesOdd;
                    chkPagesFromTo.Checked = SelectedPageRange.Pages;
                    chkAllPages.Checked = SelectedPageRange.AllPages;
                    txtPageRanges.Text = SelectedPageRange.PageRanges;

                    chkAllPages_CheckedChanged(null, null);
                }
            }
            finally
            {
                this.Cursor = null;
            }        }

        private void nudOddFrom_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown nu = (NumericUpDown)sender;

            if (nu.Value % 2 == 0)
            {
                Module.ShowMessage("Please insert an odd number !");
                e.Cancel = true;
            }
        }

        private void nudEvenFrom_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown nu = (NumericUpDown)sender;

            if (nu.Value % 2 != 0)
            {
                Module.ShowMessage("Please insert an even number !");
                e.Cancel = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedPageRange.Initialized = true;

            SelectedPageRange.NumberOfPages=int.Parse(txtPages.Text);
            SelectedPageRange.PagesEvenFrom=(int)nudEvenFrom.Value;
            SelectedPageRange.PagesEvenTo = (int)nudEvenTo.Value;
            SelectedPageRange.PagesEveryValue = (int)nudEvery.Value;
            SelectedPageRange.PagesEveryFrom = (int)nudEveryFrom.Value;
            SelectedPageRange.PagesEveryTo = (int)nudEveryTo.Value;
            SelectedPageRange.PagesFrom = (int)nudFrom.Value;
            SelectedPageRange.PagesTo = (int)nudTo.Value;
            SelectedPageRange.PagesOddFrom = (int)nudOddFrom.Value;
            SelectedPageRange.PagesOddTo = (int)nudOddTo.Value;

            SelectedPageRange.PagesEven = chkEven.Checked;
            SelectedPageRange.PagesEvery = chkEvery.Checked;
            SelectedPageRange.PagesOdd = chkOdd.Checked;
            SelectedPageRange.Pages = chkPagesFromTo.Checked;

            SelectedPageRange.AllPages = chkAllPages.Checked;

            SelectedPageRange.PagesContainingText = chkText.Checked;
            SelectedPageRange.PageText = "";

            SelectedPageRange.IncludedNumberOfPages = 0;
            SelectedPageRange.PageRanges = txtPageRanges.Text;

            /*
            PdfReader reader = null;

            if (chkText.Checked)
            {
                reader = new PdfReader(Filepath);
                string Password = "";

                if (reader.IsEncrypted())
                {
                    reader.Close();

                    while (true)
                    {
                        try
                        {
                            if (Password == "")
                            {
                                frmPassword f2 = new frmPassword();
                                DialogResult dres = f2.ShowDialog();

                                if (dres == DialogResult.OK)
                                {
                                    reader = new PdfReader(Filepath, Encoding.Default.GetBytes(f2.txtPassword.Text));

                                    if (f2.chkPassword.Checked)
                                    {
                                        Password = f2.txtPassword.Text;
                                    }

                                    break;
                                }
                                else if (dres == DialogResult.Cancel)
                                {
                                    Module.ShowMessage("Unable to Decrypt Document ! - " + Filepath);
                                    return;
                                }
                            }
                            else
                            {
                                reader = new PdfReader(Filepath, Encoding.Default.GetBytes(Password));
                                break;
                            }
                        }
                        catch
                        {
                            Module.ShowMessage("Unable to Decrypt Document ! - " + Filepath);
                            Password = "";
                            reader = null;

                            return;
                        }
                    }
                }
            }

            for (int k = 1; k <= SelectedPageRange.NumberOfPages; k++)
            {               
                if (MergeHelper.ShouldAddPage(k,SelectedPageRange,reader))
                {
                    SelectedPageRange.IncludedNumberOfPages++;
                }
            }

            frmMain.Instance.SetupTotalPages();
            */
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chkAllPages_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllPages.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void txtPageRanges_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtPageRanges.Text.Trim() != String.Empty)
                {
                    string[] ranges = txtPageRanges.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    for (int k = 0; k < ranges.Length; k++)
                    {
                        string[] range = ranges[k].Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                        int ifrom = int.Parse(range[0]);
                        int ito = int.Parse(range[1]);

                        if (ifrom <= 0 || ito<=0 || ifrom>int.Parse(txtPages.Text) || ito>int.Parse(txtPages.Text) || ifrom>ito)
                        {
                            Module.ShowMessage("Please insert valid page ranges, comma separated, e.g. 15-20,25-40,50-60");
                            e.Cancel = true;
                        }

                        
                    }
                }
            }
            catch
            {
                Module.ShowMessage("Please insert valid page ranges, comma separated, e.g. 15-20,25-40,50-60");
                e.Cancel = true;
            }
        }

        private void chkText_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Enabled = chkText.Checked;
        }
    }

    
}

