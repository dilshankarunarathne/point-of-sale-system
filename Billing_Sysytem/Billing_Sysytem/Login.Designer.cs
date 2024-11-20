namespace Billing_Sysytem
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxusername = new TextBox();
            textBoxpassword = new TextBox();
            button_login = new Button();
            button_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 514);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(440, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(384, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Billing System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 198);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 289);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new Point(490, 204);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(355, 27);
            textBoxusername.TabIndex = 4;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Location = new Point(490, 289);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(355, 27);
            textBoxpassword.TabIndex = 5;
            // 
            // button_login
            // 
            button_login.Font = new Font("Teko SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.Location = new Point(585, 360);
            button_login.Name = "button_login";
            button_login.Size = new Size(160, 38);
            button_login.TabIndex = 6;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            button_reset.Font = new Font("Teko SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_reset.Location = new Point(585, 421);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(160, 38);
            button_reset.TabIndex = 7;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 514);
            Controls.Add(button_reset);
            Controls.Add(button_login);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Login";
            Text = "Billing System";
            Load += this.Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBoxusername;
        private TextBox textBoxpassword;
        private Button button_login;
        private Button button_reset;
    }
}
