namespace WinForms_Hotel
{
    partial class Room_info
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
            lblTypeOfRoom = new Label();
            lblPrice = new Label();
            lblMaxGuests = new Label();
            btnBook = new Button();
            lblHotelName = new Label();
            btnProfile = new Button();
            dateIn = new DateTimePicker();
            dateOut = new DateTimePicker();
            lblDateIn = new Label();
            lblDateOut = new Label();
            SuspendLayout();
            // 
            // lblTypeOfRoom
            // 
            lblTypeOfRoom.AutoSize = true;
            lblTypeOfRoom.Font = new Font("Segoe UI", 16F);
            lblTypeOfRoom.Location = new Point(47, 35);
            lblTypeOfRoom.Name = "lblTypeOfRoom";
            lblTypeOfRoom.Size = new Size(191, 37);
            lblTypeOfRoom.TabIndex = 0;
            lblTypeOfRoom.Text = "Type Of Room:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(47, 206);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price: ";
            // 
            // lblMaxGuests
            // 
            lblMaxGuests.AutoSize = true;
            lblMaxGuests.Font = new Font("Segoe UI", 12F);
            lblMaxGuests.Location = new Point(47, 157);
            lblMaxGuests.Name = "lblMaxGuests";
            lblMaxGuests.Size = new Size(121, 28);
            lblMaxGuests.TabIndex = 7;
            lblMaxGuests.Text = "Max Guests: ";
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 12F);
            btnBook.Location = new Point(105, 384);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(229, 51);
            btnBook.TabIndex = 8;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI", 12F);
            lblHotelName.Location = new Point(47, 104);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(126, 28);
            lblHotelName.TabIndex = 9;
            lblHotelName.Text = "Hotel Name: ";
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(280, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(128, 36);
            btnProfile.TabIndex = 10;
            btnProfile.Text = "User Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // dateIn
            // 
            dateIn.Font = new Font("Segoe UI", 12F);
            dateIn.Location = new Point(152, 251);
            dateIn.Name = "dateIn";
            dateIn.Size = new Size(256, 34);
            dateIn.TabIndex = 11;
            // 
            // dateOut
            // 
            dateOut.Font = new Font("Segoe UI", 12F);
            dateOut.Location = new Point(152, 309);
            dateOut.Name = "dateOut";
            dateOut.Size = new Size(256, 34);
            dateOut.TabIndex = 12;
            // 
            // lblDateIn
            // 
            lblDateIn.AutoSize = true;
            lblDateIn.Font = new Font("Segoe UI", 12F);
            lblDateIn.Location = new Point(47, 251);
            lblDateIn.Name = "lblDateIn";
            lblDateIn.Size = new Size(78, 28);
            lblDateIn.TabIndex = 13;
            lblDateIn.Text = "Date In:";
            // 
            // lblDateOut
            // 
            lblDateOut.AutoSize = true;
            lblDateOut.Font = new Font("Segoe UI", 12F);
            lblDateOut.Location = new Point(47, 309);
            lblDateOut.Name = "lblDateOut";
            lblDateOut.Size = new Size(95, 28);
            lblDateOut.TabIndex = 14;
            lblDateOut.Text = "Date Out:";
            // 
            // Room_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 459);
            Controls.Add(lblDateOut);
            Controls.Add(lblDateIn);
            Controls.Add(dateOut);
            Controls.Add(dateIn);
            Controls.Add(btnProfile);
            Controls.Add(lblHotelName);
            Controls.Add(btnBook);
            Controls.Add(lblMaxGuests);
            Controls.Add(lblPrice);
            Controls.Add(lblTypeOfRoom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Room_info";
            Text = "Room_info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypeOfRoom;
        private Label lblPrice;
        private Label lblMaxGuests;
        private Label lblHotelName;
        private Button btnBook;
        private Button btnProfile;
        private DateTimePicker dateIn;
        private DateTimePicker dateOut;
        private Label lblDateIn;
        private Label lblDateOut;
    }
}