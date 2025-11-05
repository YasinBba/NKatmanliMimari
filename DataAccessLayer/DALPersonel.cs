using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("Select * from Tbl_PersonelBilgi", Baglanti.baglanti);
            
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.PersonelId1 = Convert.ToInt32(dr["PersonelId"]);
                ent.PersonelAd1 = dr["PersonelAd"].ToString();
                ent.PersonelSoyad1 = dr["PersonelSoyad"].ToString();
                ent.PersonelSehir1 = dr["PersonelSehir"].ToString();
                ent.PersonelGorev1 = dr["PersonelGorev"].ToString();
                ent.PersonelMaas1 = Convert.ToInt16(dr["PersonelMaas"]);
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }
    }
}
