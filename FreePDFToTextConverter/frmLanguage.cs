using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreePDFToTextConverter
{
    public partial class frmLanguage : CustomForm
    {
        public static List<string> LangCodes = new List<string>();
        public static List<string> LangDesc = new List<string>();
        public static List<Image> LangImg = new List<Image>();

        public static string SelectedLanguageCode = "";

        public frmLanguage()
        {
            InitializeComponent();
            
        }
                
        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedLanguageCode = LangCodes[cmbLanguage.SelectedIndex];
            this.DialogResult = DialogResult.OK;
        }

        public static void SetLanguages()
        {
            LangCodes.Add("en-US");
            LangCodes.Add("de-DE");
            LangCodes.Add("fr-FR");
            LangCodes.Add("es-ES");
            LangCodes.Add("pt-PT");
            LangCodes.Add("it-IT");
            LangCodes.Add("zh-CHS");
            LangCodes.Add("nl-NL");
            LangCodes.Add("fi-FI");
            LangCodes.Add("da-DK");
            LangCodes.Add("ja-JP");
            LangCodes.Add("nn-NO");
            LangCodes.Add("ru-RU");
            LangCodes.Add("sv-SE");
            LangCodes.Add("el-GR");
            LangCodes.Add("ar-SA");
            LangCodes.Add("cs-CZ");
            LangCodes.Add("he-IL");
            LangCodes.Add("hu-HU");
            LangCodes.Add("is-IS");
            LangCodes.Add("ko-KR");
            LangCodes.Add("pl-PL");
            LangCodes.Add("ro-RO");
            LangCodes.Add("hr-HR");
            LangCodes.Add("sk-SK");
            LangCodes.Add("th-TH");
            LangCodes.Add("tr-TR");
            LangCodes.Add("id-ID");
            LangCodes.Add("uk-UA");
            LangCodes.Add("be-BY");
            LangCodes.Add("sl-SL");
            LangCodes.Add("et-EE");
            LangCodes.Add("lv-LV");
            LangCodes.Add("lt-LT");
            LangCodes.Add("fa-IR");
            LangCodes.Add("vi-VN");
            LangCodes.Add("ka-GE");
            LangCodes.Add("hi-IN");

            LangDesc.Add("English");
            LangDesc.Add("Deutsch");
            LangDesc.Add("Français");
            LangDesc.Add("Español");
            LangDesc.Add("Português");
            LangDesc.Add("Italiano");
            LangDesc.Add("中文");
            LangDesc.Add("Nederlands");
            LangDesc.Add("Suomi");
            LangDesc.Add("Dansk");
            LangDesc.Add("日本の");
            LangDesc.Add("Norske");
            LangDesc.Add("Pусский");
            LangDesc.Add("Svenskt");
            LangDesc.Add("Ελληνικά");
            LangDesc.Add("العربية");
            LangDesc.Add("český");
            LangDesc.Add("עברית");
            LangDesc.Add("Magyar");
            LangDesc.Add("Íslenska");
            LangDesc.Add("한국인");
            LangDesc.Add("Polski");
            LangDesc.Add("Român");
            LangDesc.Add("Hrvatski");
            LangDesc.Add("Slovenských");
            LangDesc.Add("คนไทย");
            LangDesc.Add("Türk");
            LangDesc.Add("Indonesia");
            LangDesc.Add("Yкраїнець");
            LangDesc.Add("беларускай");
            LangDesc.Add("Slovenski");
            LangDesc.Add("Eestlane");
            LangDesc.Add("Latvietis");
            LangDesc.Add("Lietuvis");
            LangDesc.Add("فارسی");
            LangDesc.Add("Việt");
            LangDesc.Add("საქართველოს");
            LangDesc.Add("हिंदी");

            LangImg.Add((Image)ResFlags.flag_great_britain);
            LangImg.Add((Image)ResFlags.flag_germany);
            LangImg.Add((Image)ResFlags.flag_france);
            LangImg.Add((Image)ResFlags.flag_spain);
            LangImg.Add((Image)ResFlags.flag_portugal);
            LangImg.Add((Image)ResFlags.flag_italy);
            LangImg.Add((Image)ResFlags.flag_china);
            LangImg.Add((Image)ResFlags.flag_netherlands);
            LangImg.Add((Image)ResFlags.flag_finland);
            LangImg.Add((Image)ResFlags.flag_denmark);
            LangImg.Add((Image)ResFlags.flag_japan);
            LangImg.Add((Image)ResFlags.flag_norway);
            LangImg.Add((Image)ResFlags.flag_russia);
            LangImg.Add((Image)ResFlags.flag_sweden);
            LangImg.Add((Image)ResFlags.flag_greece);
            LangImg.Add((Image)ResFlags.flag_saudi_arabia);
            LangImg.Add((Image)ResFlags.flag_czech_republic);
            LangImg.Add((Image)ResFlags.flag_israel);
            LangImg.Add((Image)ResFlags.flag_hungary);
            LangImg.Add((Image)ResFlags.flag_iceland);
            LangImg.Add((Image)ResFlags.flag_south_korea);
            LangImg.Add((Image)ResFlags.flag_poland);
            LangImg.Add((Image)ResFlags.flag_romania);
            LangImg.Add((Image)ResFlags.flag_croatia);
            LangImg.Add((Image)ResFlags.flag_slovenia);
            LangImg.Add((Image)ResFlags.flag_thailand);
            LangImg.Add((Image)ResFlags.flag_turkey);
            LangImg.Add((Image)ResFlags.flag_indonesia);
            LangImg.Add((Image)ResFlags.flag_ukraine);
            LangImg.Add((Image)ResFlags.flag_belarus);
            LangImg.Add((Image)ResFlags.flag_slovenia);
            LangImg.Add((Image)ResFlags.flag_estonia);
            LangImg.Add((Image)ResFlags.flag_latvia);
            LangImg.Add((Image)ResFlags.flag_lithuania);
            LangImg.Add((Image)ResFlags.flag_iran);
            LangImg.Add((Image)ResFlags.flag_vietnam);
            LangImg.Add((Image)ResFlags.flag_georgia);
            LangImg.Add((Image)ResFlags.flag_india);

            

        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            //chinese,dutch,finish,danish,japan,norway,russia,sweden
            /*
            cmbLanguage.Items.AddRange(new string[] { "English", "Deutsch", "Français", "Español", "Português",
            "Italiano", "中文", "Nederlands", "Suomi", "Dansk", "日本の", "Norske", "Pусский", "Svenskt",
            "Ελληνικά",
            "العربية","český","עברית","Magyar","Íslenska","한국인","Polski","Român","Hrvatski","Slovenských",
            "คนไทย","Türk","Indonesia","Yкраїнець","беларускай","Slovenski","Eestlane","Latvietis",
                "Lietuvis","فارسی","Việt","საქართველოს","हिंदी"
            
            });
            */

            

            cmbLanguage.ImageList = new ImageList();

            for (int k = 0; k < LangImg.Count; k++)
            {
                cmbLanguage.ImageList.Images.Add(LangImg[k]);
                cmbLanguage.Items.Add(new ComboBoxExItem(LangDesc[k],k));
            }
            
            cmbLanguage.SelectedIndex = 0;
        }
    }
}


