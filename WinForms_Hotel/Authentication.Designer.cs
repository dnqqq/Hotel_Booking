namespace WinForms_Hotel
{
    partial class Authentication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxUsername = new TextBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            txtboxPassword = new TextBox();
            txtboxAdminPassword = new TextBox();
            lblUsername = new Label();
            lblAdminPassword = new Label();
            lblPassword = new Label();
            isAdmin = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            txtboxUsername.Location = new Point(40, 53);
            txtboxUsername.Margin = new Padding(3, 4, 3, 4);
            txtboxUsername.Name = "textBox1";
            txtboxUsername.Size = new Size(258, 27);
            txtboxUsername.TabIndex = 0;
            // 
            // button1
            // 
            btnSignIn.Location = new Point(62, 307);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "button1";
            btnSignIn.Size = new Size(86, 31);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            btnSignUp.Location = new Point(170, 307);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "button2";
            btnSignUp.Size = new Size(86, 31);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            txtboxPassword.Location = new Point(40, 127);
            txtboxPassword.Margin = new Padding(3, 4, 3, 4);
            txtboxPassword.Name = "textBox2";
            txtboxPassword.Size = new Size(258, 27);
            txtboxPassword.TabIndex = 3;
            // 
            // textBox3
            // 
            txtboxAdminPassword.Location = new Point(40, 236);
            txtboxAdminPassword.Margin = new Padding(3, 4, 3, 4);
            txtboxAdminPassword.Name = "textBox3";
            txtboxAdminPassword.Size = new Size(258, 27);
            txtboxAdminPassword.TabIndex = 4;
            // 
            // label1
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(40, 29);
            lblUsername.Name = "label1";
            lblUsername.Size = new Size(77, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "user name";
            // 
            // label2
            // 
            lblAdminPassword.AutoSize = true;
            lblAdminPassword.Location = new Point(40, 212);
            lblAdminPassword.Name = "label2";
            lblAdminPassword.Size = new Size(118, 20);
            lblAdminPassword.TabIndex = 6;
            lblAdminPassword.Text = "admin password";
            // 
            // label3
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 103);
            lblPassword.Name = "label3";
            lblPassword.Size = new Size(72, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "password";
            // 
            // checkBox1
            // 
            isAdmin.AutoSize = true;
            isAdmin.Location = new Point(40, 165);
            isAdmin.Margin = new Padding(3, 4, 3, 4);
            isAdmin.Name = "checkBox1";
            isAdmin.Size = new Size(87, 24);
            isAdmin.TabIndex = 9;
            isAdmin.Text = "is admin";
            isAdmin.UseVisualStyleBackColor = true;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 368);
            Controls.Add(isAdmin);
            Controls.Add(lblPassword);
            Controls.Add(lblAdminPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtboxAdminPassword);
            Controls.Add(txtboxPassword);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtboxUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Authentication";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxUsername;
        private Button btnSignIn;
        private Button btnSignUp;
        private TextBox txtboxPassword;
        private TextBox txtboxAdminPassword;
        private Label lblUsername;
        private Label lblAdminPassword;
        private Label lblPassword;
        private CheckBox isAdmin;
    }
}
