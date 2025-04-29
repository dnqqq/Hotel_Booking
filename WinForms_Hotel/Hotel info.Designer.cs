namespace WinForms_Hotel
{
    partial class Hotel_info
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
            lblHotelName = new Label();
            lblHotelDescription = new Label();
            lblHotelLocation = new Label();
            btnShowRooms = new Button();
            lblHotelStars = new Label();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI", 16F);
            lblHotelName.Location = new Point(165, 30);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(83, 37);
            lblHotelName.TabIndex = 0;
            lblHotelName.Text = "name";
            // 
            // lblHotelDescription
            // 
            lblHotelDescription.AutoSize = true;
            lblHotelDescription.Font = new Font("Segoe UI", 12F);
            lblHotelDescription.Location = new Point(47, 156);
            lblHotelDescription.Name = "lblHotelDescription";
            lblHotelDescription.Size = new Size(110, 28);
            lblHotelDescription.TabIndex = 6;
            lblHotelDescription.Text = "description";
            // 
            // lblHotelLocation
            // 
            lblHotelLocation.AutoSize = true;
            lblHotelLocation.Font = new Font("Segoe UI", 12F);
            lblHotelLocation.Location = new Point(47, 106);
            lblHotelLocation.Name = "lblHotelLocation";
            lblHotelLocation.Size = new Size(83, 28);
            lblHotelLocation.TabIndex = 7;
            lblHotelLocation.Text = "location";
            // 
            // btnShowRooms
            // 
            btnShowRooms.Font = new Font("Segoe UI", 12F);
            btnShowRooms.Location = new Point(98, 291);
            btnShowRooms.Margin = new Padding(3, 4, 3, 4);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(229, 51);
            btnShowRooms.TabIndex = 8;
            btnShowRooms.Text = "show available rooms";
            btnShowRooms.UseVisualStyleBackColor = true;
            btnShowRooms.Click += btnShowRooms_Click;
            // 
            // lblHotelStars
            // 
            lblHotelStars.AutoSize = true;
            lblHotelStars.Font = new Font("Segoe UI", 12F);
            lblHotelStars.Location = new Point(47, 208);
            lblHotelStars.Name = "lblHotelStars";
            lblHotelStars.Size = new Size(52, 28);
            lblHotelStars.TabIndex = 9;
            lblHotelStars.Text = "stars";
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(326, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(128, 36);
            btnProfile.TabIndex = 10;
            btnProfile.Text = "User Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // Hotel_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 415);
            Controls.Add(btnProfile);
            Controls.Add(lblHotelStars);
            Controls.Add(btnShowRooms);
            Controls.Add(lblHotelLocation);
            Controls.Add(lblHotelDescription);
            Controls.Add(lblHotelName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Hotel_info";
            Text = "Hotel_info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHotelName;
        private Label lblHotelDescription;
        private Label lblHotelLocation;
        private Label lblHotelStars;
        private Button btnShowRooms;
        private Button btnProfile;
    }
}