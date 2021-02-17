using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmerWebAPI.Models.GetModels;
using Microsoft.AspNetCore.Mvc;

namespace FarmerWebAPI.Models
{
    public class FarmerRepository 
    {
        private readonly FarmerDataBaseContext _context;
        public FarmerRepository(FarmerDataBaseContext context)
        {
            _context = context;
        }

        public Boolean AddVegetableItems(Item veg)
        {
            try
            {
                _context.Item.Add(veg);
                _context.SaveChanges();
                return true;

            }
            catch (System.Threading.ThreadAbortException)
            {
                return false;
            }
        }

        public Boolean ConfirmOrder(VegOrder veg)
        {
            
            var result = _context.VegOrder.Where(c =>  c.Order_id == veg.Order_id).FirstOrDefault();
            try
            {
                result.status = 0;
                result.ship_date = veg.ship_date;
                result.ord_description = veg.ord_description;

                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<VegOrder> GetOrders(int fid)
        {
            //status == 1 =>not confirmed the order
            List<VegOrder> test = _context.VegOrder
                .Where(e => e.is_active == 1 && e.farmer_id== fid && e.status ==1 )
              .ToList();
            return test;

        }

        public VegOrder GerOrderByID(int id)
        {



            var test = _context.VegOrder
                .Where(et => et.Order_id == id)
                .FirstOrDefault();
            return test;

        }

        public Boolean AddType(ProductType type)
        {
            try
            {
                _context.ProductType.Add(type);
                _context.SaveChanges();
                return true;

            }
            catch (System.Threading.ThreadAbortException)
            {
                return false;
            }
        }

        public IEnumerable<ProductType> GetTypes()
        {
            //List<ProductType> test = _context.ProductType.ToList();
            List<ProductType> test = _context.ProductType
            .Where(e => e.is_active == 1 )
          .ToList();
            return test;

        }

        public IEnumerable<Item> GetTypeById(int id)
        {



            List <Item> test = _context.Item
                .Where(et => et.type_id == id && et.is_active ==1)
                .ToList();
            return test;

        }

        public Item GetItemById(int id)
        {
            var test = _context.Item
                .Where(et => et.item_id == id && et.is_active==1)
                .FirstOrDefault();
            return test;
        }

        public Boolean DeleteItem(int id)
        {
            var result = _context.Item.Where(c => c.is_active == 1 && c.item_id == id).FirstOrDefault();
            try
            {
                result.is_active = 0;
                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Boolean RejectOrder(int id)
        {
            var result = _context.VegOrder.Where(c => c.Order_id == id).FirstOrDefault();
            try
            {
                result.is_active = 0;
                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public IEnumerable<VegOrder> ConfirmedOrders(int fid) {
            List<VegOrder> test = _context.VegOrder
                  .Where(et => et.farmer_id == fid && et.status == 0)
                  .ToList();
            return test;
        }

        public Boolean AddPost(PostOrder veg)
        {
            try
            {
                _context.PostOrder.Add(veg);
                _context.SaveChanges();
                return true;

            }
            catch (System.Threading.ThreadAbortException)
            {
                return false;
            }
        }

        public IEnumerable<PostOrder> GetFarmerPosts(int fid)
        {
            List<PostOrder> test = _context.PostOrder
                  .Where(et => et.user_id == fid && et.is_active == 1)
                  .ToList();
            return test;
        }

        public Boolean DeletePost(int id)
        {
            var result = _context.PostOrder.Where(c => c.item_id == id).FirstOrDefault();
            try
            {
                result.is_active = 0;
                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Users GetUserById(int id)
        {
            var test = _context.Users
                .Where(et => et.user_id == id && et.is_active == 1)
                .FirstOrDefault();
            return test;
        }

        public Boolean UpdateItem(Item item)
        {
            try
            {

                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
