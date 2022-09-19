namespace Hotel_Management__Beta_1._0_
{
    partial class Rooms_Form
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
            this.OK_Button = new System.Windows.Forms.Button();
            this.AvailableRooms_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(643, 399);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(145, 40);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // AvailableRooms_Label
            // 
            this.AvailableRooms_Label.AutoSize = true;
            this.AvailableRooms_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailableRooms_Label.Location = new System.Drawing.Point(13, 10);
            this.AvailableRooms_Label.Name = "AvailableRooms_Label";
            this.AvailableRooms_Label.Size = new System.Drawing.Size(151, 25);
            this.AvailableRooms_Label.TabIndex = 1;
            this.AvailableRooms_Label.Text = "Available rooms:";
            // 
            // Rooms_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvailableRooms_Label);
            this.Controls.Add(this.OK_Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rooms_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OK_Button;
        private Label AvailableRooms_Label;
    }
}