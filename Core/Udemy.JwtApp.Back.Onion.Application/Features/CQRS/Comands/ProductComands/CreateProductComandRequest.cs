﻿using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands
{
    public class CreateProductComandRequest : IRequest
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
