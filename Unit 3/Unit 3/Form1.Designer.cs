namespace Unit_3
{
    partial class Form1
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
            label1 = new Label();
            LoadBtn = new Button();
            DataNumber = new Label();
            DataView = new DataGridView();
            ExitBtn = new Button();
            label2 = new Label();
            Selection = new ComboBox();
            Greeting = new Label();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 82);
            label1.Name = "label1";
            label1.Size = new Size(660, 86);
            label1.TabIndex = 0;
            label1.Text = "Northwind Database";
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(546, 208);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(113, 48);
            LoadBtn.TabIndex = 0;
            LoadBtn.Text = "Load";
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DataNumber
            // 
            DataNumber.AutoSize = true;
            DataNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataNumber.Location = new Point(49, 314);
            DataNumber.Name = "DataNumber";
            DataNumber.Size = new Size(206, 32);
            DataNumber.TabIndex = 1;
            DataNumber.Text = "Number of Data:";
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(49, 372);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 82;
            DataView.Size = new Size(752, 499);
            DataView.TabIndex = 2;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(672, 904);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(129, 46);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Logout";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 216);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 4;
            label2.Text = "Record:";
            // 
            // Selection
            // 
            Selection.FormattingEnabled = true;
            Selection.Location = new Point(285, 213);
            Selection.Name = "Selection";
            Selection.Size = new Size(242, 40);
            Selection.TabIndex = 5;
            // 
            // Greeting
            // 
            Greeting.AutoSize = true;
            Greeting.Location = new Point(49, 37);
            Greeting.Name = "Greeting";
            Greeting.Size = new Size(82, 32);
            Greeting.TabIndex = 6;
            Greeting.Text = "Hello, ";
            Greeting.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 997);
            Controls.Add(Greeting);
            Controls.Add(Selection);
            Controls.Add(label2);
            Controls.Add(ExitBtn);
            Controls.Add(DataView);
            Controls.Add(DataNumber);
            Controls.Add(LoadBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Northwind Database";
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoadBtn;
        private Label DataNumber;
        private DataGridView DataView;
        private Button ExitBtn;
        private Label label2;
        private ComboBox Selection;
        private Label Greeting;
    }
}
