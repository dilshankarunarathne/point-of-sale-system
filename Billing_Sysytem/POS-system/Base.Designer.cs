namespace POS_system
{
    partial class Base
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
            panel4 = new Panel();
            Logout_btn = new Button();
            Dashbord_btn = new Button();
            Billing_btn = new Button();
            Customer_btn = new Button();
            Categories_btn = new Button();
            Item_btn = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 531);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(Logout_btn);
            panel4.Controls.Add(Dashbord_btn);
            panel4.Controls.Add(Billing_btn);
            panel4.Controls.Add(Customer_btn);
            panel4.Controls.Add(Categories_btn);
            panel4.Controls.Add(Item_btn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 364);
            panel4.TabIndex = 1;
            // 
            // Logout_btn
            // 
            Logout_btn.Dock = DockStyle.Bottom;
            Logout_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Logout_btn.Location = new Point(0, 311);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(250, 53);
            Logout_btn.TabIndex = 5;
            Logout_btn.Text = "Log Out";
            Logout_btn.UseVisualStyleBackColor = true;
            // 
            // Dashbord_btn
            // 
            Dashbord_btn.Dock = DockStyle.Top;
            Dashbord_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Dashbord_btn.Location = new Point(0, 212);
            Dashbord_btn.Name = "Dashbord_btn";
            Dashbord_btn.Size = new Size(250, 53);
            Dashbord_btn.TabIndex = 4;
            Dashbord_btn.Text = "Dashbord";
            Dashbord_btn.UseVisualStyleBackColor = true;
            // 
            // Billing_btn
            // 
            Billing_btn.Dock = DockStyle.Top;
            Billing_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Billing_btn.Location = new Point(0, 159);
            Billing_btn.Name = "Billing_btn";
            Billing_btn.Size = new Size(250, 53);
            Billing_btn.TabIndex = 3;
            Billing_btn.Text = "Billing";
            Billing_btn.UseVisualStyleBackColor = true;
            Billing_btn.Click += Billing_btn_Click;
            // 
            // Customer_btn
            // 
            Customer_btn.Dock = DockStyle.Top;
            Customer_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Customer_btn.Location = new Point(0, 106);
            Customer_btn.Name = "Customer_btn";
            Customer_btn.Size = new Size(250, 53);
            Customer_btn.TabIndex = 2;
            Customer_btn.Text = "Customer";
            Customer_btn.UseVisualStyleBackColor = true;
            // 
            // Categories_btn
            // 
            Categories_btn.Dock = DockStyle.Top;
            Categories_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Categories_btn.Location = new Point(0, 53);
            Categories_btn.Name = "Categories_btn";
            Categories_btn.Size = new Size(250, 53);
            Categories_btn.TabIndex = 1;
            Categories_btn.Text = "Categories";
            Categories_btn.UseVisualStyleBackColor = true;
            Categories_btn.Click += Categories_btn_Click;
            // 
            // Item_btn
            // 
            Item_btn.Dock = DockStyle.Top;
            Item_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Item_btn.Location = new Point(0, 0);
            Item_btn.Name = "Item_btn";
            Item_btn.Size = new Size(250, 53);
            Item_btn.TabIndex = 0;
            Item_btn.Text = "Item";
            Item_btn.UseVisualStyleBackColor = true;
            Item_btn.Click += Item_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 167);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(39, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 531);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 531);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Base";
            Text = "Base";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button Logout_btn;
        private Button Dashbord_btn;
        private Button Billing_btn;
        private Button Customer_btn;
        private Button Categories_btn;
        private Button Item_btn;
        private PictureBox pictureBox1;
    }
}