namespace WinForms_Hotel
{
    partial class Room_Form
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
            btnAddRoom = new Button();
            lblAvailableRooms = new Label();
            listAlailableRooms = new ListBox();
            btnRemoveRoom = new Button();
            btnEditRoom = new Button();
            btnProfile = new Button();
            lblHotel = new Label();
            SuspendLayout();
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new Font("Segoe UI", 12F);
            btnAddRoom.Location = new Point(369, 118);
            btnAddRoom.Margin = new Padding(3, 4, 3, 4);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(145, 40);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "add room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 13F);
            lblAvailableRooms.Location = new Point(37, 75);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(172, 30);
            lblAvailableRooms.TabIndex = 2;
            lblAvailableRooms.Text = "Available Rooms";
            // 
            // listAlailableRooms
            // 
            listAlailableRooms.FormattingEnabled = true;
            listAlailableRooms.Location = new Point(37, 118);
            listAlailableRooms.Margin = new Padding(3, 4, 3, 4);
            listAlailableRooms.Name = "listAlailableRooms";
            listAlailableRooms.Size = new Size(237, 244);
            listAlailableRooms.TabIndex = 3;
            listAlailableRooms.DoubleClick += listAlailableRooms_DoubleClick;
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.Font = new Font("Segoe UI", 12F);
            btnRemoveRoom.Location = new Point(369, 183);
            btnRemoveRoom.Margin = new Padding(3, 4, 3, 4);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(145, 40);
            btnRemoveRoom.TabIndex = 4;
            btnRemoveRoom.Text = "remove room";
            btnRemoveRoom.UseVisualStyleBackColor = true;
            btnRemoveRoom.Click += btnRemoveRoom_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.Font = new Font("Segoe UI", 12F);
            btnEditRoom.Location = new Point(369, 250);
            btnEditRoom.Margin = new Padding(3, 4, 3, 4);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(145, 37);
            btnEditRoom.TabIndex = 5;
            btnEditRoom.Text = "edit room";
            btnEditRoom.UseVisualStyleBackColor = true;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(648, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(128, 36);
            btnProfile.TabIndex = 9;
            btnProfile.Text = "User Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Font = new Font("Segoe UI", 16F);
            lblHotel.Location = new Point(37, 12);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(82, 37);
            lblHotel.TabIndex = 10;
            lblHotel.Text = "Hotel";
            // 
            // Room_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 408);
            Controls.Add(lblHotel);
            Controls.Add(btnProfile);
            Controls.Add(btnEditRoom);
            Controls.Add(btnRemoveRoom);
            Controls.Add(listAlailableRooms);
            Controls.Add(lblAvailableRooms);
            Controls.Add(btnAddRoom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Room_Form";
            Text = "Room_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAvailableRooms;
        private ListBox listAlailableRooms;
        private Button btnAddRoom;
        private Button btnRemoveRoom;
        private Button btnEditRoom;
        private Button btnProfile;
        private Label lblHotel;
    }
}