namespace FreePDFToTextConverter
{
    partial class frmDocOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPageRanges = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOdd = new System.Windows.Forms.CheckBox();
            this.nudOddFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudOddTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudEvenTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEvenFrom = new System.Windows.Forms.NumericUpDown();
            this.chkEven = new System.Windows.Forms.CheckBox();
            this.nudEvery = new System.Windows.Forms.NumericUpDown();
            this.chkEvery = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.chkPagesFromTo = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nudEveryTo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudEveryFrom = new System.Windows.Forms.NumericUpDown();
            this.chkAllPages = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.chkText = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOddFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOddTo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvenTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvenFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEveryTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEveryFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // txtDocument
            // 
            this.txtDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtDocument, "txtDocument");
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ReadOnly = true;
            // 
            // txtPages
            // 
            this.txtPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtPages, "txtPages");
            this.txtPages.Name = "txtPages";
            this.txtPages.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // txtPageRanges
            // 
            resources.ApplyResources(this.txtPageRanges, "txtPageRanges");
            this.txtPageRanges.Name = "txtPageRanges";
            this.txtPageRanges.Validating += new System.ComponentModel.CancelEventHandler(this.txtPageRanges_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // chkOdd
            // 
            resources.ApplyResources(this.chkOdd, "chkOdd");
            this.chkOdd.BackColor = System.Drawing.Color.Transparent;
            this.chkOdd.Name = "chkOdd";
            this.chkOdd.UseVisualStyleBackColor = false;
            // 
            // nudOddFrom
            // 
            resources.ApplyResources(this.nudOddFrom, "nudOddFrom");
            this.nudOddFrom.Name = "nudOddFrom";
            this.nudOddFrom.Validating += new System.ComponentModel.CancelEventHandler(this.nudOddFrom_Validating);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // nudOddTo
            // 
            resources.ApplyResources(this.nudOddTo, "nudOddTo");
            this.nudOddTo.Name = "nudOddTo";
            this.nudOddTo.Validating += new System.ComponentModel.CancelEventHandler(this.nudOddFrom_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPages);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDocument);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // nudEvenTo
            // 
            resources.ApplyResources(this.nudEvenTo, "nudEvenTo");
            this.nudEvenTo.Name = "nudEvenTo";
            this.nudEvenTo.Validating += new System.ComponentModel.CancelEventHandler(this.nudEvenFrom_Validating);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // nudEvenFrom
            // 
            resources.ApplyResources(this.nudEvenFrom, "nudEvenFrom");
            this.nudEvenFrom.Name = "nudEvenFrom";
            this.nudEvenFrom.Validating += new System.ComponentModel.CancelEventHandler(this.nudEvenFrom_Validating);
            // 
            // chkEven
            // 
            resources.ApplyResources(this.chkEven, "chkEven");
            this.chkEven.BackColor = System.Drawing.Color.Transparent;
            this.chkEven.Name = "chkEven";
            this.chkEven.UseVisualStyleBackColor = false;
            // 
            // nudEvery
            // 
            resources.ApplyResources(this.nudEvery, "nudEvery");
            this.nudEvery.Name = "nudEvery";
            // 
            // chkEvery
            // 
            resources.ApplyResources(this.chkEvery, "chkEvery");
            this.chkEvery.BackColor = System.Drawing.Color.Transparent;
            this.chkEvery.Name = "chkEvery";
            this.chkEvery.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // nudTo
            // 
            resources.ApplyResources(this.nudTo, "nudTo");
            this.nudTo.Name = "nudTo";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // nudFrom
            // 
            resources.ApplyResources(this.nudFrom, "nudFrom");
            this.nudFrom.Name = "nudFrom";
            // 
            // chkPagesFromTo
            // 
            resources.ApplyResources(this.chkPagesFromTo, "chkPagesFromTo");
            this.chkPagesFromTo.BackColor = System.Drawing.Color.Transparent;
            this.chkPagesFromTo.Name = "chkPagesFromTo";
            this.chkPagesFromTo.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::FreePDFToTextConverter.Properties.Resources.check;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FreePDFToTextConverter.Properties.Resources.exit;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // nudEveryTo
            // 
            resources.ApplyResources(this.nudEveryTo, "nudEveryTo");
            this.nudEveryTo.Name = "nudEveryTo";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // nudEveryFrom
            // 
            resources.ApplyResources(this.nudEveryFrom, "nudEveryFrom");
            this.nudEveryFrom.Name = "nudEveryFrom";
            // 
            // chkAllPages
            // 
            resources.ApplyResources(this.chkAllPages, "chkAllPages");
            this.chkAllPages.BackColor = System.Drawing.Color.Transparent;
            this.chkAllPages.Checked = true;
            this.chkAllPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllPages.Name = "chkAllPages";
            this.chkAllPages.UseVisualStyleBackColor = false;
            this.chkAllPages.CheckedChanged += new System.EventHandler(this.chkAllPages_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtText);
            this.groupBox2.Controls.Add(this.chkText);
            this.groupBox2.Controls.Add(this.nudEveryTo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudEveryFrom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudTo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudFrom);
            this.groupBox2.Controls.Add(this.chkPagesFromTo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudEvery);
            this.groupBox2.Controls.Add(this.chkEvery);
            this.groupBox2.Controls.Add(this.nudEvenTo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudEvenFrom);
            this.groupBox2.Controls.Add(this.chkEven);
            this.groupBox2.Controls.Add(this.nudOddTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudOddFrom);
            this.groupBox2.Controls.Add(this.chkOdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPageRanges);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtText
            // 
            resources.ApplyResources(this.txtText, "txtText");
            this.txtText.Name = "txtText";
            // 
            // chkText
            // 
            resources.ApplyResources(this.chkText, "chkText");
            this.chkText.BackColor = System.Drawing.Color.Transparent;
            this.chkText.Name = "chkText";
            this.chkText.UseVisualStyleBackColor = false;
            this.chkText.CheckedChanged += new System.EventHandler(this.chkText_CheckedChanged);
            // 
            // frmDocOptions
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkAllPages);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDocOptions";
            this.Load += new System.EventHandler(this.frmDocOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOddFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOddTo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvenTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvenFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEveryTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEveryFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageRanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOdd;
        private System.Windows.Forms.NumericUpDown nudOddFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudOddTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudEvenTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudEvenFrom;
        private System.Windows.Forms.CheckBox chkEven;
        private System.Windows.Forms.NumericUpDown nudEvery;
        private System.Windows.Forms.CheckBox chkEvery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.CheckBox chkPagesFromTo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudEveryTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudEveryFrom;
        private System.Windows.Forms.CheckBox chkAllPages;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox chkText;
        public System.Windows.Forms.RichTextBox txtText;
    }
}
