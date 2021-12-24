using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreePDFToTextConverter
{
    public partial class frmProgress : CustomForm
    {
        public static frmProgress Instance = null;
        public frmProgress()
        {
            InitializeComponent();
            Instance = this;
            this.TopMost = true;
        }
    }
}

