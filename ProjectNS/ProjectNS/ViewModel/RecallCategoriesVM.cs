using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class RecallCategoriesVM
    {
        public int RecallCategoriesId { get; set; }
        [Required(ErrorMessage = "Please Enter Recall Categories Type"), MaxLength(30)]
        public string RecallCategoriesName { get; set; }
        [Required(ErrorMessage = "Please Enter Description"), MaxLength(255)]
        public string Description { get; set; }
    }
}
