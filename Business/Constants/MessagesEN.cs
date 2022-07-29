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
        public static string CarAdded = "Car Added";
        public static string CarDeleted = "Car Deleted";
        public static string CarUpdated = "Car Updated";
        public static string CarListed = "Cars Listed";
        public static string CarListedByBrand = "Car listed by Brand";
        public static string CarListedByColor = "Car listed by Color";
        public static string CarDailyPriceWrong = "Error, Car didn't added.\nPlease check DailyPrice(DailyPrice must be more than 0)";
        //-------------------Brand----------------------//
        public static string BrandNameWrong = "Error, Car didn't added.\nPlease check BrandName(BrandName must be min. 2 charecters) ";
        public static string BrandAdded = "Brand Added";
        public static string BrandDeleted = "Brand Deleted";
        public static string BrandListed = "Brand Listed";
        public static string BrandUpdated = "Brand Updated";
        //------------------------Color------------------------//
        public static string ColorListed = "Color Listed";
        public static string ColorRemoved = "Color Deleted";
        public static string ColorUpdated = "Color Updated";
    }
}
