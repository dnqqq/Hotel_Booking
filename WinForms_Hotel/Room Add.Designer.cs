namespace WinForms_Hotel
{
    partial class Room_Add
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
            txtboxTypeOfRoom = new TextBox();
            txtboxMaxGuests = new TextBox();
            txtboxPrice = new TextBox();
            lblTypeOfRoom = new Label();
            lblMaxGuests = new Label();
            lblPrice = new Label();
            btnAddRoom = new Button();
            lblID = new Label();
            txtboxID = new TextBox();
            lblHotelName = new Label();
            txtboxHotelName = new TextBox();
            SuspendLayout();
            // 
            // txtboxTypeOfRoom
            // 
            txtboxTypeOfRoom.Location = new Point(172, 67);
            txtboxTypeOfRoom.Name = "txtboxTypeOfRoom";
            txtboxTypeOfRoom.Size = new Size(198, 27);
            txtboxTypeOfRoom.TabIndex = 0;
            // 
            // txtboxMaxGuests
            // 
            txtboxMaxGuests.Location = new Point(172, 117);
            txtboxMaxGuests.Name = "txtboxMaxGuests";
            txtboxMaxGuests.Size = new Size(198, 27);
            txtboxMaxGuests.TabIndex = 1;
            // 
            // txtboxPrice
            // 
            txtboxPrice.Location = new Point(172, 172);
            txtboxPrice.Name = "txtboxPrice";
            txtboxPrice.Size = new Size(198, 27);
            txtboxPrice.TabIndex = 2;
            // 
            // lblTypeOfRoom
            // 
            lblTypeOfRoom.AutoSize = true;
            lblTypeOfRoom.Font = new Font("Segoe UI", 12F);
            lblTypeOfRoom.Location = new Point(29, 63);
            lblTypeOfRoom.Name = "lblTypeOfRoom";
            lblTypeOfRoom.Size = new Size(137, 28);
            lblTypeOfRoom.TabIndex = 4;
            lblTypeOfRoom.Text = "Type of Room:";
            // 
            // lblMaxGuests
            // 
            lblMaxGuests.AutoSize = true;
            lblMaxGuests.Font = new Font("Segoe UI", 12F);
            lblMaxGuests.Location = new Point(29, 113);
            lblMaxGuests.Name = "lblMaxGuests";
            lblMaxGuests.Size = new Size(116, 28);
            lblMaxGuests.TabIndex = 5;
            lblMaxGuests.Text = "Max Guests:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(29, 168);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new Font("Segoe UI", 14F);
            btnAddRoom.Location = new Point(118, 304);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(178, 55);
            btnAddRoom.TabIndex = 8;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(29, 221);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 28);
            lblID.TabIndex = 9;
            lblID.Text = "ID:";
            // 
            // txtboxID
            // 
            txtboxID.Location = new Point(172, 222);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(198, 27);
            txtboxID.TabIndex = 10;
            // 
            // label1
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI", 12F);
            lblHotelName.Location = new Point(29, 23);
            lblHotelName.Name = "label1";
            lblHotelName.Size = new Size(121, 28);
            lblHotelName.TabIndex = 11;
            lblHotelName.Text = "Hotel Name:";
            // 
            // textBox1
            // 
            txtboxHotelName.Location = new Point(172, 27);
            txtboxHotelName.Name = "textBox1";
            txtboxHotelName.Size = new Size(198, 27);
            txtboxHotelName.TabIndex = 12;
            // 
            // Room_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 415);
            Controls.Add(txtboxHotelName);
            Controls.Add(lblHotelName);
            Controls.Add(txtboxID);
            Controls.Add(lblID);
            Controls.Add(btnAddRoom);
            Controls.Add(lblPrice);
            Controls.Add(lblMaxGuests);
            Controls.Add(lblTypeOfRoom);
            Controls.Add(txtboxPrice);
            Controls.Add(txtboxMaxGuests);
            Controls.Add(txtboxTypeOfRoom);
            Name = "Room_Add";
            Text = "Hotel_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxTypeOfRoom;
        private TextBox txtboxMaxGuests;
        private TextBox txtboxPrice;
        private Label lblTypeOfRoom;
        private Label lblMaxGuests;
        private Label lblPrice;
        private Button btnAddRoom;
        private Label lblID;
        private TextBox txtboxID;
        private Label lblHotelName;
        private TextBox txtboxHotelName;
    }
}