﻿namespace FirstGUI
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
            this.runGuessBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is my first GUI.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // runGuessBtn
            // 
            this.runGuessBtn.AccessibleName = "";
            this.runGuessBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.runGuessBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runGuessBtn.BackColor = System.Drawing.Color.Plum;
            this.runGuessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runGuessBtn.ForeColor = System.Drawing.Color.Black;
            this.runGuessBtn.Location = new System.Drawing.Point(433, 219);
            this.runGuessBtn.Name = "runGuessBtn";
            this.runGuessBtn.Size = new System.Drawing.Size(149, 35);
            this.runGuessBtn.TabIndex = 1;
            this.runGuessBtn.Text = "Run Guesser";
            this.runGuessBtn.UseVisualStyleBackColor = false;
            this.runGuessBtn.Click += new System.EventHandler(this.runGuessBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(433, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(978, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.runGuessBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runGuessBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

