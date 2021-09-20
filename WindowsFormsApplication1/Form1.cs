using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ActionLayer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
	public Form1()
	{
	    InitializeComponent();
	}
	private void GenerateDynamcUserControl()
	{
	    flowLayoutPanel1.Controls.Clear();
	    ClassActionLayer obj = new ClassActionLayer();
	    DataTable table = obj.GetItems();
	    if (table != null)
	    {
		if (table.Rows.Count > 0)
		{
		    MyUserControl[] listItems = new MyUserControl[table.Rows.Count];
		    for (int i = 0; i < 1; i++)
		    {
			foreach (DataRow row in table.Rows)
			{
			    listItems[i] = new MyUserControl();
			    MemoryStream stream = new MemoryStream((byte[]) row["Image"]);
			    listItems[i].Icon = new Bitmap(stream);
			    listItems[i].Title = row["Title"].ToString();
			    listItems[i].SubTitle = row["SubTitle"].ToString();
			    flowLayoutPanel1.Controls.Add(listItems[i]);
			    listItems[i].Click += new EventHandler(this.UserControl_Click);
			}
		    }
		}
	    }
	}
	void UserControl_Click(object sender, EventArgs e)
	{
	    MyUserControl obj = (MyUserControl) sender;
	    pictureBox1.Image = obj.Icon;
	    label1.Text = obj.Title;
	    label2.Text = obj.SubTitle;
	    if (panel1.Visible == false) panel1.Visible = true;
	}
	public void refresh_Click(object sender, EventArgs e)
	{
	    GenerateDynamcUserControl();
	}
	public void add_Click(object sender, EventArgs e)
	{
	    new Form2().Show();
	}
	private void Form1_Load(object sender, EventArgs e)
	{
	    GenerateDynamcUserControl();
	}
	private void panel1_Paint(object sender, PaintEventArgs e)
	{

	}
    }
}
