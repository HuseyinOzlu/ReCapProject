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
        //-----------------------Araba-------------------------//         
        ///-----------Hatalı------------///
        public static string CarDailyPriceWrong = "Hata, işlem yapılamadı.\nLütfen günlük kiralama fiyatıını kontrol ediniz(Günlük kiralama Fiyatı 0'dan büyü olmak zorundadır).";
        public static string CarDontDeliver = "Araba Teslim Edilmedi.";
        ///-----------Başarılı---------///
        public static string CarAdded = "Araba Eklendi.";
        public static string CarDeleted = "Araba Silindi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarListed = "Arabalar Listelendi.";
        public static string CarListedByBrand = "Araba markaya göre listelendi.";
        public static string CarListedByColor = "Araba renklerine göre listelendi.";
        
        //------------------------Marka------------------------//            
        ///-----------Hatalı---------///
        public static string BrandNameWrong = "Hata, işlem yapılamadı.\nLütfen marka adını kontrol ediniz(Marka adı en az 2 karakter olamak zorundadır).";
        ///-----------Başarılı---------//
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandListed = "Marka Listelendi.";
        public static string BrandUpdated = "Marka Güncellendi.";

        //------------------------Renk------------------------//
        ///-----------Hatalı---------///
        public static string ColorNotListed = "Renkler Listelenemedi.";
        ///-----------Başarılı-------///
        public static string ColorListed = "Renk listelendi.";
        public static string ColorRemoved = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        
        //---------------------Arac-Resmi-------------------//
        ///-----------Hatalı---------///
        public static string CarSelectionErrorForCarImages = "Lütfen Eklemek istediğiniz aracın resmini seçiniz.";
        public static string CarImageLimited = "Araç resmi ekleme sınırına ulaşıldı.";
        public static string CarImageNotExist = "Araç resmi bulunmamaktadır.";
        ///-----------Başarılı-------///
        public static string CarImageAdded = "Araç Resmi Başarı ile Eklendi.";
        public static string CarImageListed = "Araç Resimleri başarı ile Listelendi.";
        public static string SuccessImageDeleted = "Araç Resmi başarı ile silindi.";
        internal static string CarImageListedByCarId;
    }
}
