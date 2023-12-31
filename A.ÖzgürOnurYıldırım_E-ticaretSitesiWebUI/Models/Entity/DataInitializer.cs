using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Linq;
using System.Web;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
             new Category(){Name="Geliştirme Kartları" ,Description="Arduino Stm32"},
             new Category(){Name="Komponentler", Description="Direnç Kondansatör diyot "},
             new Category(){Name="Entegreler",Description="Sürücüler,lojik devre, opamp"},
             new Category(){Name="Motorlar",Description="DC motor,Stepper, Servo" },
             new Category(){Name="Ölçü Aletleri",Description="Multimetre,Osiloskop"},
             
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
              new Product(){Name="Arduino Uno",Description="Geliştirme kartı 8 bit",Price=160,Stock=1000 , IsApproved =true, CategoryId=1,IsHome=true ,Image="2.jpg"},
              new Product(){Name="Stm32f103",Description="Geliştirme Kartı 32bit",Price=200 ,Stock=1000 , IsApproved =true, CategoryId=1,IsHome=true ,Image="3.jpg"},
              new Product(){Name="Stm32f407",Description="Geliştirme kartı 32bit",Price=1250,Stock=500 , IsApproved =true, CategoryId=1,IsHome=true,Image="4.jpg" },
              new Product(){Name="ESP8266",Description="Nesnelerin interneti geliştirme kartı wi-fi 8 bit",Price=200,Stock=1000 , IsApproved =true, CategoryId=1,IsHome=true ,Image="5.jpg"},
              new Product(){Name="ESP32S",Description="Nesnelerin interneti geliştirme kartı 32 bit wi-fi bluetooth",Price=300 ,Stock=1000, IsApproved =true, CategoryId=1 ,IsHome=true,Image="6.jpg"},

              new Product(){Name="Direnç SMD",Description="SMD",Price=1 ,Stock=10000 , IsApproved =true, CategoryId=2,IsHome=true ,Image="7.jpg" },
              new Product(){Name="Kondansatör",Description="THT kutuplu kutupsuz",Price=2 ,Stock=10000, IsApproved =true, CategoryId= 2,IsHome=true,Image="8.jpg" },
              new Product(){Name="Diyot 1N40xx",Description="diyot SMD ve THT",Price=5 ,Stock=10000, IsApproved =true, CategoryId=2 ,IsHome=true ,Image="9.jpg"},
              new Product(){Name="Transistör",Description="bc547,bc546",Price=10 ,Stock=10000 , IsApproved =true, CategoryId=2,IsHome=true ,Image="10.jpg" },
              new Product(){Name="Mosfet",Description="Güç mosfet",Price=12 ,Stock=1000, IsApproved =true, CategoryId=2,IsHome=true,Image="11.jpg" },
              new Product(){Name="Lm7805",Description="Voltaj regülatörü",Price=8 ,Stock=1000, IsApproved =true, CategoryId=3,IsHome=true ,Image="12.jpg" },
              new Product(){Name="Ne555",Description="Timer enregresi",Price=9,Stock=10000, IsApproved =true, CategoryId=3,IsHome=true ,Image="13.jpg" },
              new Product(){Name="74HC14",Description="schmitt Triger Entegresi",Price=7 ,Stock=10000, IsApproved =false, CategoryId=3,Image="2.jpg"},
              new Product(){Name="L293B",Description="Motor Sürücü",Price=90 ,Stock=1000 , IsApproved =false, CategoryId=3,IsHome=true ,Image="2.jpg"},
              new Product(){Name="A4988",Description="CNC sürücü,step motor sürücüsü",Price=38 ,Stock=1000, IsApproved =true, CategoryId=3,IsHome=true ,Image="14.jpg"},
              new Product(){Name="Nema17 Adım motoru",Description="Adım açısı 1.8 derece",Price=350,Stock=500, IsApproved =true, CategoryId=4 ,IsHome=true,Image="15.jpg" },
              new Product(){Name="Nema23",Description="Nema23",Price=420 ,Stock=100, IsApproved =true, CategoryId=4 ,IsHome=true,Image="16.jpg" },
              new Product(){Name="BLDC",Description="fırçasız dc motor 3phase 850 rpm 10A",Price=350 ,Stock=280, IsApproved =true, CategoryId=4 ,IsHome=true ,Image="17.jpg"},
              new Product(){Name="Servo",Description="180derece servo motor",Price=40 ,Stock=1000 , IsApproved =true, CategoryId=4,IsHome=true,Image="18.jpg"  },
              new Product(){Name="Relüktörlü Dc motor",Description="Relüktörlü 2A 5V dc motor",Price=150 ,Stock=280 , IsApproved =true, CategoryId=4,IsHome=true ,Image="19.jpg"},
              new Product(){Name="UNIT Multimetre",Description="Yüksek hassasiyetli gerilim akım ölçümü max1000V",Price=400 ,Stock=500 , IsApproved =true, CategoryId=5,IsHome=true,Image="20.jpg" },
              new Product(){Name="Marxlow DT",Description="Multimetre DC AC gerilim akım ölçümü",Price=50 ,Stock=1000 , IsApproved =true, CategoryId=5,IsHome=true ,Image="21.jpg" },
              new Product(){Name="UNIT UTD",Description="Dijital Osiloskop 2Channel 500MHz",Price=11000,Stock=200, IsApproved =true, CategoryId=5 ,IsHome=true ,Image="22.jpg"},
              new Product(){Name="UNIT LM",Description="Lazer mesafe ölçer",Price=1600 ,Stock=250 , IsApproved =true, CategoryId=5,IsHome=true ,Image="23.jpg" },
              new Product(){Name="UNIT UT83",Description="LUX metre aydınlatma birimi",Price=798,Stock=100, IsApproved =true, CategoryId=5,IsHome=true,Image="24.jpg"  },
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }

    }
}