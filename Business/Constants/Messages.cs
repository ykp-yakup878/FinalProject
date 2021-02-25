using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi"; 
        public static string ProductNameInValid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride En Fazla 10 Ürün Olabilir";
        public static string ProductUpdated="Ürün Güncellendi";
        public static string ProductNameAllReadyExists="Aynı Üründen Var!";
        public static string CategoryLimitedExceded="Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor";
    }
}
