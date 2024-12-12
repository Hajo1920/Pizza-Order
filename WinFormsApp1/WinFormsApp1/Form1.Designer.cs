namespace WinFormsApp1
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbSize = new GroupBox();
            rdLarge = new RadioButton();
            rdMedium = new RadioButton();
            rdSmall = new RadioButton();
            gbTopping = new GroupBox();
            chkTomato = new CheckBox();
            chkMashroom = new CheckBox();
            chkOlives = new CheckBox();
            chkGreenPaper = new CheckBox();
            chkExtraChees = new CheckBox();
            chkOnion = new CheckBox();
            gbCrust = new GroupBox();
            rdThin = new RadioButton();
            rdThick = new RadioButton();
            gbOutput = new GroupBox();
            lbToppings = new RichTextBox();
            lbPrice = new Label();
            label5 = new Label();
            lbWhereToEat = new Label();
            lbCrust = new Label();
            lbSize = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            gbWhereToEat = new GroupBox();
            rdEatHere = new RadioButton();
            rdTakeaway = new RadioButton();
            btnReset = new Button();
            btnOrder = new Button();
            dateTimePicker1 = new DateTimePicker();
            gbSize.SuspendLayout();
            gbTopping.SuspendLayout();
            gbCrust.SuspendLayout();
            gbOutput.SuspendLayout();
            gbWhereToEat.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("OCR A Extended", 65F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 67);
            label1.TabIndex = 4;
            label1.Text = "Pizza For You";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(395, 280);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(400, 286);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 19;
            // 
            // gbSize
            // 
            gbSize.BackColor = Color.FromArgb(255, 128, 0);
            gbSize.Controls.Add(rdLarge);
            gbSize.Controls.Add(rdMedium);
            gbSize.Controls.Add(rdSmall);
            gbSize.Font = new Font("Microsoft Sans Serif", 10F);
            gbSize.Location = new Point(27, 108);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(189, 138);
            gbSize.TabIndex = 20;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // rdLarge
            // 
            rdLarge.AutoSize = true;
            rdLarge.Location = new Point(11, 84);
            rdLarge.Name = "rdLarge";
            rdLarge.Size = new Size(73, 24);
            rdLarge.TabIndex = 2;
            rdLarge.Tag = "30";
            rdLarge.Text = "Large";
            rdLarge.UseVisualStyleBackColor = true;
            rdLarge.CheckedChanged += rdLarge_CheckedChanged;
            // 
            // rdMedium
            // 
            rdMedium.AutoSize = true;
            rdMedium.Checked = true;
            rdMedium.Location = new Point(12, 56);
            rdMedium.Name = "rdMedium";
            rdMedium.Size = new Size(89, 24);
            rdMedium.TabIndex = 1;
            rdMedium.TabStop = true;
            rdMedium.Tag = "25";
            rdMedium.Text = "Medium";
            rdMedium.UseVisualStyleBackColor = true;
            rdMedium.CheckedChanged += rdMedium_CheckedChanged;
            // 
            // rdSmall
            // 
            rdSmall.AutoSize = true;
            rdSmall.Location = new Point(13, 27);
            rdSmall.Name = "rdSmall";
            rdSmall.Size = new Size(72, 24);
            rdSmall.TabIndex = 0;
            rdSmall.Tag = "20";
            rdSmall.Text = "Small";
            rdSmall.UseVisualStyleBackColor = true;
            rdSmall.CheckedChanged += rdSmall_CheckedChanged;
            // 
            // gbTopping
            // 
            gbTopping.BackColor = Color.FromArgb(255, 128, 0);
            gbTopping.Controls.Add(chkTomato);
            gbTopping.Controls.Add(chkMashroom);
            gbTopping.Controls.Add(chkOlives);
            gbTopping.Controls.Add(chkGreenPaper);
            gbTopping.Controls.Add(chkExtraChees);
            gbTopping.Controls.Add(chkOnion);
            gbTopping.Font = new Font("Microsoft Sans Serif", 10F);
            gbTopping.Location = new Point(250, 108);
            gbTopping.Name = "gbTopping";
            gbTopping.Size = new Size(396, 138);
            gbTopping.TabIndex = 21;
            gbTopping.TabStop = false;
            gbTopping.Text = "Toppings";
            // 
            // chkTomato
            // 
            chkTomato.AutoSize = true;
            chkTomato.Location = new Point(208, 96);
            chkTomato.Name = "chkTomato";
            chkTomato.Size = new Size(87, 24);
            chkTomato.TabIndex = 30;
            chkTomato.Tag = "2";
            chkTomato.Text = "Tomato";
            chkTomato.UseVisualStyleBackColor = true;
            chkTomato.CheckedChanged += chkTomato_CheckedChanged;
            // 
            // chkMashroom
            // 
            chkMashroom.AutoSize = true;
            chkMashroom.Location = new Point(209, 27);
            chkMashroom.Name = "chkMashroom";
            chkMashroom.Size = new Size(110, 24);
            chkMashroom.TabIndex = 28;
            chkMashroom.Tag = "2";
            chkMashroom.Text = "Mashroom";
            chkMashroom.UseVisualStyleBackColor = true;
            chkMashroom.CheckedChanged += chkMashroom_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Location = new Point(208, 62);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(78, 24);
            chkOlives.TabIndex = 29;
            chkOlives.Tag = "2";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkGreenPaper
            // 
            chkGreenPaper.AutoSize = true;
            chkGreenPaper.Location = new Point(18, 96);
            chkGreenPaper.Name = "chkGreenPaper";
            chkGreenPaper.Size = new Size(126, 24);
            chkGreenPaper.TabIndex = 27;
            chkGreenPaper.Tag = "2";
            chkGreenPaper.Text = "Green Paper";
            chkGreenPaper.UseVisualStyleBackColor = true;
            chkGreenPaper.CheckedChanged += chkGreenPaper_CheckedChanged;
            // 
            // chkExtraChees
            // 
            chkExtraChees.AutoSize = true;
            chkExtraChees.Location = new Point(19, 27);
            chkExtraChees.Name = "chkExtraChees";
            chkExtraChees.Size = new Size(123, 24);
            chkExtraChees.TabIndex = 25;
            chkExtraChees.Tag = "2";
            chkExtraChees.Text = "Extra Chees";
            chkExtraChees.UseVisualStyleBackColor = true;
            chkExtraChees.CheckedChanged += chkExtraChees_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Location = new Point(18, 62);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(75, 24);
            chkOnion.TabIndex = 26;
            chkOnion.Tag = "2";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // gbCrust
            // 
            gbCrust.BackColor = Color.FromArgb(255, 128, 0);
            gbCrust.Controls.Add(rdThin);
            gbCrust.Controls.Add(rdThick);
            gbCrust.Font = new Font("Microsoft Sans Serif", 10F);
            gbCrust.Location = new Point(27, 283);
            gbCrust.Name = "gbCrust";
            gbCrust.Size = new Size(189, 138);
            gbCrust.TabIndex = 21;
            gbCrust.TabStop = false;
            gbCrust.Text = "Crust";
            // 
            // rdThin
            // 
            rdThin.AutoSize = true;
            rdThin.Checked = true;
            rdThin.Location = new Point(21, 27);
            rdThin.Name = "rdThin";
            rdThin.Size = new Size(62, 24);
            rdThin.TabIndex = 2;
            rdThin.TabStop = true;
            rdThin.Tag = "0";
            rdThin.Text = "Thin";
            rdThin.UseVisualStyleBackColor = true;
            rdThin.CheckedChanged += rdThin_CheckedChanged;
            // 
            // rdThick
            // 
            rdThick.AutoSize = true;
            rdThick.Location = new Point(21, 56);
            rdThick.Name = "rdThick";
            rdThick.Size = new Size(70, 24);
            rdThick.TabIndex = 1;
            rdThick.Tag = "10";
            rdThick.Text = "Thick";
            rdThick.UseVisualStyleBackColor = true;
            rdThick.CheckedChanged += rdThick_CheckedChanged;
            // 
            // gbOutput
            // 
            gbOutput.BackColor = Color.FromArgb(255, 128, 0);
            gbOutput.Controls.Add(lbToppings);
            gbOutput.Controls.Add(lbPrice);
            gbOutput.Controls.Add(label5);
            gbOutput.Controls.Add(lbWhereToEat);
            gbOutput.Controls.Add(lbCrust);
            gbOutput.Controls.Add(lbSize);
            gbOutput.Controls.Add(label8);
            gbOutput.Controls.Add(label7);
            gbOutput.Controls.Add(label6);
            gbOutput.Controls.Add(label4);
            gbOutput.Font = new Font("OCR A Extended", 12F);
            gbOutput.Location = new Point(866, 101);
            gbOutput.Name = "gbOutput";
            gbOutput.Size = new Size(352, 413);
            gbOutput.TabIndex = 21;
            gbOutput.TabStop = false;
            gbOutput.Text = "Output";
            // 
            // lbToppings
            // 
            lbToppings.BorderStyle = BorderStyle.None;
            lbToppings.Enabled = false;
            lbToppings.Location = new Point(31, 130);
            lbToppings.Name = "lbToppings";
            lbToppings.Size = new Size(290, 83);
            lbToppings.TabIndex = 11;
            lbToppings.Text = "";
            lbToppings.TextChanged += lbToppings_TextChanged;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = Color.Black;
            lbPrice.Font = new Font("OCR A Extended", 22F, FontStyle.Bold);
            lbPrice.ForeColor = Color.White;
            lbPrice.Location = new Point(226, 359);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(0, 39);
            lbPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("OCR A Extended", 14F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 365);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 1;
            label5.Text = "Total Price:";
            // 
            // lbWhereToEat
            // 
            lbWhereToEat.AutoSize = true;
            lbWhereToEat.BackColor = Color.White;
            lbWhereToEat.Font = new Font("OCR A Extended", 14F);
            lbWhereToEat.ForeColor = Color.Black;
            lbWhereToEat.Location = new Point(197, 275);
            lbWhereToEat.Name = "lbWhereToEat";
            lbWhereToEat.Size = new Size(124, 25);
            lbWhereToEat.TabIndex = 9;
            lbWhereToEat.Text = "Eat Here";
            lbWhereToEat.Click += lbWhereToEat_Click;
            // 
            // lbCrust
            // 
            lbCrust.AutoSize = true;
            lbCrust.BackColor = Color.White;
            lbCrust.Font = new Font("OCR A Extended", 14F);
            lbCrust.ForeColor = Color.Black;
            lbCrust.Location = new Point(201, 226);
            lbCrust.Name = "lbCrust";
            lbCrust.Size = new Size(68, 25);
            lbCrust.TabIndex = 8;
            lbCrust.Text = "Thin";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.BackColor = Color.White;
            lbSize.Font = new Font("OCR A Extended", 14F);
            lbSize.ForeColor = Color.Black;
            lbSize.Location = new Point(198, 53);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(68, 25);
            lbSize.TabIndex = 6;
            lbSize.Text = "None";
            lbSize.Click += lbSize_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(31, 104);
            label8.Name = "label8";
            label8.Size = new Size(118, 23);
            label8.TabIndex = 4;
            label8.Text = "Toppings:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 228);
            label7.Name = "label7";
            label7.Size = new Size(142, 23);
            label7.TabIndex = 3;
            label7.Text = "Crust Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(31, 277);
            label6.Name = "label6";
            label6.Size = new Size(166, 23);
            label6.TabIndex = 2;
            label6.Text = "Where To Eat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 53);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 0;
            label4.Text = "Size:";
            // 
            // gbWhereToEat
            // 
            gbWhereToEat.BackColor = Color.FromArgb(255, 128, 0);
            gbWhereToEat.Controls.Add(rdEatHere);
            gbWhereToEat.Controls.Add(rdTakeaway);
            gbWhereToEat.Font = new Font("Microsoft Sans Serif", 10F);
            gbWhereToEat.Location = new Point(251, 283);
            gbWhereToEat.Name = "gbWhereToEat";
            gbWhereToEat.Size = new Size(189, 138);
            gbWhereToEat.TabIndex = 22;
            gbWhereToEat.TabStop = false;
            gbWhereToEat.Text = "Where to Eat";
            // 
            // rdEatHere
            // 
            rdEatHere.AutoSize = true;
            rdEatHere.Checked = true;
            rdEatHere.Location = new Point(28, 32);
            rdEatHere.Name = "rdEatHere";
            rdEatHere.Size = new Size(93, 24);
            rdEatHere.TabIndex = 4;
            rdEatHere.TabStop = true;
            rdEatHere.Text = "Eat here";
            rdEatHere.UseVisualStyleBackColor = true;
            rdEatHere.CheckedChanged += rdEatHere_CheckedChanged;
            // 
            // rdTakeaway
            // 
            rdTakeaway.AutoSize = true;
            rdTakeaway.Location = new Point(28, 61);
            rdTakeaway.Name = "rdTakeaway";
            rdTakeaway.Size = new Size(109, 24);
            rdTakeaway.TabIndex = 3;
            rdTakeaway.Text = "Take away";
            rdTakeaway.UseVisualStyleBackColor = true;
            rdTakeaway.CheckedChanged += rdTakeaway_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(529, 485);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(420, 485);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 24;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(884, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 30);
            dateTimePicker1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1238, 526);
            Controls.Add(gbCrust);
            Controls.Add(gbSize);
            Controls.Add(gbWhereToEat);
            Controls.Add(gbTopping);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnOrder);
            Controls.Add(btnReset);
            Controls.Add(gbOutput);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registeration ";
            Load += Form1_Load;
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbTopping.ResumeLayout(false);
            gbTopping.PerformLayout();
            gbCrust.ResumeLayout(false);
            gbCrust.PerformLayout();
            gbOutput.ResumeLayout(false);
            gbOutput.PerformLayout();
            gbWhereToEat.ResumeLayout(false);
            gbWhereToEat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox gbSize;
        private GroupBox gbTopping;
        private GroupBox gbCrust;
        private GroupBox gbOutput;
        private GroupBox gbWhereToEat;
        private CheckBox chkGreenPaper;
        private CheckBox chkOnion;
        private CheckBox chkExtraChees;
        private Button btnReset;
        private Button btnOrder;
        private CheckBox chkTomato;
        private CheckBox chkMashroom;
        private CheckBox chkOlives;
        private RadioButton rdLarge;
        private RadioButton rdMedium;
        private RadioButton rdSmall;
        private RadioButton rdThin;
        private RadioButton rdThick;
        private RadioButton rdEatHere;
        private RadioButton rdTakeaway;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lbSize;
        private Label lbPrice;
        private Label lbWhereToEat;
        private Label lbCrust;
        private RichTextBox lbToppings;
    }
}
