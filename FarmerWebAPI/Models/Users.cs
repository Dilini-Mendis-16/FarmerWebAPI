using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerWebAPI.Models
{
    public class Users
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int user_id { get; set; }
		public String user_name { get; set; }
		public String email { get; set; }
		public String contact { get; set; }
		public String city { get; set; }
		public String district { get; set; }
		public String address { get; set; }
		public String description { get; set; }
		public int role_id { get; set; }
		public int ratings { get; set; }
		public int is_active { get; set; }
		public String Transport_Facility {get; set;}
		public int Price_Per_Km {get;set;}
		public int Average_Rate {get;set;}
		public String Account_Number{get;set;}
	}
}
