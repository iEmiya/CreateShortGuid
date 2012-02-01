namespace CreateShortGuid
{
    partial class Main
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
            this.Copy = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.GroupBox();
            this.lResult = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.GroupBox();
            this.format3 = new System.Windows.Forms.RadioButton();
            this.format2 = new System.Windows.Forms.RadioButton();
            this.format1 = new System.Windows.Forms.RadioButton();
            this.Result.SuspendLayout();
            this.Format.SuspendLayout();
            this.SuspendLayout();
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(270, 12);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 0;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(270, 41);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 0;
            this.New.Text = "New GUID";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(270, 70);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Result
            // 
            this.Result.Controls.Add(this.lResult);
            this.Result.Location = new System.Drawing.Point(12, 200);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(333, 100);
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // lResult
            // 
            this.lResult.Location = new System.Drawing.Point(6, 16);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(321, 81);
            this.lResult.TabIndex = 0;
            this.lResult.Text = "lResult";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(12, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(252, 55);
            this.Help.TabIndex = 1;
            this.Help.Text = "Выберите форматирование и нажмите «Copy» для помещения результата в буфер обмена." +
                " Выберете «Exit» для завершения.";
            // 
            // Format
            // 
            this.Format.Controls.Add(this.format3);
            this.Format.Controls.Add(this.format1);
            this.Format.Controls.Add(this.format2);
            this.Format.Location = new System.Drawing.Point(12, 67);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(252, 127);
            this.Format.TabIndex = 2;
            this.Format.TabStop = false;
            this.Format.Text = "ShoertGuid Format";
            // 
            // format3
            // 
            this.format3.AutoSize = true;
            this.format3.Location = new System.Drawing.Point(9, 65);
            this.format3.Name = "format3";
            this.format3.Size = new System.Drawing.Size(205, 17);
            this.format3.TabIndex = 0;
            this.format3.TabStop = true;
            this.format3.Text = "3. static const struct ShortGuid = { ... }";
            this.format3.UseVisualStyleBackColor = true;
            this.format3.CheckedChanged += new System.EventHandler(this.format3_CheckedChanged);
            // 
            // format2
            // 
            this.format2.AutoSize = true;
            this.format2.Location = new System.Drawing.Point(9, 42);
            this.format2.Name = "format2";
            this.format2.Size = new System.Drawing.Size(237, 17);
            this.format2.TabIndex = 0;
            this.format2.TabStop = true;
            this.format2.Text = "2. Registry Format (ie. {xxxxxxx-xxxx ... xxxx })";
            this.format2.UseVisualStyleBackColor = true;
            this.format2.CheckedChanged += new System.EventHandler(this.format2_CheckedChanged);
            // 
            // format1
            // 
            this.format1.AutoSize = true;
            this.format1.Location = new System.Drawing.Point(9, 19);
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(176, 17);
            this.format1.TabIndex = 0;
            this.format1.TabStop = true;
            this.format1.Text = "1. Only Value (ie. \"xxxx ... xxxx\")";
            this.format1.UseVisualStyleBackColor = true;
            this.format1.CheckedChanged += new System.EventHandler(this.format1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 312);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Create ShortGuid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Result.ResumeLayout(false);
            this.Format.ResumeLayout(false);
            this.Format.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.GroupBox Format;
        private System.Windows.Forms.RadioButton format2;
        private System.Windows.Forms.RadioButton format3;
        private System.Windows.Forms.RadioButton format1;
    }
}

