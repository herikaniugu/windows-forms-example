using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.DataLayer;

namespace WindowsFormsApplication1.ActionLayer
{
    class ClassActionLayer
    {
	public bool SaveItems(Image image, string title, string subtitle)
	{
	    try
	    {
		ClassDataLayer obj = new ClassDataLayer();
		return obj.AddItemsToTable(image, title, subtitle);
	    }
	    catch (Exception e)
	    {
		DialogResult result = MessageBox.Show(e.Message.ToString());
		return false;
	    }
	}
	public DataTable GetItems()
	{
	    try
	    {
		ClassDataLayer obj = new ClassDataLayer();
		return obj.ReadItemsTable();
	    }
	    catch (Exception e)
	    {
		DialogResult result = MessageBox.Show(e.Message.ToString());
		return null;
	    }
	}
    }
}