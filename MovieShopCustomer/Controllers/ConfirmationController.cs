﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopCustomer.Models;
using MovieShopDll;
using MovieShopDll.Entities;

namespace MovieShopCustomer.Controllers
{
    public class ConfirmationController : Controller
    {

        IServiceGateway<Customer> _cm = new DllFacade().GetCustomerManager();
        IServiceGateway<Movie> _mm = new DllFacade().GetMovieManager();
        IServiceGateway<Order> _om = new DllFacade().GetOrderManager();



        // GET: Confirmation
        public ActionResult Index(int mId, int cId, int oId)
        {
            var model = new CustomerMovieOrderModel()
            {
                Customer = _cm.Read(cId),
                Movie = _mm.Read(mId),
                Order = _om.Read(oId)
            };

            return View(model);
        }
    }
}