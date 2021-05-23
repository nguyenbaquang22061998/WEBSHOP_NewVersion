﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DOLPHIN.Model;
using Microsoft.AspNetCore.Http;
using DOLPHIN.DTO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using DOLPHIN.Service.Interfaces;
using DOLPHIN.WebApi.Model;
using DOLPHIN.WebApi.Enums;

namespace DOLPHIN.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IAddressService addressService;
        public CartController(ApplicationDBContext context, IAddressService addressService)
        {
            _context = context;
            this.addressService = addressService;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                int total = 0;
                foreach (var item in dataCart)
                {
                    int price = Int32.Parse(item.Products.Price);
                    total = price * item.Quantity;
                }
                ViewBag.Total = total;
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
            //return View();
        }

        public async Task<IActionResult> Payment(OrderRequestDto orderRequestDto)
        {
            // Call Api GHN Create Order.
            var cart = HttpContext.Session.GetString("cart");//get key cart
            List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            string token = "98bb7369-1162-11eb-a23c-065c95c021cb";
            orderRequestDto.WardCode = "1A0314";
            orderRequestDto.DistrictId = 1488;
            orderRequestDto.CliendOrderCode = Guid.NewGuid().ToString();
            var newItems = new ItemsDto();
            foreach (var item in dataCart)
            {
                newItems.Code = item.Products.Id.ToString();
                newItems.Name = item.Products.ProductName;
                newItems.Quantity = item.Quantity;
            }
            
            orderRequestDto.Items = newItems;
            var result =  await this.addressService.CreateOrder(token, orderRequestDto);
            var newOrder = new Orders();
            // Create Order DB
            foreach (var item in result)
            {
                newOrder.Id = Guid.NewGuid();
                newOrder.CustomerName = orderRequestDto.Name;
                newOrder.Address = orderRequestDto.Address;
                newOrder.Phone = orderRequestDto.Phone;
                newOrder.CreatedById = new Guid("82d9c886-9fb9-43f4-bd9c-bcd2d8e0112f");
                newOrder.UpdatedById = new Guid("82d9c886-9fb9-43f4-bd9c-bcd2d8e0112f");
                newOrder.GHNRef = orderRequestDto.CliendOrderCode;
                newOrder.OrderCode = item.OrderCode;
                newOrder.ExpectedDeliveryTime = item.ExpectedDeliveryTime;
                newOrder.UserId = "82d9c886-9fb9-43f4-bd9c-bcd2d8e0112f";
                _context.Add(newOrder);
            }
            
            _ = await _context.SaveChangesAsync();

            // Create OrderDetail DB.
            var orderDetail = new OrderDetails();
            foreach (var item in dataCart)
            {
                orderDetail.OrderId = newOrder.Id;
                orderDetail.ProductId = item.Products.Id;
                orderDetail.Quantity = item.Quantity;
                orderDetail.UnitPrice = item.Products.Price;
            }
            _context.Add(orderDetail);
            _ = await _context.SaveChangesAsync();

            return View(newOrder);
        }

        public async Task<IActionResult> CheckingOrderByClient(string orderCode)
        {
            if (string.IsNullOrWhiteSpace(orderCode))
            {
                return View();
            }
            var orders = _context.Orders.Where(x => x.GHNRef == orderCode).FirstOrDefault();
            if (orders != null)
            {
                var orderInfo = await this.addressService.TrackingOrders(orderCode);
                return View("TrackingSucces" ,orderInfo);
            }
            return View("404");
        }
            public Products GetDetails(Guid id)
        {
            var product = _context.Products.Find(id);
            return product;
        }
        public List<Products> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public IActionResult AddCart(Guid id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = GetDetails(id);
                List<CartItem> listCart = new List<CartItem>()
               {
                   new CartItem
                   {
                       Products = product,
                       Quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Products.Id == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartItem
                    {
                        Products = GetDetails(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return Redirect("/Cart/Index");

        }

        [HttpPost]
        public IActionResult updateCart(Guid id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Products.Id == id)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }


        public IActionResult DeleteCart(Guid id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Products.Id == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return Redirect("/Cart/Index");
            }
            return Redirect("/Cart/Index");
        }

        public IActionResult ProductNotFound()
        {
            return View();
        }

    }
}
