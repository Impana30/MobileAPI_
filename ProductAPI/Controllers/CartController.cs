using BAL;
using Entity_Layer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartServices _CartServices;

        public CartController(CartServices CartServices)
        {
            _CartServices = CartServices;
        }
        [HttpGet("GetAllCarts")]
        public IActionResult GetAllCarts()
        {

            var result = _CartServices.GetAllCarts();
            return Ok(result);
        }
        [HttpPost("CreateCart")]
        public IActionResult CreateCart([FromBody] CartModel Model)
        {
            var result = _CartServices.AddCart(Model);
            return Ok(result);
        }
        [HttpPut("UpdateCart")]
        public IActionResult UpdateCart(CartModel Model)
        {
            var result = _CartServices.UpdateCart(Model);
            return Ok(result);

        }


        [HttpDelete("RemoveCart")]
        public IActionResult RemoveCart(int CartId)
        {
            var result = _CartServices.RemoveCart(CartId);
            return Ok(result);
        }
        [HttpGet("GetCart")]
        public IActionResult GetCart(int CartId)
        {
            var result = _CartServices.GetCart(CartId);
            return Ok(result);
        }
        
    }
}
