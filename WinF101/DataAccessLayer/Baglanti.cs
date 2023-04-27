using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection connection =new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=DBKatmanliMimari;Integrated Security=True");
    }
}
