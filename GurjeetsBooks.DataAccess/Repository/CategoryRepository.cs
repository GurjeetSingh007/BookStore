using AndrewsBooks.DataAccess.Repository;
using GurjeetsBooks.DataAccess.Repository.IRepository;
using GurjeetsBooks.Models;
using GurjeetsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GurjeetsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
