using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class MessagesEN : IMessages
    {
        //--------------------Car-----------------------//
        /// -----------ERROR------------ ///  
        public static string CarDailyPriceWrong = "Error, Car didn't add.\nPlease check DailyPrice(DailyPrice must be more than 0).";
        public static string CarDontDeliver = "Car didn't deliver.";
        /// -----------SUCCESS------------ ///
        public static string CarAdded = "Car Added";
        public static string CarDeleted = "Car Deleted.";
        public static string CarUpdated = "Car Updated.";
        public static string CarListed = "Cars Listed.";
        public static string CarListedByBrand = "Car listed by Brand.";
        public static string CarListedByColor = "Car listed by Color.";

        //-------------------Brand----------------------//
        /// -----------ERROR------------ ///
        public static string BrandNameWrong = "Error, Brand didn't add.\nPlease check BrandName(BrandName must be min. 2 charecters).";
        /// -----------SUCCESS------------ ///
        public static string BrandAdded = "Brand Added.";
        public static string BrandDeleted = "Brand Deleted.";
        public static string BrandListed = "Brand Listed.";
        public static string BrandUpdated = "Brand Updated.";

        //-------------------Color----------------------//
        /// -----------ERROR------------///
        public static string ColorNotListed = "The Colors didn't list.";
        /// -----------SUCCESS------------ ///
        public static string ColorListed = "Color Listed.";
        public static string ColorRemoved = "Color Deleted.";
        public static string ColorUpdated = "Color Updated.";
        
        //------------------Car-Image------------------//
        /// -----------ERROR------------///
        public static string CarSelectionErrorForCarImages = "Please, Select car images which you want to add.";
        public static string CarImageNotExist = "There aren't Images";
        public static string CarImageLimited = "Can't added more Car Images, because You limited";
        /// -----------SUCCESS------------ ///
        public static string CarImageAdded = "Car Image added successly.";
        public static string CarImageListed = "Car Image listed successly.";
        public static string SuccessImageDeleted = "Car Image successly deleted.";
        internal static string CarImageListedByCarId;
    }
}
