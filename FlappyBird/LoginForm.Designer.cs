namespace FlappyBird
{
    partial class LoginForm
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(188, 255);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(95, 36);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // txt_username
            // 
            this.txt_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_username.Location = new System.Drawing.Point(61, 127);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(210, 22);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Username";
            this.txt_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_username_MouseClick);
            // 
            // txt_password
            // 
            this.txt_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_password.Location = new System.Drawing.Point(61, 202);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(210, 22);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_password_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "FlappyBird \r\nby AndyT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.Location = new System.Drawing.Point(283, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(46, 30);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.Location = new System.Drawing.Point(46, 255);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(95, 36);
            this.btn_signUp.TabIndex = 5;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.Btn_signUp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(330, 318);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button btn_signUp;
    }
}