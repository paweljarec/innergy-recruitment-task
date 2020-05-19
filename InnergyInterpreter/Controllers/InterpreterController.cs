using InnergyInterpreter.Extensions;
using InnergyInterpreter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InnergyInterpreter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterpreterController : ControllerBase
    {
        private readonly IInterpreterService _interpreterService;

        public InterpreterController(IInterpreterService interpreterService)
        {
            _interpreterService = interpreterService;
        }

        [HttpPost]
        public async Task<string> GetMaterials(IFormFile uploadedFile)
        {
            //if (uploadedFile == null || uploadedFile.Length == 0)
            //    return Content("file not selected");

            var result = await uploadedFile.ReadAsStringAsync();

            _interpreterService.Execute(result);

            return null;
        }
    }
}
