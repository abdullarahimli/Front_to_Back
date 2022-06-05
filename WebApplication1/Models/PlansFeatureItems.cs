using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PlansFeatureItems
    {
        public int Id { get; set; }
        public Plans Plans { get; set; }
        public int PlansId { get; set; }
        public FeatureItems FeatureItems { get; set; }
        public int FeatureItemsId { get; set; }
    }
}
