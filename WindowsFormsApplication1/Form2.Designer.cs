﻿namespace WindowsFormsApplication1
{
    partial class Form2
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
	    this.pictureBox1 = new System.Windows.Forms.PictureBox();
	    this.button1 = new System.Windows.Forms.Button();
	    this.textBox1 = new System.Windows.Forms.TextBox();
	    this.textBox2 = new System.Windows.Forms.TextBox();
	    this.button2 = new System.Windows.Forms.Button();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // pictureBox1
	    // 
	    this.pictureBox1.Location = new System.Drawing.Point(70, 25);
	    this.pictureBox1.Name = "pictureBox1";
	    this.pictureBox1.Size = new System.Drawing.Size(142, 115);
	    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
	    this.pictureBox1.TabIndex = 0;
	    this.pictureBox1.TabStop = false;
	    // 
	    // button1
	    // 
	    this.button1.Location = new System.Drawing.Point(83, 146);
	    this.button1.Name = "button1";
	    this.button1.Size = new System.Drawing.Size(117, 23);
	    this.button1.TabIndex = 1;
	    this.button1.Text = "Upload Image";
	    this.button1.UseVisualStyleBackColor = true;
	    this.button1.Click += new System.EventHandler(this.upload_Click);
	    // 
	    // textBox1
	    // 
	    this.textBox1.Location = new System.Drawing.Point(83, 175);
	    this.textBox1.Name = "textBox1";
	    this.textBox1.Size = new System.Drawing.Size(117, 20);
	    this.textBox1.TabIndex = 2;
	    // 
	    // textBox2
	    // 
	    this.textBox2.Location = new System.Drawing.Point(83, 201);
	    this.textBox2.Name = "textBox2";
	    this.textBox2.Size = new System.Drawing.Size(117, 20);
	    this.textBox2.TabIndex = 3;
	    // 
	    // button2
	    // 
	    this.button2.Location = new System.Drawing.Point(105, 227);
	    this.button2.Name = "button2";
	    this.button2.Size = new System.Drawing.Size(75, 23);
	    this.button2.TabIndex = 4;
	    this.button2.Text = "Save";
	    this.button2.UseVisualStyleBackColor = true;
	    this.button2.Click += new System.EventHandler(this.save_Click);
	    // 
	    // Form2
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(284, 261);
	    this.Controls.Add(this.button2);
	    this.Controls.Add(this.textBox2);
	    this.Controls.Add(this.textBox1);
	    this.Controls.Add(this.button1);
	    this.Controls.Add(this.pictureBox1);
	    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
	    this.Name = "Form2";
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Form2";
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.PictureBox pictureBox1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.Button button2;
    }
}