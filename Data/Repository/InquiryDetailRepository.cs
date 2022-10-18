using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;
using RockyProject.Repository;
using System.Linq.Expressions;

namespace RockyProject.Data.Repository
{
    public class InquiryDetailRepository : Repository<InquiryDetail>,IInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(InquiryDetail obj)
        {
            _db.InquiryDetail.Update(obj);
        }
    }
}
