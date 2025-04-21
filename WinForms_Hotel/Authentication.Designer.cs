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
            txtboxPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnSignUp = new Button();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(40, 53);
            txtboxUsername.Margin = new Padding(3, 4, 3, 4);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(258, 27);
            txtboxUsername.TabIndex = 0;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(40, 127);
            txtboxPassword.Margin = new Padding(3, 4, 3, 4);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(258, 27);
            txtboxPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(40, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "password";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(185, 194);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(86, 31);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(56, 194);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(86, 31);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 271);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtboxPassword);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtboxUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Authentication";
            Text = "Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnSignUp;
        private Button btnSignIn;
    }
}
