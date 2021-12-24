using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace FreePDFToTextConverter
{
    class ExtractTextHelper
    {
        public static string AllText = "";
        public static string AllFilepath = "";
        public static string FirstOutputFile = "";


        public static string ExtractText(DataTable dt)
        {
            string err = "";
            AllText = "";
            AllFilepath = "";
            bool add_to_one_pdf = frmMain.Instance.chkOneFile.Checked;
            FirstOutputFile = "";
            string encoding = "";

         for (int k = 0; k < dt.Rows.Count; k++)
            {                

                try
                {
                    string filepath = dt.Rows[k]["fullfilepath"].ToString();
                    string password = dt.Rows[k]["password"].ToString();
                    PageRange pagerange = (PageRange)dt.Rows[k]["pagerange"];
                    encoding = dt.Rows[k]["encoding"].ToString();
                    bool html = frmMain.Instance.chkHTML.Checked;

                    string outputfile = "";

                    if (frmMain.Instance.rdDocumentsFolder.Checked)
                    {
                        outputfile = System.IO.Path.Combine(frmMain.Instance.rdDocumentsFolder.Text, System.IO.Path.GetFileNameWithoutExtension(filepath) + ".txt");
                    }
                    else
                    {
                        string dirpath = System.IO.Path.GetDirectoryName(filepath);
                        outputfile = System.IO.Path.Combine(dirpath, System.IO.Path.GetFileNameWithoutExtension(filepath) + ".txt");
                    }
                    
                    
                                       
                    err += ExtractText(filepath, outputfile,password, encoding,html,pagerange, add_to_one_pdf);

                    if (add_to_one_pdf && AllFilepath==String.Empty)
                    {
                        AllFilepath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(outputfile), System.IO.Path.GetFileNameWithoutExtension(outputfile) + ".all.txt");
                    }

                    if (add_to_one_pdf)
                    {
                        FirstOutputFile = AllFilepath;
                    }
                    else if (FirstOutputFile == String.Empty)
                    {
                        FirstOutputFile = outputfile;
                    }

                }
                catch (Exception ex)
                {
                    err += ex.Message;
                }
            }

            if (add_to_one_pdf)
            {
                if (encoding != String.Empty)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(AllFilepath,false,Encoding.GetEncoding(encoding)))
                    {
                        sw.Write(AllText);
                    }
                }
                else
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(AllFilepath))
                    {
                        sw.Write(AllText);
                    }
                }
            }

            return err;

        }

        public static string ExtractText(string filepath,string outputfile,string password,string encoding,bool html,PageRange pagerange,bool add_to_one_pdf)
        {
            string err = "";
            string outtext = "";
            
            string tempfi = System.IO.Path.GetTempFileName();
            string tempfi2 = System.IO.Path.GetTempFileName();
            
            try
            {


                string arguments = "";

                if (!String.IsNullOrEmpty(password))
                {
                    arguments += " -password \"" + password + "\"";
                }

                if (!String.IsNullOrEmpty(encoding))
                {
                    arguments += " -encoding " + encoding;
                }

                if (html)
                {
                    arguments += " -html";
                }
                org.apache.pdfbox.pdmodel.PDDocument document =
                 org.apache.pdfbox.pdmodel.PDDocument.load(filepath);
                if (document.isEncrypted() && !String.IsNullOrEmpty(password))
                {
                    org.apache.pdfbox.pdmodel.encryption.StandardDecryptionMaterial sdm = new org.apache.pdfbox.pdmodel.encryption.StandardDecryptionMaterial(password);
                    document.openProtection(sdm); 
                                        
                }

                int numpages = document.getNumberOfPages();
                document.close();

                bool last_added = false;
                int endpage = 0;
                int startpage = 0;


                for (int i = 1; i <= numpages; i++)
                {
                    bool should_add = false;

                    if (!last_added)
                    {
                        startpage = i;
                    }

                    if (!last_added)
                    {
                        endpage = i;
                    }

                    try
                    {
                        string pagetext = "";

                        if (pagerange.PagesContainingText)
                        {
                            System.Diagnostics.ProcessStartInfo pi2 = new System.Diagnostics.ProcessStartInfo();
                            pi2.FileName = Application.StartupPath + "\\ExtractText.exe";
                            
                            pi2.Arguments = arguments + " -startPage " + i.ToString() + " -endPage " + i.ToString()
                            + " \"" + filepath + "\" \"" + tempfi2 + "\"";
                            pi2.UseShellExecute = false;
                            pi2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            pi2.RedirectStandardError = true;
                            pi2.CreateNoWindow = true;
                            System.Diagnostics.Process p2 = new System.Diagnostics.Process();
                            p2.StartInfo = pi2;
                            p2.Start();

                            p2.WaitForExit();

                            err += p2.StandardError.ReadToEnd();

                            if (encoding != String.Empty)
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi2, Encoding.GetEncoding(encoding)))
                                {
                                    pagetext += sr.ReadToEnd();
                                }
                            }
                            else
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi2))
                                {
                                    pagetext += sr.ReadToEnd();
                                }
                            }
                        }

                        if (ShouldAddPage(i, pagerange, pagetext))
                        {
                            endpage = i;
                            should_add = true;
                        }
                        else
                        {
                            should_add = false;
                        }
                    }
                    catch (Exception exi)
                    {
                        err += exi.Message + "\r\n";
                    }

                    if ((!should_add && last_added) || (last_added && i == numpages))
                    {
                        System.Diagnostics.ProcessStartInfo pi = new System.Diagnostics.ProcessStartInfo();
                        pi.FileName = Application.StartupPath + "\\ExtractText.exe";
                        
                        pi.Arguments = arguments + " -startPage " + startpage.ToString() + " -endPage " + endpage.ToString()
                        + " \"" + filepath + "\" \"" + tempfi + "\"";
                        pi.UseShellExecute = false;
                        pi.CreateNoWindow = true;
                        pi.RedirectStandardError = true;
                        pi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        System.Diagnostics.Process p = new System.Diagnostics.Process();
                        p.StartInfo = pi;
                        p.Start();

                        p.WaitForExit();

                        err += p.StandardError.ReadToEnd();

                        if (!add_to_one_pdf)
                        {
                            if (encoding != String.Empty)
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi, Encoding.GetEncoding(encoding)))
                                {
                                    if (outtext != String.Empty)
                                    {
                                        outtext += "\r\n";
                                    }

                                    outtext += sr.ReadToEnd();
                                }
                            }
                            else
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi))
                                {
                                    if (outtext != String.Empty)
                                    {
                                        outtext += "\r\n";
                                    }

                                    outtext += sr.ReadToEnd();
                                }
                            }
                        }
                        else
                        {
                            if (encoding != String.Empty)
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi, Encoding.GetEncoding(encoding)))
                                {
                                    if (AllText != String.Empty)
                                    {
                                        AllText += "\r\n";
                                    }

                                    AllText += sr.ReadToEnd();
                                }
                            }
                            else
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(tempfi))
                                {
                                    if (AllText != String.Empty)
                                    {
                                        AllText += "\r\n";
                                    }

                                    AllText += sr.ReadToEnd();
                                }
                            }
                        }
                    }


                    last_added = should_add;
                }
            }
            catch (Exception ex)
            {
                err += ex.Message + "\r\n";
            }
            finally
            {
                if (System.IO.File.Exists(tempfi))
                {
                    try { System.IO.File.Delete(tempfi); }
                    catch { }
                }

                if (System.IO.File.Exists(tempfi2))
                {
                    try { System.IO.File.Delete(tempfi2); }
                    catch { }
                }
            }
            if (!add_to_one_pdf)
            {
                if (encoding != String.Empty)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputfile,false,Encoding.GetEncoding(encoding)))
                    {
                        sw.Write(outtext);
                    }
                }
                else
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputfile))
                    {
                        sw.Write(outtext);
                    }
                }
            }


            return err;
        }

        public static bool ShouldAddPage(int pagenum, PageRange pagerange,string pagetext)
        {
            if (pagerange.AllPages)
            {
                return true;
            }

            bool add = false;

            if (pagerange.Pages)
            {
                if (pagenum < pagerange.PagesFrom || pagenum > pagerange.PagesTo)
                {

                }
                else
                {
                    return true;

                }

            }

            if (pagerange.PagesOdd)
            {
                if (pagenum % 2 != 0)
                {
                    if (pagenum < pagerange.PagesOddFrom || pagenum > pagerange.PagesOddTo)
                    {

                    }
                    else
                    {
                        return true;
                    }
                }
            }

            if (pagerange.PagesEven)
            {
                if (pagenum % 2 == 0)
                {

                    if (pagenum < pagerange.PagesEvenFrom || pagenum > pagerange.PagesEvenTo)
                    {

                    }
                    else
                    {
                        return true;
                    }
                }
            }

            if (pagerange.PagesEvery)
            {
                if (pagenum < pagerange.PagesEveryFrom || pagenum > pagerange.PagesEveryTo)
                {

                }
                else
                {
                    int ieveryfrom = (int)pagerange.PagesEveryFrom;

                    if ((pagenum - ieveryfrom) % pagerange.PagesEveryValue == 0)
                    {
                        return true;
                    }
                }
            }

            if (pagerange.PageRanges.Trim() != String.Empty)
            {
                string[] ranges = pagerange.PageRanges.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < ranges.Length; k++)
                {
                    string[] range = ranges[k].Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                    int ifrom = int.Parse(range[0]);
                    int ito = int.Parse(range[1]);

                    if (pagenum < ifrom || pagenum > ito)
                    {

                    }
                    else
                    {
                        return true;
                    }
                }

            }

            if (pagerange.PagesContainingText)
            {
                if (pagetext.Contains(pagerange.PageText))                
                {
                    return true;
                }
            }

            return false;
        }

    }
}
