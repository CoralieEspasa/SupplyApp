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
            return View(GetSupplierById(Id));
        }

        [HttpPost, ActionName("NewOrder")]
        public IActionResult NewOrder(Int32 supplierId,
                                      [FromBody] OrderLine userEntry)
        {
            CreateSupplierOrder(supplierId, userEntry);
            return View();
        }

        public Supplier GetSupplierById(Int32 supplierId)
        {
            IEnumerable<Supplier> suppliers = new List<Supplier>(_context.Suppliers.Select(s => s));
            Supplier supplier = suppliers.Where(s => s.Id == supplierId)
                                         .FirstOrDefault();
            return supplier;
        }
        public Supplier CreateSupplierOrder(Int32 supplierId, OrderLine userEntry)
        {
            Supplier supplier = GetSupplierById(supplierId);

            PurchaseOrder order = new PurchaseOrder();
            order.CreationDate = DateTime.Now;
            order.SupplierId = supplierId;

            ICollection<OrderLine> lines = new List<OrderLine>();
            foreach (OrderLine line in lines)
            {
                line.ItemReference = userEntry.ItemReference;
                line.ItemName = userEntry.ItemName;
                line.Quantity = userEntry.Quantity;
                line.Remise = userEntry.Remise;
                line.UnitPrice = userEntry.UnitPrice;
                line.DeliveryTime = userEntry.DeliveryTime;
                line.DeliveryDate = DateTime.Now.AddDays(line.DeliveryTime);
                line.PurchaseOrderId = order.Id;
            }

            supplier.PurchaseOrders.Add(order);
            _context.SaveChanges();

            return supplier;
        }
    }
}
