using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmerWebAPI.Models;
using FarmerWebAPI.Models.GetModels;
using FarmerWebAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace FarmerWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/farmer")]
    public class FarmerController : Controller
    {
        private readonly FarmerDataBaseContext _context;
        private readonly FarmerService _service;

        public FarmerController(FarmerDataBaseContext context)
        {
            _context = context;
            _service = new FarmerService(_context);
        }

        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("addItem")]
        public IActionResult AddVegetableItem([FromBody] GetVegetable v)
        {
            Item veg = new Item();
            //veg.Id = 2;
            veg.item_name = v.itemName;
            veg.quantity = v.quantity;
            veg.unit_price = v.unitPrice;
            veg.expired_date = v.expireDate;
            veg.harvest_date = v.harvestDate;
            veg.item_image = v.item_image;
            veg.type_id = v.type_id;
            veg.is_active = 1;
            Boolean id = _service.AddVegetableItems(veg);
            if (id)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


       
        [Produces("application/json")]
        [HttpGet("getfrorder/{fid}")]
        public IActionResult GetOrdersForFarmer(int fid)
        {


            var result = _service.GetOrders(fid);
            return Ok(result);


        }

       [Produces("application/json")]
        [HttpGet("getorder/{id}")]
        public VegOrder GetOrderById(int id)
        {
            return _service.GetOrderByID(id);

        }
       
        [Produces("application/json")]
        [HttpGet("getOrders")]
        public ActionResult Index()

        {

            using (var context = _context)

            {

                List<VegOrder> Employeelist = context.VegOrder.ToList();

            }

            return View();

        }

        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("confirmorder")]
        public IActionResult AddOrder([FromBody] ConfirmOrder v)
        {
            VegOrder veg = new VegOrder();
            veg.Order_id = v.order_id;
            veg.ship_date = v.ship_date;
            veg.ord_description = v.ord_description;
            veg.status = 0; //complete order

            
            Boolean id = _service.ConfirmOrder(veg);
            if (id)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("addType")]
        public IActionResult AddType([FromBody] GetType v)
        {
            ProductType p = new ProductType();
            p.type_name = v.type_name;
            p.description = v.description;
            p.is_active = 1;


            Boolean id = _service.AddType(p);
            if (id)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("getTypes")]
        public IActionResult GetTypes()
        {


            var result = _service.GetTypes();
            return Ok(result);


        }


        [Produces("application/json")]
        [HttpGet("getallfor/{id}")]

        public IActionResult GetTypeById(int id)
        {
            var result = _service.GetTypeById(id);
            return Ok(result);

        }

        [Produces("application/json")]
        [HttpGet("getitem/{id}")]

        public Item GetItemById(int id)
        {
            return _service.GetItemById(id);

        }

        [HttpGet("deleteitem/{id}")]
        public Boolean DeleteItem(int id)
        {
            return _service.DeleteItem(id);
        }

        [HttpGet("rejectorder/{id}")]
        public Boolean RejectOrder(int id)
        {
            return _service.RejectOrder(id);
        }

        [Produces("application/json")]
        [HttpGet("confirmedorders/{id}")]

        public IActionResult ConfirmedOrders(int id)
        {
            var result = _service.ConfirmedOrders(id);
            return Ok(result);

        }


        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("addpost")]
        public IActionResult AddPost([FromBody] GetPost v)
        {
            PostOrder veg = new PostOrder();
            //veg.Id = 2;
            veg.item_name = v.itemName;
            veg.quantity = v.quantity;
            veg.unit_price = v.unitPrice;
            veg.expired_date = v.expireDate;
            veg.harvest_date = v.harvestDate;
            veg.item_image = v.item_image;
            veg.description = v.description;
            veg.is_active = 1;
            veg.user_id = v.farmerId;
            Boolean id = _service.AddPost(veg);
            if (id)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("farmerpost/{id}")]

        public IActionResult GetFarmerPosts(int id)
        {
            var result = _service.GetFarmerPosts(id);
            return Ok(result);

        }

        [HttpGet("deletepost/{id}")]
        public Boolean DeletePost(int id)
        {
            return _service.DeletePost(id);
        }

        [Produces("application/json")]
        [HttpGet("getuser/{id}")]

        public Users GetUserById(int id)
        {
            return _service.GetUserById(id);

        }
    }
}
