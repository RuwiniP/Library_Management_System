namespace LibraryManagementSystem
{
    partial class updateBooks

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            addBooksBtn = new Button();
            button5 = new Button();
            viewStudentInfoBtn = new Button();
            issueBooksBtn = new Button();
            exitBtn = new Button();
            addStudentsBtn = new Button();
            panel3 = new Panel();
            label3 = new Label();
            Bname = new TextBox();
            panel4 = new Panel();
            searchBtn = new Button();
            backBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            label10 = new Label();
            Price = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ISBN = new TextBox();
            Quantity = new TextBox();
            AName = new TextBox();
            PName = new TextBox();
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
            panel2.Controls.Add(addBooksBtn);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(viewStudentInfoBtn);
            panel2.Controls.Add(issueBooksBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Controls.Add(addStudentsBtn);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // addBooksBtn
            // 
            addBooksBtn.BackColor = SystemColors.GradientInactiveCaption;
            addBooksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBooksBtn.Location = new Point(12, 27);
            addBooksBtn.Name = "addBooksBtn";
            addBooksBtn.Size = new Size(170, 43);
            addBooksBtn.TabIndex = 22;
            addBooksBtn.Text = "Add Books";
            addBooksBtn.UseVisualStyleBackColor = false;
            addBooksBtn.Click += addBooksBtn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 90);
            button5.Name = "button5";
            button5.Size = new Size(170, 43);
            button5.TabIndex = 13;
            button5.Text = "View Books";
            button5.UseVisualStyleBackColor = false;
            // 
            // viewStudentInfoBtn
            // 
            viewStudentInfoBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewStudentInfoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewStudentInfoBtn.ForeColor = SystemColors.ControlText;
            viewStudentInfoBtn.Location = new Point(12, 292);
            viewStudentInfoBtn.Name = "viewStudentInfoBtn";
            viewStudentInfoBtn.Size = new Size(170, 43);
            viewStudentInfoBtn.TabIndex = 21;
            viewStudentInfoBtn.Text = "View Student Info";
            viewStudentInfoBtn.UseVisualStyleBackColor = false;
            viewStudentInfoBtn.Click += viewStudentInfoBtn_Click;
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
            label3.Size = new Size(146, 20);
            label3.TabIndex = 0;
            label3.Text = "Update Book Details";
            // 
            // Bname
            // 
            Bname.Location = new Point(149, 100);
            Bname.Name = "Bname";
            Bname.Size = new Size(125, 27);
            Bname.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(backBtn);
            panel4.Controls.Add(deleteBtn);
            panel4.Controls.Add(updateBtn);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(Price);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(ISBN);
            panel4.Controls.Add(Quantity);
            panel4.Controls.Add(AName);
            panel4.Controls.Add(PName);
            panel4.Controls.Add(Bname);
            panel4.Location = new Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 321);
            panel4.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.Highlight;
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
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Location = new Point(234, 266);
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
            updateBtn.Click += updateBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 14);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 15;
            label10.Text = "ISBN :";
            // 
            // Price
            // 
            Price.Location = new Point(415, 101);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 103);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 12;
            label8.Text = "price :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 155);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 11;
            label7.Text = "Author :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 209);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 10;
            label6.Text = "Publisher :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 156);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Quantity : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 104);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Name :";
            // 
            // ISBN
            // 
            ISBN.Location = new Point(149, 19);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(125, 27);
            ISBN.TabIndex = 7;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(415, 152);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(125, 27);
            Quantity.TabIndex = 6;
            // 
            // AName
            // 
            AName.Location = new Point(149, 148);
            AName.Name = "AName";
            AName.Size = new Size(125, 27);
            AName.TabIndex = 5;
            // 
            // PName
            // 
            PName.Location = new Point(149, 202);
            PName.Name = "PName";
            PName.Size = new Size(125, 27);
            PName.TabIndex = 4;
            // 
            // updateBooks
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
            Name = "updateBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateBooks Page";
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
        private TextBox Bname;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox ISBN;
        private TextBox Quantity;
        private TextBox AName;
        private TextBox PName;
        private Button backBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Label label10;
        private TextBox Price;
        private Button issueBooksBtn;
        private Button addStudentsBtn;
        private Button searchBtn;
        private Button button5;
        private Button viewStudentInfoBtn;
        private Button addBooksBtn;
    }
}