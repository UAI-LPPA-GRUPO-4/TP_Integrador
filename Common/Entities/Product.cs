using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ArtistId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double AvgStars { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime ChangedOn { get; set; }
        public string ChangedBy { get; set; }
    }
}
