using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarFeatureDtos
{
    public class ResultCarFeatureDto
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
    }
}
