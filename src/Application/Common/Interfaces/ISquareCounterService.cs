using Square.Application.Common.Responses;
using System.Threading.Tasks;

namespace Square.Application.Common.Interfaces
{
    public interface ISquareCounterService
    {
        public Task<SquareCounterResponse> Count();
    }
}