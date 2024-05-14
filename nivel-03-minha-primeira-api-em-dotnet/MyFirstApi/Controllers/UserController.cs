using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Request;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get([FromRoute] int id, [FromRoute] string nickName, [FromHeader] int? age)
        {
            return Ok("Reinan");
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
        {
            var response = new ResponseRegisteredUserJson
            {
                Id = 1,
                Name = request.Name,
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update(
            [FromRoute] int id,
            [FromBody] RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>),StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new List<User>()
            {
                new User() {Id= 1, Age = 7, Name="Reinan"},
                new User() {Id= 2, Age = 7, Name="Maria"}
            };

            return Ok(response);
        }

        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
        {
            return NoContent();
        }
    }
}
