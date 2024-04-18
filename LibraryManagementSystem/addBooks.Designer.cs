namespace LibraryManagementSystem
{
    partial class addBooks

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBooks));
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
            bookName = new TextBox();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            saveBtn = new Button();
            qty = new TextBox();
            label10 = new Label();
            category = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            price = new TextBox();
            publisher = new TextBox();
            author = new TextBox();
            isbn = new TextBox();
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
            button10.Click += button10_Click_1;
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
            button8.Location = new Point(12, 162);
            button8.Name = "button8";
            button8.Size = new Size(170, 43);
            button8.TabIndex = 9;
            button8.Text = "Issue Books";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
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
            button6.Click += button6_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 2;
            button1.Text = "Add Books";
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
            label3.Size = new Size(144, 20);
            label3.TabIndex = 0;
            label3.Text = "Submit Book Details";
            // 
            // bookName
            // 
            bookName.Location = new Point(149, 14);
            bookName.Name = "bookName";
            bookName.Size = new Size(125, 27);
            bookName.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(saveBtn);
            panel4.Controls.Add(qty);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(category);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(price);
            panel4.Controls.Add(publisher);
            panel4.Controls.Add(author);
            panel4.Controls.Add(isbn);
            panel4.Controls.Add(bookName);
            panel4.Location = new Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 321);
            panel4.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(394, 266);
            button4.Name = "button4";
            button4.Size = new Size(114, 36);
            button4.TabIndex = 19;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(219, 266);
            button3.Name = "button3";
            button3.Size = new Size(114, 36);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            // qty
            // 
            qty.Location = new Point(415, 58);
            qty.Name = "qty";
            qty.Size = new Size(125, 27);
            qty.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(326, 21);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 15;
            label10.Text = "Price :";
            // 
            // category
            // 
            category.Location = new Point(149, 195);
            category.Name = "category";
            category.Size = new Size(125, 27);
            category.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(326, 61);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 13;
            label9.Text = "Quantity :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 195);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 12;
            label8.Text = "Category : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 153);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 11;
            label7.Text = "Publisher :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 105);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 10;
            label6.Text = "Author :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 61);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 17);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Name :";
            // 
            // price
            // 
            price.Location = new Point(415, 14);
            price.Name = "price";
            price.Size = new Size(125, 27);
            price.TabIndex = 7;
            // 
            // publisher
            // 
            publisher.Location = new Point(149, 145);
            publisher.Name = "publisher";
            publisher.Size = new Size(125, 27);
            publisher.TabIndex = 6;
            // 
            // author
            // 
            author.Location = new Point(149, 98);
            author.Name = "author";
            author.Size = new Size(125, 27);
            author.TabIndex = 5;
            // 
            // isbn
            // 
            isbn.Location = new Point(149, 58);
            isbn.Name = "isbn";
            isbn.Size = new Size(125, 27);
            isbn.TabIndex = 4;
            // 
            // addBooks
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
            Name = "addBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBooks Page";
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
        private Button button7;
        private Button button6;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button10;
        private Panel panel3;
        private Label label3;
        private TextBox bookName;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox price;
        private TextBox publisher;
        private TextBox author;
        private TextBox isbn;
        private Button button4;
        private Button button3;
        private Button saveBtn;
        private TextBox qty;
        private Label label10;
        private TextBox category;
        private Label label9;
    }
}