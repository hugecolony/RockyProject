using Microsoft.AspNetCore.Mvc;
using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;
using RockyProject.Repository;

namespace RockyProject.Data.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeader.Update(obj);
        }

    }
}
