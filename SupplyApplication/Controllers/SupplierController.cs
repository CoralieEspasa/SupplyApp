using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyApplication.Data;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SupplyApplication.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SupplierController(ApplicationDbContext injectedContext)
        {
            _context = injectedContext;
        }

        [HttpGet]
        public IActionResult Index(String searchString)
        {
            if (_context.Suppliers.Any())
            {
                return View(GetSupplierList(searchString));
            }
            else
            {
                return BadRequest();
            }
            
        }

        [HttpGet]
        public IActionResult SupplierDetails(Int32 Id)
        {
            if (Id != 0)
            {
                return View(GetSupplierDetails(Id));
            }
            else
            {
                return BadRequest();
            }

        }
        public List<Supplier> GetSupplierList(String searchString)
        {
            List<Supplier> suppliers = new List<Supplier>(_context.Suppliers.Where(s => s.Name.Contains(searchString) || s.SIRET.Contains(searchString) || s.Location.Contains(searchString)));                                                                 
            return suppliers;
        }

        public Supplier GetSupplierDetails(Int32 supplierId)
        {
            IEnumerable<Supplier> suppliers = new List<Supplier>();
            Supplier supplier = new Supplier();
            suppliers = _context.Suppliers.Where(s => s.Id == supplierId).Include(s => s.PurchaseOrders).Include(s => s.Items);
            supplier = suppliers.FirstOrDefault();
            
            foreach (PurchaseOrder order in supplier.PurchaseOrders)
            {
                GetOrderDetails(order.Id);
                
                foreach(OrderLine line in order.OrderLines)
                {
                    GetOrderLines(order.Id);
                }
            }

            foreach(Item item in supplier.Items)
            {
                GetSupplierItems(supplier.Id);
            }

            return supplier;
        }

        public PurchaseOrder GetOrderDetails(Int32 orderId)
        {
            IEnumerable<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrders = _context.PurchaseOrders.Where(p => p.Id == orderId).Include(p => p.OrderLines) ;
            purchaseOrder = purchaseOrders.FirstOrDefault();
            return purchaseOrder;
        }
        public IEnumerable<OrderLine> GetOrderLines(Int32 orderId)
        {
            IEnumerable<OrderLine> lines = new List<OrderLine>();
            lines = _context.OrderLines.Select(i => i);
            return lines;
        }

        public IEnumerable<Item> GetSupplierItems(Int32 supplierId)
        {
            IEnumerable<Item> items = new List<Item>();
            items = _context.Items.Include(i => i.Suppliers.Where(s => s.Id ==supplierId)).Include(i => i.Suppliers);
            return items;
        }

    }
}
