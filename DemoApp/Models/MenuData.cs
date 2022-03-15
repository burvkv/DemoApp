using DemoApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp.Models
{
    public class MenuData
    {
        public List<MenuEntity> GetMenus()
        {
            using (DemoAppDbContext context = new DemoAppDbContext())
            {
                return  context.MenuEntities.ToList();

            }
        }
    }
}
