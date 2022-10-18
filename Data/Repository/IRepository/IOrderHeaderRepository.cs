using Microsoft.AspNetCore.Mvc;
using RockyProject.Models;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);


    }
}
