﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity
{
    public class Category
    {
      
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}