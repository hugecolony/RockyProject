using RockyProject.Models;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IApplicationTypeRepository :IRepository<ApplicationType>
    {
        void Update(ApplicationType obj);
    }
}
