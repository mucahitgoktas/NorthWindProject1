using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            ListCategory(); // Kategorileri Listeleyecek.
            
            ListProductByCategory();

        }

        private void ListProductByCategory(int categoryId) // ben sana bir kategori id vericem, ürünleri listele ama verdiğim kategoride listele..
        {
            using (NorthwindContext Context = new NorthwindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                crxKategori.DataSource =
                    Context.Categories.Where(p => p.CategoryID == categoryId).ToList(); // kategori seçtiğimizde,
                                                                                        // kategori id bizim tanımladığımız değere eşitlenecek ve gridview'de o kategoridekiler listelenecek.
                                                                                        // veri tabanına select * from gönderecek. Listeleyecek.

                crxKategori.DisplayMember = "CategoryName";
                crxKategori.ValueMember = "CategoryID";
            }
        }

        private void ListCategory()
        {
            using (NorthwindContext Context = new NorthwindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk.
                // ismini context yaptık.
            {
                crxKategori.DataSource =
                    Context.Categories.ToList(); // Datagridview'in üzerine contextin kategori tablosunu gönderiyoruz.
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

       
        private void crxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductByCategory(Convert.ToInt32(crxKategori.SelectedValue));
            }
            catch 
            {
                
            }
            
        }
    }
}
