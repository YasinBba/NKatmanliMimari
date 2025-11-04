using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int PersonelId;
        private string PersonelAd;
        private string PersonelSoyad;
        private string PersonelSehir;
        private string PersonelGorev;
        private short PersonelMaas;

        public int PersonelId1 { get => PersonelId; set => PersonelId = value; }
        public string PersonelAd1 { get => PersonelAd; set => PersonelAd = value; }
        public string PersonelSoyad1 { get => PersonelSoyad; set => PersonelSoyad = value; }
        public string PersonelSehir1 { get => PersonelSehir; set => PersonelSehir = value; }
        public string PersonelGorev1 { get => PersonelGorev; set => PersonelGorev = value; }
        public short PersonelMaas1 { get => PersonelMaas; set => PersonelMaas = value; }
    }
}
