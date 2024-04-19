namespace LibraryManagementSystem
{
    partial class addStudents

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudents));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            viewStudentInfoBtn = new Button();
            addBooksBtn = new Button();
            issueBooksBtn = new Button();
            viewBooksBtn = new Button();
            exitBtn = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            Sname = new TextBox();
            panel4 = new Panel();
            cancelBtn = new Button();
            clearBtn = new Button();
            saveBtn = new Button();
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
            panel2.Controls.Add(viewStudentInfoBtn);
            panel2.Controls.Add(addBooksBtn);
            panel2.Controls.Add(issueBooksBtn);
            panel2.Controls.Add(viewBooksBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // viewStudentInfoBtn
            // 
            viewStudentInfoBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewStudentInfoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewStudentInfoBtn.Location = new Point(12, 290);
            viewStudentInfoBtn.Name = "viewStudentInfoBtn";
            viewStudentInfoBtn.Size = new Size(170, 43);
            viewStudentInfoBtn.TabIndex = 11;
            viewStudentInfoBtn.Text = "View Student Info";
            viewStudentInfoBtn.UseVisualStyleBackColor = false;
            viewStudentInfoBtn.Click += viewStudentInfoBtn_Click;
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
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 2;
            button1.Text = "Add Students";
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
            label3.Size = new Size(142, 20);
            label3.TabIndex = 0;
            label3.Text = "Add Student Details";
            // 
            // Sname
            // 
            Sname.Location = new Point(149, 14);
            Sname.Name = "Sname";
            Sname.Size = new Size(125, 27);
            Sname.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cancelBtn);
            panel4.Controls.Add(clearBtn);
            panel4.Controls.Add(saveBtn);
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
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Crimson;
            cancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(394, 266);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(114, 36);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Gray;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = SystemColors.ButtonHighlight;
            clearBtn.Location = new Point(219, 266);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(114, 36);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.SeaGreen;
            saveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ButtonHighlight;
            saveBtn.Location = new Point(55, 266);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(114, 36);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // Department
            // 
            Department.Location = new Point(415, 58);
            Department.Name = "Department";
            Department.Size = new Size(125, 27);
            Department.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 17);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 15;
            label10.Text = "Enrollment No :";
            // 
            // Semester
            // 
            Semester.Location = new Point(149, 195);
            Semester.Name = "Semester";
            Semester.Size = new Size(125, 27);
            Semester.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 61);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 13;
            label9.Text = "Department :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 195);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 12;
            label8.Text = "Enrolled Semester :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 108);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 11;
            label7.Text = "Student Contact :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 61);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 10;
            label6.Text = "Student Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 156);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 9;
            label5.Text = "Enrolled Campus : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 17);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 8;
            label4.Text = "Student Name :";
            // 
            // SID
            // 
            SID.Location = new Point(415, 14);
            SID.Name = "SID";
            SID.Size = new Size(125, 27);
            SID.TabIndex = 7;
            // 
            // Campus
            // 
            Campus.Location = new Point(149, 145);
            Campus.Name = "Campus";
            Campus.Size = new Size(125, 27);
            Campus.TabIndex = 6;
            // 
            // Scontact
            // 
            Scontact.Location = new Point(149, 98);
            Scontact.Name = "Scontact";
            Scontact.Size = new Size(125, 27);
            Scontact.TabIndex = 5;
            // 
            // Semail
            // 
            Semail.Location = new Point(149, 58);
            Semail.Name = "Semail";
            Semail.Size = new Size(125, 27);
            Semail.TabIndex = 4;
            // 
            // addStudents
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
            Name = "addStudents";
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
        private Button viewBooksBtn;
        private Button exitBtn;
        private Button button1;
        private Button addBooksBtn;
        private Button issueBooksBtn;
        private Button viewStudentInfoBtn;
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
        private Button cancelBtn;
        private Button clearBtn;
        private Button saveBtn;
        private TextBox Department;
        private Label label10;
        private TextBox Semester;
        private Label label9;
    }
}