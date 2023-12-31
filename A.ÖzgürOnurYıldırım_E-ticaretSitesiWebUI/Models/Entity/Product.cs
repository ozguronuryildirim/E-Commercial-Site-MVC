using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Description { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public bool IsApproved { get; set; }

        public int CategoryId { get; set; } // kategori 1.anahtarı
        public Category Category { get; set; }//1'e çok ilişki kuruldu









    }
}