using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ActionLayer;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
	public Form2()
	{
	    InitializeComponent();
	}
	public void save_Click(object sender, EventArgs e)
	{
	    ClassActionLayer obj = new ClassActionLayer();
	    if (obj.SaveItems(pictureBox1.Image, textBox1.Text, textBox2.Text))
    	    {
		MessageBox.Show("Success");
	    }
	    else
	    {
		MessageBox.Show("Failed.");
	    }
	}
	private void upload_Click(object server, EventArgs e)
	{
	    OpenFileDialog dialog = new OpenFileDialog();
	    if (dialog.ShowDialog() == DialogResult.OK)
	    {
		Image image = Image.FromFile(dialog.FileName);
		pictureBox1.Image = image;
	    }
	}
    }
}
