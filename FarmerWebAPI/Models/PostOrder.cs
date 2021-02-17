using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmerWebAPI.Models
{
    public class PostOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int item_id { get; set; }

        public String item_name { get; set; }

        public int quantity { get; set; }

        public int unit_price { get; set; }

        public DateTime? expired_date { get; set; }

        public DateTime? harvest_date { get; set; }

        public String item_image { get; set; }

        public String description { get; set; }

        public int is_active { get; set; }
        public int user_id { get; set; }
    }
}
