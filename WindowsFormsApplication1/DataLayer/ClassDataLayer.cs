using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DataLayer
{
    class ClassDataLayer
    {
	public bool AddItemsToTable(Image image, string title, string subtitle)
	{
	    Connection connection = new Connection();
	    if (ConnectionState.Closed == connection.connect.State)
	    {
		connection.connect.Open();
	    }
	    string query = "INSERT INTO table_test (Title, SubTitle, Image) values (@Title, @Subtitle, @Image)";
	    try
	    {
		using (SqlCommand sql = new SqlCommand(query, connection.connect))
		{
		    sql.Parameters.AddWithValue("@Title", title.Trim());
		    sql.Parameters.AddWithValue("@SubTitle", subtitle.Trim());

		    MemoryStream stream = new MemoryStream();
		    image.Save(stream, image.RawFormat);
		    sql.Parameters.AddWithValue("@Image", stream.ToArray());
		    sql.ExecuteNonQuery();
		}
		return true;
	    }
	    catch
	    {
		throw;
	    }
	}
	public DataTable ReadItemsTable()
	{
	    Connection connection = new Connection();
	    if (ConnectionState.Closed == connection.connect.State)
	    {
		connection.connect.Open();
	    }
	    string query = "SELECT * FROM table_test;";
	    SqlCommand sql = new SqlCommand(query, connection.connect);
	    try
	    {
		using (SqlDataAdapter adapter = new SqlDataAdapter(sql))
		{
		    DataTable table = new DataTable();
		    adapter.Fill(table);
		    return table;
		}
	    }
	    catch
	    {
		throw;
	    }
	}
    }
}
