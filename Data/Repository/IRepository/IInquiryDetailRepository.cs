using RockyProject.Models;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IInquiryDetailRepository : IRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);
    

    }
}
