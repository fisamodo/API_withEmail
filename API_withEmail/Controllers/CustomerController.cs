﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API_withEmail.Models;

namespace API_withEmail.Controllers
{
    public class CustomerController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Customer
        public IQueryable<Customer> GetCustomer()
        {
            return db.Customer;
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}