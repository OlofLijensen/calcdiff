﻿namespace calcdiff
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
            this.Outputfield = new System.Windows.Forms.TextBox();
            this.InputField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Outputfield
            // 
            this.Outputfield.Location = new System.Drawing.Point(136, 174);
            this.Outputfield.Name = "Outputfield";
            this.Outputfield.Size = new System.Drawing.Size(381, 20);
            this.Outputfield.TabIndex = 1;
            this.Outputfield.TextChanged += new System.EventHandler(this.Outputfield_TextChanged);
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(136, 62);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(381, 20);
            this.InputField.TabIndex = 0;
            this.InputField.TextChanged += new System.EventHandler(this.Inputfield_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Outputfield);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Outputfield;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button button1;
    }
}

