using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class MessagesTR : IMessages
    {
        //-----------------------Araba---------------------------//
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarDailyPriceWrong = "Hata, işlem yapılamadı.\nLütfen günlük kiralama fiyatıını kontrol ediniz(Günlük kiralama Fiyatı 0'dan büyü olmak zorundadır)";
        public static string CarListedByBrand = "Araba markaya göre listelendi";
        public static string CarListedByColor = "Araba renklerine göre listelendi";
        public static string CarDontDeliver = "Araba Teslim Edilmedi";
        //------------------------Marka------------------------//
        public static string BrandNameWrong = "Hata, işlem yapılamadı.\nLütfen marka adını kontrol ediniz(Marka adı en az 2 karakter olamak zorundadır)";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Marka Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";
        //------------------------Color------------------------//
        public static string ColorListed = "Renk listelendi";
        public static string ColorRemoved = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        
    }
}
