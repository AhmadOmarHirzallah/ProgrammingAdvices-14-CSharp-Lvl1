namespace _1st_Application
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_disable_txt2 = new System.Windows.Forms.Button();
            this.button_enable_txt2 = new System.Windows.Forms.Button();
            this.buttonHideUnnecessary = new System.Windows.Forms.Button();
            this.buttonDisplayHidden = new System.Windows.Forms.Button();
            this.buttonChangeTheme = new System.Windows.Forms.Button();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.buttonApplyFormTitle = new System.Windows.Forms.Button();
            this.labelFormHeader = new System.Windows.Forms.Label();
            this.txtFormHeader = new System.Windows.Forms.TextBox();
            this.btnApplyFormHeader = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFormHeaderAuto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(459, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 29);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy from Box1 to Box2 By Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(479, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Copy from Box2 to Box1 By Click";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(43, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 86);
            this.button3.TabIndex = 1;
            this.button3.Text = "Copy from Box1 to Box2 By Mouse Enter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button3.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(463, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 86);
            this.button4.TabIndex = 1;
            this.button4.Text = "Copy from Box2 to Box1 By Mouse Enter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            this.button4.MouseEnter += new System.EventHandler(this.cpyMsEntrB2toB1);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(247, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(403, 29);
            this.textBox3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(142, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mirror";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(460, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text 2";
            // 
            // button_disable_txt2
            // 
            this.button_disable_txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disable_txt2.Location = new System.Drawing.Point(22, 634);
            this.button_disable_txt2.Name = "button_disable_txt2";
            this.button_disable_txt2.Size = new System.Drawing.Size(174, 43);
            this.button_disable_txt2.TabIndex = 1;
            this.button_disable_txt2.Text = "Disable Text 2";
            this.button_disable_txt2.UseVisualStyleBackColor = true;
            this.button_disable_txt2.Click += new System.EventHandler(this.button_disable_txt2_Click);
            this.button_disable_txt2.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // button_enable_txt2
            // 
            this.button_enable_txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enable_txt2.Location = new System.Drawing.Point(22, 585);
            this.button_enable_txt2.Name = "button_enable_txt2";
            this.button_enable_txt2.Size = new System.Drawing.Size(174, 43);
            this.button_enable_txt2.TabIndex = 1;
            this.button_enable_txt2.Text = "Enable Text 2";
            this.button_enable_txt2.UseVisualStyleBackColor = true;
            this.button_enable_txt2.Click += new System.EventHandler(this.button_enable_txt2_Click);
            this.button_enable_txt2.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // buttonHideUnnecessary
            // 
            this.buttonHideUnnecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideUnnecessary.Location = new System.Drawing.Point(22, 686);
            this.buttonHideUnnecessary.Name = "buttonHideUnnecessary";
            this.buttonHideUnnecessary.Size = new System.Drawing.Size(227, 43);
            this.buttonHideUnnecessary.TabIndex = 1;
            this.buttonHideUnnecessary.Text = "Hide Unnecessary";
            this.buttonHideUnnecessary.UseVisualStyleBackColor = true;
            this.buttonHideUnnecessary.Click += new System.EventHandler(this.buttonHideUnnecessary_Click);
            this.buttonHideUnnecessary.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // buttonDisplayHidden
            // 
            this.buttonDisplayHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayHidden.Location = new System.Drawing.Point(22, 735);
            this.buttonDisplayHidden.Name = "buttonDisplayHidden";
            this.buttonDisplayHidden.Size = new System.Drawing.Size(227, 43);
            this.buttonDisplayHidden.TabIndex = 1;
            this.buttonDisplayHidden.Text = "Display Hidden";
            this.buttonDisplayHidden.UseVisualStyleBackColor = true;
            this.buttonDisplayHidden.Click += new System.EventHandler(this.buttonDisplayHidden_Click);
            this.buttonDisplayHidden.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // buttonChangeTheme
            // 
            this.buttonChangeTheme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeTheme.Location = new System.Drawing.Point(279, 686);
            this.buttonChangeTheme.Name = "buttonChangeTheme";
            this.buttonChangeTheme.Size = new System.Drawing.Size(226, 92);
            this.buttonChangeTheme.TabIndex = 1;
            this.buttonChangeTheme.Text = "Change Theme Mode (Dark/Light)";
            this.buttonChangeTheme.UseVisualStyleBackColor = false;
            this.buttonChangeTheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChangeTheme_MouseClick);
            this.buttonChangeTheme.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.Location = new System.Drawing.Point(893, 148);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(242, 29);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelFormTitle.Location = new System.Drawing.Point(888, 115);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(170, 25);
            this.labelFormTitle.TabIndex = 2;
            this.labelFormTitle.Text = "New Form Title";
            // 
            // buttonApplyFormTitle
            // 
            this.buttonApplyFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFormTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonApplyFormTitle.Location = new System.Drawing.Point(893, 190);
            this.buttonApplyFormTitle.Name = "buttonApplyFormTitle";
            this.buttonApplyFormTitle.Size = new System.Drawing.Size(129, 43);
            this.buttonApplyFormTitle.TabIndex = 1;
            this.buttonApplyFormTitle.Text = "Apply";
            this.buttonApplyFormTitle.UseVisualStyleBackColor = true;
            this.buttonApplyFormTitle.Click += new System.EventHandler(this.buttonApplyFormTitle_Click);
            this.buttonApplyFormTitle.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // labelFormHeader
            // 
            this.labelFormHeader.AutoSize = true;
            this.labelFormHeader.Font = new System.Drawing.Font("Showcard Gothic", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormHeader.ForeColor = System.Drawing.Color.Blue;
            this.labelFormHeader.Location = new System.Drawing.Point(15, 9);
            this.labelFormHeader.Name = "labelFormHeader";
            this.labelFormHeader.Size = new System.Drawing.Size(925, 80);
            this.labelFormHeader.TabIndex = 3;
            this.labelFormHeader.Text = "This is a Training Project ";
            // 
            // txtFormHeader
            // 
            this.txtFormHeader.Location = new System.Drawing.Point(829, 353);
            this.txtFormHeader.Name = "txtFormHeader";
            this.txtFormHeader.Size = new System.Drawing.Size(306, 29);
            this.txtFormHeader.TabIndex = 0;
            this.txtFormHeader.TabStop = false;
            this.txtFormHeader.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnApplyFormHeader
            // 
            this.btnApplyFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFormHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnApplyFormHeader.Location = new System.Drawing.Point(829, 392);
            this.btnApplyFormHeader.Name = "btnApplyFormHeader";
            this.btnApplyFormHeader.Size = new System.Drawing.Size(129, 43);
            this.btnApplyFormHeader.TabIndex = 1;
            this.btnApplyFormHeader.Text = "Apply";
            this.btnApplyFormHeader.UseVisualStyleBackColor = true;
            this.btnApplyFormHeader.Click += new System.EventHandler(this.btnApplyFormHeader_Click);
            this.btnApplyFormHeader.MouseEnter += new System.EventHandler(this.cpyMsEntrB1toB2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(824, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Form Header";
            // 
            // txtFormHeaderAuto
            // 
            this.txtFormHeaderAuto.Location = new System.Drawing.Point(829, 503);
            this.txtFormHeaderAuto.Name = "txtFormHeaderAuto";
            this.txtFormHeaderAuto.Size = new System.Drawing.Size(306, 29);
            this.txtFormHeaderAuto.TabIndex = 0;
            this.txtFormHeaderAuto.TabStop = false;
            this.txtFormHeaderAuto.TextChanged += new System.EventHandler(this.txtFormHeaderAuto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(823, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Form Header Automatic";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(565, 591);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 86);
            this.button5.TabIndex = 1;
            this.button5.Text = "MSG BOX";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.msgBoxBtn);
            this.button5.MouseEnter += new System.EventHandler(this.cpyMsEntrB2toB1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(965, 661);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 835);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelFormHeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFormTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonChangeTheme);
            this.Controls.Add(this.btnApplyFormHeader);
            this.Controls.Add(this.buttonApplyFormTitle);
            this.Controls.Add(this.button_enable_txt2);
            this.Controls.Add(this.buttonDisplayHidden);
            this.Controls.Add(this.buttonHideUnnecessary);
            this.Controls.Add(this.button_disable_txt2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtFormHeaderAuto);
            this.Controls.Add(this.txtFormHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFormTitle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Default Title";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_disable_txt2;
        private System.Windows.Forms.Button button_enable_txt2;
        private System.Windows.Forms.Button buttonHideUnnecessary;
        private System.Windows.Forms.Button buttonDisplayHidden;
        private System.Windows.Forms.Button buttonChangeTheme;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Button buttonApplyFormTitle;
        private System.Windows.Forms.Label labelFormHeader;
        private System.Windows.Forms.TextBox txtFormHeader;
        private System.Windows.Forms.Button btnApplyFormHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFormHeaderAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

