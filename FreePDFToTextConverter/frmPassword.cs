using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreePDFToTextConverter
{
    public partial class frmPassword : FreePDFToTextConverter.CustomForm
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                Module.ShowMessage("Please insert a valid Password !");
                return;

            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

