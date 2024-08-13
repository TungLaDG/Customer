using Microsoft.EntityFrameworkCore;
using Customer.Models;

namespace Customer.Repository

{
    public class CategoryRepo : ICategory
    {
        private carmanagContext _context = new carmanagContext();


        public CategoryRepo(carmanagContext ctx)
        {
            _context = ctx;

        }
        public List<Category> getAllCategory()
        {
            return _context.Categories.ToList();
        }


    }
}
