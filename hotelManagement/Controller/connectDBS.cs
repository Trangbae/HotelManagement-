using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Controller
{
    public class connectDBS
    {
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection("Server=103.42.56.28;Initial Catalog=HotelSystem;User ID=quantrivien;Password=admin@123;Pooling=False;");
            return con;
        }

    }
}
