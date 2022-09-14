using MenuItemsListingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemsListingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private static List<MenuItem> menuItems = new List<MenuItem>
            {
                new MenuItem { MenuItemId=1 , Name="Pizza" , FreeDelivery=true , Price=250 ,DateOfLaunch = new DateTime(2022,09,02) , Active=true },
                new MenuItem { MenuItemId=2 , Name="Burger" , FreeDelivery=true , Price=100 ,DateOfLaunch = new DateTime(2022,12,12) , Active=true },
                new MenuItem { MenuItemId=3 , Name="French fries" , FreeDelivery=true , Price=100 ,DateOfLaunch = new DateTime(2022,10,10) , Active=true },
                new MenuItem { MenuItemId=4 , Name="Samosa" , FreeDelivery=true , Price=50 ,DateOfLaunch = new DateTime(2022,02,02) , Active=true }
            };

        [HttpGet]
        public List<MenuItem> Get()
        {
            
            return menuItems;
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult Get(int Id)
        {
            //foreach (var item in menuItems)
            //{
            //    if (item.MenuItemId == Id)
            //    {
            //        return Ok(item);
            //    }
               
            //}
            //return NotFound();

            //var item = (from i in menuItems where i.MenuItemId == Id select i).FirstOrDefault();
            //if (item == null)
            //    return NotFound();

            //return Ok(item);

            var otherway = menuItems.Where(i => i.MenuItemId == Id).FirstOrDefault();
            if (otherway == null)
                return NotFound();
            return Ok(otherway);
           
        }
    }
}
