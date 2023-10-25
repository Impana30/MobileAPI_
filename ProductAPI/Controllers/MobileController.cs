using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BAL;
using Entity_Layer;



namespace MobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly MobileServices _MobileServices;

        public MobileController(MobileServices MobileServices)
        {
            _MobileServices = MobileServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _MobileServices.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateMobile(MobileModel Mobile)
        {
            var result = _MobileServices.AddMobile(Mobile);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateMobile(MobileModel Mobile)
        {
            var result = _MobileServices.UpdateMobile(Mobile);
            return Ok(result);

        }
        [HttpDelete]
        public IActionResult DeleteMobile(int MobileId)
        {
            var result = _MobileServices.DeleteMobile(MobileId);
            return Ok(result);
        }
        [HttpGet("GetMobile")]
        public IActionResult GetMobile(int MobileId)
        {
            var result = _MobileServices.GetMobile(MobileId);
            return Ok(result);
        }

    }
}


