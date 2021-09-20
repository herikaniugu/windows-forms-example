namespace WindowsFormsApplication1
{
    partial class MyUserControl
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

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.pictureBox1 = new System.Windows.Forms.PictureBox();
	    this.label1 = new System.Windows.Forms.Label();
	    this.label2 = new System.Windows.Forms.Label();
	    this.panel1.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // panel1
	    // 
	    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
	    this.panel1.Controls.Add(this.pictureBox1);
	    this.panel1.Location = new System.Drawing.Point(20, 20);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(80, 80);
	    this.panel1.TabIndex = 0;
	    // 
	    // pictureBox1
	    // 
	    this.pictureBox1.Location = new System.Drawing.Point(10, 10);
	    this.pictureBox1.Name = "pictureBox1";
	    this.pictureBox1.Size = new System.Drawing.Size(60, 60);
	    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
	    this.pictureBox1.TabIndex = 0;
	    this.pictureBox1.TabStop = false;
	    // 
	    // label1
	    // 
	    this.label1.AutoSize = true;
	    this.label1.Location = new System.Drawing.Point(110, 30);
	    this.label1.Name = "label1";
	    this.label1.Size = new System.Drawing.Size(27, 13);
	    this.label1.TabIndex = 1;
	    this.label1.Text = "Title";
	    this.label1.Click += new System.EventHandler(this.label1_Click);
	    // 
	    // label2
	    // 
	    this.label2.AutoSize = true;
	    this.label2.Location = new System.Drawing.Point(110, 60);
	    this.label2.Name = "label2";
	    this.label2.Size = new System.Drawing.Size(42, 13);
	    this.label2.TabIndex = 2;
	    this.label2.Text = "Subtitle";
	    // 
	    // MyUserControl
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.Controls.Add(this.label2);
	    this.Controls.Add(this.label1);
	    this.Controls.Add(this.panel1);
	    this.Margin = new System.Windows.Forms.Padding(0);
	    this.Name = "MyUserControl";
	    this.Size = new System.Drawing.Size(190, 120);
	    this.MouseEnter += new System.EventHandler(this.ucRequest_MouseEnter);
	    this.MouseLeave += new System.EventHandler(this.ucRequest_MouseLeave);
	    this.panel1.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Panel panel1;
	private System.Windows.Forms.PictureBox pictureBox1;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
    }
}
