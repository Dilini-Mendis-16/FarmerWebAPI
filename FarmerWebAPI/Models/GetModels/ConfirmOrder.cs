using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerWebAPI.Models.GetModels
{
    public class ConfirmOrder
    {
        public int order_id { get; set; }
  public DateTime ship_date { get; set; }

  public String ord_description { get; set; }
    }
}
