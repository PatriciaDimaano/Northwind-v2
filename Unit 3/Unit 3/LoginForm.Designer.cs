namespace Unit_3
{
    partial class LoginForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            OkBtn = new Button();
            CancelBtn = new Button();
            ServerName = new TextBox();
            DatabaseName = new TextBox();
            UserName = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 51);
            label1.Name = "label1";
            label1.Size = new Size(500, 86);
            label1.TabIndex = 1;
            label1.Text = "Database Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 209);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 3;
            label3.Text = "Server:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 263);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 4;
            label4.Text = "Database:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 313);
            label5.Name = "label5";
            label5.Size = new Size(66, 32);
            label5.TabIndex = 5;
            label5.Text = "User:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 368);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 6;
            label6.Text = "Password:";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(237, 468);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(144, 46);
            OkBtn.TabIndex = 7;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(409, 468);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 46);
            CancelBtn.TabIndex = 8;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ServerName
            // 
            ServerName.Location = new Point(237, 206);
            ServerName.Name = "ServerName";
            ServerName.Size = new Size(322, 39);
            ServerName.TabIndex = 9;
            // 
            // DatabaseName
            // 
            DatabaseName.Location = new Point(237, 260);
            DatabaseName.Name = "DatabaseName";
            DatabaseName.Size = new Size(322, 39);
            DatabaseName.TabIndex = 10;
            // 
            // UserName
            // 
            UserName.Location = new Point(237, 313);
            UserName.Name = "UserName";
            UserName.Size = new Size(322, 39);
            UserName.TabIndex = 11;
            // 
            // Password
            // 
            Password.Location = new Point(237, 368);
            Password.Name = "Password";
            Password.Size = new Size(322, 39);
            Password.TabIndex = 12;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 560);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(DatabaseName);
            Controls.Add(ServerName);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Database Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button OkBtn;
        private Button CancelBtn;
        private TextBox ServerName;
        private TextBox DatabaseName;
        private TextBox UserName;
        private TextBox Password;
    }
}