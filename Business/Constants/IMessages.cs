using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface IMessages
    {
        //--------------Car----------------//
        /// -----------ERROR------------ ///  
        public static string CarDontDeliver;
        public static string CarDailyPriceWrong;
        /// -----------SUCCESS------------ ///
        public static string CarAdded;
        public static string CarDeleted;
        public static string CarUpdated;
        public static string CarListed;
        public static string CarListedByBrand;
        public static string CarListedByColor;

        //-------------Brand---------------//
        /// -----------ERROR------------ ///  
        public static string BrandNameWrong;
        /// -----------SUCCESS------------ ///
        public static string BrandAdded;
        public static string BrandDeleted;
        public static string BrandListed;
        public static string BrandUpdated;

        //-------------Color---------------//
        /// -----------ERROR------------ ///  
        public static string ColorNotListed;
        /// -----------SUCCESS------------ ///
        public static string ColorListed;
        public static string ColorRemoved;
        public static string ColorUpdated;

        //-----------Car-Image-------------//
        /// -----------ERROR------------ ///  
        public static string CarSelectionErrorForCarImages;
        public static string CarImageNotExist;
        public static string CarImageLimited;
        /// -----------SUCCESS------------ ///
        public static string CarImageAdded;
        public static string CarImageListed;
        public static string SuccessImageDeleted;

    }
}
