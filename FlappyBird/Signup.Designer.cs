namespace FlappyBird
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "FlappyBird \r\nby AndyT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_password
            // 
            this.txt_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_password.Location = new System.Drawing.Point(60, 154);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(210, 22);
            this.txt_password.TabIndex = 6;
            this.txt_password.Text = "Password";
            this.txt_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_password_MouseClick);
            // 
            // txt_username
            // 
            this.txt_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_username.Location = new System.Drawing.Point(60, 111);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(210, 22);
            this.txt_username.TabIndex = 7;
            this.txt_username.Text = "Username";
            this.txt_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_username_MouseClick);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.Color.Black;
            this.btn_signUp.Location = new System.Drawing.Point(116, 243);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(95, 36);
            this.btn_signUp.TabIndex = 5;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.Btn_signUp_Click);
            // 
            // txt_confirm
            // 
            this.txt_confirm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_confirm.Location = new System.Drawing.Point(60, 193);
            this.txt_confirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(210, 22);
            this.txt_confirm.TabIndex = 8;
            this.txt_confirm.Text = "Confirm Password";
            this.txt_confirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_confirm_MouseClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.Location = new System.Drawing.Point(280, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(46, 30);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(330, 318);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.Label Exit;
    }
}