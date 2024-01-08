using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var result =  _blogRepository.GetBlogByAuthorId(request.Id);
            return result.Select(x => new GetBlogByAuthorIdQueryResult
            {
                AuthorDescription = x.Author.Description,
                AuthorID = x.AuthorID,
                AuthorImageUrl = x.Author.ImageUrl,
                AuthorName  = x.Author.Name,
                BlogID = x.BlogID
            }).ToList();
        }
    }
}
