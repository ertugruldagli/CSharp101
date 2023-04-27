using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer; 

namespace BussinesLayer
{
    public class BLDers
    {

        public static int DersEkleBL(EntityDers p1)
        {
            if (p1.DersAd != null && p1.DersAd.Length >=3 && p1.DersAd.Length<=30 )
            {
                return DalDers.DersEkle(p1);
            }
            return -1;
        }
    }
}
