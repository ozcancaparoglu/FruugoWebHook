﻿using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Commands.CreateOrUpdateProduct
{
    public class CreateOrUpdateProductCommand : IRequest<string>
    {
        public List<ProductList> products { get; set; }
    }

   
}
