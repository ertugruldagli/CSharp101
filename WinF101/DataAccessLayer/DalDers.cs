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

            SqlCommand command = new SqlCommand(query, DalBaglanti.connection);

            if (command.Connection.State!=ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@DersAd",p.DersAd);

            return command.ExecuteNonQuery();
        }

       public static List<EntityDers> DersListesi()
      {
            List<EntityDers> Dersler =new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERSLER",DalBaglanti.connection);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                EntityDers ent = new EntityDers();  
                ent.DersID= byte.Parse( sdr["DersID"].ToString());
                ent.DersAd = sdr["DersAd"].ToString();
                Dersler.Add(ent);   
            }
            sdr.Close();
            return Dersler;
      }

       public static int DersSil(byte prm)
        {
            SqlCommand query = new SqlCommand("DELETE FROM TBLDERSLER WHERE DersID=@DersID ",DalBaglanti.connection);

            if (query.Connection.State != ConnectionState.Open)
            {
                query.Connection.Open();    
            }
            query.Parameters.AddWithValue("@DersID", prm);

            return query.ExecuteNonQuery();

        }
    }

   
}
