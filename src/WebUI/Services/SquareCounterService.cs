using Microsoft.EntityFrameworkCore;
using Square.Application.Common.Interfaces;
using Square.Application.Common.Rasteriser;
using Square.Application.Common.Responses;
using Square.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace Square.WebUI.Services
{
    public class SquareCounterService : ISquareCounterService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly PolygonRasteriser _polygonRasterizer;

        public SquareCounterService(ApplicationDbContext applicationDbContext, PolygonRasteriser polygonRasterizer)
        {
            _applicationDbContext = applicationDbContext;
            _polygonRasterizer = polygonRasterizer;
        }

        public async Task<SquareCounterResponse> Count()
        {
            var points = await _applicationDbContext.Points.ToListAsync();
            var squareCounterResponse = _polygonRasterizer.Rasterise(points);
            return squareCounterResponse;
        }
    }
}