namespace Hotel_Management__Beta_1._0_
{
    partial class CheckIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn_Form));
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Guest_Icon = new System.Windows.Forms.PictureBox();
            this.GuestInfo_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Selector = new System.Windows.Forms.NumericUpDown();
            this.Age_Label = new System.Windows.Forms.Label();
            this.BedConfig_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Room_Label = new System.Windows.Forms.Label();
            this.BedConfig_Selector = new System.Windows.Forms.NumericUpDown();
            this.Price_Selector = new System.Windows.Forms.NumericUpDown();
            this.Room_Selector = new System.Windows.Forms.NumericUpDown();
            this.Payment_Label = new System.Windows.Forms.Label();
            this.CreditDebit_RadioButton = new System.Windows.Forms.RadioButton();
            this.Cash_RadioButton = new System.Windows.Forms.RadioButton();
            this.CreditDebit_Icon = new System.Windows.Forms.PictureBox();
            this.Cash_Icon = new System.Windows.Forms.PictureBox();
            this.StayLength_Label = new System.Windows.Forms.Label();
            this.StayLength_Selector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedConfig_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebit_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(373, 606);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(154, 40);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(213, 606);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(154, 40);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Guest_Icon
            // 
            this.Guest_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Guest_Icon.Image")));
            this.Guest_Icon.Location = new System.Drawing.Point(105, 25);
            this.Guest_Icon.Name = "Guest_Icon";
            this.Guest_Icon.Size = new System.Drawing.Size(147, 91);
            this.Guest_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guest_Icon.TabIndex = 2;
            this.Guest_Icon.TabStop = false;
            // 
            // GuestInfo_Label
            // 
            this.GuestInfo_Label.AutoSize = true;
            this.GuestInfo_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestInfo_Label.Location = new System.Drawing.Point(244, 62);
            this.GuestInfo_Label.Name = "GuestInfo_Label";
            this.GuestInfo_Label.Size = new System.Drawing.Size(207, 32);
            this.GuestInfo_Label.TabIndex = 3;
            this.GuestInfo_Label.Text = "Guest Information";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_TextBox.Location = new System.Drawing.Point(137, 160);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(363, 32);
            this.Name_TextBox.TabIndex = 4;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(16, 163);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(66, 25);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "Name:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(17, 211);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(104, 25);
            this.LastName_Label.TabIndex = 6;
            this.LastName_Label.Text = "Last Name:";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_TextBox.Location = new System.Drawing.Point(137, 208);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(363, 32);
            this.LastName_TextBox.TabIndex = 7;
            // 
            // Age_Selector
            // 
            this.Age_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age_Selector.Location = new System.Drawing.Point(137, 262);
            this.Age_Selector.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Age_Selector.Name = "Age_Selector";
            this.Age_Selector.Size = new System.Drawing.Size(61, 32);
            this.Age_Selector.TabIndex = 8;
            this.Age_Selector.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age_Label.Location = new System.Drawing.Point(17, 265);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(49, 25);
            this.Age_Label.TabIndex = 9;
            this.Age_Label.Text = "Age:";
            // 
            // BedConfig_Label
            // 
            this.BedConfig_Label.AutoSize = true;
            this.BedConfig_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BedConfig_Label.Location = new System.Drawing.Point(17, 314);
            this.BedConfig_Label.Name = "BedConfig_Label";
            this.BedConfig_Label.Size = new System.Drawing.Size(68, 25);
            this.BedConfig_Label.TabIndex = 10;
            this.BedConfig_Label.Text = "Bed(s):";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_Label.Location = new System.Drawing.Point(17, 366);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(118, 25);
            this.Price_Label.TabIndex = 11;
            this.Price_Label.Text = "Price:          $";
            // 
            // Room_Label
            // 
            this.Room_Label.AutoSize = true;
            this.Room_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_Label.Location = new System.Drawing.Point(18, 418);
            this.Room_Label.Name = "Room_Label";
            this.Room_Label.Size = new System.Drawing.Size(80, 25);
            this.Room_Label.TabIndex = 12;
            this.Room_Label.Text = "Room #:";
            // 
            // BedConfig_Selector
            // 
            this.BedConfig_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BedConfig_Selector.Location = new System.Drawing.Point(137, 312);
            this.BedConfig_Selector.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.BedConfig_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BedConfig_Selector.Name = "BedConfig_Selector";
            this.BedConfig_Selector.Size = new System.Drawing.Size(61, 32);
            this.BedConfig_Selector.TabIndex = 13;
            this.BedConfig_Selector.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Price_Selector
            // 
            this.Price_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_Selector.Location = new System.Drawing.Point(137, 364);
            this.Price_Selector.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Price_Selector.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Price_Selector.Name = "Price_Selector";
            this.Price_Selector.Size = new System.Drawing.Size(61, 32);
            this.Price_Selector.TabIndex = 14;
            this.Price_Selector.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Room_Selector
            // 
            this.Room_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Room_Selector.Location = new System.Drawing.Point(137, 414);
            this.Room_Selector.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Room_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room_Selector.Name = "Room_Selector";
            this.Room_Selector.Size = new System.Drawing.Size(61, 32);
            this.Room_Selector.TabIndex = 15;
            this.Room_Selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Payment_Label
            // 
            this.Payment_Label.AutoSize = true;
            this.Payment_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_Label.Location = new System.Drawing.Point(18, 513);
            this.Payment_Label.Name = "Payment_Label";
            this.Payment_Label.Size = new System.Drawing.Size(88, 25);
            this.Payment_Label.TabIndex = 16;
            this.Payment_Label.Text = "Payment:";
            // 
            // CreditDebit_RadioButton
            // 
            this.CreditDebit_RadioButton.AutoSize = true;
            this.CreditDebit_RadioButton.Checked = true;
            this.CreditDebit_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditDebit_RadioButton.Location = new System.Drawing.Point(185, 556);
            this.CreditDebit_RadioButton.Name = "CreditDebit_RadioButton";
            this.CreditDebit_RadioButton.Size = new System.Drawing.Size(125, 27);
            this.CreditDebit_RadioButton.TabIndex = 17;
            this.CreditDebit_RadioButton.TabStop = true;
            this.CreditDebit_RadioButton.Text = "Credit/Debit";
            this.CreditDebit_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Cash_RadioButton
            // 
            this.Cash_RadioButton.AutoSize = true;
            this.Cash_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cash_RadioButton.Location = new System.Drawing.Point(378, 556);
            this.Cash_RadioButton.Name = "Cash_RadioButton";
            this.Cash_RadioButton.Size = new System.Drawing.Size(68, 27);
            this.Cash_RadioButton.TabIndex = 18;
            this.Cash_RadioButton.Text = "Cash";
            this.Cash_RadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditDebit_Icon
            // 
            this.CreditDebit_Icon.Image = ((System.Drawing.Image)(resources.GetObject("CreditDebit_Icon.Image")));
            this.CreditDebit_Icon.Location = new System.Drawing.Point(195, 473);
            this.CreditDebit_Icon.Name = "CreditDebit_Icon";
            this.CreditDebit_Icon.Size = new System.Drawing.Size(113, 100);
            this.CreditDebit_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreditDebit_Icon.TabIndex = 19;
            this.CreditDebit_Icon.TabStop = false;
            // 
            // Cash_Icon
            // 
            this.Cash_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Cash_Icon.Image")));
            this.Cash_Icon.Location = new System.Drawing.Point(355, 476);
            this.Cash_Icon.Name = "Cash_Icon";
            this.Cash_Icon.Size = new System.Drawing.Size(106, 89);
            this.Cash_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cash_Icon.TabIndex = 20;
            this.Cash_Icon.TabStop = false;
            // 
            // StayLength_Label
            // 
            this.StayLength_Label.AutoSize = true;
            this.StayLength_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Label.Location = new System.Drawing.Point(286, 265);
            this.StayLength_Label.Name = "StayLength_Label";
            this.StayLength_Label.Size = new System.Drawing.Size(214, 25);
            this.StayLength_Label.TabIndex = 21;
            this.StayLength_Label.Text = "Stay:                    night(s)";
            // 
            // StayLength_Selector
            // 
            this.StayLength_Selector.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StayLength_Selector.Location = new System.Drawing.Point(357, 262);
            this.StayLength_Selector.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.StayLength_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StayLength_Selector.Name = "StayLength_Selector";
            this.StayLength_Selector.Size = new System.Drawing.Size(61, 32);
            this.StayLength_Selector.TabIndex = 22;
            this.StayLength_Selector.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // CheckIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 658);
            this.Controls.Add(this.StayLength_Selector);
            this.Controls.Add(this.StayLength_Label);
            this.Controls.Add(this.Cash_RadioButton);
            this.Controls.Add(this.CreditDebit_RadioButton);
            this.Controls.Add(this.Payment_Label);
            this.Controls.Add(this.Room_Selector);
            this.Controls.Add(this.Price_Selector);
            this.Controls.Add(this.BedConfig_Selector);
            this.Controls.Add(this.Room_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.BedConfig_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Age_Selector);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.GuestInfo_Label);
            this.Controls.Add(this.Guest_Icon);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.CreditDebit_Icon);
            this.Controls.Add(this.Cash_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.CheckIn_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedConfig_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebit_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StayLength_Selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button OK_Button;
        private PictureBox Guest_Icon;
        private Label GuestInfo_Label;
        private TextBox Name_TextBox;
        private Label Name_Label;
        private Label LastName_Label;
        private TextBox LastName_TextBox;
        private NumericUpDown Age_Selector;
        private Label Age_Label;
        private Label BedConfig_Label;
        private Label Price_Label;
        private Label Room_Label;
        private NumericUpDown BedConfig_Selector;
        private NumericUpDown Price_Selector;
        private NumericUpDown Room_Selector;
        private Label Payment_Label;
        private RadioButton CreditDebit_RadioButton;
        private RadioButton Cash_RadioButton;
        private PictureBox CreditDebit_Icon;
        private PictureBox Cash_Icon;
        private Label StayLength_Label;
        private NumericUpDown StayLength_Selector;
    }
}