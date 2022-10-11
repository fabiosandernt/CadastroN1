﻿using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Infrastructure.Data.Repositories;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductViewModelService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
           _productRepository.Delete(id);
        }

        public ProductViewModel Get(int id)
        {
            var entity = _productRepository.Get(id);
            if (entity == null) 
                return null;

            return _mapper.Map<ProductViewModel>(entity);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var list = _productRepository.GetAllWithClient();
            if (list.Count() == 0)
                return new ProductViewModel[] { };

            return _mapper.Map<IEnumerable<ProductViewModel>>(list);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Update(entity);
        }
    }
}
