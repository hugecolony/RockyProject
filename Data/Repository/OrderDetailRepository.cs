using Microsoft.AspNetCore.Mvc;
using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;
using RockyProject.Repository;

namespace RockyProject.Data.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
            private readonly ApplicationDbContext _db;
            public OrderDetailRepository(ApplicationDbContext db) : base(db)
            {
                _db = db;
            }

            public void Update(OrderDetail obj)
            {
                _db.OrderDetail.Update(obj);
            }

    }
}
