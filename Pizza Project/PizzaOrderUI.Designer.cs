namespace Pizza_Project
{
    partial class PizzaOrderUI
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
            rdoSmallSize = new RadioButton();
            rdoMediumSize = new RadioButton();
            rdoLargeSize = new RadioButton();
            gbSize = new GroupBox();
            gbCrustType = new GroupBox();
            rdoThickCrust = new RadioButton();
            rdoThinCrust = new RadioButton();
            gbToppings = new GroupBox();
            chkGreenPepper = new CheckBox();
            chkTomatoes = new CheckBox();
            chkOlives = new CheckBox();
            chkMushrooms = new CheckBox();
            chkOnion = new CheckBox();
            chkExtraCheese = new CheckBox();
            gbWhereToEat = new GroupBox();
            rdoEatOut = new RadioButton();
            rdoEatIn = new RadioButton();
            btnOrderPizza = new Button();
            btnResetForm = new Button();
            label1 = new Label();
            groupBox5 = new GroupBox();
            lblTotalPrice = new Label();
            lblWhereEat = new Label();
            lblCrstType = new Label();
            lblToppings = new Label();
            lblSize = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbSize.SuspendLayout();
            gbCrustType.SuspendLayout();
            gbToppings.SuspendLayout();
            gbWhereToEat.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // rdoSmallSize
            // 
            rdoSmallSize.AutoSize = true;
            rdoSmallSize.Font = new Font("Segoe UI", 13F);
            rdoSmallSize.Location = new Point(97, 40);
            rdoSmallSize.Margin = new Padding(3, 2, 3, 2);
            rdoSmallSize.Name = "rdoSmallSize";
            rdoSmallSize.Size = new Size(101, 40);
            rdoSmallSize.TabIndex = 0;
            rdoSmallSize.Tag = "15";
            rdoSmallSize.Text = "Small";
            rdoSmallSize.UseVisualStyleBackColor = true;
            rdoSmallSize.CheckedChanged += rdoSmallSize_CheckedChanged;
            // 
            // rdoMediumSize
            // 
            rdoMediumSize.AutoSize = true;
            rdoMediumSize.Checked = true;
            rdoMediumSize.Font = new Font("Segoe UI", 13F);
            rdoMediumSize.Location = new Point(97, 85);
            rdoMediumSize.Margin = new Padding(3, 2, 3, 2);
            rdoMediumSize.Name = "rdoMediumSize";
            rdoMediumSize.Size = new Size(135, 40);
            rdoMediumSize.TabIndex = 0;
            rdoMediumSize.TabStop = true;
            rdoMediumSize.Tag = "25";
            rdoMediumSize.Text = "Medium";
            rdoMediumSize.UseVisualStyleBackColor = true;
            rdoMediumSize.CheckedChanged += rdoMediumSize_CheckedChanged;
            // 
            // rdoLargeSize
            // 
            rdoLargeSize.AutoSize = true;
            rdoLargeSize.Font = new Font("Segoe UI", 13F);
            rdoLargeSize.Location = new Point(97, 130);
            rdoLargeSize.Margin = new Padding(3, 2, 3, 2);
            rdoLargeSize.Name = "rdoLargeSize";
            rdoLargeSize.Size = new Size(103, 40);
            rdoLargeSize.TabIndex = 0;
            rdoLargeSize.Tag = "30";
            rdoLargeSize.Text = "Large";
            rdoLargeSize.UseVisualStyleBackColor = true;
            rdoLargeSize.CheckedChanged += rdoLargeSize_CheckedChanged;
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rdoLargeSize);
            gbSize.Controls.Add(rdoMediumSize);
            gbSize.Controls.Add(rdoSmallSize);
            gbSize.Font = new Font("Segoe UI", 13F);
            gbSize.Location = new Point(172, 165);
            gbSize.Margin = new Padding(3, 2, 3, 2);
            gbSize.Name = "gbSize";
            gbSize.Padding = new Padding(3, 2, 3, 2);
            gbSize.Size = new Size(230, 181);
            gbSize.TabIndex = 1;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // gbCrustType
            // 
            gbCrustType.Controls.Add(rdoThickCrust);
            gbCrustType.Controls.Add(rdoThinCrust);
            gbCrustType.Font = new Font("Segoe UI", 13F);
            gbCrustType.Location = new Point(172, 445);
            gbCrustType.Margin = new Padding(3, 2, 3, 2);
            gbCrustType.Name = "gbCrustType";
            gbCrustType.Padding = new Padding(3, 2, 3, 2);
            gbCrustType.Size = new Size(230, 155);
            gbCrustType.TabIndex = 1;
            gbCrustType.TabStop = false;
            gbCrustType.Text = "Crust Type";
            // 
            // rdoThickCrust
            // 
            rdoThickCrust.AutoSize = true;
            rdoThickCrust.Font = new Font("Segoe UI", 13F);
            rdoThickCrust.Location = new Point(101, 104);
            rdoThickCrust.Margin = new Padding(3, 2, 3, 2);
            rdoThickCrust.Name = "rdoThickCrust";
            rdoThickCrust.Size = new Size(100, 40);
            rdoThickCrust.TabIndex = 0;
            rdoThickCrust.Tag = "15";
            rdoThickCrust.Text = "Thick";
            rdoThickCrust.UseVisualStyleBackColor = true;
            rdoThickCrust.CheckedChanged += rdoThickCrust_CheckedChanged;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Checked = true;
            rdoThinCrust.Font = new Font("Segoe UI", 13F);
            rdoThinCrust.Location = new Point(101, 54);
            rdoThinCrust.Margin = new Padding(3, 2, 3, 2);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(90, 40);
            rdoThinCrust.TabIndex = 0;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Tag = "0";
            rdoThinCrust.Text = "Thin";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += rdoThinCrust_CheckedChanged;
            // 
            // gbToppings
            // 
            gbToppings.Controls.Add(chkGreenPepper);
            gbToppings.Controls.Add(chkTomatoes);
            gbToppings.Controls.Add(chkOlives);
            gbToppings.Controls.Add(chkMushrooms);
            gbToppings.Controls.Add(chkOnion);
            gbToppings.Controls.Add(chkExtraCheese);
            gbToppings.Font = new Font("Segoe UI", 13F);
            gbToppings.Location = new Point(579, 165);
            gbToppings.Margin = new Padding(3, 2, 3, 2);
            gbToppings.Name = "gbToppings";
            gbToppings.Padding = new Padding(3, 2, 3, 2);
            gbToppings.Size = new Size(476, 217);
            gbToppings.TabIndex = 1;
            gbToppings.TabStop = false;
            gbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            chkGreenPepper.AutoSize = true;
            chkGreenPepper.Font = new Font("Segoe UI", 13F);
            chkGreenPepper.Location = new Point(254, 152);
            chkGreenPepper.Margin = new Padding(3, 2, 3, 2);
            chkGreenPepper.Name = "chkGreenPepper";
            chkGreenPepper.Size = new Size(210, 40);
            chkGreenPepper.TabIndex = 0;
            chkGreenPepper.Tag = "3.9";
            chkGreenPepper.Text = "Green Peppers";
            chkGreenPepper.UseVisualStyleBackColor = true;
            chkGreenPepper.CheckedChanged += chkGreenPepper_CheckedChanged;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Checked = true;
            chkTomatoes.CheckState = CheckState.Checked;
            chkTomatoes.Font = new Font("Segoe UI", 13F);
            chkTomatoes.Location = new Point(50, 152);
            chkTomatoes.Margin = new Padding(3, 2, 3, 2);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(151, 40);
            chkTomatoes.TabIndex = 0;
            chkTomatoes.Tag = "2";
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Font = new Font("Segoe UI", 13F);
            chkOlives.Location = new Point(254, 102);
            chkOlives.Margin = new Padding(3, 2, 3, 2);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(110, 40);
            chkOlives.TabIndex = 0;
            chkOlives.Tag = "3.5";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Font = new Font("Segoe UI", 13F);
            chkMushrooms.Location = new Point(50, 102);
            chkMushrooms.Margin = new Padding(3, 2, 3, 2);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(177, 40);
            chkMushrooms.TabIndex = 0;
            chkMushrooms.Tag = "6";
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += chkMushrooms_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Font = new Font("Segoe UI", 13F);
            chkOnion.Location = new Point(254, 48);
            chkOnion.Margin = new Padding(3, 2, 3, 2);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(112, 40);
            chkOnion.TabIndex = 0;
            chkOnion.Tag = "2";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Font = new Font("Segoe UI", 13F);
            chkExtraCheese.Location = new Point(50, 48);
            chkExtraCheese.Margin = new Padding(3, 2, 3, 2);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(188, 40);
            chkExtraCheese.TabIndex = 0;
            chkExtraCheese.Tag = "5";
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            chkExtraCheese.CheckedChanged += chkExtraCheese_CheckedChanged;
            // 
            // gbWhereToEat
            // 
            gbWhereToEat.Controls.Add(rdoEatOut);
            gbWhereToEat.Controls.Add(rdoEatIn);
            gbWhereToEat.Font = new Font("Segoe UI", 13F);
            gbWhereToEat.Location = new Point(579, 445);
            gbWhereToEat.Margin = new Padding(3, 2, 3, 2);
            gbWhereToEat.Name = "gbWhereToEat";
            gbWhereToEat.Padding = new Padding(3, 2, 3, 2);
            gbWhereToEat.Size = new Size(364, 155);
            gbWhereToEat.TabIndex = 1;
            gbWhereToEat.TabStop = false;
            gbWhereToEat.Text = "Where To Eat";
            // 
            // rdoEatOut
            // 
            rdoEatOut.AutoSize = true;
            rdoEatOut.Checked = true;
            rdoEatOut.Font = new Font("Segoe UI", 13F);
            rdoEatOut.Location = new Point(101, 104);
            rdoEatOut.Margin = new Padding(3, 2, 3, 2);
            rdoEatOut.Name = "rdoEatOut";
            rdoEatOut.Size = new Size(249, 40);
            rdoEatOut.TabIndex = 0;
            rdoEatOut.TabStop = true;
            rdoEatOut.Text = "Out Of Restaurant";
            rdoEatOut.UseVisualStyleBackColor = true;
            rdoEatOut.CheckedChanged += rdoEatOut_CheckedChanged;
            // 
            // rdoEatIn
            // 
            rdoEatIn.AutoSize = true;
            rdoEatIn.Font = new Font("Segoe UI", 13F);
            rdoEatIn.Location = new Point(101, 54);
            rdoEatIn.Margin = new Padding(3, 2, 3, 2);
            rdoEatIn.Name = "rdoEatIn";
            rdoEatIn.Size = new Size(192, 40);
            rdoEatIn.TabIndex = 0;
            rdoEatIn.Text = "In Restaurant";
            rdoEatIn.UseVisualStyleBackColor = true;
            rdoEatIn.CheckedChanged += rdoEatIn_CheckedChanged;
            // 
            // btnOrderPizza
            // 
            btnOrderPizza.Font = new Font("Segoe UI", 13F);
            btnOrderPizza.Location = new Point(394, 661);
            btnOrderPizza.Margin = new Padding(3, 2, 3, 2);
            btnOrderPizza.Name = "btnOrderPizza";
            btnOrderPizza.Size = new Size(260, 93);
            btnOrderPizza.TabIndex = 2;
            btnOrderPizza.Text = "Order Pizza";
            btnOrderPizza.UseVisualStyleBackColor = true;
            btnOrderPizza.Click += btnOrderPizza_Click;
            // 
            // btnResetForm
            // 
            btnResetForm.Font = new Font("Segoe UI", 13F);
            btnResetForm.Location = new Point(739, 669);
            btnResetForm.Margin = new Padding(3, 2, 3, 2);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(232, 77);
            btnResetForm.TabIndex = 2;
            btnResetForm.Text = "Reset";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += btnResetForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(968, 119);
            label1.TabIndex = 3;
            label1.Text = "Order Your Pizza";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTotalPrice);
            groupBox5.Controls.Add(lblWhereEat);
            groupBox5.Controls.Add(lblCrstType);
            groupBox5.Controls.Add(lblToppings);
            groupBox5.Controls.Add(lblSize);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Font = new Font("Segoe UI", 13F);
            groupBox5.Location = new Point(1092, 165);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(479, 581);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Stencil", 28F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Olive;
            lblTotalPrice.Location = new Point(219, 511);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(143, 67);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "30 $";
            // 
            // lblWhereEat
            // 
            lblWhereEat.AutoSize = true;
            lblWhereEat.Location = new Point(254, 426);
            lblWhereEat.Name = "lblWhereEat";
            lblWhereEat.Size = new Size(83, 36);
            lblWhereEat.TabIndex = 1;
            lblWhereEat.Text = "label7";
            // 
            // lblCrstType
            // 
            lblCrstType.AutoSize = true;
            lblCrstType.Location = new Point(219, 370);
            lblCrstType.Name = "lblCrstType";
            lblCrstType.Size = new Size(83, 36);
            lblCrstType.TabIndex = 1;
            lblCrstType.Text = "label7";
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(200, 128);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(83, 36);
            lblToppings.TabIndex = 1;
            lblToppings.Text = "label7";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(124, 62);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(83, 36);
            lblSize.TabIndex = 1;
            lblSize.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 511);
            label6.Name = "label6";
            label6.Size = new Size(176, 38);
            label6.TabIndex = 0;
            label6.Text = "Total Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 424);
            label5.Name = "label5";
            label5.Size = new Size(211, 38);
            label5.TabIndex = 0;
            label5.Text = "Where To Eat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 368);
            label4.Name = "label4";
            label4.Size = new Size(176, 38);
            label4.TabIndex = 0;
            label4.Text = "Crust Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 126);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 0;
            label3.Text = "Toppings:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 60);
            label2.Name = "label2";
            label2.Size = new Size(81, 38);
            label2.TabIndex = 0;
            label2.Text = "Size:";
            // 
            // PizzaOrderUI
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 775);
            Controls.Add(label1);
            Controls.Add(btnResetForm);
            Controls.Add(btnOrderPizza);
            Controls.Add(gbWhereToEat);
            Controls.Add(gbCrustType);
            Controls.Add(groupBox5);
            Controls.Add(gbToppings);
            Controls.Add(gbSize);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PizzaOrderUI";
            Text = "Form1";
            Load += PizzaOrderUI_Load;
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbCrustType.ResumeLayout(false);
            gbCrustType.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbWhereToEat.ResumeLayout(false);
            gbWhereToEat.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoSmallSize;
        private RadioButton rdoMediumSize;
        private RadioButton rdoLargeSize;
        private GroupBox gbSize;
        private GroupBox gbCrustType;
        private RadioButton rdoThickCrust;
        private RadioButton rdoThinCrust;
        private GroupBox gbToppings;
        private CheckBox chkGreenPepper;
        private CheckBox chkTomatoes;
        private CheckBox chkOlives;
        private CheckBox chkMushrooms;
        private CheckBox chkOnion;
        private CheckBox chkExtraCheese;
        private GroupBox gbWhereToEat;
        private RadioButton rdoEatOut;
        private RadioButton rdoEatIn;
        private Button btnOrderPizza;
        private Button btnResetForm;
        private Label label1;
        private GroupBox groupBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label lblSize;
        private Label lblTotalPrice;
        private Label lblWhereEat;
        private Label lblCrstType;
        private Label lblToppings;
    }
}
