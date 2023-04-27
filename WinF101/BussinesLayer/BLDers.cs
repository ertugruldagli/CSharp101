﻿using DataAccessLayer;
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

        public static List<EntityDers> DersListesiBL()
        {
            return DalDers.DersListesi();
        }

        public static int DersSilBL(byte prm)
        {
            if (prm >=1)
            {
                return DalDers.DersSil(prm);
            }
            else
            {
                return -1;
            }
        }
    }
}
