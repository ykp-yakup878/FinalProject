using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied="Yetki Yok";
        public static string UserAdded="Kullanıcı Eklendi";
        public static string UserRegistered="Kayıt Oldu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı Zaten Var";
        public static string AccessTokenCreated="Token Oluşturuldu";
    }
}
