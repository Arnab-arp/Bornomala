using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShoppingStore.DAL;
using OnlineShoppingStore.Models.Home;
using OnlineShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class AddToCartTest
    {
        [TestMethod]
        public void CanAddToCart()
        {
            List<Item> cart = new List<Item>();
            Tbl_Product product = new Tbl_Product
            {
                ProductId = 8,
                ProductName = "The name of Wind",
                CategoryId = 1,
                IsActive = true,
                IsDelete = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ProductImage = "0_03_21_2017_08_03_26.jpg",
                IsFeatured = true,
                Quantity = 10,
                Price = 300
            };
            cart.Add(new Item()
            {
                Product = product,
                Quantity = 1
            });

            Assert.IsNotNull(cart);
            Assert.AreEqual(1, cart.Count);
        }
        [TestMethod]
        public void CategoryCheck()
        {
            List<CategoryDetail> cat = new List<CategoryDetail>();
            Tbl_Category product = new Tbl_Category
            {
                CategoryId = 1,
                CategoryName = "Fantasy",
                IsActive = true,
                IsDelete = false
            };
            cat.Add(new CategoryDetail()
            {
                CategoryId = 1,
                CategoryName = "Fantasy",
                IsActive = true,
                IsDelete = false
            });
            Assert.IsNotNull(cat);
            Assert.AreEqual(1, cat.Count);

        }

        [TestMethod]

        public void ProductCheck() 
        {
            List<ProductDetail> PD = new List<ProductDetail>();
            Tbl_Product product = new Tbl_Product 
            {
                ProductId = 9,
                ProductName = "The silent Patient",
                CategoryId = 8,
                IsActive = true,
                IsDelete = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ProductImage = "81_12_24_2017_10_26_28.jpg",
                IsFeatured = true,
                Quantity = 12000,
                Price = 250
            };
            PD.Add(new ProductDetail
            {
                ProductId = 12,
                ProductName = "The silent Hill",
                CategoryId = 8,
                IsActive = true,
                IsDelete = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ProductImage = "121_ThesilentHill.jpg",
                IsFeatured = true,
                Quantity = 12,
                Price = 25
            });
            Assert.IsNotNull(PD);
            Assert.AreEqual(1, PD.Count);

        }
        [TestMethod]

        public void Ship() {
            List<Shippingdetail> S = new List<Shippingdetail>();
            Tbl_ShippingDetails ship = new Tbl_ShippingDetails
            {
                ShippingDetailId = 1,
                MemberId = 1,
                Adress = "123street",
                City = "ALU",
                State = "SSS",
                Country = "Gan",
                ZipCode = "1234",
                OrderId = 1234,
                AmountPaid = 600,
                PaymentType = "Paypal"
            };
            S.Add(new Shippingdetail
            {
                ShippingDetailId = 1,
                MemberId = 1,
                Adress = "123street",
                City = "ALU",
                State = "SSS",
                Country = "Gan",
                ZipCode = "1234",
                OrderId = 1234,
                AmountPaid = 600,
                PaymentType = "Paypal"
            });
            Assert.IsNotNull(S);
            Assert.AreEqual(1, S.Count);

        }

        [TestMethod]
        public void EmplopyeeView() {
            List<EmployeeViewModel> EM = new List<EmployeeViewModel>();
            Tbl_Category c = new Tbl_Category
            {
                CategoryId = 17,
                CategoryName = "Adventure",
                IsActive = true,
                IsDelete = false
            };
            EM.Add(new EmployeeViewModel
            {
                CategoryId = 15,
                CategoryName = "Fun",
            });
            Assert.IsNotNull(EM);
            Assert.AreEqual(1, EM.Count);
        }



    }
}

