using Microsoft.AspNetCore.Mvc;
using Square.Application.Common.Responses;
using Square.WebUI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Square.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquareCounterController : ControllerBase
    {
        private readonly SquareCounterService _squareCounterService;

        public SquareCounterController(SquareCounterService squareCounterService)
        {
            _squareCounterService = squareCounterService;
        }

        [HttpGet]
        public async Task<SquareCounterResponse> Count() => await _squareCounterService.Count();

    }
}
