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
    public class DALPersonel
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
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_PersonelBilgi (PersonelAd,PersonelSoyad,PersonelSehir,PersonelGorev,PersonelMaas) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.PersonelAd1);
            komut2.Parameters.AddWithValue("@p2", p.PersonelSoyad1);
            komut2.Parameters.AddWithValue("@p3", p.PersonelSehir1);
            komut2.Parameters.AddWithValue("@p4", p.PersonelGorev1);
            komut2.Parameters.AddWithValue("@p5", p.PersonelMaas1);
            return komut2.ExecuteNonQuery();
        }
        public static int PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_PersonelBilgi where PersonelId=@p1", Baglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery();
        } 
        public static int PersonelGuncelle(EntityPersonel p)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_PersonelBilgi set PersonelAd=@p1,PersonelSoyad=@p2,PersonelSehir=@p3,PersonelGorev=@p4,PersonelMaas=@p5 where PersonelId=@p6", Baglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", p.PersonelAd1);
            komut4.Parameters.AddWithValue("@p2", p.PersonelSoyad1);
            komut4.Parameters.AddWithValue("@p3", p.PersonelSehir1);
            komut4.Parameters.AddWithValue("@p4", p.PersonelGorev1);
            komut4.Parameters.AddWithValue("@p5", p.PersonelMaas1);
            komut4.Parameters.AddWithValue("@p6", p.PersonelId1);
            return komut4.ExecuteNonQuery();
        }
    }
}
