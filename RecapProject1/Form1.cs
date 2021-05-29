using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) // programın load'ı. açılış anındaki ilk görüntü/çalışma.
        {
            ListProducts(); //veri tabanına select* from gönderecek.Ürünleri Listeleyecek.

            ListCategory(); // Kategorileri isimlerini Listeleyecek.

            




        }

        private void ListProductByCategoryId(string key) // Hangi numarayı verirsek ona göre CategoryId filtrelemesiy yap.
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                crxKategori.DataSource = context.Categories.Where(p=> p.CategoryID(tbxSearchByCategoryId.Text)).ToList();
            }
        }

        private void ListProductByCategory(int categoryId) // ben sana bir kategori id vericem, ürünleri listele ama verdiğim kategoride listele..
        {
            using (NorthwindContext Context = new NorthwindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                crxKategori.DataSource = Context.Categories.Where(p => p.CategoryID == categoryId).ToList(); // kategori seçtiğimizde,
                                                                                        // kategori id bizim tanımladığımız değere eşitlenecek ve gridview'de o kategoridekiler listelenecek.
                                                                                        // veri tabanına select * from gönderecek. Listeleyecek.

                crxKategori.DisplayMember = "CategoryName";
                crxKategori.ValueMember = "CategoryID";
            }
        }

        private void ListProductByProductName(string key) // Key değeri olarak hangi harfler veya kelime girilirse onu listelemek üzere metot.
        {
            using (NorthwindContext context =new NorthwindContext())// NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.Contains(tbxSearch.Text)).ToList();
            }
        }

        private void ListCategory()
        {
            using (NorthwindContext Context = new NorthwindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                crxKategori.DataSource = Context.Categories.ToList(); // Datagridview'in üzerine contextin kategori tablosunu gönderiyoruz.
                // veri tabanına select * from gönderecek. Listeleyecek.

                crxKategori.DataSource = Context.Categories.ToList();
                crxKategori.DisplayMember = "CategoryName";
                crxKategori.ValueMember = "CategoryID";
            }
        }

        
        private void ListProducts()
        {
            using (NorthwindContext Context = new NorthwindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                dgwProduct.DataSource =
                    Context.Products.ToList(); // Datagridview'in üzerine contextin ürünler tablosunu gönderiyoruz.
                // veri tabanına select * from gönderecek. Listeleyecek.
            }
        }

       
        private void crxKategori_SelectedIndexChanged(object sender, EventArgs e) // combobox için event ekleme.
        {
            try
            {
                ListProductByCategory(Convert.ToInt32(crxKategori.SelectedValue)); // seçilen değerin listelenmesi için "ListProductByCategory" methodunu çağırma.
            }
            catch 
            {
                
            }
            
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e) // textbox Search için event.

        {
            ListProductByProductName(tbxSearch.Text);
        }

        private void tbxSearchByCategoryId_TextChanged(object sender, EventArgs e) // textbox Kategoriye Göre ara için event.
        {
            ListProductByProductName(tbxSearchByCategoryId.Text);
        }
    }
}
