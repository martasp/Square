using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Square.Domain.Entities;
using Square.Application.Common.Rasteriser;

namespace Square.Application.UnitTests.Common.Exceptions
{
    public class PolygonRasteriserTests
    {
        [Test]
        public void ShouldSimpleTrangleReturn4Squares()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point { X = 0, Y = 0 });
            points.Add(new Point { X = 2, Y = 4 });
            points.Add(new Point { X = 4, Y = 0 });

            var polygonRasteriser = new PolygonRasteriser();
            var countedSquares = polygonRasteriser.Rasterise(points);

            countedSquares.Count.Should().Be(4);
        }
        [Test]
        public void Should10x10SquareHave100()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point { X = 0, Y = 0 });
            points.Add(new Point { X = 10, Y = 0 });
            points.Add(new Point { X = 10, Y = 10 });
            points.Add(new Point { X = 0, Y = 10 });

            var polygonRasteriser = new PolygonRasteriser();
            var countedSquares = polygonRasteriser.Rasterise(points);

            countedSquares.Count.Should().Be(100);
        }

    }
}
