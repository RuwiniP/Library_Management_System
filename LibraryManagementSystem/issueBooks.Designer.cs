namespace LibraryManagementSystem
{
    partial class issueBooks

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            sContact = new Label();
            sEmail = new Label();
            sName = new Label();
            label11 = new Label();
            issueBookBtn = new Button();
            panel5 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            isbn = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            searchBtn = new Button();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 42);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(743, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(611, 9);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome , Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 0;
            label1.Text = "Conestoga Library Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.GradientInactiveCaption;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(12, 290);
            button10.Name = "button10";
            button10.Size = new Size(170, 43);
            button10.TabIndex = 11;
            button10.Text = "View Student Info";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GradientInactiveCaption;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(12, 225);
            button9.Name = "button9";
            button9.Size = new Size(170, 43);
            button9.TabIndex = 10;
            button9.Text = "Add Students";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientInactiveCaption;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(12, 27);
            button8.Name = "button8";
            button8.Size = new Size(170, 43);
            button8.TabIndex = 9;
            button8.Text = "Add Books";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 94);
            button7.Name = "button7";
            button7.Size = new Size(170, 43);
            button7.TabIndex = 8;
            button7.Text = "View Books";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.AliceBlue;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 358);
            button6.Name = "button6";
            button6.Size = new Size(170, 43);
            button6.TabIndex = 7;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 155);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 2;
            button1.Text = "Issue Books";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(217, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(559, 32);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(15, 5);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 0;
            label3.Text = "Issue Book Details";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(sContact);
            panel4.Controls.Add(sEmail);
            panel4.Controls.Add(sName);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(issueBookBtn);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 336);
            panel4.TabIndex = 4;
            // 
            // sContact
            // 
            sContact.AutoSize = true;
            sContact.Location = new Point(116, 212);
            sContact.Name = "sContact";
            sContact.Size = new Size(0, 20);
            sContact.TabIndex = 25;
            // 
            // sEmail
            // 
            sEmail.AutoSize = true;
            sEmail.Location = new Point(75, 160);
            sEmail.Name = "sEmail";
            sEmail.Size = new Size(0, 20);
            sEmail.TabIndex = 24;
            // 
            // sName
            // 
            sName.AutoSize = true;
            sName.Location = new Point(132, 109);
            sName.Name = "sName";
            sName.Size = new Size(0, 20);
            sName.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(230, 306);
            label11.Name = "label11";
            label11.Size = new Size(326, 17);
            label11.TabIndex = 22;
            label11.Text = "Maximum three books can be issued to the same student.";
            // 
            // issueBookBtn
            // 
            issueBookBtn.BackColor = Color.MidnightBlue;
            issueBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBookBtn.ForeColor = SystemColors.ButtonHighlight;
            issueBookBtn.Location = new Point(426, 232);
            issueBookBtn.Name = "issueBookBtn";
            issueBookBtn.Size = new Size(114, 36);
            issueBookBtn.TabIndex = 18;
            issueBookBtn.Text = "Issue Book";
            issueBookBtn.UseVisualStyleBackColor = false;
            issueBookBtn.Click += issueBookBtn_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(isbn);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(313, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 211);
            panel5.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(13, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 112);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 15;
            label10.Text = "Date of Issue :";
            // 
            // isbn
            // 
            isbn.Location = new Point(13, 60);
            isbn.Name = "isbn";
            isbn.Size = new Size(194, 27);
            isbn.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 27);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "Add ISBN :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(19, 83);
            label6.Name = "label6";
            label6.Size = new Size(200, 17);
            label6.TabIndex = 20;
            label6.Text = "Perform the search to display data";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(149, 254);
            button4.Name = "button4";
            button4.Size = new Size(114, 36);
            button4.TabIndex = 19;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(19, 254);
            button3.Name = "button3";
            button3.Size = new Size(114, 36);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.MidnightBlue;
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(160, 45);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(114, 36);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 160);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 13;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 109);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 12;
            label8.Text = "Student Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 212);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 9;
            label5.Text = "Contact No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 18);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 8;
            label4.Text = "Enter Student Enrollment No :";
            // 
            // issueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "issueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "issueBooks Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button10;
        private Panel panel3;
        private Label label3;
        private TextBox textBox1;
        private Panel panel4;
        private Label label8;
        private Label label5;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button searchBtn;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private Label label7;
        private Label label6;
        private Button issueBookBtn;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label sContact;
        private Label sEmail;
        private Label sName;
        private TextBox isbn;
    }
}