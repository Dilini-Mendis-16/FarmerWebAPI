using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerWebAPI.Models.GetModels
{
    public class GetPost
    {
        public String itemName { get; set; }

        public int quantity { get; set; }

        public int unitPrice { get; set; }

        public DateTime expireDate { get; set; }

        public DateTime harvestDate { get; set; }

        public String item_image { get; set; }

        public String  description { get; set; }
        public int farmerId { get; set; }
    }
}
