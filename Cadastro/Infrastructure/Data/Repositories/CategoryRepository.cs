﻿using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Infrastructure.Data.Common;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class CategoryRepository : EfRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RegisterContext dbContext)
            : base(dbContext)
        {

        }
    }
}
