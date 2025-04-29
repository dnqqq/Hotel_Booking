namespace WinForms_Hotel
{
    partial class User_Profile
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
            lblUsername = new Label();
            lblBookedRooms = new Label();
            listBooked = new DataGridView();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)listBooked).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(51, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblBookedRooms
            // 
            lblBookedRooms.AutoSize = true;
            lblBookedRooms.Font = new Font("Segoe UI", 12F);
            lblBookedRooms.Location = new Point(51, 119);
            lblBookedRooms.Name = "lblBookedRooms";
            lblBookedRooms.Size = new Size(144, 28);
            lblBookedRooms.TabIndex = 1;
            lblBookedRooms.Text = "Booked Rooms";
            // 
            // listBooked
            // 
            listBooked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBooked.Location = new Point(27, 161);
            listBooked.Name = "listBooked";
            listBooked.RowHeadersWidth = 51;
            listBooked.Size = new Size(656, 246);
            listBooked.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Location = new Point(737, 161);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 44);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(btnRemove);
            Controls.Add(listBooked);
            Controls.Add(lblBookedRooms);
            Controls.Add(lblUsername);
            Name = "User_Profile";
            Text = "User_Profile";
            ((System.ComponentModel.ISupportInitialize)listBooked).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblBookedRooms;
        private DataGridView listBooked;
        private Button btnRemove;
    }
}