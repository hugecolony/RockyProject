using Microsoft.AspNetCore.Mvc.Rendering;
using RockyProject.Models;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
    }
}