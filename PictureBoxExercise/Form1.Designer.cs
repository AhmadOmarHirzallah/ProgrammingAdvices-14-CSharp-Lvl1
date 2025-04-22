namespace PictureBoxExercise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbPicsChoice = new GroupBox();
            rdoPen = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            rdoBook = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            rdoGirl = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            rdoBoy = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            picDisplay = new ReaLTaiizor.Controls.HopePictureBox();
            lblTitle = new ReaLTaiizor.Controls.BigLabel();
            gbPicsChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rdoPen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rdoBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rdoGirl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rdoBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            SuspendLayout();
            // 
            // gbPicsChoice
            // 
            gbPicsChoice.BackColor = Color.Snow;
            gbPicsChoice.Controls.Add(rdoPen);
            gbPicsChoice.Controls.Add(rdoBook);
            gbPicsChoice.Controls.Add(rdoGirl);
            gbPicsChoice.Controls.Add(rdoBoy);
            gbPicsChoice.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPicsChoice.ForeColor = SystemColors.Highlight;
            gbPicsChoice.Location = new Point(440, 540);
            gbPicsChoice.Name = "gbPicsChoice";
            gbPicsChoice.Size = new Size(1028, 220);
            gbPicsChoice.TabIndex = 0;
            gbPicsChoice.TabStop = false;
            gbPicsChoice.Text = "Choose 1 Picture";
            // 
            // rdoPen
            // 
            rdoPen.AccessibilityEnabled = true;
            rdoPen.BeforeTouchSize = new Size(111, 53);
            rdoPen.ImageCheckBoxSize = new Size(19, 19);
            rdoPen.Location = new Point(810, 103);
            rdoPen.MetroColor = Color.FromArgb(88, 89, 91);
            rdoPen.Name = "rdoPen";
            rdoPen.Size = new Size(111, 53);
            rdoPen.TabIndex = 0;
            rdoPen.Tag = "Pen";
            rdoPen.Text = "Pen";
            // 
            // rdoBook
            // 
            rdoBook.AccessibilityEnabled = true;
            rdoBook.BeforeTouchSize = new Size(132, 53);
            rdoBook.ImageCheckBoxSize = new Size(19, 19);
            rdoBook.Location = new Point(557, 103);
            rdoBook.MetroColor = Color.FromArgb(88, 89, 91);
            rdoBook.Name = "rdoBook";
            rdoBook.Size = new Size(132, 53);
            rdoBook.TabIndex = 0;
            rdoBook.Tag = "Book";
            rdoBook.Text = "Book";
            // 
            // rdoGirl
            // 
            rdoGirl.AccessibilityEnabled = true;
            rdoGirl.BeforeTouchSize = new Size(111, 53);
            rdoGirl.ImageCheckBoxSize = new Size(19, 19);
            rdoGirl.Location = new Point(324, 103);
            rdoGirl.MetroColor = Color.FromArgb(88, 89, 91);
            rdoGirl.Name = "rdoGirl";
            rdoGirl.Size = new Size(111, 53);
            rdoGirl.TabIndex = 0;
            rdoGirl.Tag = "Girl";
            rdoGirl.Text = "Girl";
            // 
            // rdoBoy
            // 
            rdoBoy.AccessibilityEnabled = true;
            rdoBoy.BeforeTouchSize = new Size(111, 53);
            rdoBoy.ImageCheckBoxSize = new Size(19, 19);
            rdoBoy.Location = new Point(92, 103);
            rdoBoy.MetroColor = Color.FromArgb(88, 89, 91);
            rdoBoy.Name = "rdoBoy";
            rdoBoy.Size = new Size(111, 53);
            rdoBoy.TabIndex = 0;
            rdoBoy.Tag = "Boy";
            rdoBoy.Text = "Boy";
            // 
            // picDisplay
            // 
            picDisplay.BackColor = Color.Snow;
            picDisplay.Image = Properties.Resources.Boy;
            picDisplay.Location = new Point(440, 123);
            picDisplay.Name = "picDisplay";
            picDisplay.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            picDisplay.Size = new Size(1028, 340);
            picDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            picDisplay.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            picDisplay.TabIndex = 1;
            picDisplay.TabStop = false;
            picDisplay.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(80, 80, 80);
            lblTitle.Location = new Point(882, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 67);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Boy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1841, 820);
            Controls.Add(lblTitle);
            Controls.Add(picDisplay);
            Controls.Add(gbPicsChoice);
            Name = "Form1";
            Text = "Form1";
            gbPicsChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rdoPen).EndInit();
            ((System.ComponentModel.ISupportInitialize)rdoBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)rdoGirl).EndInit();
            ((System.ComponentModel.ISupportInitialize)rdoBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbPicsChoice;
        private ReaLTaiizor.Controls.HopePictureBox picDisplay;
        private ReaLTaiizor.Controls.BigLabel lblTitle;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdoBoy;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdoPen;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdoBook;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rdoGirl;
    }
}
