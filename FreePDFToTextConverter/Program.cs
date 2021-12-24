using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace FreePDFToTextConverter
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        const int ATTACH_PARENT_PROCESS = -1;
        const int ERROR_ACCESS_DENIED = 5;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///         
        [STAThread]
        static void Main(string[] args)
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLanguage.SetLanguages();
            SetLanguage();

            if (args.Length > 0 && args[0].StartsWith("/uninstall"))
            {
                
                return;
                Environment.Exit(0);
            }

            ExceptionHandlersHelper.AddUnhandledExceptionHandlers();

            if (args.Length > 0)
            {
                //System.Threading.Thread.Sleep(2000);
            }

            ArgsHelper.ExamineArgs(args);                                    

            Application.Run(new frmMain());
            Environment.Exit(0);
        }

        public static void SetLanguage()
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey key2 = Registry.CurrentUser;
            string lang = "";

            try
            {
                key = key.OpenSubKey("Software\\4dots Software", true);

                if (key == null)
                {
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\4dots Software");
                }

                key2 = key.OpenSubKey("PDF To Text Converter", true);

                if (key2 == null)
                {
                    key2 = key.CreateSubKey("PDF To Text Converter");
                }

                key = key2;

                bool setlang = false;

                if (key.GetValue("Language") == null)
                {
                    frmLanguage fl = new frmLanguage();
                    fl.ShowDialog();

                    key.SetValue("Language", frmLanguage.SelectedLanguageCode);
                    setlang = true;   
                    
                }

                if (key != null && key.GetValue("Language") != null)
                {
                    lang = key.GetValue("Language").ToString();
                    Module.SelectedLanguage = lang;
                    if (lang == "en-US")
                    {
                        System.Threading.Thread.CurrentThread.CurrentUICulture =
                            System.Globalization.CultureInfo.InvariantCulture;

                        Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

                    }
                    else
                    {

                        try
                        {
                            System.Threading.Thread.CurrentThread.CurrentUICulture = new
                            System.Globalization.CultureInfo(lang);

                            Application.CurrentCulture = new System.Globalization.CultureInfo(lang);
                        }
                        catch (Exception ex)
                        {
                            Module.ShowError(ex);
                        }
                    }
                }

                if (setlang)
                {
                    key.SetValue("Menu Item Caption", TranslateHelper.Translate("Convert PDF to Text"));
                }
                
            }
            catch (Exception exr)
            {
                Module.ShowError(exr);
            }
            finally
            {
                key.Close();
                key2.Close();
            }

            
        }


    }
}