using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";

        //CarImage
        internal static string ImageAdded = "Resim eklendi";
        internal static string ImageDeleted = "Resim silindi";
        internal static string ImageListed = "Resim listelendi";
        internal static string ImageUpdated = "Resim güncellendi";
        internal static string MaximumCarImageLimitExceded = "Maksimum araç fotoğrafı sayısına ulaşıldı";

        //Brand
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        internal static string BrandLimitExceded = "Marka limiti aşıldığı için yeni marka eklenemiyor";
        internal static string BrandNameAlreadyExists = "Aynı modelden iki defa eklenemez";

        //Color
        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";

        //User
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";

        //Rental
        public static string RentalAdded = "Kiralanma bilgisi eklendi";
        public static string RentalUpdated = "Kiralanma bilgisi güncellendi";
        public static string RentalDeleted = "Kiralanma bilgisi silindi";
        public static string RentalListed = "Kiralanma bilgileri listelendi";
        public static string RentalAddErrorMessage = "Araç teslim edilmemiş";
        public static string RentalDeleteErrorMessage = "Araç silinemedi";


        public static string CompanyNameInvalid = "Şirket ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";

       
    }
}