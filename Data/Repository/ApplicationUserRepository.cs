using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;
using RockyProject.Repository;
using System.Linq.Expressions;

namespace RockyProject.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
