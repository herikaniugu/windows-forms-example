namespace WindowsFormsApplication1
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
	    this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
	    this.pictureBox1 = new System.Windows.Forms.PictureBox();
	    this.label1 = new System.Windows.Forms.Label();
	    this.label2 = new System.Windows.Forms.Label();
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.button1 = new System.Windows.Forms.Button();
	    this.button2 = new System.Windows.Forms.Button();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
	    this.panel1.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // flowLayoutPanel1
	    // 
	    this.flowLayoutPanel1.AutoScroll = true;
	    this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
	    this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
	    this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
	    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
	    this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 320);
	    this.flowLayoutPanel1.TabIndex = 0;
	    this.flowLayoutPanel1.WrapContents = false;
	    // 
	    // pictureBox1
	    // 
	    this.pictureBox1.Location = new System.Drawing.Point(20, 20);
	    this.pictureBox1.Name = "pictureBox1";
	    this.pictureBox1.Size = new System.Drawing.Size(80, 80);
	    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
	    this.pictureBox1.TabIndex = 1;
	    this.pictureBox1.TabStop = false;
	    // 
	    // label1
	    // 
	    this.label1.AutoSize = true;
	    this.label1.Location = new System.Drawing.Point(42, 118);
	    this.label1.Name = "label1";
	    this.label1.Size = new System.Drawing.Size(35, 13);
	    this.label1.TabIndex = 2;
	    this.label1.Text = "label1";
	    // 
	    // label2
	    // 
	    this.label2.AutoSize = true;
	    this.label2.Location = new System.Drawing.Point(42, 153);
	    this.label2.Name = "label2";
	    this.label2.Size = new System.Drawing.Size(35, 13);
	    this.label2.TabIndex = 3;
	    this.label2.Text = "label2";
	    // 
	    // panel1
	    // 
	    this.panel1.Controls.Add(this.label2);
	    this.panel1.Controls.Add(this.pictureBox1);
	    this.panel1.Controls.Add(this.label1);
	    this.panel1.Location = new System.Drawing.Point(236, 90);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(120, 211);
	    this.panel1.TabIndex = 4;
	    this.panel1.Visible = false;
	    this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
	    // 
	    // button1
	    // 
	    this.button1.Location = new System.Drawing.Point(236, 20);
	    this.button1.Name = "button1";
	    this.button1.Size = new System.Drawing.Size(120, 23);
	    this.button1.TabIndex = 5;
	    this.button1.Text = "Refresh";
	    this.button1.UseVisualStyleBackColor = true;
	    this.button1.Click += new System.EventHandler(this.refresh_Click);
	    // 
	    // button2
	    // 
	    this.button2.Location = new System.Drawing.Point(236, 50);
	    this.button2.Name = "button2";
	    this.button2.Size = new System.Drawing.Size(120, 23);
	    this.button2.TabIndex = 6;
	    this.button2.Text = "Add";
	    this.button2.UseVisualStyleBackColor = true;
	    this.button2.Click += new System.EventHandler(this.add_Click);
	    // 
	    // Form1
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(384, 321);
	    this.Controls.Add(this.button2);
	    this.Controls.Add(this.button1);
	    this.Controls.Add(this.panel1);
	    this.Controls.Add(this.flowLayoutPanel1);
	    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
	    this.Name = "Form1";
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Form1";
	    this.Load += new System.EventHandler(this.Form1_Load);
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
	    this.panel1.ResumeLayout(false);
	    this.panel1.PerformLayout();
	    this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	private System.Windows.Forms.PictureBox pictureBox1;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Panel panel1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
    }
}

