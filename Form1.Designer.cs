namespace Student_Grade
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstGrades = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Midterm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Final";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(647, 26);
            this.txtName.TabIndex = 7;
            // 
            // lstGrades
            // 
            this.lstGrades.FormattingEnabled = true;
            this.lstGrades.ItemHeight = 20;
            this.lstGrades.Location = new System.Drawing.Point(-3, 226);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.Size = new System.Drawing.Size(801, 204);
            this.lstGrades.TabIndex = 8;
            this.lstGrades.SelectedIndexChanged += new System.EventHandler(this.lstGrades_SelectedIndexChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(304, 153);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(194, 51);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display Grade";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(565, 153);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(194, 51);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Ouit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(112, 85);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(161, 26);
            this.txtSSN.TabIndex = 11;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(391, 85);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(136, 26);
            this.txtMidterm.TabIndex = 12;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(621, 85);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(138, 26);
            this.txtFinal.TabIndex = 13;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(40, 153);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(194, 51);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter Information";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Semester Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstGrades;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnEnter;
    }
}

