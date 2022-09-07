using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public string imageName { get; set; }
        public int Car_Id { get; set; }
        public string Path_Image { get; set; }
        public DateTime Car_Date { get; set; }
    }
}
