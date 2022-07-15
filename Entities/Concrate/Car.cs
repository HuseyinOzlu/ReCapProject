using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrate
{
    public class Car : IEntity
    {
        // Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
        public int Id { get; set; }
        public int Model_Year { get; set; }
        public float Daily_Price { get; set; }
        public string Description  { get; set; }
        public Brand Brands { get; set; }
        public Color Colors { get; set; }

    }
}
