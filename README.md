# Square API

Find squares of a shape with given points and identify squares.

The service can count squares how many squares are in a given point shape, also the response identifies squares that include in the region.

# Example :
![alt text](https://www.scratchapixel.com/images/upload/rasterization/rasterization-triangle1.png?)

## Installing

```
git clone https://github.com/martasp/Square.git
cd \src\WebUI
dotnet run
```
## Questions
* Need example input-output example because of ambiguity.
* Do we need to support complex shapes? 
* Do we need to identify shape always as unit 1 square?

## Improvements 
* PointsController is automatically generated therefore consider refactoring to services, repositories
* Support negative coordinates 
* Use image as base64 instead of points in a json response

