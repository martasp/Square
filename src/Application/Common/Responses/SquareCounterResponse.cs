using Square.Application.Common.Dtos;
using System.Collections.Generic;

namespace Square.Application.Common.Responses
{
    public class SquareCounterResponse
    {
        public List<PointDto> SquarePositions { get; set; } = new List<PointDto>();
        public int Count { get; set; }
    }
}