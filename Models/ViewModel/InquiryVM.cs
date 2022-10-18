namespace RockyProject.Models.ViewModel
{
    public class InquiryVM
    {
        //one inquiryHeader 
        public InquiryHeader InquiryHeader { get; set; }
        //multiple details for ienumerable
        public IEnumerable<InquiryDetail> InquiryDetail { get; set; }
    }
}
