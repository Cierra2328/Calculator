namespace Calculator
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
            this.TopLbl = new System.Windows.Forms.Label();
            this.InputLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLbl
            // 
            this.TopLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopLbl.Location = new System.Drawing.Point(136, 45);
            this.TopLbl.Name = "TopLbl";
            this.TopLbl.Size = new System.Drawing.Size(148, 37);
            this.TopLbl.TabIndex = 0;
            this.TopLbl.Text = "Calculator";
            // 
            // InputLbl
            // 
            this.InputLbl.BackColor = System.Drawing.SystemColors.Info;
            this.InputLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputLbl.Location = new System.Drawing.Point(53, 104);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(307, 110);
            this.InputLbl.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(283, 617);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.Location = new System.Drawing.Point(161, 617);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(94, 29);
            this.EnterBtn.TabIndex = 13;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(38, 617);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 29);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivideBtn.Location = new System.Drawing.Point(226, 547);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(94, 29);
            this.DivideBtn.TabIndex = 15;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplyBtn.Location = new System.Drawing.Point(92, 547);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(94, 29);
            this.MultiplyBtn.TabIndex = 16;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubtractBtn.Location = new System.Drawing.Point(226, 485);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(94, 29);
            this.SubtractBtn.TabIndex = 17;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(92, 485);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZeroBtn.Location = new System.Drawing.Point(161, 416);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(94, 29);
            this.ZeroBtn.TabIndex = 51;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click_1);
            // 
            // NineBtn
            // 
            this.NineBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NineBtn.Location = new System.Drawing.Point(283, 360);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(94, 29);
            this.NineBtn.TabIndex = 50;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click_1);
            // 
            // EightBtn
            // 
            this.EightBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EightBtn.Location = new System.Drawing.Point(161, 360);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(94, 29);
            this.EightBtn.TabIndex = 49;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click_1);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SevenBtn.Location = new System.Drawing.Point(38, 360);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(94, 29);
            this.SevenBtn.TabIndex = 48;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click_1);
            // 
            // SixBtn
            // 
            this.SixBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SixBtn.Location = new System.Drawing.Point(283, 303);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(94, 29);
            this.SixBtn.TabIndex = 47;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click_1);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FiveBtn.Location = new System.Drawing.Point(161, 303);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(94, 29);
            this.FiveBtn.TabIndex = 46;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click_1);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FourBtn.Location = new System.Drawing.Point(38, 303);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(94, 29);
            this.FourBtn.TabIndex = 45;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click_1);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThreeBtn.Location = new System.Drawing.Point(283, 244);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(94, 29);
            this.ThreeBtn.TabIndex = 44;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click_1);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TwoBtn.Location = new System.Drawing.Point(161, 244);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(94, 29);
            this.TwoBtn.TabIndex = 43;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click_1);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OneBtn.Location = new System.Drawing.Point(38, 244);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(94, 29);
            this.OneBtn.TabIndex = 42;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(283, 416);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 52;
            this.DeleteBtn.Text = "<<< DEL";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(402, 672);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InputLbl);
            this.Controls.Add(this.TopLbl);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Label TopLbl;
        private Label InputLbl;
        private Button ExitBtn;
        private Button EnterBtn;
        private Button ClearBtn;
        private Button DivideBtn;
        private Button MultiplyBtn;
        private Button SubtractBtn;
        private Button AddBtn;
        private Button ZeroBtn;
        private Button NineBtn;
        private Button EightBtn;
        private Button SevenBtn;
        private Button SixBtn;
        private Button FiveBtn;
        private Button FourBtn;
        private Button ThreeBtn;
        private Button TwoBtn;
        private Button OneBtn;
        private Button DeleteBtn;
    }
}