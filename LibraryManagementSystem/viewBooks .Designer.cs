namespace LibraryManagementSystem
{
    partial class viewBooks

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            addBooksBtn = new Button();
            button5 = new Button();
            viewStudentInfoBtn = new Button();
            addStudentBtn = new Button();
            issueBooksBtn = new Button();
            exitBtn = new Button();
            panel3 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            updateBtn = new Button();
            dataGridView1 = new DataGridView();
            cancelBtn = new Button();
            clearBtn = new Button();
            searchBtn = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Controls.Add(addStudentBtn);
            panel2.Controls.Add(issueBooksBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // addBooksBtn
            // 
            addBooksBtn.BackColor = SystemColors.GradientInactiveCaption;
            addBooksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBooksBtn.Location = new Point(12, 32);
            addBooksBtn.Name = "addBooksBtn";
            addBooksBtn.Size = new Size(170, 43);
            addBooksBtn.TabIndex = 13;
            addBooksBtn.Text = "Add Books";
            addBooksBtn.UseVisualStyleBackColor = false;
            addBooksBtn.Click += addBooksBtn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 94);
            button5.Name = "button5";
            button5.Size = new Size(170, 43);
            button5.TabIndex = 12;
            button5.Text = "View Books";
            button5.UseVisualStyleBackColor = false;
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
            // addStudentBtn
            // 
            addStudentBtn.BackColor = SystemColors.GradientInactiveCaption;
            addStudentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentBtn.Location = new Point(12, 225);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(170, 43);
            addStudentBtn.TabIndex = 10;
            addStudentBtn.Text = "Add Students";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
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
            label3.Size = new Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = " View Book Details";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(updateBtn);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(cancelBtn);
            panel4.Controls.Add(clearBtn);
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 321);
            panel4.TabIndex = 4;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.ForestGreen;
            updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(399, 266);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(143, 36);
            updateBtn.TabIndex = 21;
            updateBtn.Text = "Update Book Info";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(527, 188);
            dataGridView1.TabIndex = 20;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Crimson;
            cancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(162, 266);
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
            clearBtn.Location = new Point(29, 266);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(114, 36);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.MidnightBlue;
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(360, 11);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 32);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 17);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Name / ISBN :";
            // 
            // viewBooks
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
            Name = "viewBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewBooks Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button exitBtn;
        private Button addStudentBtn;
        private Button issueBooksBtn;
        private Button viewStudentInfoBtn;
        private Panel panel3;
        private Label label3;
        private TextBox textBox1;
        private Panel panel4;
        private Label label4;
        private Button cancelBtn;
        private Button clearBtn;
        private Button searchBtn;
        private Button addBooksBtn;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button updateBtn;
    }
}