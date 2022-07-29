using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface IMessages
    {
        //--------------Car------------//
        public static string CarAdded;
        public static string CarDeleted;
        public static string CarUpdated;
        public static string CarListed;
        public static string CarDailyPriceWrong;
        public static string CarListedByBrand;
        public static string CarListedByColor;
        //-------------Brand---------------//
        public static string BrandNameWrong;
        public static string BrandAdded;
        public static string BrandDeleted;
        public static string BrandListed;
        public static string BrandUpdated;
        //------------------------Color------------------------//
        public static string ColorListed;
        public static string ColorRemoved;
        public static string ColorUpdated;
    }
}
