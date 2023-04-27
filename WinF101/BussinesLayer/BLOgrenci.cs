using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BussinesLayer
{
    public class BLOgrenci
    {
        public static int OgrenciEkleBL(EntityOgrenci prm)
        {
            if (prm.Ad!="")
            {
                return DalOgrenci.OgrenciEkle(prm);
            }

            return -1;
        }

        public static List<EntityOgrenci> OgrenciListesiBL()
        {
            return DalOgrenci.OgrenciListesi();
        }
    }
}
