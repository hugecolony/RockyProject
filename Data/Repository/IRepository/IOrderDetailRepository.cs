using Microsoft.AspNetCore.Mvc;
using RockyProject.Models;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);


    }
}