using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrate
{
    public class Car : IEntity
    {
        // Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
        public int Id { get; set; }
        public string Cars_Name { get; set; }
        public int Model_Year { get; set; }
        public double Daily_Price { get; set; }
        public string Description  { get; set; }
        public int BrandsId { get; set; }
        public int ColorsId { get; set; }

    }
}
