using Microsoft.AspNetCore.Mvc.Rendering;

namespace RockyProject.Models.ViewModel
{
    public class OrderListVM
    {
        public IEnumerable<OrderHeader> OrderHList { get; set; }

        public IEnumerable<SelectListItem> StatusList { get; set; }

        public string Status { get; set; }
    }
}
