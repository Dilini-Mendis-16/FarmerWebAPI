using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmerWebAPI.Models;
using FarmerWebAPI.Models.GetModels;
using Microsoft.AspNetCore.Mvc;

namespace FarmerWebAPI.Service
{
    public class FarmerService 
    {
        private readonly FarmerRepository _service;


        private readonly FarmerDataBaseContext _context;

        public FarmerService(FarmerDataBaseContext context)
        {
            _context = context;
            _service = new FarmerRepository(_context);
        }

        public Boolean AddVegetableItems(Item v)
        {
            return _service.AddVegetableItems(v);
        }

        public Boolean ConfirmOrder(VegOrder v)
        {
            return _service.ConfirmOrder(v);
        }

        public Boolean AddType(ProductType t)
        {
            return _service.AddType(t);
        }

        public IEnumerable<VegOrder> GetOrders(int id)
        {

            return _service.GetOrders(id);

        }
        public VegOrder GetOrderByID(int id)
        {
            return _service.GerOrderByID(id);

        }

        public IEnumerable<ProductType> GetTypes()
        {

            return _service.GetTypes();

        }

        public IEnumerable <Item> GetTypeById(int id)
        {
            return _service.GetTypeById(id);

        }

        public Item GetItemById(int id)
        {
            return _service.GetItemById(id);

        }

        public Boolean DeleteItem(int id)
        {
            return _service.DeleteItem(id);
        }

        public Boolean RejectOrder(int id)
        {
            return _service.RejectOrder(id);
        }

        public IEnumerable<VegOrder> ConfirmedOrders(int id)
        {

            return _service.ConfirmedOrders(id);

        }

        public Boolean AddPost(PostOrder t)
        {
            return _service.AddPost(t);
        }

        public IEnumerable<PostOrder> GetFarmerPosts(int id)
        {

            return _service.GetFarmerPosts(id);

        }
        public Boolean DeletePost(int id)
        {
            return _service.DeletePost(id);
        }

        public Users GetUserById(int id)
        {
            return _service.GetUserById(id);
        }

        public Boolean UpdateItem(Item item) {
            return _service.UpdateItem(item);
        }
    }
}
