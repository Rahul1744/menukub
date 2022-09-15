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
                new MenuItem { MenuItemId=1 , Name="Samosa" , FreeDelivery=false , Price=50 ,DateOfLaunch = new DateTime(2021,08,09) , Active=true },
                new MenuItem { MenuItemId=2 , Name="Kachori" , FreeDelivery=true , Price=60 ,DateOfLaunch = new DateTime(2021,06,02) , Active=true },
                 new MenuItem { MenuItemId=1 , Name="Panipuri" , FreeDelivery=false , Price=40 ,DateOfLaunch = new DateTime(2021,04,06) , Active=true },
                new MenuItem { MenuItemId=2 , Name="Vadapav" , FreeDelivery=true , Price=70 ,DateOfLaunch = new DateTime(2021,04,04) , Active=false }
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
