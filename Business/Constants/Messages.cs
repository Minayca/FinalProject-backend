using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Tekrar tekrar new'lememek için static yapıyoruz çünkü bu sabit bir yapı.
    public static class Messages
    {
        //public'ler büyük harfle private'lar küçük harfle başlanarak yazılır.
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
    }
}
