using Microsoft.AspNetCore.Mvc;
using Square.Application.Common.Interfaces;
using Square.Application.Common.Responses;
using Square.WebUI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Square.WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SquareCounterController : ControllerBase
    {
        private readonly ISquareCounterService _squareCounterService;

        public SquareCounterController(ISquareCounterService squareCounterService)
        {
            _squareCounterService = squareCounterService;
        }

        [HttpGet]
        public async Task<SquareCounterResponse> Count() => await _squareCounterService.Count();

    }
}
