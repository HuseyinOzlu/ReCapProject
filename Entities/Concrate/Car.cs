using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrate
{
    public class Car
    {
        // Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
        public int Id { get; set; }
        
        public int BrandId { get; set; }
        
        public int ColorId { get; set; }
        
        public int ModelYear { get; set; }
        
        public int DailyPrice { get; set; }
        
        public string Description  { get; set; }

    }
}
