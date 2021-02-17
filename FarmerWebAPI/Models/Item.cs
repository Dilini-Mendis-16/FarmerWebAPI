using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerWebAPI.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int item_id { get; set; } 
       
        public String item_name { get; set; }

         public int quantity  { get; set; }

         public  int unit_price { get;set; }

         public DateTime? expired_date { get; set; }

        public  DateTime? harvest_date { get; set; }

        public String item_image { get; set; }   
        
        public int type_id { get; set; }

        public int is_active { get; set; }


        }
}
