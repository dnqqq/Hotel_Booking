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
            SuspendLayout();
            // 
            // lblTypeOfRoom
            // 
            lblTypeOfRoom.AutoSize = true;
            lblTypeOfRoom.Font = new Font("Segoe UI", 16F);
            lblTypeOfRoom.Location = new Point(136, 29);
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
            btnBook.Location = new Point(98, 291);
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
            // Room_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 415);
            Controls.Add(lblHotelName);
            Controls.Add(btnBook);
            Controls.Add(lblMaxGuests);
            Controls.Add(lblPrice);
            Controls.Add(lblTypeOfRoom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Room_info";
            Text = "Hotel_info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypeOfRoom;
        private Label lblPrice;
        private Label lblMaxGuests;
        private Label lblHotelName;
        private Button btnBook;
    }
}