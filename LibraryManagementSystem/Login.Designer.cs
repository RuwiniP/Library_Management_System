namespace LibraryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LoginBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 423);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 375);
            label2.Name = "label2";
            label2.Size = new Size(418, 20);
            label2.TabIndex = 2;
            label2.Text = "Connects – people to people, people to place, people to learning.";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = SystemColors.GradientActiveCaption;
            usernameTxt.ForeColor = SystemColors.InactiveCaptionText;
            usernameTxt.Location = new Point(571, 176);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(169, 27);
            usernameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = SystemColors.GradientActiveCaption;
            passwordTxt.ForeColor = SystemColors.InactiveCaptionText;
            passwordTxt.Location = new Point(571, 254);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(169, 27);
            passwordTxt.TabIndex = 5;
            passwordTxt.PasswordChar = '*';
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(571, 156);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 6;
            label3.Text = "Email or username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(571, 234);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.MidnightBlue;
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(582, 316);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(146, 47);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(571, 30);
            label5.Name = "label5";
            label5.Size = new Size(142, 60);
            label5.TabIndex = 9;
            label5.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(579, 90);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 10;
            label6.Text = "Stay Connected....";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 481);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.CornflowerBlue;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Label label3;
        private Label label4;
        private Button LoginBtn;
        private Label label5;
        private Label label6;
    }
}
