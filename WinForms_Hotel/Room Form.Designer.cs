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
            SuspendLayout();
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new Font("Segoe UI", 12F);
            btnAddRoom.Location = new Point(398, 87);
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
            lblAvailableRooms.Font = new Font("Segoe UI", 16F);
            lblAvailableRooms.Location = new Point(37, 43);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(213, 37);
            lblAvailableRooms.TabIndex = 2;
            lblAvailableRooms.Text = "Available Rooms";
            // 
            // listAlailableRooms
            // 
            listAlailableRooms.FormattingEnabled = true;
            listAlailableRooms.Location = new Point(37, 87);
            listAlailableRooms.Margin = new Padding(3, 4, 3, 4);
            listAlailableRooms.Name = "listAlailableRooms";
            listAlailableRooms.Size = new Size(237, 244);
            listAlailableRooms.TabIndex = 3;
            listAlailableRooms.DoubleClick += listAlailableRooms_DoubleClick;
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.Font = new Font("Segoe UI", 12F);
            btnRemoveRoom.Location = new Point(398, 148);
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
            btnEditRoom.Location = new Point(398, 208);
            btnEditRoom.Margin = new Padding(3, 4, 3, 4);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(145, 37);
            btnEditRoom.TabIndex = 5;
            btnEditRoom.Text = "edit room";
            btnEditRoom.UseVisualStyleBackColor = true;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // Room_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
    }
}