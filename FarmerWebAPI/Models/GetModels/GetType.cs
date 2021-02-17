using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerWebAPI.Models.GetModels
{
    public class GetType
    {
        public String type_name { get; set; }
        public String description { get; set; }
        public int is_active { get; set; }
    }
}
