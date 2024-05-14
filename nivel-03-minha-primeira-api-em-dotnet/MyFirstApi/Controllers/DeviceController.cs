using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers
{
    
    public class DeviceController : MyFirstApiBaseController
    {
        public IActionResult Get()
        {
            var laptop = new Laoptop();

            var model = laptop.GetBranch();

            return Ok(model);
        }
    }
}
