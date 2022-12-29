using KitapProjesi.Entity;

namespace KitapProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = KitapAl();
            listBoxKitaplar.Items.Add(yeniKitap);
            KitapListesiOlustur(yeniKitap);
        }

        private Kitap KitapAl()
        {
            Kitap yeniKitap = new();
            yeniKitap.KitapAdi = txtKitapAdi.Text;
            yeniKitap.YazarAdi = txtYazarAdi.Text;
            yeniKitap.IsbnNumarasi = txtIsbnNumarasi.Text;
            yeniKitap.KitapBasimYili = dtKitapBasimYili.Value;
            yeniKitap.SayfaSayisi = Convert.ToInt32(nmdSayfaSayisi.Value);
            return yeniKitap;


        }

        private void KitapListesiOlustur(Kitap kitap)
        {
            KitapListesi kitapListesi = new();
            kitapListesi.Add(kitap);

        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            Form2 frm = new();
            frm.ShowDialog();
        }
    }
}