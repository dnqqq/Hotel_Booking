namespace WinForms_Hotel
{
    partial class Room_Edit
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
            btnEditRoom = new Button();
            lblID = new Label();
            txtboxID = new TextBox();
            SuspendLayout();
            // 
            // txtboxTypeOfRoom
            // 
            txtboxTypeOfRoom.Location = new Point(174, 45);
            txtboxTypeOfRoom.Name = "txtboxTypeOfRoom";
            txtboxTypeOfRoom.Size = new Size(198, 27);
            txtboxTypeOfRoom.TabIndex = 0;
            // 
            // txtboxMaxGuests
            // 
            txtboxMaxGuests.Location = new Point(174, 95);
            txtboxMaxGuests.Name = "txtboxMaxGuests";
            txtboxMaxGuests.Size = new Size(198, 27);
            txtboxMaxGuests.TabIndex = 1;
            // 
            // txtboxPrice
            // 
            txtboxPrice.Location = new Point(174, 150);
            txtboxPrice.Name = "txtboxPrice";
            txtboxPrice.Size = new Size(198, 27);
            txtboxPrice.TabIndex = 2;
            // 
            // lblTypeOfRoom
            // 
            lblTypeOfRoom.AutoSize = true;
            lblTypeOfRoom.Font = new Font("Segoe UI", 12F);
            lblTypeOfRoom.Location = new Point(31, 41);
            lblTypeOfRoom.Name = "lblTypeOfRoom";
            lblTypeOfRoom.Size = new Size(137, 28);
            lblTypeOfRoom.TabIndex = 4;
            lblTypeOfRoom.Text = "Type of Room:";
            // 
            // lblMaxGuests
            // 
            lblMaxGuests.AutoSize = true;
            lblMaxGuests.Font = new Font("Segoe UI", 12F);
            lblMaxGuests.Location = new Point(31, 91);
            lblMaxGuests.Name = "lblMaxGuests";
            lblMaxGuests.Size = new Size(116, 28);
            lblMaxGuests.TabIndex = 5;
            lblMaxGuests.Text = "Max Guests:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(31, 146);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // btnAddRoom
            // 
            btnEditRoom.Font = new Font("Segoe UI", 14F);
            btnEditRoom.Location = new Point(119, 294);
            btnEditRoom.Name = "btnAddRoom";
            btnEditRoom.Size = new Size(178, 55);
            btnEditRoom.TabIndex = 8;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = true;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(31, 199);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 28);
            lblID.TabIndex = 9;
            lblID.Text = "ID:";
            // 
            // txtboxID
            // 
            txtboxID.Location = new Point(174, 200);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(198, 27);
            txtboxID.TabIndex = 10;
            // 
            // Room_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 415);
            Controls.Add(txtboxID);
            Controls.Add(lblID);
            Controls.Add(btnEditRoom);
            Controls.Add(lblPrice);
            Controls.Add(lblMaxGuests);
            Controls.Add(lblTypeOfRoom);
            Controls.Add(txtboxPrice);
            Controls.Add(txtboxMaxGuests);
            Controls.Add(txtboxTypeOfRoom);
            Name = "Room_Edit";
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
        private Button btnEditRoom;
        private Label lblID;
        private TextBox txtboxID;
    }
}