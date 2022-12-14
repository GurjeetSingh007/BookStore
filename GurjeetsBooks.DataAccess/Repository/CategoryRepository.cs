using AndrewsBooks.DataAccess.Repository;
using GurjeetsBooks.DataAccess.Repository.IRepository;
using GurjeetsBooks.Models;
using GurjeetsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Update(Category category)
        {
            //use .net LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the categori id
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
            }
        }
    }
}
