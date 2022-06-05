using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Plans
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsFeature { get; set; }
        public List<PlansFeatureItems> PlansFeatureItems { get; set; }
    }
}
