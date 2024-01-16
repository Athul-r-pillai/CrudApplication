using CrudApplication.CommonLayer.Model;
using CrudApplication.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CrudApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudApplicationController : ControllerBase
    {
        public readonly ICrudApplicationSL _crudApplicationSL;

        public CrudApplicationController(ICrudApplicationSL crudApplicationSL)
        {
            _crudApplicationSL = crudApplicationSL;
        }

        [HttpPost]
        public IActionResult AddInformation(AddInformationRequest request)
        {
            AddInformationResponse response = new AddInformationResponse();
            try { }
            catch (Exception) { }
            return Ok();
        }
    }
}
