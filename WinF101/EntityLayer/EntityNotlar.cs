using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityNotlar
    {
        public int NotID { get; set; }
        public int Ogrenci { get; set; }
        public byte Ders { get; set; }//veritabanında tinyt int olarak tanımlandığı içinn burada byte olarak tanımlanmalırıdr.

        public byte DersNotu { get; set; }//veritabanında tinyt int olarak tanımlandığı içinn burada byte olarak tanımlanmalırıdr.
    }
}
