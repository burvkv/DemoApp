using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models {
    static class Data {
     
        public static List<Order> Orders = new List<Order>() {
           
            new Order {
                OrderID = 1,
                OrderDate = new DateTime(2021, 6, 22),
                ShipCountry = "Turkey",
                ShipCity = "Istanbul",
                CustomerName = "Furkan Tacyildiz"
            },
            new Order {
                OrderID = 2,
                OrderDate = new DateTime(1996, 10, 12),
                ShipCountry = "Turkey",
                ShipCity = "Adana",
                CustomerName = "Furkan Arslan"
            },
            new Order {
                OrderID = 3,
                OrderDate = new DateTime(1996, 9, 2),
                ShipCountry = "Turkey",
                ShipCity = "Ankara",
                CustomerName = "Eren Hanedar"
            },
            new Order {
                OrderID = 4,
                OrderDate = new DateTime(1996, 3, 3),
                ShipCountry = "Turkey",
                ShipCity = "Izmir",
                CustomerName = "Fatih Yaren"
            },
            new Order {
                OrderID = 5,
                OrderDate = new DateTime(1996, 5, 9),
                ShipCountry = "Turkey",
                ShipCity = "Antalya",
                CustomerName = "Burak Arslan"
            }
        };
    }
}
