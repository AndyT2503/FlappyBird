namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Scoretxt = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowResult = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_highscore = new System.Windows.Forms.Button();
            this.pipeBotom1 = new System.Windows.Forms.PictureBox();
            this.pipeBotom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // Scoretxt
            // 
            this.Scoretxt.BackColor = System.Drawing.Color.Aqua;
            this.Scoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.Location = new System.Drawing.Point(409, 418);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(86, 23);
            this.Scoretxt.TabIndex = 6;
            this.Scoretxt.Text = "00";
            this.Scoretxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(293, 413);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 33);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ShowResult
            // 
            this.ShowResult.Interval = 1000;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(188, 413);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 33);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_highscore
            // 
            this.btn_highscore.AutoSize = true;
            this.btn_highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highscore.Location = new System.Drawing.Point(16, 413);
            this.btn_highscore.Name = "btn_highscore";
            this.btn_highscore.Size = new System.Drawing.Size(111, 33);
            this.btn_highscore.TabIndex = 9;
            this.btn_highscore.Text = "High Score";
            this.btn_highscore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_highscore.UseVisualStyleBackColor = true;
            this.btn_highscore.Click += new System.EventHandler(this.Btn_highscore_Click);
            // 
            // pipeBotom1
            // 
            this.pipeBotom1.BackColor = System.Drawing.Color.Transparent;
            this.pipeBotom1.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBotom1.Location = new System.Drawing.Point(228, 273);
            this.pipeBotom1.Name = "pipeBotom1";
            this.pipeBotom1.Size = new System.Drawing.Size(53, 103);
            this.pipeBotom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBotom1.TabIndex = 3;
            this.pipeBotom1.TabStop = false;
            // 
            // pipeBotom2
            // 
            this.pipeBotom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBotom2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBotom2.Location = new System.Drawing.Point(366, 255);
            this.pipeBotom2.Name = "pipeBotom2";
            this.pipeBotom2.Size = new System.Drawing.Size(53, 122);
            this.pipeBotom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBotom2.TabIndex = 1;
            this.pipeBotom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(442, 0);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(53, 145);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 0;
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop1.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop1.Location = new System.Drawing.Point(257, 0);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(53, 172);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 2;
            this.pipeTop1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 376);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(528, 87);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(12, 189);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(49, 45);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 4;
            this.Bird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(525, 463);
            this.Controls.Add(this.btn_highscore);
            this.Controls.Add(this.pipeBotom1);
            this.Controls.Add(this.pipeBotom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.Scoretxt);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBotom2;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeBotom1;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Scoretxt;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer ShowResult;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_highscore;
    }
}

