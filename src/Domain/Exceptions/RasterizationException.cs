using System;

namespace Square.Domain.Exceptions
{
    public class RasterizationException : Exception
    {
        public RasterizationException()
            : base($"Can not rasterize less than 3 points")
        {
        }
    }
}
