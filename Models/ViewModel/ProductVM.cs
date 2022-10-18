using Microsoft.AspNetCore.Mvc.Rendering;

namespace RockyProject.Models.ViewModel
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        
        public IEnumerable<SelectListItem> ApplicationTypeSelectList { get; set; }
    }
}
