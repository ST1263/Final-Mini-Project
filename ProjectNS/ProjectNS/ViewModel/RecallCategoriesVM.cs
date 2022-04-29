
using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class RecallCategoriesVM
    {
        public int RecallCategoriesId { get; set; }
        [MaxLength(30)]
        public string RecallCategoriesName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
