using System.Data.SqlClient;

namespace WindowsFormsApplication1.DataLayer
{
    class Connection
    {
	public SqlConnection connect = new SqlConnection("Data Source=DESKTOP-0G5OTMF\\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
