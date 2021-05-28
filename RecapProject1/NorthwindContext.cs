using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Entities;

namespace RecapProject1
{
    class NorthwindContext : DbContext
    {
        public DbSet<Product>Products { get; set; } // Producs tablosu içerisinde
                                                    // Products nesnesinin içerdiği kolonlara karşılık gelecek get set ayarı.

        public DbSet<Category> Categories { get; set; } // Categories tablosu ile Category.cs bağlantısı.
    }
}
