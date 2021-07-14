﻿using HutechStore.Data.EF;
using HutechStore.ViewModels.Catalog.Categories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HutechStore.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly HutechStoreDbContext _context;

        public CategoryService(HutechStoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name
            }).ToListAsync();
        }
    }
}