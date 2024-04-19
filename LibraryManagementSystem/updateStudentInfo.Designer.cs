namespace LibraryManagementSystem
{
    partial class updateStudentInfo

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateStudentInfo));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            addBooksBtn = new Button();
            issueBooksBtn = new Button();
            viewBooksBtn = new Button();
            exitBtn = new Button();
            addStudentsBtn = new Button();
            panel3 = new Panel();
            label3 = new Label();
            Sname = new TextBox();
            panel4 = new Panel();
            searchBtn = new Button();
            backBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            Department = new TextBox();
            label10 = new Label();
            Semester = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SID = new TextBox();
            Campus = new TextBox();
            Scontact = new TextBox();
            Semail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel2.Controls.Add(button5);
            panel2.Controls.Add(addBooksBtn);
            panel2.Controls.Add(issueBooksBtn);
            panel2.Controls.Add(viewBooksBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Controls.Add(addStudentsBtn);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 287);
            button5.Name = "button5";
            button5.Size = new Size(170, 43);
            button5.TabIndex = 13;
            button5.Text = "View Student Info";
            button5.UseVisualStyleBackColor = false;
            // 
            // addBooksBtn
            // 
            addBooksBtn.BackColor = SystemColors.GradientInactiveCaption;
            addBooksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBooksBtn.Location = new Point(12, 27);
            addBooksBtn.Name = "addBooksBtn";
            addBooksBtn.Size = new Size(170, 43);
            addBooksBtn.TabIndex = 10;
            addBooksBtn.Text = "Add Books";
            addBooksBtn.UseVisualStyleBackColor = false;
            addBooksBtn.Click += addBooksBtn_Click;
            // 
            // issueBooksBtn
            // 
            issueBooksBtn.BackColor = SystemColors.GradientInactiveCaption;
            issueBooksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBooksBtn.Location = new Point(12, 162);
            issueBooksBtn.Name = "issueBooksBtn";
            issueBooksBtn.Size = new Size(170, 43);
            issueBooksBtn.TabIndex = 9;
            issueBooksBtn.Text = "Issue Books";
            issueBooksBtn.UseVisualStyleBackColor = false;
            issueBooksBtn.Click += issueBooksBtn_Click;
            // 
            // viewBooksBtn
            // 
            viewBooksBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewBooksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewBooksBtn.Location = new Point(12, 94);
            viewBooksBtn.Name = "viewBooksBtn";
            viewBooksBtn.Size = new Size(170, 43);
            viewBooksBtn.TabIndex = 8;
            viewBooksBtn.Text = "View Books";
            viewBooksBtn.UseVisualStyleBackColor = false;
            viewBooksBtn.Click += viewBooksBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.AliceBlue;
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(12, 358);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(170, 43);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // addStudentsBtn
            // 
            addStudentsBtn.BackColor = SystemColors.GradientInactiveCaption;
            addStudentsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentsBtn.ForeColor = SystemColors.ControlText;
            addStudentsBtn.Location = new Point(12, 221);
            addStudentsBtn.Name = "addStudentsBtn";
            addStudentsBtn.Size = new Size(170, 43);
            addStudentsBtn.TabIndex = 2;
            addStudentsBtn.Text = "Add Students";
            addStudentsBtn.UseVisualStyleBackColor = false;
            addStudentsBtn.Click += addStudentsBtn_Click;
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
            label3.Size = new Size(163, 20);
            label3.TabIndex = 0;
            label3.Text = "Update Student Details";
            // 
            // Sname
            // 
            Sname.Location = new Point(149, 100);
            Sname.Name = "Sname";
            Sname.Size = new Size(125, 27);
            Sname.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(backBtn);
            panel4.Controls.Add(deleteBtn);
            panel4.Controls.Add(updateBtn);
            panel4.Controls.Add(Department);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(Semester);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(SID);
            panel4.Controls.Add(Campus);
            panel4.Controls.Add(Scontact);
            panel4.Controls.Add(Semail);
            panel4.Controls.Add(Sname);
            panel4.Location = new Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 321);
            panel4.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.SeaGreen;
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(309, 14);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(114, 36);
            searchBtn.TabIndex = 20;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ControlDarkDark;
            backBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.ButtonHighlight;
            backBtn.Location = new Point(394, 266);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(114, 36);
            backBtn.TabIndex = 19;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Location = new Point(219, 266);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(114, 36);
            deleteBtn.TabIndex = 18;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(55, 266);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(114, 36);
            updateBtn.TabIndex = 17;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click_1;
            // 
            // Department
            // 
            Department.Location = new Point(415, 206);
            Department.Name = "Department";
            Department.Size = new Size(125, 27);
            Department.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 14);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 15;
            label10.Text = "Enrollment No :";
            // 
            // Semester
            // 
            Semester.Location = new Point(415, 101);
            Semester.Name = "Semester";
            Semester.Size = new Size(125, 27);
            Semester.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 213);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 13;
            label9.Text = "Department :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 104);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 12;
            label8.Text = "Enrolled Semester :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 155);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 11;
            label7.Text = "Student Contact :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 209);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 10;
            label6.Text = "Student Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 156);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 9;
            label5.Text = "Enrolled Campus : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 104);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 8;
            label4.Text = "Student Name :";
            label4.Click += label4_Click;
            // 
            // SID
            // 
            SID.Location = new Point(149, 14);
            SID.Name = "SID";
            SID.Size = new Size(125, 27);
            SID.TabIndex = 7;
            // 
            // Campus
            // 
            Campus.Location = new Point(415, 152);
            Campus.Name = "Campus";
            Campus.Size = new Size(125, 27);
            Campus.TabIndex = 6;
            // 
            // Scontact
            // 
            Scontact.Location = new Point(149, 148);
            Scontact.Name = "Scontact";
            Scontact.Size = new Size(125, 27);
            Scontact.TabIndex = 5;
            // 
            // Semail
            // 
            Semail.Location = new Point(149, 202);
            Semail.Name = "Semail";
            Semail.Size = new Size(125, 27);
            Semail.TabIndex = 4;
            // 
            // updateStudentInfo
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
            Name = "updateStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addStudents Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button exitBtn;
        private Panel panel3;
        private Label label3;
        private TextBox Sname;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox SID;
        private TextBox Campus;
        private TextBox Scontact;
        private TextBox Semail;
        private Button backBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox Department;
        private Label label10;
        private TextBox Semester;
        private Label label9;
        private Button addBooksBtn;
        private Button issueBooksBtn;
        private Button viewBooksBtn;
        private Button addStudentsBtn;
        private Button button5;
        private Button searchBtn;
    }
}