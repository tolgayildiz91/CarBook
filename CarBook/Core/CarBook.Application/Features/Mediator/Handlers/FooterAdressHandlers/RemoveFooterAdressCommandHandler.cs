﻿using CarBook.Application.Features.Mediator.Commands.FooterAdressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
    public class RemoveFooterAdressCommandHandler : IRequestHandler<RemoveFooterAdressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public RemoveFooterAdressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}