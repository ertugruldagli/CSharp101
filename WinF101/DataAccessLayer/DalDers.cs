using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalDers
    {
        //Crud İşlemleri
        //Ekle Silme Güncelleme Listeleme

       public static int DersEkle(EntityDers p)
        {
            string query = "INSERT INTO TBLDERSLER (DersAd) VALUES (@DersAd)";

            SqlCommand command = new SqlCommand(query, Baglanti.connection);

            if (command.Connection.State!=ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@DersAd",p.DersAd);

            return command.ExecuteNonQuery();
        }
    }

   
}
