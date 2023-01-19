using MediatR;
using MediatrExample.Models;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {
    }
}
