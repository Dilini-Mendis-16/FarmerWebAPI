using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FarmerWebAPI.Models
{
    public class FarmerDataBaseContext: DbContext
    {
        // private FarmerDataBaseContext context;

        //public FarmerDataBaseContext(DbContextOptions<FarmerDataBaseContext> options) : base(options)
        public FarmerDataBaseContext(DbContextOptions<FarmerDataBaseContext> options) : base(options)
        {

        }
        

        /*public FarmerDataBaseContext(FarmerDataBaseContext context)
        {
            this.context = context;
        }
        */
        public DbSet<Item> Item { get; set; }
        public DbSet<VegOrder> VegOrder { get; set; }
        public DbSet<ProductType> ProductType{ get; set; }

        public DbSet<PostOrder> PostOrder { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
