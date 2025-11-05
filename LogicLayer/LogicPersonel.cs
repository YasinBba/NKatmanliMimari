using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.PersonelAd1 != "" && p.PersonelSoyad1 != "" && p.PersonelSehir1 != "" && p.PersonelGorev1 != "" && p.PersonelMaas1 > 0)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int p)
        {
            if (p >= 1)
            {
                return DALPersonel.PersonelSil(p) > 0;
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel p)
        {
            if (p.PersonelAd1 != "" && p.PersonelSoyad1 != "" && p.PersonelSehir1 != "" && p.PersonelGorev1 != "" && p.PersonelMaas1 > 0)
            {
                return DALPersonel.PersonelGuncelle(p) > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
