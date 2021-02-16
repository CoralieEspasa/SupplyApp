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
        public IActionResult NewOrder([FromQuery] Int32 supplierId, [FromForm] OrderLine line)
        {
            CreateSupplierOrder(supplierId);
            return View(GetSupplierById(supplierId));
        }

        public Supplier GetSupplierById(Int32 supplierId)
        {
            IEnumerable<Supplier> suppliers = new List<Supplier>(_context.Suppliers.Select(s => s));
            Supplier supplier = suppliers.Where(s => s.Id == supplierId)
                                         .FirstOrDefault();
            return supplier;
        }
        public PurchaseOrder CreateSupplierOrder(Int32 supplierId)
        {
            Supplier supplier = GetSupplierById(supplierId);
            PurchaseOrder order = new PurchaseOrder();
            order.CreationDate = DateTime.Now;
            order.SupplierId = supplierId;
            supplier.PurchaseOrders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public PurchaseOrder GetOrderById(Int32 orderId)
        {
            IEnumerable<PurchaseOrder> orders = new List<PurchaseOrder>(_context.PurchaseOrders.Select(po => po));
            PurchaseOrder order = orders.Where(po => po.Id == orderId)
                                         .FirstOrDefault();
            return order;
        }
        public OrderLine CreateSupplierOrderLine(Int32 orderId, OrderLine line)
        {
            PurchaseOrder order = GetOrderById(orderId);
            line.DeliveryDate = DateTime.Now.AddDays(line.DeliveryTime);
            line.PurchaseOrderId = order.Id;
            _context.OrderLines.Add(line);
            _context.SaveChanges();

            return line;
        }
    }
}
