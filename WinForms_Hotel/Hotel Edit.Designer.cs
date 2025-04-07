namespace WinForms_Hotel
{
    partial class Hotel_Edit
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
            txtboxLocation = new TextBox();
            txtboxDescription = new TextBox();
            selectStars = new ComboBox();
            lblHotelName = new Label();
            lblLocation = new Label();
            lblDescription = new Label();
            lblStars = new Label();
            btnAddHotel = new Button();
            lblID = new Label();
            txtboxID = new TextBox();
            SuspendLayout();
            // 
            // txtboxHotelName
            // 
            txtboxHotelName.Location = new Point(171, 45);
            txtboxHotelName.Name = "txtboxHotelName";
            txtboxHotelName.Size = new Size(198, 27);
            txtboxHotelName.TabIndex = 0;
            // 
            // txtboxLocation
            // 
            txtboxLocation.Location = new Point(171, 95);
            txtboxLocation.Name = "txtboxLocation";
            txtboxLocation.Size = new Size(198, 27);
            txtboxLocation.TabIndex = 1;
            // 
            // txtboxDescription
            // 
            txtboxDescription.Location = new Point(171, 150);
            txtboxDescription.Name = "txtboxDescription";
            txtboxDescription.Size = new Size(198, 27);
            txtboxDescription.TabIndex = 2;
            // 
            // selectStars
            // 
            selectStars.FormattingEnabled = true;
            selectStars.Location = new Point(171, 253);
            selectStars.Name = "selectStars";
            selectStars.Size = new Size(198, 28);
            selectStars.TabIndex = 3;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI", 12F);
            lblHotelName.Location = new Point(31, 41);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(121, 28);
            lblHotelName.TabIndex = 4;
            lblHotelName.Text = "Hotel Name:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 12F);
            lblLocation.Location = new Point(31, 91);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(91, 28);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Location:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(31, 146);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(116, 28);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Font = new Font("Segoe UI", 12F);
            lblStars.Location = new Point(31, 253);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(58, 28);
            lblStars.TabIndex = 7;
            lblStars.Text = "Stars:";
            // 
            // btnAddHotel
            // 
            btnAddHotel.Font = new Font("Segoe UI", 14F);
            btnAddHotel.Location = new Point(120, 331);
            btnAddHotel.Name = "btnAddHotel";
            btnAddHotel.Size = new Size(178, 55);
            btnAddHotel.TabIndex = 8;
            btnAddHotel.Text = "Edit Hotel";
            btnAddHotel.UseVisualStyleBackColor = true;
            btnAddHotel.Click += btnEditHotel_Click;
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
            txtboxID.Location = new Point(171, 200);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(198, 27);
            txtboxID.TabIndex = 10;
            // 
            // Hotel_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 415);
            Controls.Add(txtboxID);
            Controls.Add(lblID);
            Controls.Add(btnAddHotel);
            Controls.Add(lblStars);
            Controls.Add(lblDescription);
            Controls.Add(lblLocation);
            Controls.Add(lblHotelName);
            Controls.Add(selectStars);
            Controls.Add(txtboxDescription);
            Controls.Add(txtboxLocation);
            Controls.Add(txtboxHotelName);
            Name = "Hotel_Edit";
            Text = "Hotel_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxHotelName;
        private TextBox txtboxLocation;
        private TextBox txtboxDescription;
        private ComboBox selectStars;
        private Label lblHotelName;
        private Label lblLocation;
        private Label lblDescription;
        private Label lblStars;
        private Button btnAddHotel;
        private Label lblID;
        private TextBox txtboxID;
    }
}