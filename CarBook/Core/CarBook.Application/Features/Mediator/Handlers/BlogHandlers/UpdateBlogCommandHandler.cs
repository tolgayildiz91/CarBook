﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _blogRepository;

        public UpdateBlogCommandHandler(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _blogRepository.GetByIdAsync(request.BlogID);
            value.Description = request.Description;
            value.AuthorID = request.AuthorID;
            value.Description= request.Description;
            value.CreatedDate = request.CreatedDate;
            value.CategoryID = request.CategoryID;
            value.CoverImageUrl = request.CoverImageUrl;
            await _blogRepository.UpdateAsync(value);
        }
    }
}
