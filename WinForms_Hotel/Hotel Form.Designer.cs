namespace WinForms_Hotel
{
    partial class Hotel_Form
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
            txtboxHotelName = new TextBox();
            btnAddHotel = new Button();
            lblAvailableHotels = new Label();
            listAlailableHotels = new ListBox();
            btnRemoveHotel = new Button();
            btnEditHotel = new Button();
            lblHotelName = new Label();
            btnSearch = new Button();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // txtboxHotelName
            // 
            txtboxHotelName.Location = new Point(397, 88);
            txtboxHotelName.Margin = new Padding(3, 4, 3, 4);
            txtboxHotelName.Name = "txtboxHotelName";
            txtboxHotelName.Size = new Size(204, 27);
            txtboxHotelName.TabIndex = 0;
            // 
            // btnAddHotel
            // 
            btnAddHotel.Font = new Font("Segoe UI", 12F);
            btnAddHotel.Location = new Point(398, 149);
            btnAddHotel.Margin = new Padding(3, 4, 3, 4);
            btnAddHotel.Name = "btnAddHotel";
            btnAddHotel.Size = new Size(125, 40);
            btnAddHotel.TabIndex = 1;
            btnAddHotel.Text = "add hotel";
            btnAddHotel.UseVisualStyleBackColor = true;
            btnAddHotel.Click += btnAddHotel_Click;
            // 
            // lblAvailableHotels
            // 
            lblAvailableHotels.AutoSize = true;
            lblAvailableHotels.Font = new Font("Segoe UI", 16F);
            lblAvailableHotels.Location = new Point(37, 43);
            lblAvailableHotels.Name = "lblAvailableHotels";
            lblAvailableHotels.Size = new Size(208, 37);
            lblAvailableHotels.TabIndex = 2;
            lblAvailableHotels.Text = "Available Hotels";
            // 
            // listAlailableHotels
            // 
            listAlailableHotels.FormattingEnabled = true;
            listAlailableHotels.Location = new Point(37, 87);
            listAlailableHotels.Margin = new Padding(3, 4, 3, 4);
            listAlailableHotels.Name = "listAlailableHotels";
            listAlailableHotels.Size = new Size(237, 244);
            listAlailableHotels.TabIndex = 3;
            listAlailableHotels.DoubleClick += listAlailableHotels_DoubleClick;
            // 
            // btnRemoveHotel
            // 
            btnRemoveHotel.Font = new Font("Segoe UI", 12F);
            btnRemoveHotel.Location = new Point(398, 209);
            btnRemoveHotel.Margin = new Padding(3, 4, 3, 4);
            btnRemoveHotel.Name = "btnRemoveHotel";
            btnRemoveHotel.Size = new Size(125, 40);
            btnRemoveHotel.TabIndex = 4;
            btnRemoveHotel.Text = "remove hotel";
            btnRemoveHotel.UseVisualStyleBackColor = true;
            btnRemoveHotel.Click += btnRemoveHotel_Click;
            // 
            // btnEditHotel
            // 
            btnEditHotel.Font = new Font("Segoe UI", 12F);
            btnEditHotel.Location = new Point(398, 267);
            btnEditHotel.Margin = new Padding(3, 4, 3, 4);
            btnEditHotel.Name = "btnEditHotel";
            btnEditHotel.Size = new Size(125, 37);
            btnEditHotel.TabIndex = 5;
            btnEditHotel.Text = "edit hotel";
            btnEditHotel.UseVisualStyleBackColor = true;
            btnEditHotel.Click += btnEditHotel_Click;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI", 12F);
            lblHotelName.Location = new Point(398, 52);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(203, 28);
            lblHotelName.TabIndex = 6;
            lblHotelName.Text = "Search by Hotel name";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(625, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 45);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(787, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(128, 36);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "User Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // Hotel_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 401);
            Controls.Add(btnProfile);
            Controls.Add(btnSearch);
            Controls.Add(lblHotelName);
            Controls.Add(btnEditHotel);
            Controls.Add(btnRemoveHotel);
            Controls.Add(listAlailableHotels);
            Controls.Add(lblAvailableHotels);
            Controls.Add(btnAddHotel);
            Controls.Add(txtboxHotelName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Hotel_Form";
            Text = "Hotel_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxHotelName;
        private Label lblHotelName;
        private Label lblAvailableHotels;
        private ListBox listAlailableHotels;
        private Button btnAddHotel;
        private Button btnRemoveHotel;
        private Button btnEditHotel;
        private Button btnSearch;
        private Button btnProfile;
    }
}