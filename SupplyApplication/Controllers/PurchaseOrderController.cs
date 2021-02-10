using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyApplication.Data;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseOrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PurchaseOrderController(ApplicationDbContext injectedContext)
        {
            _context = injectedContext;
        }

        [HttpGet]
        public IActionResult NewOrder(Int32 Id)
        {
            return View(GetSupplier(Id));
        }

        [HttpPost, ActionName("add")]
        public IActionResult NewOrder(Int32 Id, OrderLine userEntry)
        {
            return View(CreatePurchaseOrder(Id, userEntry));
        }


        public PurchaseOrder CreatePurchaseOrder(Int32 Id,OrderLine userEntry)
        {
            List<OrderLine> orderLines = new List<OrderLine>();
            OrderLine line = new OrderLine
            {
                ItemReference = userEntry.Id,
                ItemName = userEntry.ItemName,
                Quantity = userEntry.Quantity,
                UnitPrice = userEntry.UnitPrice,
                Remise = userEntry.Remise,
                DeliveryTime = userEntry.DeliveryTime,
                DeliveryDate = DateTime.Now.AddDays(userEntry.DeliveryTime)
            };

            orderLines.Add(line);

            PurchaseOrder purchaseOrder = new PurchaseOrder
            {
                OrderLines = orderLines,
                CreationDate = DateTime.Now
            };

            GetSupplier(Id).PurchaseOrders.Add(purchaseOrder);
            
            _context.SaveChanges();

            return purchaseOrder;
        }

        public Supplier GetSupplier(Int32 Id)
        {
            IEnumerable<Supplier> suppliers = new List<Supplier>(_context.Suppliers.Select(s=>s).Include(s =>s.Items));
            Supplier supplier = suppliers.Where(s => s.Id == Id).FirstOrDefault();
            return supplier;
        }
    }
}
