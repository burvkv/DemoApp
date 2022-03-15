using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DemoApp.Data;
using DemoApp.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers {

    [Route("api/[controller]")]
    public class DataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
           
                return DataSourceLoader.Load(Models.Data.Orders, loadOptions);
            
            
        }

    }
}