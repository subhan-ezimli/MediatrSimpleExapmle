using MediatR;
using MediatrExample.Models;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest <GetProductByIdViewModel>    
    {
        public Guid Id  { get; set; }

    }
}
