using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci prm)
        {
            string query = "INSERT INTO TBLOGRENCILER (Ad, Soyad, Numara, Bolum) VALUES (@Ad, @Soyad, @Numara, @Bolum)";
            SqlCommand cmd = new SqlCommand(query, DalBaglanti.connection);

            if (cmd.Connection.State !=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@Ad",prm.Ad);
            cmd.Parameters.AddWithValue("@Soyad", prm.Soyad);
            cmd.Parameters.AddWithValue("@Numara", prm.Numara);
            cmd.Parameters.AddWithValue("@Bolum", prm.Bolum);

            return cmd.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> Ogrenciler = new List<EntityOgrenci>();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBLOGRENCILER",DalBaglanti.connection);

            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open(); 

            }

            SqlDataReader sdr = cmd2.ExecuteReader();
            while (sdr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrID = int.Parse(sdr[0].ToString());
                ent.Ad = sdr[1].ToString();
                ent.Soyad = sdr[2].ToString();
                ent.Numara = sdr[3].ToString();
                ent.Bolum = sdr[4].ToString();

                Ogrenciler.Add(ent);
            }
            sdr.Close();
            return Ogrenciler;
            
        }
        public static int OgrenciSil(int prm)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBLOGRENCILER WHERE OgrID=@OgrID", DalBaglanti.connection);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@OgrID",prm);

            return cmd.ExecuteNonQuery();
        }
    }
}
