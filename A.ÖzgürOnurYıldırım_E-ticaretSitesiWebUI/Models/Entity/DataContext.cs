using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//Entity Framework

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")//base parentez içine connection string içindeki adres veriliyor
        {                                          //bas olmazsa Adres verilmezse random olarak oluşturuluyor
            
        }







        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}