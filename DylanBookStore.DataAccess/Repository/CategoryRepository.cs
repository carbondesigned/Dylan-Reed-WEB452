using System;
using System.Linq;
using DylanBookStore.DataAccess.Data;
using DylanBookStore.Models;

namespace DylanBookStore.DataAccess.Repository.IRepository
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
            var objFromDb = _db.Categories.FirstOrDefault(s => s.ID == category.ID);
            if (objFromDb != null)
            {
                objFromDb.Title = category.Title;
                _db.SaveChanges();
            }
        }
    }
}

