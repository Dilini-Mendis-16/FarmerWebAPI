using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmerWebAPI.Models
{
    public class VegOrder
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_id { get; set; }
        public String Order_name { get; set; }
        public int is_active { get; set; }

        public int quantity { get; set; }
        public DateTime expected_delivery_date { get; set; }
        public String description { get; set; }
        public int customer_id { get; set; }
        public int farmer_id { get; set; }

        public DateTime ship_date { get; set; }
        public String  ord_description { get; set; }
        public int status { get; set; }

    }
}
