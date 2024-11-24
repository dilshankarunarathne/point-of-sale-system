namespace POS_system
{
    partial class billing
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
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            search_btn = new Button();
            total_box = new TextBox();
            label7 = new Label();
            discount_box = new TextBox();
            label5 = new Label();
            deleteBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            quentity_box = new TextBox();
            label4 = new Label();
            price_box = new TextBox();
            label3 = new Label();
            item_box = new TextBox();
            label2 = new Label();
            search_box = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 46);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Teko SemiBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(99, 29);
            label6.TabIndex = 3;
            label6.Text = "POS-System";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 258);
            panel2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Right;
            dataGridView2.Location = new Point(617, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(595, 223);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(595, 223);
            dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1212, 35);
            panel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(635, 6);
            label9.Name = "label9";
            label9.Size = new Size(36, 23);
            label9.TabIndex = 2;
            label9.Text = "Bill";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 6);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 1;
            label8.Text = "Item List";
            // 
            // panel3
            // 
            panel3.Controls.Add(search_btn);
            panel3.Controls.Add(total_box);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(discount_box);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(deleteBtn);
            panel3.Controls.Add(addBtn);
            panel3.Controls.Add(editBtn);
            panel3.Controls.Add(quentity_box);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(price_box);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(item_box);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(search_box);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1212, 231);
            panel3.TabIndex = 4;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Silver;
            search_btn.Location = new Point(26, 87);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 29);
            search_btn.TabIndex = 15;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += button1_Click;
            // 
            // total_box
            // 
            total_box.Location = new Point(662, 127);
            total_box.Name = "total_box";
            total_box.Size = new Size(239, 27);
            total_box.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(662, 93);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 13;
            label7.Text = "Total Price";
            // 
            // discount_box
            // 
            discount_box.Location = new Point(344, 127);
            discount_box.Name = "discount_box";
            discount_box.Size = new Size(239, 27);
            discount_box.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(344, 93);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 11;
            label5.Text = "Discount";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Tomato;
            deleteBtn.Location = new Point(720, 196);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(568, 196);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Silver;
            editBtn.Location = new Point(417, 196);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 8;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // quentity_box
            // 
            quentity_box.Location = new Point(937, 51);
            quentity_box.Name = "quentity_box";
            quentity_box.Size = new Size(239, 27);
            quentity_box.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(954, 15);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 6;
            label4.Text = "Quentity";
            // 
            // price_box
            // 
            price_box.Location = new Point(662, 51);
            price_box.Name = "price_box";
            price_box.Size = new Size(239, 27);
            price_box.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(662, 15);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // item_box
            // 
            item_box.Location = new Point(344, 51);
            item_box.Name = "item_box";
            item_box.Size = new Size(239, 27);
            item_box.TabIndex = 3;
            item_box.TextChanged += item_box_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 2;
            label2.Text = "Item";
            // 
            // search_box
            // 
            search_box.Location = new Point(26, 51);
            search_box.Name = "search_box";
            search_box.Size = new Size(239, 27);
            search_box.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 535);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "billing";
            Text = "billing";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private TextBox total_box;
        private Label label7;
        private TextBox discount_box;
        private Label label5;
        private Button deleteBtn;
        private Button addBtn;
        private Button editBtn;
        private TextBox quentity_box;
        private Label label4;
        private TextBox price_box;
        private Label label3;
        private TextBox item_box;
        private Label label2;
        private TextBox search_box;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label9;
        private Label label8;
        private Button search_btn;
    }
}