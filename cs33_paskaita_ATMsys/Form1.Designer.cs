namespace cs33_paskaita_ATMsys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AtmMonitor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.LastOperations = new System.Windows.Forms.Button();
            this.CashOut = new System.Windows.Forms.Button();
            this.InputNum1 = new System.Windows.Forms.Button();
            this.InputNum2 = new System.Windows.Forms.Button();
            this.InputNum3 = new System.Windows.Forms.Button();
            this.InputNum4 = new System.Windows.Forms.Button();
            this.InputNum5 = new System.Windows.Forms.Button();
            this.InputNum6 = new System.Windows.Forms.Button();
            this.InputNum7 = new System.Windows.Forms.Button();
            this.InputNum8 = new System.Windows.Forms.Button();
            this.InputNum9 = new System.Windows.Forms.Button();
            this.InputNum0 = new System.Windows.Forms.Button();
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.TurnOn = new System.Windows.Forms.Button();
            this.TurnOff = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AtmMonitor
            // 
            this.AtmMonitor.Cursor = System.Windows.Forms.Cursors.No;
            this.AtmMonitor.Location = new System.Drawing.Point(92, 28);
            this.AtmMonitor.Name = "AtmMonitor";
            this.AtmMonitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AtmMonitor.Size = new System.Drawing.Size(168, 225);
            this.AtmMonitor.TabIndex = 0;
            this.AtmMonitor.Text = "";
            this.AtmMonitor.TextChanged += new System.EventHandler(this.AtmMonitor_TextChanged);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.ForeColor = System.Drawing.Color.Green;
            this.EnterButton.Location = new System.Drawing.Point(266, 202);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(23, 23);
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "🔑";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CheckBalance
            // 
            this.CheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBalance.Location = new System.Drawing.Point(266, 28);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(81, 23);
            this.CheckBalance.TabIndex = 7;
            this.CheckBalance.Text = "Likutis";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // LastOperations
            // 
            this.LastOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastOperations.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastOperations.Location = new System.Drawing.Point(266, 57);
            this.LastOperations.Name = "LastOperations";
            this.LastOperations.Size = new System.Drawing.Size(81, 23);
            this.LastOperations.TabIndex = 8;
            this.LastOperations.Text = "Operacijos";
            this.LastOperations.UseVisualStyleBackColor = true;
            this.LastOperations.Click += new System.EventHandler(this.LastOperations_Click);
            // 
            // CashOut
            // 
            this.CashOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CashOut.Location = new System.Drawing.Point(266, 86);
            this.CashOut.Name = "CashOut";
            this.CashOut.Size = new System.Drawing.Size(81, 23);
            this.CashOut.TabIndex = 9;
            this.CashOut.Text = "Gryninimas";
            this.CashOut.UseVisualStyleBackColor = true;
            this.CashOut.Click += new System.EventHandler(this.CashOut_Click);
            // 
            // InputNum1
            // 
            this.InputNum1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum1.Location = new System.Drawing.Point(266, 115);
            this.InputNum1.Name = "InputNum1";
            this.InputNum1.Size = new System.Drawing.Size(23, 23);
            this.InputNum1.TabIndex = 10;
            this.InputNum1.Text = "1";
            this.InputNum1.UseVisualStyleBackColor = true;
            this.InputNum1.Click += new System.EventHandler(this.InputNum1_Click);
            // 
            // InputNum2
            // 
            this.InputNum2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum2.Location = new System.Drawing.Point(295, 115);
            this.InputNum2.Name = "InputNum2";
            this.InputNum2.Size = new System.Drawing.Size(23, 23);
            this.InputNum2.TabIndex = 11;
            this.InputNum2.Text = "2";
            this.InputNum2.UseVisualStyleBackColor = true;
            this.InputNum2.Click += new System.EventHandler(this.InputNum2_Click);
            // 
            // InputNum3
            // 
            this.InputNum3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum3.Location = new System.Drawing.Point(324, 115);
            this.InputNum3.Name = "InputNum3";
            this.InputNum3.Size = new System.Drawing.Size(23, 23);
            this.InputNum3.TabIndex = 12;
            this.InputNum3.Text = "3";
            this.InputNum3.UseVisualStyleBackColor = true;
            this.InputNum3.Click += new System.EventHandler(this.InputNum3_Click);
            // 
            // InputNum4
            // 
            this.InputNum4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum4.Location = new System.Drawing.Point(266, 144);
            this.InputNum4.Name = "InputNum4";
            this.InputNum4.Size = new System.Drawing.Size(23, 23);
            this.InputNum4.TabIndex = 13;
            this.InputNum4.Text = "4";
            this.InputNum4.UseVisualStyleBackColor = true;
            this.InputNum4.Click += new System.EventHandler(this.InputNum4_Click);
            // 
            // InputNum5
            // 
            this.InputNum5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum5.Location = new System.Drawing.Point(295, 144);
            this.InputNum5.Name = "InputNum5";
            this.InputNum5.Size = new System.Drawing.Size(23, 23);
            this.InputNum5.TabIndex = 14;
            this.InputNum5.Text = "5";
            this.InputNum5.UseVisualStyleBackColor = true;
            this.InputNum5.Click += new System.EventHandler(this.InputNum5_Click);
            // 
            // InputNum6
            // 
            this.InputNum6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum6.Location = new System.Drawing.Point(324, 144);
            this.InputNum6.Name = "InputNum6";
            this.InputNum6.Size = new System.Drawing.Size(23, 23);
            this.InputNum6.TabIndex = 15;
            this.InputNum6.Text = "6";
            this.InputNum6.UseVisualStyleBackColor = true;
            this.InputNum6.Click += new System.EventHandler(this.InputNum6_Click);
            // 
            // InputNum7
            // 
            this.InputNum7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum7.Location = new System.Drawing.Point(266, 172);
            this.InputNum7.Name = "InputNum7";
            this.InputNum7.Size = new System.Drawing.Size(23, 23);
            this.InputNum7.TabIndex = 16;
            this.InputNum7.Text = "7";
            this.InputNum7.UseVisualStyleBackColor = true;
            this.InputNum7.Click += new System.EventHandler(this.InputNum7_Click);
            // 
            // InputNum8
            // 
            this.InputNum8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum8.Location = new System.Drawing.Point(295, 172);
            this.InputNum8.Name = "InputNum8";
            this.InputNum8.Size = new System.Drawing.Size(23, 23);
            this.InputNum8.TabIndex = 17;
            this.InputNum8.Text = "8";
            this.InputNum8.UseVisualStyleBackColor = true;
            this.InputNum8.Click += new System.EventHandler(this.InputNum8_Click);
            // 
            // InputNum9
            // 
            this.InputNum9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum9.Location = new System.Drawing.Point(324, 173);
            this.InputNum9.Name = "InputNum9";
            this.InputNum9.Size = new System.Drawing.Size(23, 23);
            this.InputNum9.TabIndex = 18;
            this.InputNum9.Text = "9";
            this.InputNum9.UseVisualStyleBackColor = true;
            this.InputNum9.Click += new System.EventHandler(this.InputNum9_Click);
            // 
            // InputNum0
            // 
            this.InputNum0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputNum0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputNum0.Location = new System.Drawing.Point(295, 201);
            this.InputNum0.Name = "InputNum0";
            this.InputNum0.Size = new System.Drawing.Size(23, 23);
            this.InputNum0.TabIndex = 19;
            this.InputNum0.Text = "0";
            this.InputNum0.UseVisualStyleBackColor = true;
            this.InputNum0.Click += new System.EventHandler(this.InputNum0_Click);
            // 
            // Card1
            // 
            this.Card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card1.BackgroundImage")));
            this.Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Card1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Card1.Location = new System.Drawing.Point(18, 28);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(68, 52);
            this.Card1.TabIndex = 20;
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // Card2
            // 
            this.Card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card2.BackgroundImage")));
            this.Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Card2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Card2.Location = new System.Drawing.Point(18, 86);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(68, 52);
            this.Card2.TabIndex = 21;
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Card3
            // 
            this.Card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card3.BackgroundImage")));
            this.Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Card3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Card3.Location = new System.Drawing.Point(18, 144);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(68, 52);
            this.Card3.TabIndex = 22;
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // Card4
            // 
            this.Card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card4.BackgroundImage")));
            this.Card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Card4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Card4.Location = new System.Drawing.Point(18, 202);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(68, 51);
            this.Card4.TabIndex = 23;
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // TurnOn
            // 
            this.TurnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TurnOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TurnOn.Location = new System.Drawing.Point(92, 259);
            this.TurnOn.Name = "TurnOn";
            this.TurnOn.Size = new System.Drawing.Size(81, 52);
            this.TurnOn.TabIndex = 24;
            this.TurnOn.Text = "Įjungti";
            this.TurnOn.UseVisualStyleBackColor = false;
            this.TurnOn.Click += new System.EventHandler(this.TurnOn_Click);
            // 
            // TurnOff
            // 
            this.TurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TurnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TurnOff.Location = new System.Drawing.Point(179, 259);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(81, 52);
            this.TurnOff.TabIndex = 25;
            this.TurnOff.Text = "Išjungti";
            this.TurnOff.UseVisualStyleBackColor = false;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw.Location = new System.Drawing.Point(266, 230);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(81, 23);
            this.Withdraw.TabIndex = 26;
            this.Withdraw.Text = "Grįninti";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backspace.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Backspace.Location = new System.Drawing.Point(324, 202);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(23, 24);
            this.Backspace.TabIndex = 27;
            this.Backspace.Text = "<";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 330);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.TurnOff);
            this.Controls.Add(this.TurnOn);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.InputNum0);
            this.Controls.Add(this.InputNum9);
            this.Controls.Add(this.InputNum8);
            this.Controls.Add(this.InputNum7);
            this.Controls.Add(this.InputNum6);
            this.Controls.Add(this.InputNum5);
            this.Controls.Add(this.InputNum4);
            this.Controls.Add(this.InputNum3);
            this.Controls.Add(this.InputNum2);
            this.Controls.Add(this.InputNum1);
            this.Controls.Add(this.CashOut);
            this.Controls.Add(this.LastOperations);
            this.Controls.Add(this.CheckBalance);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AtmMonitor);
            this.Name = "Form1";
            this.Text = "ATM aplinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AtmMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.Button LastOperations;
        private System.Windows.Forms.Button CashOut;
        private System.Windows.Forms.Button InputNum1;
        private System.Windows.Forms.Button InputNum2;
        private System.Windows.Forms.Button InputNum3;
        private System.Windows.Forms.Button InputNum4;
        private System.Windows.Forms.Button InputNum5;
        private System.Windows.Forms.Button InputNum6;
        private System.Windows.Forms.Button InputNum7;
        private System.Windows.Forms.Button InputNum8;
        private System.Windows.Forms.Button InputNum9;
        private System.Windows.Forms.Button InputNum0;
        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button TurnOn;
        private System.Windows.Forms.Button TurnOff;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Backspace;
    }
}
