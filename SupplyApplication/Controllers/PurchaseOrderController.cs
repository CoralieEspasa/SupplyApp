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
        public async Task<IActionResult> NewOrder(Int32 supplierId,
                                                  PurchaseOrder order,
                                                  [FromBody]OrderLine userEntry)
        {
            order = CreateSupplierOrder(userEntry);
            GetSupplier(supplierId).PurchaseOrders.Add(order);
            await _context.SaveChangesAsync();
            return View();
        }

        public PurchaseOrder CreateSupplierOrder(OrderLine userEntry)
        {
            PurchaseOrder order = new PurchaseOrder();
            order.CreationDate = DateTime.Now;

            IEnumerable<OrderLine> lines = new List<OrderLine>();
            foreach(OrderLine line in lines)
            {
                line.ItemReference = userEntry.ItemReference;
                line.ItemName = userEntry.ItemName;
                line.Quantity = userEntry.Quantity;
                line.Remise = userEntry.Remise;
                line.UnitPrice = userEntry.UnitPrice;
                line.DeliveryTime = userEntry.DeliveryTime;
                line.DeliveryDate = DateTime.Now.AddDays(line.DeliveryTime);
                order.OrderLines.Add(line);
            }
            return order;
        }

        public Supplier GetSupplier(Int32 Id)
        {
            IEnumerable<Supplier> suppliers = new List<Supplier>(_context.Suppliers.Select(s=>s)
                                                                                   .Include(s =>s.Items)
                                                                                   .Include(s=>s.PurchaseOrders));
            Supplier supplier = suppliers.Where(s => s.Id == Id)
                                         .FirstOrDefault();

            return supplier;
        }
    }
}
