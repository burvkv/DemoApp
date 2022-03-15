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

namespace DemoApp.Controllers
{

   
    public class LayoutController 
    {


        public List<MenuEntity> Get()
        {
            using (DemoAppDbContext context = new DemoAppDbContext())
            {
                List<MenuEntity> entities = new List<MenuEntity>
                {
                    new MenuEntity{Id = 1,Name = "Home",IconPath ="<i class='bx bxs-home-alt-2'></i>" },
                    new MenuEntity{Id = 2,Name = "About",IconPath ="<i class='bx bx-plus-medical' ></i>" },
                    new MenuEntity{Id = 2,Name = "Contact",IconPath ="<i class='bx bx-phone-call' ></i>" }
                };
                
                return entities;
            }
            


        }

    }
}