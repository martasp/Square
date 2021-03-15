using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Square.Application.Common.Dtos;
using Square.Application.Common.Exceptions;
using Square.Application.Common.Responses;
using Square.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Square.Application.Common.Rasteriser
{
    public class PolygonRasteriser
    {
        public SquareCounterResponse Rasterise(List<Domain.Entities.Point> points)
        {
            var isMoreThanTree = points.Count < 3;
            if (isMoreThanTree)
                throw new RasterizationException();

            var maximumCordinateOfX = points.Max(point => point.X);
            var maximumCordinateOfY = points.Max(point => point.Y);

            var pointsF = points
                .Select(point => new SixLabors.ImageSharp.PointF(point.X, point.Y))
                .ToArray();


            var squareCounterResponse = new SquareCounterResponse();
            var counter = 0;
            using (var image = new Image<Rgb24>(maximumCordinateOfX, maximumCordinateOfY))
            {
                image.Mutate(x => x.FillPolygon(Color.White, pointsF)); // fill the star with red

                for (int y = 0; y < image.Height; y++)
                {
                    Span<Rgb24> pixelRowSpan = image.GetPixelRowSpan(y);
                    for (int x = 0; x < image.Width; x++)
                    {
                        var isWhite = pixelRowSpan[x].R == 255;
                        if (isWhite)
                        {
                            squareCounterResponse.SquarePositions.Add(new PointDto {X = x, Y = y });
                            counter++;
                        }
                    }
                }
                //image.SaveAsBmp(@"C:\Users\mart\Desktop\s\image.bmp"); // Rasterised image
            }
            squareCounterResponse.Count = counter;
            return squareCounterResponse;
        }
    }
}