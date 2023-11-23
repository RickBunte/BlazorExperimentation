using BlazorExperimentation.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorExperimentation.Web.Controllers
{
    [Route("api/numbers")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        [HttpPost("transmute")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TransmuteNumberResponseModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult TransmuteNumber([FromBody] TransmuteNumberModel model)
        {
            var response = new TransmuteNumberResponseModel
            {
                Name = model.Name,
                OriginalNumber = model.Number,
                ResultNumber = model.Number * 4.5,
            };
            return new OkObjectResult(response);
        }
    }
}
