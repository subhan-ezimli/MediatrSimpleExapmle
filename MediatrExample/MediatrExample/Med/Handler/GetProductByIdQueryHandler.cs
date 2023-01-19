using MediatR;
using MediatrExample.Med.Queries;
using MediatrExample.Models;

namespace MediatrExample.Med.Handler
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
    {
        public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return Task.FromResult(viewModel);
        }
    }
}
