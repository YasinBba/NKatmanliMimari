using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;


namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> perList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = perList;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelAd1 = TxtAd.Text;
            ent.PersonelSoyad1 = TxtSoyad.Text;
            ent.PersonelSehir1 = TxtSehir.Text;
            ent.PersonelGorev1 = TxtGorev.Text;
            ent.PersonelMaas1 = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId1 = int.Parse(TxtId.Text);
            LogicPersonel.LLPersonelSil(ent.PersonelId1);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId1 = int.Parse(TxtId.Text);
            ent.PersonelAd1 = TxtAd.Text;
            ent.PersonelSoyad1 = TxtSoyad.Text;
            ent.PersonelSehir1 = TxtSehir.Text;
            ent.PersonelGorev1 = TxtGorev.Text;
            ent.PersonelMaas1 = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtGorev.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
