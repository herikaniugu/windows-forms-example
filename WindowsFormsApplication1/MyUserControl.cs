using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyUserControl : UserControl
    {
	public MyUserControl()
	{
	    InitializeComponent();
	}
	private Image _icon;
	private string _title;
	private string _subtitle;
	[Category("Custom Props")]
	public Image Icon
	{
	    get { return _icon; }
	    set { _icon = value; pictureBox1.Image = value; }
	}
	[Category("Custom Props")]
	public string Title
	{
	    get { return _title; }
	    set { _title = value; label1.Text = value; }
	}
	[Category("Custom Props")]
	public string SubTitle
	{
	    get { return _subtitle; }
	    set { _subtitle = value; label2.Text = value; }
	}
	private void ucRequest_MouseEnter(object sender, EventArgs e)
	{
	    this.BackColor = Color.FromArgb(217, 229, 242);
	}
	private void ucRequest_MouseLeave(object sender, EventArgs e)
	{
	    this.BackColor = Color.FromArgb(255, 255, 255);
	}

	private void label1_Click(object sender, EventArgs e)
	{

	}
    }
}

